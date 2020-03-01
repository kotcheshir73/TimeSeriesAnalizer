namespace WindowsFormsApp
{
    partial class FormTriangular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFuzzyLabels = new System.Windows.Forms.GroupBox();
            this.dataGridViewFuzzyLabels = new System.Windows.Forms.DataGridView();
            this.ColumnLinguisticTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPercent = new System.Windows.Forms.NumericUpDown();
            this.labelPercent = new System.Windows.Forms.Label();
            this.numericUpDownCountLabels = new System.Windows.Forms.NumericUpDown();
            this.labelCountLabels = new System.Windows.Forms.Label();
            this.textBoxEndValue = new System.Windows.Forms.TextBox();
            this.labelEndValue = new System.Windows.Forms.Label();
            this.textBoxBeginValue = new System.Windows.Forms.TextBox();
            this.labelBeginValue = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.radioButtonUseTable = new System.Windows.Forms.RadioButton();
            this.radioButtonUseParameters = new System.Windows.Forms.RadioButton();
            this.groupBoxFuzzyLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyLabels)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountLabels)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFuzzyLabels
            // 
            this.groupBoxFuzzyLabels.Controls.Add(this.dataGridViewFuzzyLabels);
            this.groupBoxFuzzyLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFuzzyLabels.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFuzzyLabels.Name = "groupBoxFuzzyLabels";
            this.groupBoxFuzzyLabels.Size = new System.Drawing.Size(624, 191);
            this.groupBoxFuzzyLabels.TabIndex = 0;
            this.groupBoxFuzzyLabels.TabStop = false;
            this.groupBoxFuzzyLabels.Text = "Нечеткие центры";
            // 
            // dataGridViewFuzzyLabels
            // 
            this.dataGridViewFuzzyLabels.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewFuzzyLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuzzyLabels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLinguisticTerm,
            this.ColumnMinVal,
            this.ColumnCenter,
            this.ColumnMaxVal});
            this.dataGridViewFuzzyLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFuzzyLabels.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFuzzyLabels.Name = "dataGridViewFuzzyLabels";
            this.dataGridViewFuzzyLabels.RowHeadersVisible = false;
            this.dataGridViewFuzzyLabels.Size = new System.Drawing.Size(618, 172);
            this.dataGridViewFuzzyLabels.TabIndex = 0;
            // 
            // ColumnLinguisticTerm
            // 
            this.ColumnLinguisticTerm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLinguisticTerm.HeaderText = "Название метки";
            this.ColumnLinguisticTerm.Name = "ColumnLinguisticTerm";
            // 
            // ColumnMinVal
            // 
            this.ColumnMinVal.HeaderText = "Мин знач.";
            this.ColumnMinVal.Name = "ColumnMinVal";
            // 
            // ColumnCenter
            // 
            this.ColumnCenter.HeaderText = "Центр";
            this.ColumnCenter.Name = "ColumnCenter";
            // 
            // ColumnMaxVal
            // 
            this.ColumnMaxVal.HeaderText = "Макс. знач.";
            this.ColumnMaxVal.Name = "ColumnMaxVal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownPercent);
            this.groupBox2.Controls.Add(this.labelPercent);
            this.groupBox2.Controls.Add(this.numericUpDownCountLabels);
            this.groupBox2.Controls.Add(this.labelCountLabels);
            this.groupBox2.Controls.Add(this.textBoxEndValue);
            this.groupBox2.Controls.Add(this.labelEndValue);
            this.groupBox2.Controls.Add(this.textBoxBeginValue);
            this.groupBox2.Controls.Add(this.labelBeginValue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автоматическое разбиение";
            // 
            // numericUpDownPercent
            // 
            this.numericUpDownPercent.Location = new System.Drawing.Point(455, 58);
            this.numericUpDownPercent.Name = "numericUpDownPercent";
            this.numericUpDownPercent.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPercent.TabIndex = 7;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(318, 61);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(112, 13);
            this.labelPercent.TabIndex = 6;
            this.labelPercent.Text = "Процент наложения:";
            // 
            // numericUpDownCountLabels
            // 
            this.numericUpDownCountLabels.Location = new System.Drawing.Point(455, 28);
            this.numericUpDownCountLabels.Name = "numericUpDownCountLabels";
            this.numericUpDownCountLabels.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCountLabels.TabIndex = 5;
            // 
            // labelCountLabels
            // 
            this.labelCountLabels.AutoSize = true;
            this.labelCountLabels.Location = new System.Drawing.Point(318, 30);
            this.labelCountLabels.Name = "labelCountLabels";
            this.labelCountLabels.Size = new System.Drawing.Size(110, 13);
            this.labelCountLabels.TabIndex = 4;
            this.labelCountLabels.Text = "Количество центров";
            // 
            // textBoxEndValue
            // 
            this.textBoxEndValue.Location = new System.Drawing.Point(162, 58);
            this.textBoxEndValue.Name = "textBoxEndValue";
            this.textBoxEndValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndValue.TabIndex = 3;
            // 
            // labelEndValue
            // 
            this.labelEndValue.AutoSize = true;
            this.labelEndValue.Location = new System.Drawing.Point(25, 61);
            this.labelEndValue.Name = "labelEndValue";
            this.labelEndValue.Size = new System.Drawing.Size(108, 13);
            this.labelEndValue.TabIndex = 2;
            this.labelEndValue.Text = "Конечное значение:";
            // 
            // textBoxBeginValue
            // 
            this.textBoxBeginValue.Location = new System.Drawing.Point(162, 27);
            this.textBoxBeginValue.Name = "textBoxBeginValue";
            this.textBoxBeginValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeginValue.TabIndex = 1;
            // 
            // labelBeginValue
            // 
            this.labelBeginValue.AutoSize = true;
            this.labelBeginValue.Location = new System.Drawing.Point(25, 30);
            this.labelBeginValue.Name = "labelBeginValue";
            this.labelBeginValue.Size = new System.Drawing.Size(115, 13);
            this.labelBeginValue.TabIndex = 0;
            this.labelBeginValue.Text = "Начальное значение:";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(537, 297);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // radioButtonUseTable
            // 
            this.radioButtonUseTable.AutoSize = true;
            this.radioButtonUseTable.Location = new System.Drawing.Point(12, 300);
            this.radioButtonUseTable.Name = "radioButtonUseTable";
            this.radioButtonUseTable.Size = new System.Drawing.Size(141, 17);
            this.radioButtonUseTable.TabIndex = 3;
            this.radioButtonUseTable.TabStop = true;
            this.radioButtonUseTable.Text = "Использовать таблицу";
            this.radioButtonUseTable.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseParameters
            // 
            this.radioButtonUseParameters.AutoSize = true;
            this.radioButtonUseParameters.Location = new System.Drawing.Point(190, 300);
            this.radioButtonUseParameters.Name = "radioButtonUseParameters";
            this.radioButtonUseParameters.Size = new System.Drawing.Size(158, 17);
            this.radioButtonUseParameters.TabIndex = 4;
            this.radioButtonUseParameters.TabStop = true;
            this.radioButtonUseParameters.Text = "Использовать параметры";
            this.radioButtonUseParameters.UseVisualStyleBackColor = true;
            // 
            // FormTriangular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 328);
            this.Controls.Add(this.radioButtonUseParameters);
            this.Controls.Add(this.radioButtonUseTable);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFuzzyLabels);
            this.Name = "FormTriangular";
            this.Text = "Треугольная ФП";
            this.groupBoxFuzzyLabels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyLabels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountLabels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuzzyLabels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewFuzzyLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLinguisticTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMinVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxVal;
        private System.Windows.Forms.TextBox textBoxBeginValue;
        private System.Windows.Forms.Label labelBeginValue;
        private System.Windows.Forms.Label labelEndValue;
        private System.Windows.Forms.Label labelCountLabels;
        private System.Windows.Forms.TextBox textBoxEndValue;
        private System.Windows.Forms.NumericUpDown numericUpDownCountLabels;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NumericUpDown numericUpDownPercent;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.RadioButton radioButtonUseTable;
        private System.Windows.Forms.RadioButton radioButtonUseParameters;
    }
}