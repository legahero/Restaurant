using System;
using System.Collections.Generic;
using System.Text;
using MixFunc;

namespace Restaurant
{
    public class CRunSetting
    {
        static public int Prompt = 0;//Reckoning
        static public int AutoClearTable = 0;//Reckoning
        static public int AutoOpenCashbox = 0;//Reckoning
        static public string CashboxPort = "LPT1";
        static public string ClientPromptPort = "COM1";
        static public int MoneyStype = 0;//Reckoning

        static public string BillPrinter = "";
        static public string BillMode = "";

        static public string OrderPrinter = "";
        static public string OrderMode = "";

        static public string ServingPrinter = "";
        static public string ServingMode = "";

        static public string ReportPrinter = "";
        static public string ReportMode = "";

        public CRunSetting()
		{
			//从注册表加载数据
			LoadData();
            
		}

        ~CRunSetting()
		{
			//保存数据
			SaveData();            
		}
        /// <summary>
		/// 加载数据
		/// </summary>
        public static void LoadData()
        {
            string szOptionFile;
            szOptionFile = System.Windows.Forms.Application.StartupPath + "\\RunSetting.dat";
            if (System.IO.File.Exists(szOptionFile))
            {
                System.Text.StringBuilder szValue = new System.Text.StringBuilder("", 256);

                int iRet;
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "Prompt", Prompt.ToString(), szValue, 256, szOptionFile);
                try
                {
                    Prompt = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "AutoClearTable", AutoClearTable.ToString(), szValue, 256, szOptionFile);
                try
                {
                    AutoClearTable = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "AutoOpenCashbox", AutoOpenCashbox.ToString(), szValue, 256, szOptionFile);
                try
                {
                    AutoOpenCashbox = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "MoneyStype", MoneyStype.ToString(), szValue, 256, szOptionFile);
                try
                {
                    MoneyStype = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "CashboxPort", CashboxPort, szValue, 256, szOptionFile);
                CashboxPort = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Reckoning", "ClientPromptPort", CashboxPort, szValue, 256, szOptionFile);
                ClientPromptPort = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "BillPrinter", BillPrinter, szValue, 256, szOptionFile);
                BillPrinter = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "BillMode", BillMode, szValue, 256, szOptionFile);
                BillMode = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "OrderPrinter", OrderPrinter, szValue, 256, szOptionFile);
                OrderPrinter = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "OrderMode", OrderMode, szValue, 256, szOptionFile);
                OrderMode = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "ServingPrinter", ServingPrinter, szValue, 256, szOptionFile);
                ServingPrinter = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "ServingMode", ServingMode, szValue, 256, szOptionFile);
                ServingMode = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "ReportPrinter", ReportPrinter, szValue, 256, szOptionFile);
                ReportPrinter = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Print", "ReportMode", ReportMode, szValue, 256, szOptionFile);
                ReportMode = szValue.ToString();
            }
        }
        /// <summary>
		/// 保存数据
		/// </summary>
        public static void SaveData()
        {
            string szOptionFile;
            szOptionFile = System.Windows.Forms.Application.StartupPath + "\\RunSetting.dat";


            int iRet = 0;
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "Prompt", Prompt.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "AutoClearTable", AutoClearTable.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "AutoOpenCashbox", AutoOpenCashbox.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "MoneyStype", MoneyStype.ToString(), szOptionFile);

            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "CashboxPort", CashboxPort, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Reckoning", "ClientPromptPort", ClientPromptPort, szOptionFile);


            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "BillPrinter", BillPrinter, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "BillMode", BillMode, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "OrderPrinter", OrderPrinter, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "OrderMode", OrderMode, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "ServingPrinter", ServingPrinter, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "ServingMode", ServingMode, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "ReportPrinter", ReportPrinter, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Print", "ReportMode", ReportMode, szOptionFile);
        }
    }
}
