﻿
namespace CSharp上位机
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_Open = new System.Windows.Forms.Button();
            this.CheckBit = new System.Windows.Forms.ComboBox();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.PortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkbox_sendNewline = new System.Windows.Forms.CheckBox();
            this.checkbox_send16 = new System.Windows.Forms.CheckBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.checkbox_rec16 = new System.Windows.Forms.CheckBox();
            this.textBox_rec = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_clearchart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.text_setmin = new System.Windows.Forms.NumericUpDown();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_setmax = new System.Windows.Forms.NumericUpDown();
            this.button_set = new System.Windows.Forms.Button();
            this.label_Temp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_chart = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_setmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_setmax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Search);
            this.groupBox1.Controls.Add(this.Button_Open);
            this.groupBox1.Controls.Add(this.CheckBit);
            this.groupBox1.Controls.Add(this.DataBit);
            this.groupBox1.Controls.Add(this.StopBit);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.PortName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(156, 23);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 20);
            this.Button_Search.TabIndex = 12;
            this.Button_Search.Text = "搜索串口";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(8, 175);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(137, 35);
            this.Button_Open.TabIndex = 10;
            this.Button_Open.Text = "打开串口";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // CheckBit
            // 
            this.CheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckBit.FormattingEnabled = true;
            this.CheckBit.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.CheckBit.Location = new System.Drawing.Point(53, 149);
            this.CheckBit.Name = "CheckBit";
            this.CheckBit.Size = new System.Drawing.Size(92, 20);
            this.CheckBit.TabIndex = 9;
            // 
            // DataBit
            // 
            this.DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.DataBit.Location = new System.Drawing.Point(53, 118);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(92, 20);
            this.DataBit.TabIndex = 8;
            // 
            // StopBit
            // 
            this.StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBit.Location = new System.Drawing.Point(53, 86);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(92, 20);
            this.StopBit.TabIndex = 7;
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(53, 53);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(92, 20);
            this.BaudRate.TabIndex = 6;
            // 
            // PortName
            // 
            this.PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortName.FormattingEnabled = true;
            this.PortName.Location = new System.Drawing.Point(53, 23);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(92, 20);
            this.PortName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.checkbox_sendNewline);
            this.tabPage1.Controls.Add(this.checkbox_send16);
            this.tabPage1.Controls.Add(this.button_send);
            this.tabPage1.Controls.Add(this.button_clear);
            this.tabPage1.Controls.Add(this.textBox_send);
            this.tabPage1.Controls.Add(this.checkbox_rec16);
            this.tabPage1.Controls.Add(this.textBox_rec);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口助手";
            // 
            // checkbox_sendNewline
            // 
            this.checkbox_sendNewline.AutoSize = true;
            this.checkbox_sendNewline.Location = new System.Drawing.Point(533, 349);
            this.checkbox_sendNewline.Name = "checkbox_sendNewline";
            this.checkbox_sendNewline.Size = new System.Drawing.Size(72, 16);
            this.checkbox_sendNewline.TabIndex = 15;
            this.checkbox_sendNewline.Text = "发送新行";
            this.checkbox_sendNewline.UseVisualStyleBackColor = true;
            // 
            // checkbox_send16
            // 
            this.checkbox_send16.AutoSize = true;
            this.checkbox_send16.Location = new System.Drawing.Point(533, 371);
            this.checkbox_send16.Name = "checkbox_send16";
            this.checkbox_send16.Size = new System.Drawing.Size(60, 16);
            this.checkbox_send16.TabIndex = 14;
            this.checkbox_send16.Text = "16进制";
            this.checkbox_send16.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(532, 393);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 13;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(684, 200);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "清空接收";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(6, 229);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(520, 187);
            this.textBox_send.TabIndex = 2;
            // 
            // checkbox_rec16
            // 
            this.checkbox_rec16.AutoSize = true;
            this.checkbox_rec16.Location = new System.Drawing.Point(684, 178);
            this.checkbox_rec16.Name = "checkbox_rec16";
            this.checkbox_rec16.Size = new System.Drawing.Size(60, 16);
            this.checkbox_rec16.TabIndex = 11;
            this.checkbox_rec16.Text = "16进制";
            this.checkbox_rec16.UseVisualStyleBackColor = true;
            // 
            // textBox_rec
            // 
            this.textBox_rec.BackColor = System.Drawing.Color.White;
            this.textBox_rec.Location = new System.Drawing.Point(249, 6);
            this.textBox_rec.Multiline = true;
            this.textBox_rec.Name = "textBox_rec";
            this.textBox_rec.ReadOnly = true;
            this.textBox_rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_rec.Size = new System.Drawing.Size(429, 217);
            this.textBox_rec.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button_clearchart);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "波形图";
            // 
            // button_clearchart
            // 
            this.button_clearchart.Location = new System.Drawing.Point(8, 364);
            this.button_clearchart.Name = "button_clearchart";
            this.button_clearchart.Size = new System.Drawing.Size(776, 52);
            this.button_clearchart.TabIndex = 1;
            this.button_clearchart.Text = "清空图表";
            this.button_clearchart.UseVisualStyleBackColor = true;
            this.button_clearchart.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 352);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.text_setmin);
            this.tabPage3.Controls.Add(this.label_min);
            this.tabPage3.Controls.Add(this.label_max);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.text_setmax);
            this.tabPage3.Controls.Add(this.button_set);
            this.tabPage3.Controls.Add(this.label_Temp);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "温度设置";
            // 
            // text_setmin
            // 
            this.text_setmin.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_setmin.Location = new System.Drawing.Point(467, 142);
            this.text_setmin.Name = "text_setmin";
            this.text_setmin.Size = new System.Drawing.Size(139, 44);
            this.text_setmin.TabIndex = 11;
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_min.Location = new System.Drawing.Point(274, 138);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(140, 48);
            this.label_min.TabIndex = 10;
            this.label_min.Text = "00.00";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_max.Location = new System.Drawing.Point(274, 73);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(140, 48);
            this.label_max.TabIndex = 9;
            this.label_max.Text = "00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 48);
            this.label8.TabIndex = 8;
            this.label8.Text = "下限：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 48);
            this.label7.TabIndex = 7;
            this.label7.Text = "上限：";
            // 
            // text_setmax
            // 
            this.text_setmax.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_setmax.Location = new System.Drawing.Point(467, 77);
            this.text_setmax.Name = "text_setmax";
            this.text_setmax.Size = new System.Drawing.Size(139, 44);
            this.text_setmax.TabIndex = 5;
            // 
            // button_set
            // 
            this.button_set.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_set.Location = new System.Drawing.Point(16, 200);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(756, 202);
            this.button_set.TabIndex = 3;
            this.button_set.Text = "设置上下限";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_Temp
            // 
            this.label_Temp.AutoSize = true;
            this.label_Temp.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Temp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Temp.Location = new System.Drawing.Point(274, 10);
            this.label_Temp.Name = "label_Temp";
            this.label_Temp.Size = new System.Drawing.Size(140, 48);
            this.label_Temp.TabIndex = 2;
            this.label_Temp.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 48);
            this.label6.TabIndex = 1;
            this.label6.Text = "当前温度：";
            // 
            // timer_chart
            // 
            this.timer_chart.Interval = 50;
            this.timer_chart.Tick += new System.EventHandler(this.timer_chart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "多功能上位机——By 赵铭鑫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_setmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_setmax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkbox_rec16;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.ComboBox CheckBit;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox PortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Search;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkbox_send16;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_rec;
        private System.Windows.Forms.CheckBox checkbox_sendNewline;
        private System.Windows.Forms.Button button_clearchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer_chart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown text_setmax;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Label label_Temp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown text_setmin;
    }
}

