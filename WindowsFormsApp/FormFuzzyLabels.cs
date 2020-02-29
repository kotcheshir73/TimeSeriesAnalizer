using System.Windows.Forms;
using TimeSeriesAnalizer;

namespace WindowsFormsApp
{
    public partial class FormFuzzyLabels : Form
    {
        public FormFuzzyLabels()
        {
            InitializeComponent();
        }

        public void Load(FuzzyLabelsViewModel model)
        {
            if(model != null)
            {
                dataGridViewFuzzyLabels.Rows.Clear();
                foreach(var elem in model.FuzzyLabels)
                {
                    dataGridViewFuzzyLabels.Rows.Add(new object[] { elem.LinguisticTerm, elem.MinVal, elem.Center, elem.MaxVal });
                }
            }
        }
    }
}