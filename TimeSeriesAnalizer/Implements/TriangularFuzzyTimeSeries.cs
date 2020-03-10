using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeSeriesAnalizer
{
    public class TriangularFuzzyTimeSeries : IFuzzyTimeSeries
    {
        private List<FuzzyLabel> fuzzyLabels;

        public void Fuzzyfication(FuzzyTimeSeriesBaseModel model)
        {
            if (model is TriangularConfig config)
            {
                if (config.List != null)
                {
                    fuzzyLabels = config.List;
                }
                else if (config.CountLabels != null)
                {
                    fuzzyLabels = new List<FuzzyLabel>();
                    var step = (config.EndValue - config.BeginValue) / config.CountLabels;
                    for (int i = 0; i < config.CountLabels; ++i)
                    {
                        fuzzyLabels.Add(new FuzzyLabel
                        {
                            MinVal = config.BeginValue + step * i - step * config.Percent / 100,
                            MaxVal = config.BeginValue + step * (i + 1) + step * config.Percent / 100,
                            Center = (2 * config.BeginValue + step * (2 * i + 1)) / 2,
                            LinguisticTerm = $"Метка {i + 1}"
                        });
                    }
                }
                else
                {
                    throw new Exception("Невозможно определить функции принадлежности");
                }
            }

            if (model.Points == null)
            {
                return;
            }

            foreach (var label in fuzzyLabels)
            {
                label.Entropy = 0.0;
                foreach (var point in model.Points)
                {
                    if(!point.Ny.HasValue)
                    {
                        point.Ny = 0;
                    }

                    if (point.Value > label.MinVal.Value && point.Value < label.MaxVal.Value)
                    {
                        point.FuzzyLabel = label.LinguisticTerm;
                        if (point.Value < label.Center.Value)
                        {
                            point.Ny = -1 * ((point.Value - label.MinVal.Value) / (label.Center.Value - label.MinVal.Value));
                        }
                        else if (point.Value >= label.Center.Value)
                        {
                            point.Ny = ((label.MaxVal.Value - point.Value) / (label.MaxVal.Value - label.Center.Value));
                        }
                        label.Entropy += Math.Abs(point.Ny.Value) * Math.Log(1.0 / Math.Abs(point.Ny.Value));
                    }
                }
               // label.Entropy /= model.Points.Where(x => x.FuzzyLabel == label.LinguisticTerm).Count();
            }
        }

        public void FuzzyPoint(FuzzyTimeSeriesBindingModel model)
        {
            if (fuzzyLabels == null || fuzzyLabels.Count == 0)
            {
                return;
            }

            if (model.Point == null)
            {
                return;
            }

            foreach (var label in fuzzyLabels)
            {
                if (model.Point.Value > label.MinVal.Value && model.Point.Value < label.MaxVal.Value)
                {
                    if (model.Point.Value < label.Center.Value)
                    {
                        model.Point.Ny = -1 * ((model.Point.Value - label.MinVal.Value) / (label.Center.Value - label.MinVal.Value));
                    }
                    else if (model.Point.Value >= label.Center.Value)
                    {
                        model.Point.Ny = ((label.MaxVal.Value - model.Point.Value) / (label.MaxVal.Value - label.Center.Value));
                    }
                    return;
                }
            }
        }

        public FuzzyLabelsViewModel GetFuzzyLabels()
        {
            return new FuzzyLabelsViewModel
            {
                FuzzyLabels = fuzzyLabels
            };
        }
    }
}