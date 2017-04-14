using System;
using System.Collections.Generic;
using System.Text;
using OleDbOperate;
using System.Data;
using System.Data.OleDb;

namespace ChefMonitor
{
    public class CDataAdaHelper : COleDbOperate
    {
        public CDataAdaHelper():base()
        {
        }

        public CDataAdaHelper(string ConnectStr)
            : base(ConnectStr)
        {
        }
        public DataTable GetGoodsClassify()
        {
            return GetDataTable("Select * From tGoodsClassify");
        }

        public bool UpdateBillListState(long BillListID, int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));

            string SQLText = "Update tBillList Set State=? where BillListID=?";
            if (State == 1)
            {
                SQLText = "Update tBillList Set State=?,OrderTime=GETDATE() where BillListID=?";
            }
            else if (State == 2)
            {
                SQLText = "Update tBillList Set State=?,ServingTime=GETDATE() where BillListID=?";
            }
            ParamCollection.Add(MakeInParam("BillListID", OleDbType.BigInt, 8, BillListID));
            if (this.ExecSql(SQLText, ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
