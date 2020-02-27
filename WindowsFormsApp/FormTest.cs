using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSeriesAnalizer;

namespace WindowsFormsApp
{
    public partial class FormTest : Form
    {
        private FuzzyTimeSeriesBaseModel fuzzyTimeSeriesBaseModel;

        public FormTest()
        {
            InitializeComponent();
        }

        private void LoadData(ILoader loader)
        {
            if(loader != null && textBoxPath.Text.IsNotEmpty())
            {
                fuzzyTimeSeriesBaseModel = new FuzzyTimeSeriesBaseModel
                {
                    Points = loader.LoadTS(new LoaderConfig { Path = textBoxPath.Text })
                };
                dataGridView1.DataSource = fuzzyTimeSeriesBaseModel.Points;
            }
        }

        private void Fuzzy(IFuzzyTimeSeries fuzzyTimeSeries)
        {
            if(fuzzyTimeSeries != null && fuzzyTimeSeriesBaseModel != null)
            {
                fuzzyTimeSeries.Fuzzyfication(fuzzyTimeSeriesBaseModel);

                dataGridView1.DataSource = fuzzyTimeSeriesBaseModel.Points;

                textBoxNyMin.Text = fuzzyTimeSeriesBaseModel.Points.Min(x => x.Ny).ToString();
                textBoxNyMax.Text = fuzzyTimeSeriesBaseModel.Points.Max(x => x.Ny).ToString();
            }
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogTxt.ShowDialog() == DialogResult.OK) { textBoxPath.Text = openFileDialogTxt.FileName; }
        }

        private void ButtonClustering_Click(object sender, EventArgs e)
        {
            var form = new FormClustering();
            if(form.ShowDialog() == DialogResult.OK)
            {
                var config = form.Config;
                config.Points = fuzzyTimeSeriesBaseModel.Points;
                fuzzyTimeSeriesBaseModel = config;

                Fuzzy(new ClusterFcmFuzzyTimeSeries());
            }
        }

        private void ButtonLoadTxt_Click(object sender, EventArgs e) => LoadData(new LoaderTxt());

        private void ButtonAnalizer_Click(object sender, EventArgs e)
        {
            if(fuzzyTimeSeriesBaseModel != null)
            {
                Analizer analizer = new Analizer();

                analizer.AnalizerTimeSeries(new AnalizerTimeSeriesBindingModel
                {
                    TimeSeries = fuzzyTimeSeriesBaseModel.Points
                });

                dataGridView1.DataSource = fuzzyTimeSeriesBaseModel.Points;
                textBoxEntropyNyMin.Text = fuzzyTimeSeriesBaseModel.Points.Min(x => x.EntropyMembershipFunction).ToString();
                textBoxEntropyNyMax.Text = fuzzyTimeSeriesBaseModel.Points.Max(x => x.EntropyMembershipFunction).ToString();
            }
        }
    }
}
