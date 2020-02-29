namespace WindowsFormsApp
{
    partial class FormFuzzyLabels
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
            this.dataGridViewFuzzyLabels = new System.Windows.Forms.DataGridView();
            this.ColumnLinguisticTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyLabels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFuzzyLabels
            // 
            this.dataGridViewFuzzyLabels.AllowUserToAddRows = false;
            this.dataGridViewFuzzyLabels.AllowUserToDeleteRows = false;
            this.dataGridViewFuzzyLabels.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewFuzzyLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuzzyLabels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLinguisticTerm,
            this.ColumnMinVal,
            this.ColumnCenter,
            this.ColumnMaxVal});
            this.dataGridViewFuzzyLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFuzzyLabels.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFuzzyLabels.Name = "dataGridViewFuzzyLabels";
            this.dataGridViewFuzzyLabels.ReadOnly = true;
            this.dataGridViewFuzzyLabels.RowHeadersVisible = false;
            this.dataGridViewFuzzyLabels.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewFuzzyLabels.TabIndex = 1;
            // 
            // ColumnLinguisticTerm
            // 
            this.ColumnLinguisticTerm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLinguisticTerm.HeaderText = "Название метки";
            this.ColumnLinguisticTerm.Name = "ColumnLinguisticTerm";
            this.ColumnLinguisticTerm.ReadOnly = true;
            // 
            // ColumnMinVal
            // 
            this.ColumnMinVal.HeaderText = "Мин знач.";
            this.ColumnMinVal.Name = "ColumnMinVal";
            this.ColumnMinVal.ReadOnly = true;
            // 
            // ColumnCenter
            // 
            this.ColumnCenter.HeaderText = "Центр";
            this.ColumnCenter.Name = "ColumnCenter";
            this.ColumnCenter.ReadOnly = true;
            // 
            // ColumnMaxVal
            // 
            this.ColumnMaxVal.HeaderText = "Макс. знач.";
            this.ColumnMaxVal.Name = "ColumnMaxVal";
            this.ColumnMaxVal.ReadOnly = true;
            // 
            // FormFuzzyLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFuzzyLabels);
            this.Name = "FormFuzzyLabels";
            this.Text = "Нечеткие центры";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyLabels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFuzzyLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLinguisticTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMinVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxVal;
    }
}