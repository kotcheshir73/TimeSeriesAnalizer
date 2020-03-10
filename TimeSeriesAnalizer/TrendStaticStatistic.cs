using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSeriesAnalizer
{
    public static class TrendStaticStatistic
    {
        private static Dictionary<PhasePlaneTrendPosition, Dictionary <PhasePlaneTrendPosition, double>> phasePlane;

        public static void Init()
        {
            phasePlane = new Dictionary<PhasePlaneTrendPosition, Dictionary<PhasePlaneTrendPosition, double>>
            {
                { PhasePlaneTrendPosition.Zero, new Dictionary<PhasePlaneTrendPosition, double>() }
            };
            phasePlane[PhasePlaneTrendPosition.Zero].Add(PhasePlaneTrendPosition.Zero, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.Zero].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.Zero].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 3);

            phasePlane.Add(PhasePlaneTrendPosition.FirstQuarter, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.FirstQuarter].Add(PhasePlaneTrendPosition.TrendMoreZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FirstQuarter].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FirstQuarter].Add(PhasePlaneTrendPosition.FourthQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FirstQuarter].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FirstQuarter].Add(PhasePlaneTrendPosition.Zero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.SecondQuarter, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.SecondQuarter].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.SecondQuarter].Add(PhasePlaneTrendPosition.TrendLessZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.SecondQuarter].Add(PhasePlaneTrendPosition.SecondQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.SecondQuarter].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.SecondQuarter].Add(PhasePlaneTrendPosition.DynamicMoreZero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.ThirdQuarter, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.ThirdQuarter].Add(PhasePlaneTrendPosition.TrendLessZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.ThirdQuarter].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.ThirdQuarter].Add(PhasePlaneTrendPosition.SecondQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.ThirdQuarter].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.ThirdQuarter].Add(PhasePlaneTrendPosition.DynamicMoreZero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.FourthQuarter, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.FourthQuarter].Add(PhasePlaneTrendPosition.TrendMoreZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FourthQuarter].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FourthQuarter].Add(PhasePlaneTrendPosition.FourthQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FourthQuarter].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.FourthQuarter].Add(PhasePlaneTrendPosition.DynamicLessZero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.TrendMoreZero, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.TrendMoreZero].Add(PhasePlaneTrendPosition.TrendMoreZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendMoreZero].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendMoreZero].Add(PhasePlaneTrendPosition.FourthQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendMoreZero].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendMoreZero].Add(PhasePlaneTrendPosition.DynamicLessZero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.TrendLessZero, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.TrendLessZero].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendLessZero].Add(PhasePlaneTrendPosition.TrendLessZero, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendLessZero].Add(PhasePlaneTrendPosition.SecondQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendLessZero].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 5);
            phasePlane[PhasePlaneTrendPosition.TrendLessZero].Add(PhasePlaneTrendPosition.DynamicMoreZero, 1.0 / 5);

            phasePlane.Add(PhasePlaneTrendPosition.DynamicMoreZero, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.DynamicMoreZero].Add(PhasePlaneTrendPosition.Zero, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.DynamicMoreZero].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.DynamicMoreZero].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 3);

            phasePlane.Add(PhasePlaneTrendPosition.DynamicLessZero, new Dictionary<PhasePlaneTrendPosition, double>());
            phasePlane[PhasePlaneTrendPosition.DynamicLessZero].Add(PhasePlaneTrendPosition.Zero, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.DynamicLessZero].Add(PhasePlaneTrendPosition.FirstQuarter, 1.0 / 3);
            phasePlane[PhasePlaneTrendPosition.DynamicLessZero].Add(PhasePlaneTrendPosition.ThirdQuarter, 1.0 / 3);
        }

        public static double GetProbability(PhasePlaneTrendPosition now, PhasePlaneTrendPosition before)
        {
            if(phasePlane == null || !phasePlane.ContainsKey(before) || !phasePlane[before].ContainsKey(now))
            {
                return -1;
            }

            return phasePlane[before][now];
        }
    }
}
