
namespace Lab13
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.par1 = new System.Windows.Forms.NumericUpDown();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.TextBox();
            this.Chi_squared = new System.Windows.Forms.TextBox();
            this.Variance = new System.Windows.Forms.TextBox();
            this.Var_err = new System.Windows.Forms.TextBox();
            this.Ave_err = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of experiments";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.start.Location = new System.Drawing.Point(355, 54);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(163, 60);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 120);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(923, 465);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // par1
            // 
            this.par1.DecimalPlaces = 2;
            this.par1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.par1.Location = new System.Drawing.Point(135, 41);
            this.par1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.par1.Name = "par1";
            this.par1.Size = new System.Drawing.Size(120, 26);
            this.par1.TabIndex = 8;
            this.par1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // number
            // 
            this.number.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.number.Location = new System.Drawing.Point(208, 82);
            this.number.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 26);
            this.number.TabIndex = 9;
            this.number.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(561, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(561, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Variance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(561, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi-squared";
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(673, 9);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(100, 26);
            this.Average.TabIndex = 13;
            // 
            // Chi_squared
            // 
            this.Chi_squared.Location = new System.Drawing.Point(673, 82);
            this.Chi_squared.Name = "Chi_squared";
            this.Chi_squared.Size = new System.Drawing.Size(100, 26);
            this.Chi_squared.TabIndex = 14;
            // 
            // Variance
            // 
            this.Variance.Location = new System.Drawing.Point(673, 43);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(100, 26);
            this.Variance.TabIndex = 15;
            // 
            // Var_err
            // 
            this.Var_err.Location = new System.Drawing.Point(804, 44);
            this.Var_err.Name = "Var_err";
            this.Var_err.Size = new System.Drawing.Size(100, 26);
            this.Var_err.TabIndex = 16;
            // 
            // Ave_err
            // 
            this.Ave_err.Location = new System.Drawing.Point(804, 9);
            this.Ave_err.Name = "Ave_err";
            this.Ave_err.Size = new System.Drawing.Size(100, 26);
            this.Ave_err.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(317, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Geometric distribution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(800, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "l";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(960, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ave_err);
            this.Controls.Add(this.Var_err);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Chi_squared);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.par1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown par1;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox Chi_squared;
        private System.Windows.Forms.TextBox Variance;
        private System.Windows.Forms.TextBox Var_err;
        private System.Windows.Forms.TextBox Ave_err;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

