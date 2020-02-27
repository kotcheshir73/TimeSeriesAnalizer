using System;
using System.Windows.Forms;
using TimeSeriesAnalizer;

namespace WindowsFormsApp
{
    public partial class FormClustering : Form
    {
        public ClusterFcmConfig Config { get; private set; }

        public FormClustering()
        {
            InitializeComponent();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            Config = new ClusterFcmConfig
            {
                CountCenters = numericUpDownClusterCount.Value.ToInt(),
                MaxStep = numericUpDownMaxSteps.Value.ToInt(),
                Accurancy = numericUpDownAccurancy.Value.ToDouble(),
                Q = numericUpDownQ.Value.ToDouble()
            };

            DialogResult = DialogResult.OK;
        }
    }
}