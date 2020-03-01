using System;

namespace TimeSeriesAnalizer
{
    public static class Calculator
    {
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

            point.EntropyMembershipFunction = Math.Round(point.Ny.Value * Math.Log(1 / Math.Abs(point.Ny.Value)), 5);
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
    }
}
