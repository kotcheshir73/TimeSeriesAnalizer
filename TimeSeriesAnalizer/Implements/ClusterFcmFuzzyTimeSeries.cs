using System;
using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public class ClusterFcmFuzzyTimeSeries : IFuzzyTimeSeries
    {
        /// <summary>
        /// список центров кластеров
        /// </summary>
        private List<FuzzyLabel> centers;

        /// <summary>
        /// список точек
        /// </summary>
        private List<TimeSeriesPoint> points;

        /// <summary>
        /// функция принадлежости
        /// </summary>
        private double[,] U;

        /// <summary>
        /// фиксированный параметр
        /// </summary>
        private double q;

        public void Fuzzyfication(FuzzyTimeSeriesBaseModel model)
        {
            if (model is ClusterFcmConfig config)
            {
                centers = new List<FuzzyLabel>(config.CountCenters);
                points = config.Points;

                if (points != null && points.Count > 0 && config.CountCenters > 0)
                {
                    U = new double[config.CountCenters, points.Count];
                }
                else
                {
                    return;
                }

                for (int i = 0; i < config.CountCenters; ++i)
                {
                    centers.Add(new FuzzyLabel { Center = 0, LinguisticTerm = $"Кластер {i + 1}" });
                }

                q = config.Q;

                Random rand = new Random();

                //формируем матрицу U
                for (int i = 0; i < centers.Count; i++)
                {
                    for (int j = 0; j < points.Count; j++)
                    {
                        U[i, j] = rand.NextDouble() / points.Count;
                    }
                }

                Normilize();

                for (int i = 0; i < config.MaxStep; i++)
                {
                    double jfirst = CalcObjectiveFunction();
                    CalcClusterCenters();
                    CalcNu();
                    double jsecond = CalcObjectiveFunction();
                    if (Math.Abs(jfirst - jsecond) < config.Accurancy)
                    {
                        break;
                    }
                }
            }
        }

        public void FuzzyPoint(FuzzyTimeSeriesBindingModel model)
        {
            double sum = 0;
            bool flag = false;
            foreach (var cent in centers)
            {
                if (model.Point.Value == cent.Center.Value)
                {
                    flag = true;
                    break;
                }

                sum += (1 / Math.Pow(CalcDistanse(model.Point, cent), 1 / (q - 1)));
            }
            for (int i = 0; i < centers.Count; i++)
            {
                if (flag && model.Point.Value == centers[i].Center.Value)
                {
                    model.Point.Ny = 1;
                    model.Point.FuzzyLabel = centers[i].LinguisticTerm;
                    break;
                }
                else if (!flag)
                {
                    var nu = (1 / Math.Pow(CalcDistanse(model.Point, centers[i]), 1 / (q - 1))) / sum;
                    if (nu > model.Point.Ny)
                    {
                        model.Point.Ny = nu;
                        model.Point.FuzzyLabel = centers[i].LinguisticTerm;
                    }
                }
            }
        }

        public FuzzyLabelsViewModel GetFuzzyLabels()
        {
            return new FuzzyLabelsViewModel
            {
                FuzzyLabels = centers
            };
        }

        /// <summary>
        /// Нормализация первоначальной матрицы, чтобы сумма по строкам == 1, а постолбцам не более points.Count
        /// </summary>
        private void Normilize()
        {
            double delta = 1.0 / (points.Count * 10);
            bool flag = true;
            double sum;

            while (flag)
            {
                flag = false;
                for (int i = 0; i < centers.Count; ++i)
                {
                    sum = 0;
                    for (int j = 0; j < points.Count; ++j)
                    {
                        sum += U[i, j];
                    }
                    while (Math.Round(sum, 6) != 1)
                    {
                        flag = true;
                        int sign = sum > 1 ? -1 : 1;
                        for (int j = 0; j < points.Count; ++j)
                        {
                            U[i, j] += delta * sign;
                            sum += delta * sign;

                            if (Math.Round(sum, 6) == 1)
                            {
                                break;
                            }
                            if((sum < 1 && sum + delta > 1) || (sum > 1 && sum - delta < 1))
                            {
                                delta = Math.Abs(sum - 1);
                            }
                        }

                        delta = 1.0 / (points.Count * 10);
                    }
                }

                for (int j = points.Count - 1; j > -1; --j)
                {
                    sum = 0;
                    for (int i = 0; i < centers.Count; ++i)
                    {
                        sum += U[i, j];
                    }
                    while (sum > points.Count || sum <= 0)
                    {
                        flag = true;
                        int sign = sum > points.Count ? -1 : 1;
                        for (int i = 0; i < centers.Count; ++i)
                        {
                            U[i, j] += delta * sign;
                            sum += delta * sign;

                            if (sum > 0 && sum <= points.Count)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Расчет функции принадлежности
        /// </summary>
        private void CalcNu()
        {
            for (int j = 0; j < points.Count; j++)
            {
                points[j].Ny = 0;
                double sum = 0;
                bool flag = false;
                foreach (var cent in centers)
                {
                    if (points[j].Value == cent.Center.Value)
                    {
                        flag = true;
                        break;
                    }

                    sum += (1 / Math.Pow(CalcDistanse(points[j], cent), 1 / (q - 1)));
                }
                for (int i = 0; i < centers.Count; i++)
                {
                    if (flag && points[j].Value == centers[i].Center.Value)
                    {
                        U[i, j] = 1;
                        points[j].Ny = U[i, j];
                        points[j].FuzzyLabel = centers[i].LinguisticTerm;
                    }
                    else if (flag && points[j].Value != centers[i].Center.Value)
                    {
                        U[i, j] = 0;
                    }
                    else
                    {
                        U[i, j] = Math.Round((1 / Math.Pow(CalcDistanse(points[j], centers[i]), 1 / (q - 1))) / sum, 4);
                        if (Math.Abs(points[j].Ny.Value) < U[i, j])
                        {
                            points[j].Ny = U[i, j];
                            points[j].FuzzyLabel = centers[i].LinguisticTerm;

                            if(points[j].Value < centers[i].Center)
                            {
                                points[j].Ny *= -1;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Перерасчет кластерных центров
        /// </summary>
        private void CalcClusterCenters()
        {
            for (int i = 0; i < centers.Count; ++i)
            {
                double numerator = 0;
                double denominator = 0;
                for (int j = 0; j < points.Count; ++j)
                {
                    var pow = Math.Pow(U[i, j], q);
                    numerator += pow * points[j].Value;
                    denominator += pow;
                }

                centers[i].Center = numerator / denominator;
            }
        }

        /// <summary>
        /// Что-то считаем )))))
        /// </summary>
        /// <returns></returns>
        private double CalcObjectiveFunction()
        {
            double J = 0;
            for (int i = 0; i < centers.Count; ++i)
            {
                for (int j = 0; j < points.Count; ++j)
                {
                    J += Math.Pow(U[i, j], q) * Math.Pow(CalcDistanse(points[j], centers[i]), 2);
                }
            }
            return J;
        }

        /// <summary>
        /// Расчет расстояния между точкой и центром
        /// </summary>
        /// <param name="value">значение точки</param>
        /// <param name="center">центр кластеризации</param>
        /// <returns>расстояние</returns>
        private double CalcDistanse(TimeSeriesPoint value, FuzzyLabel center)
        {
            return value.Value - center.Center.Value;
        }
    }
}