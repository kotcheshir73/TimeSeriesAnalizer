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
    public partial class FormTriangular : Form
    {
        public TriangularConfig Config { get; set; }

        public FormTriangular()
        {
            InitializeComponent();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if(radioButtonUseTable.Checked)
            {
                if(dataGridViewFuzzyLabels.Rows.Count == 1)
                {
                    MessageBox.Show("Введите нечеткие метки");
                    return;
                }

                Config = new TriangularConfig
                {
                    List = new List<FuzzyLabel>()
                };

                for(int i = 0;i < dataGridViewFuzzyLabels.Rows.Count - 1; ++i)
                {
                    Config.List.Add(new FuzzyLabel
                    {
                        LinguisticTerm = dataGridViewFuzzyLabels.Rows[i].Cells[0].Value.ToString(),
                        MinVal = dataGridViewFuzzyLabels.Rows[i].Cells[1].Value.ToDouble(),
                        Center = dataGridViewFuzzyLabels.Rows[i].Cells[2].Value.ToDouble(),
                        MaxVal = dataGridViewFuzzyLabels.Rows[i].Cells[3].Value.ToDouble()
                    });
                }
            }
            else if (radioButtonUseParameters.Checked)
            {
                if(textBoxBeginValue.Text.IsEmpty() || textBoxEndValue.Text.IsEmpty() || numericUpDownCountLabels.Value == 0 || numericUpDownPercent.Value == 0)
                {
                    MessageBox.Show("Не все параметры заполнены");
                    return;
                }

                Config = new TriangularConfig
                {
                    BeginValue = textBoxBeginValue.Text.ToDouble(),
                    EndValue = textBoxEndValue.Text.ToDouble(),
                    CountLabels = numericUpDownCountLabels.Value.ToInt(),
                    Percent = numericUpDownPercent.Value.ToInt()
                };
            }

            DialogResult = DialogResult.OK;
        }
    }
}