﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace CSharp上位机
{
    public partial class Form1 : Form
    {
        private byte[] data_to_send = new byte[7];

        private List<int> List_ia = new List<int>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        /*
         * 功能：打开程序后搜索串口并设定默认值
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortName.Items.AddRange(ports);
            PortName.SelectedIndex = PortName.Items.Count > 0 ? 0 : -1;

            BaudRate.Text = "115200";
            StopBit.Text = "1";
            DataBit.Text = "8";
            CheckBit.Text = "无";

            serialPort1.DataReceived += SerialPort_ReceiveData;
        }

        /*
         * 功能：串口接收数据处理函数
         */
        private void SerialPort_ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            int length = serialPort1.BytesToRead;
            byte[] data = new byte[length];
            serialPort1.Read(data, 0, length);
            if ((data[0] == 0xff) && (data[1] == 0x01))
            {
                int datalength = data[2];
                byte[] data_to_display = new byte[datalength];
                for (int i = 0; i < datalength; i++)
                {
                    data_to_display[i] = data[i + 3];
                }
                float display_temp_num = (((Int16)data_to_display[0] << 8) | (data_to_display[1])) / 100.0f;
                float display_max_num = (((Int16)data_to_display[2] << 8) | (data_to_display[3])) / 100.0f;
                float display_min_num = (((Int16)data_to_display[4] << 8) | (data_to_display[5])) / 100.0f;

                string display_temp = display_temp_num.ToString();
                string display_max = display_max_num.ToString();
                string display_min = display_min_num.ToString();
                label_Temp.Text = display_temp;
                label_max.Text = display_max;
                label_min.Text = display_min;
                if (display_temp_num > display_max_num || display_temp_num < display_min_num)
                {
                    label_Temp.ForeColor = Color.Red;
                }
                else
                {
                    label_Temp.ForeColor = Color.Black;
                }
            }
            if (checkbox_rec16.Checked)
            {
                string str = BitConverter.ToString(data).Replace("-", " ") + " ";
                textBox_rec.AppendText(str);
            }
            else
            {
                //string str = serialPort1.ReadExisting();
                //textBox_rec.AppendText(str);
            }
        }

        /*
         * 功能：搜索串口
         */
        private void Button_Search_Click(object sender, EventArgs e)
        {
            PortName.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            PortName.Items.AddRange(ports);
            PortName.SelectedIndex = PortName.Items.Count > 0 ? 0 : -1;
        }

        /*
         * 功能：打开串口
         */
        private void Button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = PortName.SelectedItem.ToString();
                    serialPort1.BaudRate = Convert.ToInt32(BaudRate.SelectedItem);
                    switch (StopBit.SelectedItem)
                    {
                        case "1":
                            {
                                serialPort1.StopBits = StopBits.One;
                                break;
                            }
                        case "1.5":
                            {
                                serialPort1.StopBits = StopBits.OnePointFive;
                                break;
                            }
                        case "2":
                            {
                                serialPort1.StopBits = StopBits.Two;
                                break;
                            }
                        default:
                            break;
                    }
                    serialPort1.DataBits = Convert.ToInt32(DataBit.SelectedItem);
                    switch (CheckBit.SelectedItem)
                    {
                        case "无":
                            {
                                serialPort1.Parity = Parity.None;
                                break;
                            }
                        case "奇校验":
                            {
                                serialPort1.Parity = Parity.Odd;
                                break;
                            }
                        case "偶校验":
                            {
                                serialPort1.Parity = Parity.Even;
                                break;
                            }
                        default:
                            break;
                    }
                    serialPort1.Open();
                    Button_Open.Text = "关闭串口";
                    PortName.Enabled = false;
                }
                else
                {
                    serialPort1.Close();
                    Button_Open.Text = "打开串口";
                    PortName.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("打开串口失败！", "错误");
            }
        }

        /*
         * 功能：清空接收文本框内容
         */
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_rec.Clear();
        }

        /*
         * 功能：发送数据
         */
        private void button_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (checkbox_send16.Checked)//以16进制发送
                    {
                        string str = textBox_send.Text.Replace(" ", "");
                        
                        if (str.Length % 2 == 1)
                        {
                            str = str.Insert(str.Length - 1, "0");
                        }

                        int length = str.Length / 2;
                        if (checkbox_sendNewline.Checked)
                        {
                            length += 2;
                        }

                        byte[] data = new byte[length];

                        for (int i = 0; i < str.Length / 2; i++)
                        {
                            data[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
                        }
                        if (checkbox_sendNewline.Checked)
                        {
                            data[length - 2] = Convert.ToByte("0D", 16);
                            data[length - 1] = Convert.ToByte("0A", 16);
                        }

                        serialPort1.Write(data, 0, data.Length);
                    }
                    else//以字符串发送
                    {
                        string str = textBox_send.Text;
                        if (checkbox_sendNewline.Checked)
                        {
                            str += "\r\n";
                        }
                        serialPort1.Write(str);
                    }
                }
                catch
                {
                    serialPort1.Close();
                    Button_Open.Text = "打开串口";
                    PortName.Enabled = true;
                    MessageBox.Show("数据发送错误！已关闭串口", "错误");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button_clearchart.Text == "开始")
            {
                timer_chart.Start();
                button_clearchart.Text = "暂停";
            }
            else
            {
                timer_chart.Stop();
                button_clearchart.Text = "开始";
            }
        }

        private void timer_chart_Tick(object sender, EventArgs e)
        {
            int num1 = random.Next(0, 500);   //随机数
            List_ia.Add(num1);
            ListRemove(List_ia);
            DrawChart(List_ia);
        }

        private void DrawChart(List<int> List_ia)
        {
            chart1.Series[0].Points.Clear();    //清除所有点

            for (int i = 0; i < List_ia.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, List_ia[i]);   //添加点
            }

        }

        private void ClearAllList()
        {
            List_ia.Clear();

        }

        private void ListRemove(List<int> list)
        {
            if (list.Count >= 50)
            {
                list.RemoveAt(0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
            if (serialPort1.IsOpen)
            {
                data_to_send[0] = 0xff;
                data_to_send[1] = 0x02;
                data_to_send[2] = 0x04;
                //高位在前低位在后
                data_to_send[3] = (byte)(Convert.ToInt16(text_setmax.Value * 100) >> 8);
                data_to_send[4] = (byte)(Convert.ToInt16(text_setmax.Value * 100));
                data_to_send[5] = (byte)(Convert.ToInt16(text_setmin.Value * 100) >> 8);
                data_to_send[6] = (byte)(Convert.ToInt16(text_setmin.Value * 100));
                try
                {
                    serialPort1.Write(data_to_send, 0, data_to_send.Length);
                }
                catch
                {
                    MessageBox.Show("发送数据出错", "错误");
                }
                
            }
            else
            {
                MessageBox.Show("请打开串口", "提示");
            }
        }
    }
}
