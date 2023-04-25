namespace ЗамкнСМО__расчёт_кол_ва_специалистов
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.label_M = new System.Windows.Forms.Label();
            this.textBox_Nh = new System.Windows.Forms.TextBox();
            this.label_Nh = new System.Windows.Forms.Label();
            this.textBox_Tp = new System.Windows.Forms.TextBox();
            this.label_Tp = new System.Windows.Forms.Label();
            this.textBox_λ = new System.Windows.Forms.TextBox();
            this.label_λ = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Button_Grafik = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "m (кол-во сотрудников)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "S (расходы)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(15, 19);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1130, 433);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "ddd";
            title1.BorderWidth = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Расчёт необходимого количества сотрудников";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 458);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_M);
            this.groupBox2.Controls.Add(this.label_M);
            this.groupBox2.Controls.Add(this.textBox_Nh);
            this.groupBox2.Controls.Add(this.label_Nh);
            this.groupBox2.Controls.Add(this.textBox_Tp);
            this.groupBox2.Controls.Add(this.label_Tp);
            this.groupBox2.Controls.Add(this.textBox_λ);
            this.groupBox2.Controls.Add(this.label_λ);
            this.groupBox2.Controls.Add(this.textBox_n);
            this.groupBox2.Controls.Add(this.label_n);
            this.groupBox2.Controls.Add(this.menuStrip2);
            this.groupBox2.Location = new System.Drawing.Point(12, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // textBox_M
            // 
            this.textBox_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M.Location = new System.Drawing.Point(840, 36);
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(125, 26);
            this.textBox_M.TabIndex = 10;
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_M.Location = new System.Drawing.Point(651, 40);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(183, 18);
            this.label_M.TabIndex = 9;
            this.label_M.Text = "M (зарплата сотрудника)";
            this.label_M.UseMnemonic = false;
            // 
            // textBox_Nh
            // 
            this.textBox_Nh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Nh.Location = new System.Drawing.Point(510, 68);
            this.textBox_Nh.Name = "textBox_Nh";
            this.textBox_Nh.Size = new System.Drawing.Size(125, 26);
            this.textBox_Nh.TabIndex = 8;
            // 
            // label_Nh
            // 
            this.label_Nh.AutoSize = true;
            this.label_Nh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Nh.Location = new System.Drawing.Point(299, 76);
            this.label_Nh.Name = "label_Nh";
            this.label_Nh.Size = new System.Drawing.Size(205, 18);
            this.label_Nh.TabIndex = 7;
            this.label_Nh.Text = "N (стоимость часа простоя)";
            this.label_Nh.UseMnemonic = false;
            // 
            // textBox_Tp
            // 
            this.textBox_Tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Tp.Location = new System.Drawing.Point(509, 36);
            this.textBox_Tp.Name = "textBox_Tp";
            this.textBox_Tp.Size = new System.Drawing.Size(125, 26);
            this.textBox_Tp.TabIndex = 6;
            // 
            // label_Tp
            // 
            this.label_Tp.AutoSize = true;
            this.label_Tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tp.Location = new System.Drawing.Point(299, 40);
            this.label_Tp.Name = "label_Tp";
            this.label_Tp.Size = new System.Drawing.Size(138, 18);
            this.label_Tp.TabIndex = 5;
            this.label_Tp.Text = "Tp (ср.вр.ремонта)";
            this.label_Tp.UseMnemonic = false;
            // 
            // textBox_λ
            // 
            this.textBox_λ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_λ.Location = new System.Drawing.Point(155, 68);
            this.textBox_λ.Name = "textBox_λ";
            this.textBox_λ.Size = new System.Drawing.Size(125, 26);
            this.textBox_λ.TabIndex = 4;
            // 
            // label_λ
            // 
            this.label_λ.AutoSize = true;
            this.label_λ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_λ.Location = new System.Drawing.Point(20, 72);
            this.label_λ.Name = "label_λ";
            this.label_λ.Size = new System.Drawing.Size(131, 18);
            this.label_λ.TabIndex = 3;
            this.label_λ.Text = "λ (кол-во заявок)";
            this.label_λ.UseMnemonic = false;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_n.Location = new System.Drawing.Point(155, 36);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(125, 26);
            this.textBox_n.TabIndex = 2;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_n.Location = new System.Drawing.Point(20, 40);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(116, 18);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "n (кол-во ЭВМ)";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(980, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Button_Grafik
            // 
            this.Button_Grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Grafik.Location = new System.Drawing.Point(1014, 595);
            this.Button_Grafik.Name = "Button_Grafik";
            this.Button_Grafik.Size = new System.Drawing.Size(143, 39);
            this.Button_Grafik.TabIndex = 10;
            this.Button_Grafik.Text = "Построить график";
            this.Button_Grafik.UseVisualStyleBackColor = true;
            this.Button_Grafik.Click += new System.EventHandler(this.Button_Grafik_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Clear.Location = new System.Drawing.Point(1014, 542);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(143, 39);
            this.Button_Clear.TabIndex = 11;
            this.Button_Clear.Text = "Очистить график";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 662);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Grafik);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расчёт количества сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox textBox_Nh;
        private System.Windows.Forms.Label label_Nh;
        private System.Windows.Forms.TextBox textBox_Tp;
        private System.Windows.Forms.Label label_Tp;
        private System.Windows.Forms.TextBox textBox_λ;
        private System.Windows.Forms.Label label_λ;
        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Button Button_Grafik;
        private System.Windows.Forms.Button Button_Clear;
    }
}

