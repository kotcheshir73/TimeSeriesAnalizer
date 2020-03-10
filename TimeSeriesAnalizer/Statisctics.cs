using System.Collections.Generic;
using System.Linq;

namespace TimeSeriesAnalizer
{
    public static class Statisctics
    {
        private static Dictionary<string, int> fuzzyLabels;

        private static Dictionary<string, int> phasePlane;

        private static Dictionary<string, Dictionary<string, int>> phasePlaneDependce;

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

        public static void InitPhasePlaneStatistics()
        {
            if (phasePlane == null)
            {
                phasePlane = new Dictionary<string, int>();
            }
            else
            {
                phasePlane.Clear();
            }
            if (phasePlaneDependce == null)
            {
                phasePlaneDependce = new Dictionary<string, Dictionary<string, int>>();
            }
            else
            {
                phasePlaneDependce.Clear();
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

        public static double PhasePlaneStatistics(string label, string beforeLabel = null)
        {
            if (phasePlane == null) { InitFuzzyLabelStatistics(); }

            if (phasePlane.ContainsKey(label))
            {
                phasePlane[label]++;
            }
            else
            {
                phasePlane.Add(label, 1);
            }

            if(!string.IsNullOrEmpty(beforeLabel))
            {
                if(!phasePlaneDependce.ContainsKey(beforeLabel))
                {
                    phasePlaneDependce.Add(beforeLabel, new Dictionary<string, int>());
                }

                if(phasePlaneDependce[beforeLabel].ContainsKey(label))
                {
                    phasePlaneDependce[beforeLabel][label]++;
                }
                else
                {
                    phasePlaneDependce[beforeLabel].Add(label, 1);
                }

                return ((double)phasePlaneDependce[beforeLabel][label] / phasePlaneDependce[beforeLabel].Values.Sum()) / (double)phasePlane[beforeLabel] / phasePlane.Values.Sum();
            }

            return (double)phasePlane[label] / phasePlane.Values.Sum();
        }
    }
}