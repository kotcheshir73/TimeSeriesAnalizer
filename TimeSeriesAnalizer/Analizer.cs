﻿using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public class Analizer
    {
        public void AnalizerTimeSeries(AnalizerTimeSeriesBindingModel model)
        {
            TimeSeriesPoint beforePoint = null;
            foreach (var point in model.TimeSeries)
            {
                point.CalcEntropyMembershipFunction();

                if (beforePoint != null)
                {
                    point.Trend = point.Value - beforePoint.Value;

                    if (beforePoint.Trend.HasValue)
                    {
                        point.DynamicTrend = point.Trend - beforePoint.Trend;
                        point.CalcPhasePlaneTrendPosition();
                    }
                }

                beforePoint = point;
            }
            for (int i = 1; i < model.TimeSeries.Count; ++i)
            {

            }
        }

        public DynamicTrendGranuleViewModel GetDynamicTrendGranule(AnalizerTimeSeriesBindingModel model)
        {
            var result = new DynamicTrendGranuleViewModel { DynamicTrendGranules = new List<DynamicTrendGranule>() };


            return result;
        }
    }
}