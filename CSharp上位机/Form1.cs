using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CSharp上位机
{
    public partial class Form1 : Form
    {
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

            BaudRate.Text = "4800";
            StopBit.Text = "1";
            DataBit.Text = "8";
            CheckBit.Text = "无";

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_ReceiveData);
        }

        /*
         * 功能：串口接收数据处理函数
         */
        private void SerialPort_ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {

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
    }
}
