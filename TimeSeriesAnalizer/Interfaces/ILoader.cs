using System.Collections.Generic;

namespace TimeSeriesAnalizer
{
    public interface ILoader
    {
        List<TimeSeriesPoint> LoadTS(LoaderConfig config);
    }
}