namespace WindowsFormsApp
{
    partial class FormClustering
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownClusterCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMaxSteps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAccurancy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownQ = new System.Windows.Forms.NumericUpDown();
            this.buttonRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusterCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccurancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество кластеров:";
            // 
            // numericUpDownClusterCount
            // 
            this.numericUpDownClusterCount.Location = new System.Drawing.Point(209, 20);
            this.numericUpDownClusterCount.Name = "numericUpDownClusterCount";
            this.numericUpDownClusterCount.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownClusterCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальное количество шагов:";
            // 
            // numericUpDownMaxSteps
            // 
            this.numericUpDownMaxSteps.Location = new System.Drawing.Point(209, 60);
            this.numericUpDownMaxSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSteps.Name = "numericUpDownMaxSteps";
            this.numericUpDownMaxSteps.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMaxSteps.TabIndex = 3;
            this.numericUpDownMaxSteps.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Точность:";
            // 
            // numericUpDownAccurancy
            // 
            this.numericUpDownAccurancy.DecimalPlaces = 6;
            this.numericUpDownAccurancy.Location = new System.Drawing.Point(209, 99);
            this.numericUpDownAccurancy.Name = "numericUpDownAccurancy";
            this.numericUpDownAccurancy.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownAccurancy.TabIndex = 9;
            this.numericUpDownAccurancy.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Фиксированный параметр:";
            // 
            // numericUpDownQ
            // 
            this.numericUpDownQ.DecimalPlaces = 1;
            this.numericUpDownQ.Location = new System.Drawing.Point(209, 142);
            this.numericUpDownQ.Name = "numericUpDownQ";
            this.numericUpDownQ.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownQ.TabIndex = 7;
            this.numericUpDownQ.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(209, 191);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(96, 24);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // FormClustering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 236);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.numericUpDownQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownAccurancy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMaxSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownClusterCount);
            this.Controls.Add(this.label1);
            this.Name = "FormClustering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кластеризация";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusterCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccurancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownClusterCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAccurancy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownQ;
        private System.Windows.Forms.Button buttonRun;
    }
}