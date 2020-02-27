namespace TimeSeriesAnalizer
{
    public interface IFuzzyTimeSeries
    {
        void Fuzzyfication(FuzzyTimeSeriesBaseModel model);

        void FuzzyPoint(FuzzyTimeSeriesBindingModel model);
    }
}