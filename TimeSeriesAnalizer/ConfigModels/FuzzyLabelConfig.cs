using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public class FuzzyLabelConfig : FuzzyTimeSeriesBaseModel
    {
        public double? BeginValue { get; set; }

        public double? EndValue { get; set; }

        public int? CountLabels { get; set; }

        public int? Percent { get; set; }

        public List<FuzzyLabel> List { get; set; }

        public Dictionary<string, (double, double, double)> Values { get; set; }

        
    }
}