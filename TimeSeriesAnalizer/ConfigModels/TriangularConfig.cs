using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public class TriangularConfig : FuzzyTimeSeriesBaseModel
    {
        public double? BeginValue { get; set; }

        public double? EndValue { get; set; }

        public int? CountLabels { get; set; }

        public int? Percent { get; set; }

        public List<FuzzyLabel> List { get; set; }
    }
}