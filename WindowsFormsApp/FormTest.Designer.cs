namespace WindowsFormsApp
{
    partial class FormTest
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
            this.buttonClustering = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLoadTxt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAnalizer = new System.Windows.Forms.Button();
            this.textBoxNyMin = new System.Windows.Forms.TextBox();
            this.textBoxNyMax = new System.Windows.Forms.TextBox();
            this.textBoxEntropyNyMin = new System.Windows.Forms.TextBox();
            this.textBoxEntropyNyMax = new System.Windows.Forms.TextBox();
            this.buttonShowFuzzyLabels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь до файла:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(102, 6);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(219, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(327, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // openFileDialogTxt
            // 
            this.openFileDialogTxt.Filter = "TXT | *.txt";
            // 
            // buttonClustering
            // 
            this.buttonClustering.Location = new System.Drawing.Point(25, 140);
            this.buttonClustering.Name = "buttonClustering";
            this.buttonClustering.Size = new System.Drawing.Size(100, 34);
            this.buttonClustering.TabIndex = 3;
            this.buttonClustering.Text = "Кластеризация";
            this.buttonClustering.UseVisualStyleBackColor = true;
            this.buttonClustering.Click += new System.EventHandler(this.ButtonClustering_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(150, 140);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(100, 34);
            this.buttonTriangle.TabIndex = 4;
            this.buttonTriangle.Text = "Треугольная функция";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonLoadTxt
            // 
            this.buttonLoadTxt.Location = new System.Drawing.Point(56, 48);
            this.buttonLoadTxt.Name = "buttonLoadTxt";
            this.buttonLoadTxt.Size = new System.Drawing.Size(102, 49);
            this.buttonLoadTxt.TabIndex = 5;
            this.buttonLoadTxt.Text = "Загрузить текстовый файл";
            this.buttonLoadTxt.UseVisualStyleBackColor = true;
            this.buttonLoadTxt.Click += new System.EventHandler(this.ButtonLoadTxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 221);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonAnalizer
            // 
            this.buttonAnalizer.Location = new System.Drawing.Point(286, 140);
            this.buttonAnalizer.Name = "buttonAnalizer";
            this.buttonAnalizer.Size = new System.Drawing.Size(116, 34);
            this.buttonAnalizer.TabIndex = 7;
            this.buttonAnalizer.Text = "Анализ";
            this.buttonAnalizer.UseVisualStyleBackColor = true;
            this.buttonAnalizer.Click += new System.EventHandler(this.ButtonAnalizer_Click);
            // 
            // textBoxNyMin
            // 
            this.textBoxNyMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNyMin.Location = new System.Drawing.Point(517, 448);
            this.textBoxNyMin.Name = "textBoxNyMin";
            this.textBoxNyMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxNyMin.TabIndex = 8;
            // 
            // textBoxNyMax
            // 
            this.textBoxNyMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNyMax.Location = new System.Drawing.Point(517, 489);
            this.textBoxNyMax.Name = "textBoxNyMax";
            this.textBoxNyMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxNyMax.TabIndex = 9;
            // 
            // textBoxEntropyNyMin
            // 
            this.textBoxEntropyNyMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEntropyNyMin.Location = new System.Drawing.Point(654, 448);
            this.textBoxEntropyNyMin.Name = "textBoxEntropyNyMin";
            this.textBoxEntropyNyMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntropyNyMin.TabIndex = 10;
            // 
            // textBoxEntropyNyMax
            // 
            this.textBoxEntropyNyMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEntropyNyMax.Location = new System.Drawing.Point(654, 489);
            this.textBoxEntropyNyMax.Name = "textBoxEntropyNyMax";
            this.textBoxEntropyNyMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntropyNyMax.TabIndex = 11;
            // 
            // buttonShowFuzzyLabels
            // 
            this.buttonShowFuzzyLabels.Location = new System.Drawing.Point(428, 140);
            this.buttonShowFuzzyLabels.Name = "buttonShowFuzzyLabels";
            this.buttonShowFuzzyLabels.Size = new System.Drawing.Size(116, 34);
            this.buttonShowFuzzyLabels.TabIndex = 12;
            this.buttonShowFuzzyLabels.Text = "Метки";
            this.buttonShowFuzzyLabels.UseVisualStyleBackColor = true;
            this.buttonShowFuzzyLabels.Click += new System.EventHandler(this.ButtonShowFuzzyLabels_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 533);
            this.Controls.Add(this.buttonShowFuzzyLabels);
            this.Controls.Add(this.textBoxEntropyNyMax);
            this.Controls.Add(this.textBoxEntropyNyMin);
            this.Controls.Add(this.textBoxNyMax);
            this.Controls.Add(this.textBoxNyMin);
            this.Controls.Add(this.buttonAnalizer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoadTxt);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonClustering);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogTxt;
        private System.Windows.Forms.Button buttonClustering;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonLoadTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAnalizer;
        private System.Windows.Forms.TextBox textBoxNyMin;
        private System.Windows.Forms.TextBox textBoxNyMax;
        private System.Windows.Forms.TextBox textBoxEntropyNyMin;
        private System.Windows.Forms.TextBox textBoxEntropyNyMax;
        private System.Windows.Forms.Button buttonShowFuzzyLabels;
    }
}