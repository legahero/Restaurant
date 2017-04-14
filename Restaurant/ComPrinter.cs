using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Ports;

namespace Restaurant
{
    public class ComPrinter:IDisposable
    {
        System.IO.Ports.SerialPort m_sp = null;

        string m_portName = "";
        public ComPrinter(string portName)
        {
            m_portName = portName;
            m_sp = new SerialPort(portName,9600,Parity.None,8,StopBits.One);
        }
        public string PortNamae
        {
            get
            {
                return m_portName;
            }
        }
        public void Dispose()
        {
            this.Close();
        }
        public bool IsOpen
        {            
            get
            {
                return m_sp.IsOpen;
            }
        }
        public void Close()
        {
            if (m_sp.IsOpen) m_sp.Close();
        }

        public void DisplayMessage(string Msg)
        {
            m_sp.Open();

            //客显初始化
            byte[] byChar=new byte[1];
            byChar[0]=Convert.ToByte(31);
            m_sp.Write(byChar, 0, 1);

            //显示位置设置
            byte[] byChar1 = new byte[2];
            byChar1[0] = Convert.ToByte(16);
            byChar1[1] = Convert.ToByte(1);
            m_sp.Write(byChar1, 2, 0);

            m_sp.WriteLine(Msg);

            m_sp.Close();
        }

        public void OpenCashbox()
        {
            m_sp.Open();

            //客显初始化
            byte[] byChar = new byte[1];
            byChar[0] = Convert.ToByte(7);//0x7通过打印机缓冲区打开钱箱
            m_sp.Write(byChar, 0, 1);

            //显示位置设置
            byte[] byChar1 = new byte[1];
            byChar1[0] = Convert.ToByte(28);//1B  立即打开钱箱
            m_sp.Write(byChar1, 0, 1);

            m_sp.Close();
        }
    }
}
