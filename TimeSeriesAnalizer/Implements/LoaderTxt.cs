using System;
using System.Collections.Generic;
using System.IO;

namespace TimeSeriesAnalizer
{
    public class LoaderTxt : ILoader
    {
        public List<TimeSeriesPoint> LoadTS(LoaderConfig config)
        {
            var timeSeries = new List<TimeSeriesPoint>();

            try
            {
                var reading = new StreamReader(config.Path);
                string read = reading.ReadLine();
                while (read != null)
                {
                    if (double.TryParse(read.Replace('.', ','), out double val))
                    {
                        timeSeries.Add(new TimeSeriesPoint { Value = val });
                    }
                    else if (double.TryParse(read.Replace(',', '.'), out val))
                    {
                        timeSeries.Add(new TimeSeriesPoint { Value = val });
                    }
                    else
                        break;
                    read = reading.ReadLine();
                }
                reading.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return timeSeries;
        }
    }
}