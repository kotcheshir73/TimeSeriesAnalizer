using System;

namespace TimeSeriesAnalizer
{
    /// <summary>
    /// Точка временного ряда
    /// </summary>
    public class TimeSeriesPoint
    {
        /// <summary>
        /// значение точки
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// динамика в точке
        /// </summary>
        public double? Trend { get; set; }

        /// <summary>
        /// динамика динамики
        /// </summary>
        public double? DynamicTrend { get; set; }

        public DynamicLingvist? DynamicLingvist { get; set; }

        /// <summary>
        /// расположение на фазовой плоскости
        /// </summary>
        public PhasePlaneTrendPosition? PhasePlaneTrendPosition { get; set; }

        public double? Ny { get; set; }

        public string FuzzyLabel { get; set; }

        public double? EntropyMembershipFunction { get; set; }

        public double? ProbabilityFuzzyLabel { get; set; }

        public double? EntropyFuzzyLabel { get; set; }
    }
}