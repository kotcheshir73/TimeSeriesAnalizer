using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSeriesAnalizer
{
    public class AnalizerTimeSeriesBindingModel
    {
        public List<TimeSeriesPoint> TimeSeries { get; set; }

        public IFuzzyTimeSeries FuzzyTimeSeries { get; set; }
    }
}