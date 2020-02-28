using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalizer
{
    public static class Statisctics
    {
        private static Dictionary<string, int> fuzzyLabels;

        public static void InitFuzzyLabelStatistics()
        {
            if(fuzzyLabels == null)
            {
                fuzzyLabels = new Dictionary<string, int>();
            }
            else
            {
                fuzzyLabels.Clear();
            }
        }

        public static double FuzzyLabelStatistics(string label)
        {
            if(fuzzyLabels == null) { InitFuzzyLabelStatistics(); }

            if(fuzzyLabels.ContainsKey(label))
            {
                fuzzyLabels[label]++;
            }
            else
            {
                fuzzyLabels.Add(label, 1);
            }

            return (double)fuzzyLabels[label] / fuzzyLabels.Values.Sum();
        }
    }
}
