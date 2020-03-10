namespace TimeSeriesAnalizer
{
    public class FuzzyLabel
    {
        public string LinguisticTerm { get; set; }

        public double? MinVal { get; set; }

        public double? MaxVal { get; set; }

        public double? Center { get; set; }

        public double? Entropy { get; set; }
    }
}