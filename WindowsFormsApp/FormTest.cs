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

        private IFuzzyTimeSeries fuzzyTimeSeries;

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
                textBoxValueMin.Text = fuzzyTimeSeriesBaseModel.Points.Min(x => x.Value).ToString();
                textBoxValueMax.Text = fuzzyTimeSeriesBaseModel.Points.Max(x => x.Value).ToString();
            }
        }

        private void Fuzzy(IFuzzyTimeSeries fts)
        {
            fuzzyTimeSeries = fts;
            if(fuzzyTimeSeries != null && fuzzyTimeSeriesBaseModel != null)
            {
                fuzzyTimeSeries.Fuzzyfication(fuzzyTimeSeriesBaseModel);

                dataGridView1.DataSource = fuzzyTimeSeriesBaseModel.Points;

                textBoxNyMin.Text = fuzzyTimeSeriesBaseModel.Points.Min(x => Math.Abs(x.Ny.Value)).ToString();
                textBoxNyMax.Text = fuzzyTimeSeriesBaseModel.Points.Max(x => Math.Abs(x.Ny.Value)).ToString();
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
                textBoxEntropyNyMin.Text = fuzzyTimeSeriesBaseModel.Points.Min(x => Math.Abs(x.EntropyMembershipFunction.Value)).ToString();
                textBoxEntropyNyMax.Text = fuzzyTimeSeriesBaseModel.Points.Max(x => Math.Abs(x.EntropyMembershipFunction.Value)).ToString();
            }
        }

        private void ButtonShowFuzzyLabels_Click(object sender, EventArgs e)
        {
            if (fuzzyTimeSeries != null)
            {
                var form = new FormFuzzyLabels();
                form.Load(fuzzyTimeSeries.GetFuzzyLabels());
                form.Show();
            }
        }

        private void ButtonTriangle_Click(object sender, EventArgs e)
        {
            var form = new FormTriangular();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var config = form.Config;
                config.Points = fuzzyTimeSeriesBaseModel.Points;
                fuzzyTimeSeriesBaseModel = config;

                Fuzzy(new TriangularFuzzyTimeSeries());
            }
        }
    }
}
