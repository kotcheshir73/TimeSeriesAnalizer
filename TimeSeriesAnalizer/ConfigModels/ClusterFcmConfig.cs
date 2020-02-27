namespace TimeSeriesAnalizer
{
    public class ClusterFcmConfig : FuzzyTimeSeriesBaseModel
    {
        public int CountCenters { get; set; }

        public int MaxStep { get; set; }

        public double Accurancy { get; set; } //Math.Pow(10, -5);

        public double Q { get; set; } // 1.5
    }
}