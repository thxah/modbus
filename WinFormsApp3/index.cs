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

namespace WinFormsApp3
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        private void index_Load(object sender, EventArgs e)
        {

        }

        private void ReceiveBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuadrateSelect_DropDown(object sender, EventArgs e)
        {


        }
        private void BuadrateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            //BuadrateSelect.Items.Clear();
            //// 添加选项值
            //BuadrateSelect.Items.Add("9600");
            //BuadrateSelect.Items.Add("19200");
            //BuadrateSelect.Items.Add("38400");
            //BuadrateSelect.Items.Add("57600");
            //BuadrateSelect.Items.Add("115200");

            //// 设置默认选中的选项
            //BuadrateSelect.SelectedIndex = 0;

            //// 添加 ComboBox 控件到窗体中
            //Controls.Add(BuadrateSelect);
            ////BuadrateSelect.SelectedIndex = 0;

        }

        private void DataBitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("please select data");
        }

        private void OpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBaudRate = BuadrateSelect.SelectedItem.ToString();
                // 将数据添加到 TextBox 控件中
                ReceiveBox.AppendText(selectedBaudRate + "\r" + "\n");
                // 移动光标到文本末尾
                ReceiveBox.SelectionStart = ReceiveBox.Text.Length;
                // 滚动文本框
                ReceiveBox.ScrollToCaret();
            }
            catch
            {
                ReceiveBox.AppendText("error");
            }
            //PrintDataToTextBox("Hello, world!");
        }

        private void TextBoxPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DateBitsName_Click(object sender, EventArgs e)
        {

        }

        private void ComPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                ComPortSelect.Items.Add(s);
            }

            Controls.Add(ComPortSelect);
        }
    }
}
