using System;

namespace TimeSeriesAnalizer
{
    public static class Converter
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

            point.EntropyMembershipFunction = point.Ny * Math.Log(Math.Abs(point.Ny.Value));

            if((point.Ny < 0 && point.EntropyMembershipFunction > 0) || (point.Ny > 0 && point.EntropyMembershipFunction < 0))
            {
                point.EntropyMembershipFunction *= -1;
            }
        }
    }
}
