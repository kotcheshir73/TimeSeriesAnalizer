using System;

namespace TimeSeriesAnalizer
{
    public static class Calculator
    {
        public static void CalcDynamicLingvist(this TimeSeriesPoint point, double? dynamic)
        {
            if(!point.DynamicTrend.HasValue)
            {
                return;
            }

            if (point.DynamicTrend == 0)
            {
                point.DynamicLingvist = DynamicLingvist.Стабильность;
            }
            // была стабильность
            else if (!dynamic.HasValue || dynamic == 0)
            {
                if(point.DynamicTrend > 0)
                {
                    point.DynamicLingvist = DynamicLingvist.Рост;
                }
                else if(point.DynamicTrend < 0)
                {
                    point.DynamicLingvist = DynamicLingvist.Падение;
                }
            }
            // был рост
            else if(dynamic > 0)
            {
                if(point.DynamicTrend < 0)
                {
                    point.DynamicLingvist = DynamicLingvist.Падение;
                }
                else if (dynamic < point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.РостСильный;
                }
                else if (dynamic > point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.РостСлабый;
                }
                else if (dynamic == point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.РостНеизменный;
                }
            }
            // было падение
            else if (dynamic < 0)
            {
                if (point.DynamicTrend > 0)
                {
                    point.DynamicLingvist = DynamicLingvist.Рост;
                }
                else if (dynamic < point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.ПадениеСильное;
                }
                else if (dynamic > point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.ПадениеСлабое;
                }
                else if (dynamic == point.DynamicTrend)
                {
                    point.DynamicLingvist = DynamicLingvist.ПадениеНеизменное;
                }
            }
        }

        public static void CalcPhasePlaneTrendPosition(this TimeSeriesPoint point)
        {
            if(!point.Trend.HasValue || !point.DynamicTrend.HasValue)
            {
                return;
            }

            if(point.Trend == 0 && point.DynamicTrend == 0)
            {
                point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.Zero;
                return;
            }

            if(point.Trend > 0 && point.DynamicTrend > 0)
            {
                point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.FirstQuarter;
                return;
            }

            if (point.Trend < 0 && point.DynamicTrend > 0)
            {
                point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.SecondQuarter;
                return;
            }

            if (point.Trend < 0 && point.DynamicTrend < 0)
            {
                point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.ThirdQuarter;
                return;
            }

            if (point.Trend > 0 && point.DynamicTrend < 0)
            {
                point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.FourthQuarter;
                return;
            }

            if (point.DynamicTrend == 0)
            {
                if (point.Trend > 0)
                {
                    point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.TrendMoreZero;
                    return;
                }

                if (point.Trend < 0)
                {
                    point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.TrendLessZero;
                    return;
                }
            }

            if (point.Trend == 0)
            {
                if (point.DynamicTrend > 0)
                {
                    point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.DynamicMoreZero;
                    return;
                }

                if (point.DynamicTrend < 0)
                {
                    point.PhasePlaneTrendPosition = PhasePlaneTrendPosition.DynamicLessZero;
                    return;
                }
            }
        }

        public static void CalcEntropyMembershipFunction(this TimeSeriesPoint point)
        { 
            if(!point.Ny.HasValue)
            {
                return;
            }

            point.EntropyMembershipFunction = -1.0 * (Math.Round(Math.Abs(point.Ny.Value) * Math.Log(Math.Abs(point.Ny.Value)), 5) +
                Math.Round((1.0 - Math.Abs(point.Ny.Value)) * Math.Log(1.0 - Math.Abs(point.Ny.Value)), 5));
        }

        public static void CalcEntropyFuzzyLabel(this TimeSeriesPoint point)
        {
            if (string.IsNullOrEmpty(point.FuzzyLabel))
            {
                return;
            }

            point.ProbabilityFuzzyLabel = Statisctics.FuzzyLabelStatistics(point.FuzzyLabel);

            point.EntropyFuzzyLabel = point.ProbabilityFuzzyLabel * Math.Log(Math.Abs(point.ProbabilityFuzzyLabel.Value));
        }

        public static void CalcEntropyFuzzyTrend(this TimeSeriesPoint point, string before = null)
        {
            if(string.IsNullOrEmpty(before))
            {
                Statisctics.PhasePlaneStatistics(point.PhasePlaneTrendPosition.ToString());
                return;
            }

            var prob = Statisctics.PhasePlaneStatistics(point.PhasePlaneTrendPosition.ToString(), before);

            point.EntropyFuzzyTrend = prob * Math.Log(prob);
        }

        public static void CalcEntropyFuzzyTrend(this TimeSeriesPoint point, PhasePlaneTrendPosition? before)
        {
            if (!before.HasValue || !point.PhasePlaneTrendPosition.HasValue)
            {
                return;
            }

            var prob = TrendStaticStatistic.GetProbability(point.PhasePlaneTrendPosition.Value, before.Value);

            point.EntropyFuzzyTrend = prob * Math.Log(prob);
        }
    }
}