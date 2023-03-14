using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class modbusRTU
    {
        private void PrintDataToTextBox(string data)
        {
            // 在数据前添加时间戳
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string message = string.Format("[{0}] {1}{2}", timeStamp, data, Environment.NewLine);

            // 将数据添加到 TextBox 控件中
            index index = new index();
            //index
                //AppendText(message);
        }

    }
}
