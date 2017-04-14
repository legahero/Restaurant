using System;
using System.Collections.Generic;
using System.Text;
using YyLogger;
using System.Data;
using System.Data.OleDb;

namespace ChefMonitor
{
    public class CGlobalInstance
    {
        public CDataAdaHelper DbAdaHelper = null;
        public CFileLogger FileLogger = new CFileLogger("AppLog");

        public DataTable dtBillState;
        public DataTable dtBillType;
        /// <summary>
        /// 全局访问实例
        /// </summary>
        static CGlobalInstance g_Instance = new CGlobalInstance();

        CGlobalInstance()
        {
            DbAdaHelper = new CDataAdaHelper();
            DbAdaHelper.OnErrorEvent += new OleDbOperate.OnErrorEventHandler(Db_OnErrorEvent);

            dtBillState = new DataTable("dtState");
            dtBillState.Columns.Add("Name", System.Type.GetType("System.String"));
            dtBillState.Columns.Add("Value", System.Type.GetType("System.Int32"));

            DataRow dr2 = dtBillState.NewRow();
            dr2["Name"] = "未送厨";
            dr2["Value"] = 0;
            dtBillState.Rows.Add(dr2);

            dr2 = dtBillState.NewRow();
            dr2["Name"] = "已送厨";
            dr2["Value"] = 1;
            dtBillState.Rows.Add(dr2);

            dr2 = dtBillState.NewRow();
            dr2["Name"] = "等上菜";
            dr2["Value"] = 2;
            dtBillState.Rows.Add(dr2);

            dr2 = dtBillState.NewRow();
            dr2["Name"] = "已上菜";
            dr2["Value"] = 3;
            dtBillState.Rows.Add(dr2);

            dtBillType = new DataTable("Type");//点单，退单，赠单,退赠
            dtBillType.Columns.Add("Name", System.Type.GetType("System.String"));
            dtBillType.Columns.Add("Value", System.Type.GetType("System.Int32"));

            DataRow dr = dtBillType.NewRow();
            dr["Name"] = "点单";
            dr["Value"] = 0;
            dtBillType.Rows.Add(dr);

            dr = dtBillType.NewRow();
            dr["Name"] = "退单";
            dr["Value"] = 1;
            dtBillType.Rows.Add(dr);

            dr = dtBillType.NewRow();
            dr["Name"] = "赠单";
            dr["Value"] = 2;
            dtBillType.Rows.Add(dr);

            dr = dtBillType.NewRow();
            dr["Name"] = "退赠";
            dr["Value"] = 3;
            dtBillType.Rows.Add(dr);
        }

        /// <summary>
        /// 全局访问实例。
        /// </summary>
        public static CGlobalInstance Instance
        {
            get
            {

                return g_Instance;
            }
        }

        void Db_OnErrorEvent(OleDbOperate.DbErrorEventArgs e)
        {
            WriteErrorLog(LogSeverity.error, e.ExtraMsg, e.Ex);
        }
        public void WriteErrorLog(LogSeverity Level, string source, Exception Ex)
        {
            FileLogger.WriteLog(Level, source, Ex.Message + ":" + Ex.StackTrace);
        }
    }
}
