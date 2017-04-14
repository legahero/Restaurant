using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using YyLogger;
using MixFunc;

//如果您是使用 OLEDB 的应用程序开发人员，请将 ConnectionString 属性的 Provider 参数设置为“Microsoft.ACE.OLEDB.12.0” 
//如果要连接到 Microsoft Office Excel 数据，请将“Excel 12.0”添加到 OLEDB 连接字符串的扩展属性中。
//如果您是使用 ODBC 连接到 Microsoft Office Access 数据的应用程序开发人员，请将连接字符串设置为“Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=path to mdb/accdb file”
//如果您是使用 ODBC 连接到 Microsoft Office Excel 数据的应用程序开发人员，请将连接字符串设置为“Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=path to xls/xlsx/xlsm/xlsb file”

namespace MixLib
{
	/// <summary>
	/// 程序选项
	/// </summary>
	public class CAppOption
	{
		//全局变量
		public static Int64   m_lUserID=-1;//登录之后才有
		public static string m_sUserName="";//登录之后才有
        public static string m_sUserAlias="";//登录之后才有
        public static string m_sUserWorkID="";//登录之后才有

		public static string m_sUser="";
		public static string m_sPwd="";
        /// <summary>
        /// Provider=Microsoft.Jet.OLEDB.4.0;Data Source=client.mdb;Persist Security Info=False;Jet OLEDB:DataBase Password=cxw
        /// Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\DB\Restaurant.mdb;Persist Security Info=False;Jet OLEDB:DataBase Password=legahero123
        /// </summary>
        public static string m_sDbConnectString = @"";
        //@"Provider=SQLOLEDB.1;Password=13902410869;Persist Security Info=True;User ID=sa;Initial Catalog=OAManage;Data Source=192.168.1.143\\OAMANAGEDB;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=localhost;Use Encryption for Data=False;Tag with column collation when possible=False";//Integrated Security=SSPI;Packet Size=4096;Data Source=OAMANAGE\OAMANAGEDB;Tag with column collation when possible=False;Initial Catalog=OAManage;Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider=""SQLOLEDB.1"";Workstation ID=localhost;Use Encryption for Data=False";
		public static bool m_bSavePwd;//需要使用上次保存的密码

        public static int iAppStyle = 0;//应用类型，0，1
        public static string WindowTitle = "勇影餐饮系统";
        public static int iFormStyle = 0;
        public static int PageRowCount = 22;
        public static string NumberFormat;
        public static string MoneyFormat;
        public static int iSortStyle = 0;

        public static string Idiograph = "";
        public static string RegisterUser = "";
        public static string RegisterCode = "";
        public static string RegKeyNO = "";
        public static bool bRegister = false;
        public static CWindowStyleMan WindowStyleMan = new CWindowStyleMan(System.Windows.Forms.Application.StartupPath + "\\Style.dat");

        public CAppOption()
		{
			//从注册表加载数据
			LoadData();
            
		}

		 ~CAppOption()
		{
			//保存数据
			SaveData();
            
		}
        public static void LoadKeyNO()
        {
            string szOptionFile;
			szOptionFile =System.Windows.Forms.Application.StartupPath+"\\Option.dat";
            if (System.IO.File.Exists(szOptionFile))
            {
                System.Text.StringBuilder szValue = new System.Text.StringBuilder("", 1024);

                int iRet;
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Register", "KeyNO", RegKeyNO.ToString(), szValue, 1024, szOptionFile);
                try
                {
                    RegKeyNO = szValue.ToString();
                }
                catch
                {
                }
            }
        }
		/// <summary>
		/// 加载数据
		/// </summary>
		public static void LoadData()
		{
            string szOptionFile;
			szOptionFile =System.Windows.Forms.Application.StartupPath+"\\Option.dat";
            if (System.IO.File.Exists(szOptionFile))
            {
                System.Text.StringBuilder szValue = new System.Text.StringBuilder("",256);                

                int iRet ;
                iRet=PlatformInvokeKernel32.GetPrivateProfileString("App", "AppStyle", iAppStyle.ToString(), szValue, 256, szOptionFile);
                try
                {
                    iAppStyle = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Windows", "Style", iFormStyle.ToString(), szValue, 256, szOptionFile);

                try
                {
                    iFormStyle = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Windows", "SortStyle", iSortStyle.ToString(), szValue, 256, szOptionFile);

                try
                {
                    iSortStyle = Convert.ToInt32(szValue.ToString());
                }
                catch
                {
                }
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Windows", "NumberFormat", NumberFormat, szValue, 256, szOptionFile);

                NumberFormat = szValue.ToString();
                if (NumberFormat == "")
                {
                    NumberFormat = "0.00";
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Windows", "MoneyFormat", MoneyFormat, szValue, 256, szOptionFile);

                MoneyFormat = szValue.ToString();
                if (MoneyFormat == "")
                {
                    MoneyFormat = "0.00";
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Windows", "PageRowCount", PageRowCount.ToString(), szValue, 256, szOptionFile);

                try
                {
                    PageRowCount = Convert.ToInt32(szValue.ToString());
                    if (PageRowCount < 10)
                    {
                        PageRowCount = 22;
                    }
                }
                catch
                {
                    PageRowCount = 22;
                }

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("App", "Idiograph", "", szValue, 256, szOptionFile);
                Idiograph = szValue.ToString();
                
                //注册码
                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Register", "Code", "", szValue, 256, szOptionFile);
                RegisterCode = szValue.ToString();

                iRet = PlatformInvokeKernel32.GetPrivateProfileString("Register", "User", "", szValue, 256, szOptionFile);
                RegisterUser = szValue.ToString();

                string strMac = CGeneralFunction.GetMACaddressOne();                
                Restaurant.CGlobalInstance.Instance.FileLogger.WriteLog(YyLogger.LogSeverity.info, "配置加载", string.Format("Mac:{0}", strMac));

                if (strMac.Length > 0)
                {
                    SimpleScrypt SScrypt = new SimpleScrypt();
                    if (SScrypt.Encrypt(strMac) == RegisterCode)
                    {
                        bRegister = true;
                    }
                    if (!string.IsNullOrEmpty(RegisterUser) && SScrypt.Encrypt(RegisterUser) == RegisterCode)
                    {
                        bRegister = true;
                    }
#if DEBUG
                    if (bRegister==false)
                    {
                        Restaurant.CGlobalInstance.Instance.FileLogger.WriteLog(YyLogger.LogSeverity.info, "配置加载", string.Format("RegisterCode:{0}", SScrypt.Encrypt(strMac)));
                        Restaurant.CGlobalInstance.Instance.FileLogger.WriteLog(YyLogger.LogSeverity.info, "配置加载", string.Format("RegisterCode:{0}", SScrypt.Encrypt(RegisterUser)));
                    }
#endif
                }
            }
            WindowStyleMan.LoadData();
            

			RegistryKey oRegSoft;
			oRegSoft=Registry.LocalMachine.OpenSubKey("SOFTWARE",true);
			if(oRegSoft==null)
			{
				//建立
				oRegSoft=Registry.LocalMachine.CreateSubKey("SOFTWARE");
			}

			RegistryKey oRegTemp=oRegSoft.OpenSubKey(Application.ProductName,true);
			if(oRegTemp==null)
			{
				oRegTemp=oRegSoft.CreateSubKey(Application.ProductName);
			}
			m_sUser=(string)oRegTemp.GetValue("User","Admin");

            m_sPwd = "";//20090110修改，不再
			//m_sPwd=Decrypt((string)oRegTemp.GetValue("Pwd",""));

            //Jet的开发已经停止了，所以没有64位的版本。
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\DB\Restaurant.mdb;Persist Security Info=False;Jet OLEDB:DataBase Password=legahero123            
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\DB\Restaurant.accdb;Persist Security Info=False;Jet OLEDB:DataBase Password=legahero123
            string strAcc = "";//CYyScrypt.Encrypt(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Restaurant.mdb;Persist Security Info=False;Jet OLEDB:DataBase Password=legahero123");
            strAcc = "501D3F1847F9C54142AA6F0AF66D6F44C616C01EE400418CDAC8F89571A22E17D16E33A09E861EB9B253E258914D771FFDFDD75238B3085A49A885C62DFDF07D28F5DB62128B2D2D56D99B6571A27D9997C8EC446A5486366356281FBA2054D696DB7FA70E84BE91652FD7E333AA30A4DCEF7FE9D96538F2A43E3AA1777167209D4FE216F3A74373F152199CF089A987E707D7313E695522A798E4F5CAB316C1D1F72C51761BA18CA5BA726083D45D667DCA404A0CB8A5152BDCC50131A32A2BF554FCFF4FCE7AD9CC98DD954F54B177ED27D8D45E46078D704C8A83E3C4F0A8ED4E069B18936EB1998A7C72599628214665452AE7F5E217D98DD2674884";

#if TMPRELEASE
            //单机版            
            m_sDbConnectString = CYyScrypt.Decrypt(strAcc);

#else
            m_sDbConnectString = CYyScrypt.Decrypt((string)oRegTemp.GetValue("DbConnect", CYyScrypt.Encrypt(m_sDbConnectString)));
#endif
            m_bSavePwd =Convert.ToBoolean(oRegTemp.GetValue("SavePwd",true));

		
		}
        public static void SaveKeyNO()
        {
            string szOptionFile;
            szOptionFile = System.Windows.Forms.Application.StartupPath + "\\Option.dat";


            int iRet = 0;
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Register", "KeyNO", RegKeyNO.ToString(), szOptionFile);
        }
		/// <summary>
		/// 保存数据
		/// </summary>
		public static void SaveData()
		{
            string szOptionFile;
            szOptionFile = System.Windows.Forms.Application.StartupPath + "\\Option.dat";

            
            int iRet=0;
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("App", "AppStyle", iAppStyle.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("App", "Idiograph", Idiograph,  szOptionFile);


            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Windows", "Style", iFormStyle.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Windows", "SortStyle", iSortStyle.ToString(), szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Windows", "NumberFormat", NumberFormat, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Windows", "MoneyFormat", MoneyFormat, szOptionFile);
            iRet = PlatformInvokeKernel32.WritePrivateProfileString("Windows", "PageRowCount", PageRowCount.ToString(), szOptionFile);

            WindowStyleMan.SaveData();

			RegistryKey oRegSoft;
			oRegSoft=Registry.LocalMachine.OpenSubKey("SOFTWARE",true);
			if(oRegSoft==null)
			{
				//建立
				oRegSoft=Registry.LocalMachine.CreateSubKey("SOFTWARE");
			}

			RegistryKey oRegTemp=oRegSoft.OpenSubKey(Application.ProductName,true);
			if(oRegTemp==null)
			{
				oRegTemp=oRegSoft.CreateSubKey(Application.ProductName);
			}
#if RELEASE || DEBUG
            oRegTemp.SetValue("DbConnect", CYyScrypt.Encrypt(m_sDbConnectString));
#endif

			oRegTemp.SetValue("User",m_sUser);
            oRegTemp.SetValue("Pwd", CYyScrypt.Encrypt(m_sPwd));            
			oRegTemp.SetValue("SavePwd",m_bSavePwd);
			oRegTemp.Flush();
		}
				
	}
}
