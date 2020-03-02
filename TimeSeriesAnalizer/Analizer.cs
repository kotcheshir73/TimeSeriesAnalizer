using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public class Analizer
    {
        public void AnalizerTimeSeries(AnalizerTimeSeriesBindingModel model)
        {
            Statisctics.InitFuzzyLabelStatistics();
            TimeSeriesPoint beforePoint = null;
            foreach (var point in model.TimeSeries)
            {
                point.CalcEntropyMembershipFunction();
                point.CalcEntropyFuzzyLabel();

                if (beforePoint != null)
                {
                    point.Trend = point.Value - beforePoint.Value;

                    if (beforePoint.Trend.HasValue)
                    {
                        point.DynamicTrend = point.Trend - beforePoint.Trend;
                        point.CalcPhasePlaneTrendPosition();
                        point.CalcDynamicLingvist(beforePoint.DynamicTrend);
                    }
                }

                beforePoint = point;
            }
        }

        public DynamicTrendGranuleViewModel GetDynamicTrendGranule(AnalizerTimeSeriesBindingModel model)
        {
            var result = new DynamicTrendGranuleViewModel { DynamicTrendGranules = new List<DynamicTrendGranule>() };


            return result;
        }
    }
}