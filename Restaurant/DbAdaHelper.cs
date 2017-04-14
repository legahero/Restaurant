using System;
using System.Collections.Generic;
using System.Text;
using OleDbOperate;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using EncryptKVLib;
using MixFunc;
namespace Restaurant
{
    public class _tagAssociatorRecord
    {
        public long RecordID=0;
        public string	CardID="";
        public DateTime	RecordTime=DateTime.Now;
        public string	Employee="";
        public int	OpType=0;
        public double	MoneySum=0;
        public double	Surplus=0;
        public int	IntegralSum=0;
        public int ResidualIntegral = 0;
        public string	Remark="";
    }

    public class _tagAssociatorClassify
    {
        public int	ClassifyID=0;
        public string	ClassifyName="";
        public int	IsTimeLimit=0;
        public int	TimeLimit=365;
        public double AgioRate = 0.98;
        public int	IntegralRadix=100;
        public string	Remark="";
    }

    public class _tagAssociatorParam
    {
        public int AssociatorID = 0;
        public string CardID = "";
        public string CardPwd = "";        
        public string Associator = "";
        public string IdentityCard = "";
        public string Company = "";
        public string Address = "";
        public double Surplus = 0;
        public int Integral = 0;

        public string PostCode = "";
        public string Phone = "";
        public string MobilePhone = "";
        public string Remark = "";
        public DateTime EndDate = DateTime.Now;
        public DateTime RecordTime = DateTime.Now;

        public int ClassifyID = 0;
        public string ClassifyName = "";
        public int IsTimeLimit = 0;
        public int TimeLimit = 365;
        public double AgioRate = 1.00;
        public int IntegralRadix = 100;
    }
    public class _tagAssociator
    {
        public int	AssociatorID=0;
        public string	CardID="";
        public string	CardPwd="";
        public int	ClassifyID=0;
        public string	Associator="";
        public string	IdentityCard="";
        public string	Company="";
        public string	Address="";
        public string PostCode = "";
        public string	Phone="";
        public string	MobilePhone="";
        public DateTime	EndDate=DateTime.Now;
        public double Surplus = 0;
        public int	Integral=0;
        public string	Remark="";
        public DateTime	RecordTime=DateTime.Now;
    }

    public class _tagOnCreditRecord
    {
        public long	RecordID=0;
        public int	OnCreditID=0;
        public DateTime	RecordTime=DateTime.Now;
        public int	OpType=0;
        public double	Number=0;
        public string Employee = "";
        public double	LastNumber=0;//上次数量
    }
    /// <summary>
    /// 挂账
    /// </summary>
    public class _tagOnCredit
    {
        public int	OnCreditID=0;
        public string	ClientName="";
        public string	Company="";
        public string	Address="";
        public string	PostCode="";
        public string	Phone="";
        public string	MobilePhone="";
        public double OnCreditLimit = 0;//限制金额
        public string Remark = "";
        public double OnCreditSum = 0;//已挂账金额

        public double	Surplus=0;

    }

    public class _tagBillList
    {
        public long	BillListID=0;
        public long BillID = 0;        
        public int	GoodsID=0	;
        public string	GoodsName="";
        public double	GoodsNumber=0;
        public double	UnitPrice=0;
        public string	Unit="";
        public int	Type=0;
        public string	Remark="";
        public string	DeductEmployeeNO="";
        public int State=0;
    }
    public class _tagBill
    {
        public long	BillID=0;
        public string	BillNO="";
        public int	TableNO=0;
        public string TableName="";

        public string	ClientName="";
        public int	ClientNumber=0;
        public DateTime	BillTime=DateTime.Now;
        public string	Remark="";
        public double	Account=0;
        public double	Discount=0;
        public double ReceAccount = 0;
        public double	RealAccount=0;        
        public double	Deduct=0;
        public DateTime	PrintTime=DateTime.Now;
        public int Checkout = 0;

        public string Employee = "";//结帐员工
    }
    public class _tagPrearrange
    {
        public long 	PrearrangeID=0;
        public string	ClientName="";
        public int	ClientNumber=0;
        public string	Phone="";
        public string	Remark="";
        public DateTime	OrderTime=DateTime.Now;
        public int	TableNO=0;
        public string	EmployeeNO="";
        public int	State=0;
        public DateTime RecordTime = DateTime.Now;
    }
    public class _tagGoodsMaterial
    {
        public int GoodsMaterialID = 0;
        public string GoodsMaterialNO = "";
        public string GoodsMaterialName = "";
        public int GoodsSubClassifyID = 0;
        public string Unit = "";
        public string PinYin = "";
        public double Cost;

        public string GoodsClassify = "";
        public string GoodsSubClassify = "";
    }
    public class _tagGoods
    {
        public int GoodsID = 0;
        public string GoodsNO="";
        public string GoodsName="";
        public int GoodsSubClassifyID = 0;
        public string Unit="";
        public double UnitPrice;
        public int IsCurrentPrice = 0;
        public string PinYin="";
        public string GoodsCode="";
        public double Cost;
        public double Integral;
        public double Deduct;

        public string GoodsClassify="";
        public string GoodsSubClassify="";
    }

    public class _tagDiningTable
    {
        public int DiningTableID=0;
        public int TableNO;
        public string TableName;
        public int TableClassifyID;
        public int DiningDeptID;
    }
    public class _tagTableClassify
    {
        public int TableClassifyID=0;
        public string ClassifyName;
        public string AdmitNumber;
        public double SeatCost;
    }

    
    public class CDbAdaHelper:COleDbOperate
    {
        EncryptKVLib.CYyKVFile YyKVFile = new CYyKVFile();

        public bool m_KV=false;
        public CDbAdaHelper():base()
        {
            string KvFileName = AppDomain.CurrentDomain.BaseDirectory + "QueryKV.kvl";
            //string KvFileName = @"D:\project\Restaurant\kvl\中文测试\QueryKV.kvl";
            
            //MessageBox.Show("File：" + KvFileName, "写日志");

            m_KV = YyKVFile.Load(KvFileName);
            if (m_KV==false)
            {
                try
                {
                    CLogMgr.G_Instance.WriteErrorLog(LogSeverity.error, "加载KV失败!", new Exception(KvFileName + "不存在或不正确!"));
                    //this.OnError("加载KV失败!", new Exception(KvFileName + "不存在或不正确!"));//这个时候错误事件还没有绑定，无法输出
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("写日志：" + Ex.Message, "写日志");
                }
            }            
            
        }

        public CDbAdaHelper(string ConnectStr)
            : base(ConnectStr)
        {
        }
        public bool IsKVLoad
        {
            get
            {
                return m_KV;
            }
        }
        
        public DataTable GetTableClassify()
        {
#if DEBUG
            YyKVFile.SetValue("GetTableClassify", "Select * From tTableClassify");
#endif

            return GetDataTable(YyKVFile.GetValue("GetTableClassify"));
        }

        public bool UpdateTableClassify(int TableClassifyID, string ClassifyName, string AdmitNumber, double SeatCost)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClassifyName", OleDbType.VarChar, 50, ClassifyName));
            ParamCollection.Add(MakeInParam("AdmitNumber", OleDbType.VarChar, 20, AdmitNumber));
            ParamCollection.Add(MakeInParam("SeatCost", OleDbType.Double, 8, SeatCost));
            ParamCollection.Add(MakeInParam("TableClassifyID", OleDbType.Integer, 4, TableClassifyID));
#if DEBUG
            YyKVFile.SetValue("UpdateTableClassify", "Update tTableClassify Set ClassifyName=?,AdmitNumber=?,SeatCost=? Where TableClassifyID=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("UpdateTableClassify"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddTableClassify( string ClassifyName, string AdmitNumber, double SeatCost)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("TableClassifyID", OleDbType.Integer, 4, TableClassifyID));
            ParamCollection.Add(MakeInParam("ClassifyName", OleDbType.VarChar, 50, ClassifyName));
            ParamCollection.Add(MakeInParam("AdmitNumber", OleDbType.VarChar, 20, AdmitNumber));
            ParamCollection.Add(MakeInParam("SeatCost", OleDbType.Double, 8, SeatCost));
#if DEBUG
            YyKVFile.SetValue("AddTableClassify","Insert into tTableClassify(ClassifyName,AdmitNumber,SeatCost)Values(?,?,?)");
#endif

            if (ExecSql(YyKVFile.GetValue("AddTableClassify"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTableClassify(int TableClassifyID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableClassifyID", OleDbType.Integer, 4, TableClassifyID));
#if DEBUG
            YyKVFile.SetValue("DeleteTableClassify", "Delete From tTableClassify  Where TableClassifyID=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("DeleteTableClassify"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetDiningDept()
        {
            return GetDataTable("Select * From tDiningDept");
        }

        public bool AddDiningDept(int DiningDeptID, string DeptName)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("DeptName", OleDbType.VarChar, 50, DeptName));
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, DiningDeptID));
#if DEBUG
            YyKVFile.SetValue("AddDiningDept", "Insert Into tDiningDept(DeptName,DiningDeptID) Values(?,?) ");
#endif
            if (ExecSql(YyKVFile.GetValue("AddDiningDept"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDiningDept(int DiningDeptID, string DeptName)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("DeptName", OleDbType.VarChar, 50, DeptName));
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, DiningDeptID));

#if DEBUG
            YyKVFile.SetValue("UpdateDiningDept", "Update tDiningDept Set DeptName=? Where DiningDeptID=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("UpdateDiningDept"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDiningDept(int DiningDeptID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, DiningDeptID));

#if DEBUG
            YyKVFile.SetValue("DeleteDiningDept", "Delete From tDiningDept  Where DiningDeptID=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("DeleteDiningDept"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TransferDiningTable(int OldTableNO, int NewTableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableNO0", OleDbType.Integer, 4, NewTableNO));
            ParamCollection.Add(MakeInParam("TableNO1", OleDbType.Integer, 4, OldTableNO));
            

            ParamCollection.Add(MakeInParam("TableNO2", OleDbType.Integer, 4, NewTableNO));
            ParamCollection.Add(MakeInParam("TableNO3", OleDbType.Integer, 4, OldTableNO));
#if DEBUG
            YyKVFile.SetValue("TransferDiningTable", "Update tDiningTable set State=1 where TableNO=? and State=0;Update tDiningTable set State=0 where TableNO=? and State=1;Update tBill Set TableNO=? where TableNO=? and Checkout=0;");
#endif

            if (this.ExecSqlTransaction(YyKVFile.GetValue("TransferDiningTable"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UniteDiningTable(int OldTableNO, int NewTableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableNO1", OleDbType.Integer, 4, OldTableNO));
            

            ParamCollection.Add(MakeInParam("TableNO2", OleDbType.Integer, 4, NewTableNO));
            ParamCollection.Add(MakeInParam("TableNO3", OleDbType.Integer, 4, OldTableNO));

#if DEBUG
            YyKVFile.SetValue("UniteDiningTable", "Update tDiningTable set State=0 where TableNO=? and State=1;Update tBillList Set BillID=(Select BillID From tBill where TableNO=? and Checkout=0) where BillID=(Select BillID From tBill where TableNO=? and Checkout=0) ;");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("UniteDiningTable"), ParamCollection) > 0)
            {
                List<OleDbParameter> Param = new List<OleDbParameter>();
                Param.Add(MakeInParam("TableNO2", OleDbType.VarChar, 20, "Unite " + NewTableNO.ToString()));
                Param.Add(MakeInParam("TableNO1", OleDbType.Integer, 4, OldTableNO));

                this.ExecSql("Update tBill Set Checkout=1,Remark=? where TableNO=? and Checkout=0", Param);
                return true;
            }
            else
            {
                return false;
            }

        }
        public int IsIdleDiningTable(int TableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));
#if DEBUG
            YyKVFile.SetValue("IsIdleDiningTable", "Select Count(*) From tDiningTable where TableNO=? and State=0");
#endif
            object Obj = this.ExecuteScalar(YyKVFile.GetValue("IsIdleDiningTable"), ParamCollection);
            if (Obj!=null)
            {
                return Convert.ToInt32(Obj);
            }else
            {
                return 0;
            }
        }
        public int IsUsingDiningTable(int TableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));
#if DEBUG
            YyKVFile.SetValue("IsUsingDiningTable", "Select Count(*) From tDiningTable where TableNO=? and State=1");
#endif
            object Obj = this.ExecuteScalar(YyKVFile.GetValue("IsUsingDiningTable"), ParamCollection);
            if (Obj != null)
            {
                return Convert.ToInt32(Obj);
            }
            else
            {
                return 0;
            }
        }
        public string GetDiningTableName(int TableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));
#if DEBUG
            YyKVFile.SetValue("GetDiningTableName", "Select TableName From tDiningTable where TableNO=? ");
#endif
            object Obj = this.ExecuteScalar(YyKVFile.GetValue("GetDiningTableName"), ParamCollection);
            if (Obj != null)
            {
                return Obj.ToString();
            }
            else
            {
                return "";
            }
        }
        public DataTable GetDiningTable()
        {
            return GetDataTable("Select * From vDiningTable");
        }
        public DataTable GetDiningTable(int DiningDeptID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, DiningDeptID));

            return GetDataTable("Select * From vDiningTable where DiningDeptID=?", ParamCollection);
        }

        public bool AddDiningTable(_tagDiningTable data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));
            ParamCollection.Add(MakeInParam("TableName", OleDbType.VarChar, 50, data.TableName));
            ParamCollection.Add(MakeInParam("TableClassifyID", OleDbType.Integer, 4, data.TableClassifyID));
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, data.DiningDeptID));

            if (ExecSql("Insert into tDiningTable(TableNO,TableName,TableClassifyID,DiningDeptID) Values(?,?,?,?) ", ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDiningTable(_tagDiningTable data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));
            ParamCollection.Add(MakeInParam("TableName", OleDbType.VarChar, 50, data.TableName));
            ParamCollection.Add(MakeInParam("TableClassifyID", OleDbType.Integer, 4, data.TableClassifyID));
            ParamCollection.Add(MakeInParam("DiningDeptID", OleDbType.Integer, 4, data.DiningDeptID));

            ParamCollection.Add(MakeInParam("DiningTableID", OleDbType.Integer, 4, data.DiningTableID));

            if (ExecSql("Update tDiningTable Set TableNO=?,TableName=?,TableClassifyID=?,DiningDeptID=? Where DiningTableID=? ", ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDiningTableState(int TableNO, int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));

#if DEBUG
            YyKVFile.SetValue("UpdateDiningTableState", "Update tDiningTable Set State=? Where TableNO=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("UpdateDiningTableState"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDiningTable(int DiningTableID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("DiningTableID", OleDbType.Integer, 4, DiningTableID));
#if DEBUG
            YyKVFile.SetValue("DeleteDiningTable", "Delete From tDiningTable  Where DiningTableID=? ");
#endif
            if (ExecSql(YyKVFile.GetValue("DeleteDiningTable"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetGoods()
        {
#if DEBUG
            YyKVFile.SetValue("GetGoods", "Select * From vGoods");
#endif
            return GetDataTable(YyKVFile.GetValue("GetGoods"));
        }
        public DataTable GetGoodsDetail()
        {
#if DEBUG
            YyKVFile.SetValue("GetGoodsDetail", "Select * From vGoodsDetail");
#endif
            return GetDataTable(YyKVFile.GetValue("GetGoodsDetail"));
        }

        public DataTable GetGoodsDetail(int GoodsID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
#if DEBUG
            YyKVFile.SetValue("GetGoodsDetailByID", "Select * From vGoodsDetail where GoodsID=?");
#endif
            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, GoodsID));
            return GetDataTable(YyKVFile.GetValue("GetGoodsDetailByID"), ParamCollection);
        }

        public bool AddGoodsDetail(int GoodsID, int GoodsMaterialID,double Number)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, GoodsID));
            ParamCollection.Add(MakeInParam("GoodsMaterialID", OleDbType.Integer, 4, GoodsMaterialID));
            ParamCollection.Add(MakeInParam("Number", OleDbType.Double, 8, Number));

            if (this.ExecSql("Insert Into tGoodsDetail(GoodsID,GoodsMaterialID,[Number]) Values(?,?,?) ", ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateGoodsDetail(int GoodsDetailID, int GoodsMaterialID, double Number)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            
            ParamCollection.Add(MakeInParam("GoodsMaterialID", OleDbType.Integer, 4, GoodsMaterialID));
            ParamCollection.Add(MakeInParam("Number", OleDbType.Double, 8, Number));
            ParamCollection.Add(MakeInParam("GoodsDetailID", OleDbType.Integer, 4, GoodsDetailID));
#if DEBUG
            YyKVFile.SetValue("UpdateGoodsDetail", "Update tGoodsDetail Set GoodsMaterialID=?,[Number]=? Where GoodsDetailID=?");
#endif
            if (this.ExecSql(YyKVFile.GetValue("UpdateGoodsDetail"), ParamCollection) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetGoodsMaterial()
        {
#if DEBUG
            YyKVFile.SetValue("GetGoodsMaterial", "Select * From vGoodsMaterial");
#endif
            return GetDataTable(YyKVFile.GetValue("GetGoodsMaterial"));
        }

        public DataTable GetGoodsMaterial(string LongMaterialNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("LongMaterialNO", OleDbType.VarChar, 20, LongMaterialNO));
#if DEBUG
            YyKVFile.SetValue("GetGoodsMaterialByNO", "Select * From vGoodsMaterial where LongMaterialNO=?");
#endif
            return GetDataTable(YyKVFile.GetValue("GetGoodsMaterial"), ParamCollection);
        }

        public DataTable GetGoodsClassify()
        {
            return GetDataTable("Select * From tGoodsClassify");
        }

        public bool AddGoodsClassify(string GoodsClassify, string GoodsClassifyName)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsClassify", OleDbType.Char, 2, GoodsClassify));
            ParamCollection.Add(MakeInParam("GoodsClassifyName", OleDbType.VarChar, 50, GoodsClassifyName));

            if (this.ExecSql("Insert Into tGoodsClassify(GoodsClassify,GoodsClassifyName) values(?,?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGoodsClassify(string GoodsClassify)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsClassify", OleDbType.Char, 2, GoodsClassify));

            if (this.ExecSql("Delete From tGoodsClassify Where GoodsClassify=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetGoodsSubClassify(string GoodsClassify)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsClassify", OleDbType.Char, 2, GoodsClassify));

            return GetDataTable("Select * From tGoodsSubClassify where GoodsClassify=?", ParamCollection);
        }
        public int GetGoodsSubClassifyID(string GoodsClassify,string GoodsSubClassify)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsClassify", OleDbType.Char, 2, GoodsClassify));
            ParamCollection.Add(MakeInParam("GoodsSubClassify", OleDbType.Char, 2, GoodsSubClassify));

#if DEBUG
            YyKVFile.SetValue("GetGoodsSubClassifyID", "Select top 1 GoodsSubClassifyID From tGoodsSubClassify where GoodsClassify=? and GoodsSubClassify=?");
#endif
            object obj = this.ExecuteScalar(YyKVFile.GetValue("GetGoodsSubClassifyID"), ParamCollection);
            if(obj!=null)                
            {
                return (int)obj;
            }else
                return 0;
        }
        public bool AddGoodsSubClassify(string GoodsClassify,string GoodsSubClassify, string GoodsSubClassifyName)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsClassify", OleDbType.Char, 2, GoodsClassify));
            ParamCollection.Add(MakeInParam("GoodsSubClassify", OleDbType.Char, 2, GoodsSubClassify));
            ParamCollection.Add(MakeInParam("GoodsSubClassifyName", OleDbType.VarChar, 50, GoodsSubClassifyName));
#if DEBUG
            YyKVFile.SetValue("AddGoodsSubClassify", "Insert Into tGoodsSubClassify(GoodsClassify,GoodsSubClassify,GoodsSubClassifyName) values(?,?,?)");
#endif
            if (this.ExecSql(YyKVFile.GetValue("AddGoodsSubClassify"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGoodsSubClassify(int  GoodsSubClassifyID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsSubClassifyID", OleDbType.Integer, 4, GoodsSubClassifyID));

            if (this.ExecSql("Delete From tGoodsClassify Where GoodsSubClassifyID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }
        public bool AddGoodsMaterial(_tagGoodsMaterial data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("MaterialNO", OleDbType.VarChar, 30, data.GoodsMaterialNO));
            ParamCollection.Add(MakeInParam("MaterialName", OleDbType.VarChar, 50, data.GoodsMaterialName));
            ParamCollection.Add(MakeInParam("GoodsSubClassifyID", OleDbType.Integer, 4, data.GoodsSubClassifyID));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("PinYin", OleDbType.VarChar, 50, data.PinYin));
            ParamCollection.Add(MakeInParam("Cost", OleDbType.Decimal, 9, data.Cost));
#if DEBUG
            YyKVFile.SetValue("AddGoodsMaterial", "Insert Into tGoodsMaterial(MaterialNO,MaterialName,GoodsSubClassifyID,Unit,PinYin,Cost) values(?,?,?,?,?,?)");
#endif
            if (this.ExecSql(YyKVFile.GetValue("AddGoodsMaterial"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateGoodsMaterial(_tagGoodsMaterial data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("MaterialNO", OleDbType.VarChar, 30, data.GoodsMaterialNO));
            ParamCollection.Add(MakeInParam("MaterialName", OleDbType.VarChar, 50, data.GoodsMaterialName));
            ParamCollection.Add(MakeInParam("GoodsSubClassifyID", OleDbType.Integer, 4, data.GoodsSubClassifyID));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("PinYin", OleDbType.VarChar, 50, data.PinYin));
            ParamCollection.Add(MakeInParam("Cost", OleDbType.Decimal, 9, data.Cost));

            ParamCollection.Add(MakeInParam("GoodsMaterialID", OleDbType.Integer, 4, data.GoodsMaterialID));
#if DEBUG
            YyKVFile.SetValue("UpdateGoodsMaterial", "Update tGoodsMaterial Set MaterialNO=?,MaterialName=?,GoodsSubClassifyID=?,Unit=?,PinYin=?,Cost=? Where GoodsMaterialID=?");
#endif
            if (this.ExecSql(YyKVFile.GetValue("UpdateGoodsMaterial"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGoodsMaterial(int GoodsMaterialID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("GoodsMaterialID", OleDbType.Integer, 4, GoodsMaterialID));

            if (this.ExecSql("Delete from  tGoodsMaterial where GoodsMaterialID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddGoods(_tagGoods data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsNO", OleDbType.VarChar, 30, data.GoodsNO));
            ParamCollection.Add(MakeInParam("GoodsName", OleDbType.VarChar, 50, data.GoodsName));
            ParamCollection.Add(MakeInParam("GoodsSubClassifyID", OleDbType.Integer, 4, data.GoodsSubClassifyID));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("UnitPrice", OleDbType.Decimal, 9, data.UnitPrice));
            ParamCollection.Add(MakeInParam("IsCurrentPrice", OleDbType.Integer, 4, data.IsCurrentPrice));
            ParamCollection.Add(MakeInParam("PinYin", OleDbType.VarChar, 50, data.PinYin));
            ParamCollection.Add(MakeInParam("GoodsCode", OleDbType.VarChar, 50, data.GoodsCode));
            ParamCollection.Add(MakeInParam("Cost", OleDbType.Decimal, 9, data.Cost));
            ParamCollection.Add(MakeInParam("Integral", OleDbType.Double, 8, data.Integral));
            ParamCollection.Add(MakeInParam("Deduct", OleDbType.Decimal, 9, data.Deduct));
#if DEBUG
            YyKVFile.SetValue("AddGoods", "Insert Into tGoods(GoodsNO,GoodsName,GoodsSubClassifyID,Unit,UnitPrice,IsCurrentPrice,PinYin,GoodsCode,Cost,Integral,Deduct) values(?,?,?,?,?,?,?,?,?,?,?)");
#endif
            if (this.ExecSql(YyKVFile.GetValue("AddGoods"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateGoods(_tagGoods data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("GoodsNO", OleDbType.VarChar, 30, data.GoodsNO));
            ParamCollection.Add(MakeInParam("GoodsName", OleDbType.VarChar, 50, data.GoodsName));
            ParamCollection.Add(MakeInParam("GoodsSubClassifyID", OleDbType.Integer, 4, data.GoodsSubClassifyID));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("UnitPrice", OleDbType.Decimal, 9, data.UnitPrice));
            ParamCollection.Add(MakeInParam("IsCurrentPrice", OleDbType.Integer, 4, data.IsCurrentPrice));
            ParamCollection.Add(MakeInParam("PinYin", OleDbType.VarChar, 50, data.PinYin));
            ParamCollection.Add(MakeInParam("GoodsCode", OleDbType.VarChar, 50, data.GoodsCode));
            ParamCollection.Add(MakeInParam("Cost", OleDbType.Decimal, 9, data.Cost));
            ParamCollection.Add(MakeInParam("Integral", OleDbType.Double, 8, data.Integral));
            ParamCollection.Add(MakeInParam("Deduct", OleDbType.Decimal, 9, data.Deduct));

            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, data.GoodsID));
#if DEBUG
            YyKVFile.SetValue("UpdateGoods", "Update tGoods Set GoodsNO=?,GoodsName=?,GoodsSubClassifyID=?,Unit=?,UnitPrice=?,IsCurrentPrice=?,PinYin=?,GoodsCode=?,Cost=?,Integral=?,Deduct=? where GoodsID=?");
#endif
            if (this.ExecSql(YyKVFile.GetValue("UpdateGoods"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGoods(int GoodsID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, GoodsID));

            if (this.ExecSql("Delete from  tGoods where GoodsID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGoodsDetail(int GoodsDetailID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("GoodsDetailID", OleDbType.Integer, 4, GoodsDetailID));

            if (this.ExecSql("Delete from  tGoodsDetail where GoodsDetailID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetPrearrange(int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));
#if DEBUG
            YyKVFile.SetValue("GetPrearrange", "Select * from  vPrearrange where State=? order by PrearrangeID DESC");
#endif
            return this.GetDataTable(YyKVFile.GetValue("GetPrearrange"), ParamCollection);
        }

        public DataTable GetPrearrangeByTableNO(int  TableNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));
#if DEBUG
            YyKVFile.SetValue("GetPrearrangeByTableNO", "Select * from  vPrearrange where TableNO=? order by PrearrangeID DESC");
#endif
            return this.GetDataTable(YyKVFile.GetValue("GetPrearrangeByTableNO"), ParamCollection);
        }

        public DataTable GetPrearrange()
        {
            return this.GetDataTable("Select * from  vPrearrange order by PrearrangeID DESC");
            
        }

        public DataTable GetPrearrangeState()
        {
            return this.GetDataTable("Select * from  tPrearrangeState");
        }

        public bool DeletePrearrange(long PrearrangeID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("PrearrangeID", OleDbType.BigInt, 8, PrearrangeID));

            if (this.ExecSql("Delete from  tPrearrange where PrearrangeID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddPrearrange(_tagPrearrange data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("ClientNumber", OleDbType.Integer, 4, data.ClientNumber));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 50, data.Phone));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 512, data.Remark));

            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));            
            ParamCollection.Add(MakeInParam("EmployeeNO", OleDbType.VarChar, 20, data.EmployeeNO));
            ParamCollection.Add(MakeInParam("OrderTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.OrderTime.ToString())));
            //ParamCollection.Add(MakeInParam("OrderTime", OleDbType.DBTimeStamp, 8, data.OrderTime));

#if DEBUG
            YyKVFile.SetValue("AddPrearrange", "Insert Into tPrearrange(ClientName,ClientNumber,Phone,Remark,TableNO,EmployeeNO,OrderTime) values(?,?,?,?,?,?,?)");
#endif
            if (this.ExecSql(YyKVFile.GetValue("AddPrearrange"), ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdatePrearrange(_tagPrearrange data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("ClientNumber", OleDbType.Integer, 4, data.ClientNumber));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 50, data.Phone));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 512, data.Remark));

            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));
            ParamCollection.Add(MakeInParam("EmployeeNO", OleDbType.VarChar, 20, data.EmployeeNO));
            ParamCollection.Add(MakeInParam("OrderTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.OrderTime.ToString())));
            //ParamCollection.Add(MakeInParam("OrderTime", OleDbType.DBTimeStamp, 8, data.OrderTime));

            ParamCollection.Add(MakeInParam("PrearrangeID", OleDbType.BigInt, 8, data.PrearrangeID));
#if DEBUG
            YyKVFile.SetValue("UpdatePrearrange", "Update tPrearrange Set ClientName=?,ClientNumber=?,Phone=?,Remark=?,TableNO=?,EmployeeNO=?,OrderTime=? where PrearrangeID=?");
#endif
            if (this.ExecSql(YyKVFile.GetValue("UpdatePrearrange"), ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdatePrearrange(long PrearrangeID,int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));
            
            ParamCollection.Add(MakeInParam("PrearrangeID", OleDbType.BigInt, 8, PrearrangeID));

            if (this.ExecSql("Update tPrearrange Set State=? where PrearrangeID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdatePrearrangeState(long PrearrangeID, int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));

            ParamCollection.Add(MakeInParam("PrearrangeID", OleDbType.BigInt, 8, PrearrangeID));

            if (this.ExecSql("Update tPrearrange Set State=? where PrearrangeID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }


        public bool AddBill(_tagBill data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("BillNO", OleDbType.VarChar, 50, data.BillNO));
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("ClientNumber", OleDbType.Integer, 4, data.ClientNumber));
            ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.BillTime.ToString())));
            //ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, data.BillTime));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 512, data.Remark));

            if (this.ExecSql("Insert Into tBill(BillNO,TableNO,ClientName,ClientNumber,BillTime,Remark) values(?,?,?,?,?,?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateBill(_tagBill data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("BillNO", OleDbType.VarChar, 50, data.BillNO));
            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, data.TableNO));
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("ClientNumber", OleDbType.Integer, 4, data.ClientNumber));
            ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.BillTime.ToString())));
            //ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, data.BillTime));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 512, data.Remark));

            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, data.BillID));
            if (this.ExecSql("Update tBill Set BillNO=?,TableNO=?,ClientName=?,ClientNumber=?,BillTime=?,Remark=? where BillID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateBillB(_tagBill data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("Account", OleDbType.Decimal, 9, data.Account));
            ParamCollection.Add(MakeInParam("Discount", OleDbType.Decimal, 9, data.Discount));
            ParamCollection.Add(MakeInParam("ReceAccount", OleDbType.Decimal, 9, data.ReceAccount));
            ParamCollection.Add(MakeInParam("RealAccount", OleDbType.Decimal, 9, data.RealAccount));
            ParamCollection.Add(MakeInParam("Deduct", OleDbType.Decimal, 9, data.Deduct));

            ParamCollection.Add(MakeInParam("Checkout", OleDbType.Integer, 4, data.Checkout));
            ParamCollection.Add(MakeInParam("PrintTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.PrintTime.ToString())));
            //ParamCollection.Add(MakeInParam("PrintTime", OleDbType.DBTimeStamp, 8, data.PrintTime));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 512, data.Remark));

            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, data.BillID));
            if (this.ExecSql("Update tBill Set Account=?,Discount=?,ReceAccount=?,RealAccount=?,Deduct=?,Checkout=?,PrintTime=?,Remark=? where BillID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }

        //
        public _tagBill GetBillInfoOfA(int TableNO)
        {
            _tagBill data = null;

            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("TableNO", OleDbType.Integer, 4, TableNO));

            DataTable dt = this.GetDataTable("Select Top 1 * from  tBill where TableNO=? and Checkout=0 ", ParamCollection);
            if (dt != null && dt.Rows.Count > 0)
            {
                data=new _tagBill();
                data.TableNO = TableNO;
                //data.TableName = Convert.ToString(dt.Rows[0]["TableName"]);
                data.BillID = Convert.ToInt64(dt.Rows[0]["BillID"]);
                data.BillNO = Convert.ToString(dt.Rows[0]["BillNO"]);
                data.ClientName = Convert.ToString(dt.Rows[0]["ClientName"]);
                data.ClientNumber = Convert.ToInt32(dt.Rows[0]["ClientNumber"]);
                data.BillTime = Convert.ToDateTime(dt.Rows[0]["BillTime"]);
                data.Remark = Convert.ToString(dt.Rows[0]["Remark"]);
            }

            return data;
        }
        public DataTable GetBillList(long BillID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, BillID));

            return this.GetDataTable("Select * from  vBillList where BillID=? ", ParamCollection);
        }

        public DataTable GetBillListOrderType(long BillID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, BillID));

            return this.GetDataTable("Select * from  vBillList where BillID=? order by Type", ParamCollection);
        }
        public bool AddBillList(_tagBillList data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, data.BillID));
            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, data.GoodsID));
            ParamCollection.Add(MakeInParam("GoodsName", OleDbType.VarChar, 50, data.GoodsName));
            ParamCollection.Add(MakeInParam("GoodsNumber", OleDbType.Double, 8, data.GoodsNumber));
            ParamCollection.Add(MakeInParam("UnitPrice", OleDbType.Decimal, 8, data.UnitPrice));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("Type", OleDbType.Integer, 4, data.Type));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));
            ParamCollection.Add(MakeInParam("DeductEmployeeNO", OleDbType.VarChar, 20, data.DeductEmployeeNO));
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, data.State));


            if (this.ExecSql("Insert Into tBillList(BillID,GoodsID,GoodsName,GoodsNumber,UnitPrice,Unit,Type,Remark,DeductEmployeeNO,State) values(?,?,?,?,?,?,?,?,?,?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBillList(_tagBillList data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, data.BillID));
            ParamCollection.Add(MakeInParam("GoodsID", OleDbType.Integer, 4, data.GoodsID));
            ParamCollection.Add(MakeInParam("GoodsName", OleDbType.VarChar, 50, data.GoodsName));
            ParamCollection.Add(MakeInParam("GoodsNumber", OleDbType.Double, 8, data.GoodsNumber));
            ParamCollection.Add(MakeInParam("UnitPrice", OleDbType.Decimal, 8, data.UnitPrice));
            ParamCollection.Add(MakeInParam("Unit", OleDbType.VarChar, 10, data.Unit));
            ParamCollection.Add(MakeInParam("Type", OleDbType.Integer, 4, data.Type));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));
            ParamCollection.Add(MakeInParam("DeductEmployeeNO", OleDbType.VarChar, 20, data.DeductEmployeeNO));
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, data.State));

            ParamCollection.Add(MakeInParam("BillListID", OleDbType.BigInt, 8, data.BillListID));

            if (this.ExecSql("Update tBillList Set BillID=?,GoodsID=?,GoodsName=?,GoodsNumber=?,UnitPrice=?,Unit=?,Type=?,Remark=?,DeductEmployeeNO=?,State=? where BillListID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBillList(long BillListID,double GoodsNumber, double UnitPrice, int Type, string Remark, string DeductEmployeeNO)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();            
            ParamCollection.Add(MakeInParam("GoodsNumber", OleDbType.Double, 8, GoodsNumber));
            ParamCollection.Add(MakeInParam("UnitPrice", OleDbType.Decimal, 8, UnitPrice));
            ParamCollection.Add(MakeInParam("Type", OleDbType.Integer, 4, Type));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, Remark));
            ParamCollection.Add(MakeInParam("DeductEmployeeNO", OleDbType.VarChar, 20, DeductEmployeeNO));

            ParamCollection.Add(MakeInParam("BillListID", OleDbType.BigInt, 8, BillListID));

            if (this.ExecSql("Update tBillList Set GoodsNumber=?,UnitPrice=?,Type=?,Remark=?,DeductEmployeeNO=? where BillListID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteBillList(long BillListID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();


            string SQLText = "Delete From tBillList where BillListID=?  and State=0";
            
            ParamCollection.Add(MakeInParam("BillListID", OleDbType.BigInt, 8, BillListID));
            if (this.ExecSql(SQLText, ParamCollection) > 0)
            {
                return true;
            }
            return false;

        }
        public bool UpdateBillListState(long BillListID, int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));
            
            string SQLText="Update tBillList Set State=? where BillListID=?";
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

        public bool UpdateBillListAllState(long BillID, int State)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("State", OleDbType.Integer, 4, State));

            string SQLText = "Update tBillList Set State=? where BillID=? ";
            if (State == 1)
            {
                SQLText = "Update tBillList Set State=?,OrderTime=GETDATE() where BillID=? and State<>1 ";
            }
            else if (State == 2)
            {
                SQLText = "Update tBillList Set State=?,ServingTime=GETDATE() where BillID=? and State<>2 ";
            }
            ParamCollection.Add(MakeInParam("BillID", OleDbType.BigInt, 8, BillID));
            if (this.ExecSql(SQLText, ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetOnCredit()
        {
            return this.GetDataTable("Select * from  vOnCredit  ");
        }
        public _tagOnCredit GetOnCreditItem(int OnCreditID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));

            DataTable dt= this.GetDataTable("Select * from  vOnCredit  Where OnCreditID=?", ParamCollection);

            if (dt != null && dt.Rows.Count > 0)
            {
                _tagOnCredit data = new _tagOnCredit();

                data.OnCreditID = OnCreditID;
                data.ClientName = dt.Rows[0]["ClientName"].ToString();
                data.Company = dt.Rows[0]["Company"].ToString();
                data.Address = dt.Rows[0]["Address"].ToString();
                data.MobilePhone = dt.Rows[0]["MobilePhone"].ToString();

                try
                {
                    data.OnCreditLimit = Convert.ToDouble(dt.Rows[0]["OnCreditLimit"]);                    
                    data.Surplus = Convert.ToDouble(dt.Rows[0]["Surplus"]);
                    data.OnCreditSum = Convert.ToDouble(dt.Rows[0]["OnCreditSum"]);                    
                }
                catch (Exception ex)
                {
                    this.OnError("数据转换", ex);
                }

                data.Phone = dt.Rows[0]["Phone"].ToString();
                data.MobilePhone = dt.Rows[0]["MobilePhone"].ToString();
                data.PostCode = dt.Rows[0]["PostCode"].ToString();
                data.Remark = dt.Rows[0]["Remark"].ToString();
                return data;
            }
            else
            {
                return null;
            }
        }

        public bool AddOnCredit(_tagOnCredit data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("Company", OleDbType.VarChar, 128, data.Company));
            ParamCollection.Add(MakeInParam("Address", OleDbType.VarChar, 128, data.Address));
            ParamCollection.Add(MakeInParam("PostCode", OleDbType.VarChar, 10, data.PostCode));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 20, data.Phone));
            ParamCollection.Add(MakeInParam("MobilePhone", OleDbType.VarChar, 40, data.MobilePhone));

            ParamCollection.Add(MakeInParam("OnCreditLimit", OleDbType.Currency, 8, data.OnCreditLimit));
            ParamCollection.Add(MakeInParam("OnCreditSum", OleDbType.Currency, 8, data.OnCreditSum));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            if (this.ExecSql("Insert Into tOnCredit(ClientName,Company,Address,PostCode,Phone,MobilePhone,OnCreditLimit,OnCreditSum,Remark) values(?,?,?,?,?,?,?,?,?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateOnCredit(_tagOnCredit data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClientName", OleDbType.VarChar, 50, data.ClientName));
            ParamCollection.Add(MakeInParam("Company", OleDbType.VarChar, 128, data.Company));
            ParamCollection.Add(MakeInParam("Address", OleDbType.VarChar, 128, data.Address));
            ParamCollection.Add(MakeInParam("PostCode", OleDbType.VarChar, 10, data.PostCode));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 20, data.Phone));
            ParamCollection.Add(MakeInParam("MobilePhone", OleDbType.VarChar, 40, data.MobilePhone));

            ParamCollection.Add(MakeInParam("OnCreditLimit", OleDbType.Currency, 8, data.OnCreditLimit));
            ParamCollection.Add(MakeInParam("OnCreditSum", OleDbType.Currency, 8, data.OnCreditSum));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, data.OnCreditID));

            if (this.ExecSql("Update tOnCredit set ClientName=?,Company=?,Address=?,PostCode=?,Phone=?,MobilePhone=?,OnCreditLimit=?,OnCreditSum=?,Remark=? where OnCreditID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteOnCredit(long OnCreditID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));

            if (this.ExecSql("Delete from  tOnCredit where OnCreditID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetOnCreditRecord(DateTime dtFrom,DateTime dtTo)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));

            return this.GetDataTable("Select * from  vOnCreditRecord where RecordTime>=? and RecordTime<=? ", ParamCollection);
        }

        public DataTable GetOnCreditRecord(DateTime dtFrom, DateTime dtTo, int OnCreditID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));

            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));

            return this.GetDataTable("Select * from  vOnCreditRecord where RecordTime>=? and RecordTime<=? and OnCreditID=?", ParamCollection);
        }

        public DataTable GetAssociator()
        {
            return this.GetDataTable("Select * from  vAssociator  ");
        }
        public _tagAssociatorParam GetAssociatorItem(string CardID, string CardPwd)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, CardID));
            ParamCollection.Add(MakeInParam("CardPwd", OleDbType.VarChar, 50, CardPwd));
            DataTable dt = this.GetDataTable("Select * from  vAssociator Where  CardID=? and CardPwd=?", ParamCollection);

            if (dt != null && dt.Rows.Count > 0)
            {
                _tagAssociatorParam data = new _tagAssociatorParam();

                data.CardID = CardID;
                data.CardPwd = CardPwd;
                data.Associator = dt.Rows[0]["Associator"].ToString();
                data.Company = dt.Rows[0]["Company"].ToString();
                data.Address = dt.Rows[0]["Address"].ToString();                
                data.IdentityCard = dt.Rows[0]["IdentityCard"].ToString();

                try
                {
                    data.AssociatorID = Convert.ToInt32(dt.Rows[0]["AssociatorID"]);
                    data.EndDate = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
                    data.Integral = Convert.ToInt32(dt.Rows[0]["Integral"]);
                    data.Surplus = Convert.ToDouble(dt.Rows[0]["Surplus"]);
                    data.RecordTime = Convert.ToDateTime(dt.Rows[0]["RecordTime"]);
                    data.ClassifyID = Convert.ToInt32(dt.Rows[0]["ClassifyID"]);
                    data.AgioRate = Convert.ToDouble(dt.Rows[0]["AgioRate"]);
                    data.IntegralRadix = Convert.ToInt32(dt.Rows[0]["ClassifyID"]);
                    data.IsTimeLimit = Convert.ToInt32(dt.Rows[0]["IsTimeLimit"]);
                    data.TimeLimit = Convert.ToInt32(dt.Rows[0]["TimeLimit"]);
                }
                catch (Exception ex)
                {
                    this.OnError("数据转换", ex);
                }

                data.Phone = dt.Rows[0]["Phone"].ToString();
                data.MobilePhone = dt.Rows[0]["MobilePhone"].ToString();
                data.PostCode = dt.Rows[0]["PostCode"].ToString();
                data.Remark = dt.Rows[0]["Remark"].ToString();
                data.ClassifyName = dt.Rows[0]["ClassifyName"].ToString();

                return data;
            }
            else
            {
                return null;
            }
        }
        public DataTable GetAssociatorRecord(DateTime dtFrom, DateTime dtTo)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));


            return this.GetDataTable("Select * from  vAssociatorRecord where RecordTime>=? and RecordTime<=? ", ParamCollection);
        }

        public DataTable GetAssociatorRecord(DateTime dtFrom, DateTime dtTo, int AssociatorID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));

            ParamCollection.Add(MakeInParam("AssociatorID", OleDbType.Integer, 4, AssociatorID));

            return this.GetDataTable("Select * from  vAssociatorRecord where RecordTime>=? and RecordTime<=? and AssociatorID=?", ParamCollection);
        }
        public bool AddAssociator(_tagAssociator data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, data.CardID));
            ParamCollection.Add(MakeInParam("CardPwd", OleDbType.VarChar, 50, data.CardPwd));
            ParamCollection.Add(MakeInParam("ClassifyID", OleDbType.Integer, 4, data.ClassifyID));

            ParamCollection.Add(MakeInParam("Associator", OleDbType.VarChar, 20, data.Associator));
            ParamCollection.Add(MakeInParam("IdentityCard", OleDbType.VarChar, 50, data.IdentityCard));

            ParamCollection.Add(MakeInParam("Company", OleDbType.VarChar, 128, data.Company));
            ParamCollection.Add(MakeInParam("Address", OleDbType.VarChar, 128, data.Address));
            ParamCollection.Add(MakeInParam("PostCode", OleDbType.VarChar, 10, data.PostCode));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 20, data.Phone));
            ParamCollection.Add(MakeInParam("MobilePhone", OleDbType.VarChar, 40, data.MobilePhone));

            ParamCollection.Add(MakeInParam("EndDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.EndDate.ToString())));
            //ParamCollection.Add(MakeInParam("EndDate", OleDbType.DBTimeStamp, 8, data.EndDate));
            ParamCollection.Add(MakeInParam("Surplus", OleDbType.Currency, 8, data.Surplus));
            ParamCollection.Add(MakeInParam("Integral", OleDbType.Integer, 4, data.Integral));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            if (this.ExecSql("Insert Into tAssociator(CardID,CardPwd,ClassifyID,Associator,IdentityCard,Company,Address,PostCode,Phone,MobilePhone,EndDate,Surplus,Integral,Remark) values(?,?,?,?,?, ?,?,?,?,?, ?,?,?,?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateAssociator(_tagAssociator data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, data.CardID));
            ParamCollection.Add(MakeInParam("CardPwd", OleDbType.VarChar, 50, data.CardPwd));
            ParamCollection.Add(MakeInParam("ClassifyID", OleDbType.Integer, 4, data.ClassifyID));

            ParamCollection.Add(MakeInParam("Associator", OleDbType.VarChar, 20, data.Associator));
            ParamCollection.Add(MakeInParam("IdentityCard", OleDbType.VarChar, 50, data.IdentityCard));

            ParamCollection.Add(MakeInParam("Company", OleDbType.VarChar, 128, data.Company));
            ParamCollection.Add(MakeInParam("Address", OleDbType.VarChar, 128, data.Address));
            ParamCollection.Add(MakeInParam("PostCode", OleDbType.VarChar, 10, data.PostCode));
            ParamCollection.Add(MakeInParam("Phone", OleDbType.VarChar, 20, data.Phone));
            ParamCollection.Add(MakeInParam("MobilePhone", OleDbType.VarChar, 40, data.MobilePhone));

            ParamCollection.Add(MakeInParam("EndDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(data.EndDate.ToString())));
            //ParamCollection.Add(MakeInParam("EndDate", OleDbType.DBTimeStamp, 8, data.EndDate));
            ParamCollection.Add(MakeInParam("Surplus", OleDbType.Currency, 8, data.Surplus));
            ParamCollection.Add(MakeInParam("Integral", OleDbType.Integer, 4, data.Integral));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            ParamCollection.Add(MakeInParam("AssociatorID", OleDbType.Integer, 8, data.AssociatorID));

            if (this.ExecSql("Update  tAssociator Set CardID=?,CardPwd=?,ClassifyID=?,Associator=?,IdentityCard=?,Company=?,Address=?,PostCode=?,Phone=?,MobilePhone=?,EndDate=?,Surplus=?,Integral=?,Remark=? Where AssociatorID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteAssociator(int AssociatorID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("AssociatorID", OleDbType.Integer, 4, AssociatorID));

            if (this.ExecSql("Delete from  tAssociator where AssociatortID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }
        public bool OnCreditRepayment(int OnCreditID, double LastNumber, double Value, string Employee, string Remark)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("Value", OleDbType.Double, 8, Value));
            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));

            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));
            ParamCollection.Add(MakeInParam("Employee", OleDbType.VarChar, 50, Employee));
            ParamCollection.Add(MakeInParam("MoneySum", OleDbType.Currency, 8, Value));
            ParamCollection.Add(MakeInParam("LastNumber", OleDbType.Currency, 8, LastNumber));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, Remark));
#if DEBUG
            YyKVFile.SetValue("OnCreditRepayment", "Update  tOnCredit Set OnCreditSum=OnCreditSum+? where OnCreditID=?;Insert Into tOnCreditRecord(OnCreditID,Employee,OpType,[Number],LastNumber,Remark) Values(?,?,0,?,?,?)");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("OnCreditRepayment"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool OnCreditDo(int OnCreditID, double LastNumber, double Value, string Employee, string Remark)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("Value", OleDbType.Double, 8, Value));
            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));

            ParamCollection.Add(MakeInParam("OnCreditID", OleDbType.Integer, 4, OnCreditID));
            ParamCollection.Add(MakeInParam("Employee", OleDbType.VarChar, 50, Employee));
            ParamCollection.Add(MakeInParam("MoneySum", OleDbType.Currency, 8, Value));
            ParamCollection.Add(MakeInParam("LastNumber", OleDbType.Currency, 8, LastNumber));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, Remark));
#if DEBUG
            YyKVFile.SetValue("OnCreditDo", "Update  tOnCredit Set OnCreditSum=OnCreditSum+? where OnCreditID=?;Insert Into tOnCreditRecord(OnCreditID,Employee,OpType,[Number],LastNumber,Remark) Values(?,?,1,?,?,?)");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("OnCreditDo"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AssociatorDeposit(string CardID, double Surplus, double Value, string Employee, string Remark)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("Value", OleDbType.Double, 8, Value));
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, CardID));

            ParamCollection.Add(MakeInParam("CardID1", OleDbType.VarChar, 50, CardID));
            ParamCollection.Add(MakeInParam("Employee", OleDbType.VarChar, 50, Employee));
            ParamCollection.Add(MakeInParam("MoneySum", OleDbType.Currency, 8, Value));
            ParamCollection.Add(MakeInParam("Surplus", OleDbType.Currency, 8, Surplus));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 50, Remark));
#if DEBUG
            YyKVFile.SetValue("AssociatorDeposit", "Update  tAssociator Set Surplus=Surplus+? where CardID=?;Insert Into tAssociatorRecord(CardID,Employee,OpType,MoneySum,Surplus,Remark) Values(?,?,0,?,?,?)");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("AssociatorDeposit"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 会员扣帐
        /// </summary>
        /// <param name="CardID"></param>
        /// <param name="Surplus"></param>
        /// <param name="Value"></param>
        /// <param name="Employee"></param>
        /// <param name="Remark"></param>
        /// <returns></returns>
        public bool AssociatorDeduct(string CardID, double Surplus, double Value, string Employee, string Remark)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("Value", OleDbType.Double, 8, Value));
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, CardID));

            ParamCollection.Add(MakeInParam("CardID1", OleDbType.VarChar, 50, CardID));
            ParamCollection.Add(MakeInParam("Employee", OleDbType.VarChar, 50, Employee));
            ParamCollection.Add(MakeInParam("MoneySum", OleDbType.Currency, 8, -Value));
            ParamCollection.Add(MakeInParam("Surplus", OleDbType.Currency, 8, Surplus));
            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 50, Remark));
#if DEBUG
            YyKVFile.SetValue("AssociatorDeduct", "Update  tAssociator Set Surplus=Surplus-? where CardID=?;Insert Into tAssociatorRecord(CardID,Employee,OpType,MoneySum,Surplus,Remark) Values(?,?,1,?,?,?);");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("AssociatorDeduct"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AssociatorIntegral(string CardID, int Integral)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("Integral", OleDbType.Integer, 4, Integral));
            ParamCollection.Add(MakeInParam("CardID", OleDbType.VarChar, 50, CardID));
#if DEBUG
            YyKVFile.SetValue("AssociatorIntegral", "Update  tAssociator Set Integral=Integral+? where CardID=?");
#endif
            if (this.ExecSqlTransaction(YyKVFile.GetValue("AssociatorIntegral"), ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetAssociatorClassify()
        {
            return this.GetDataTable("Select * from  tAssociatorClassify  ");
        }

        public int GetAssociatorClassifyTimeLimit(int ClassifyID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClassifyID", OleDbType.Integer, 4, ClassifyID));

            Object obj= this.ExecuteScalar("Select TimeLimit from  tAssociatorClassify  Where ClassifyID=? ");
            if (obj != null)
                return Convert.ToInt32(obj);
            else
                return 365;
        }

        public bool AddAssociatorClassify(_tagAssociatorClassify data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClassifyName", OleDbType.VarChar, 50, data.ClassifyName));
            ParamCollection.Add(MakeInParam("IsTimeLimit", OleDbType.Integer, 4, data.IsTimeLimit));
            ParamCollection.Add(MakeInParam("TimeLimit", OleDbType.Integer, 4, data.TimeLimit));

            ParamCollection.Add(MakeInParam("AgioRate", OleDbType.Double, 8, data.AgioRate));
            ParamCollection.Add(MakeInParam("IntegralRadix", OleDbType.Integer, 4, data.IntegralRadix));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            if (this.ExecSql("Insert Into tAssociatorClassify(ClassifyName,IsTimeLimit,TimeLimit,AgioRate,IntegralRadix,Remark) Values(?,?,?,?,?, ?)", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateAssociatorClassify(_tagAssociatorClassify data)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            ParamCollection.Add(MakeInParam("ClassifyName", OleDbType.VarChar, 50, data.ClassifyName));
            ParamCollection.Add(MakeInParam("IsTimeLimit", OleDbType.Integer, 4, data.IsTimeLimit));
            ParamCollection.Add(MakeInParam("TimeLimit", OleDbType.Integer, 4, data.TimeLimit));
            ParamCollection.Add(MakeInParam("AgioRate", OleDbType.Double, 8, data.AgioRate));
            ParamCollection.Add(MakeInParam("IntegralRadix", OleDbType.Integer, 4, data.IntegralRadix));

            ParamCollection.Add(MakeInParam("Remark", OleDbType.VarChar, 128, data.Remark));

            ParamCollection.Add(MakeInParam("ClassifyID", OleDbType.Integer, 4, data.ClassifyID));

            if (this.ExecSql("Update tAssociatorClassify Set ClassifyName=?,IsTimeLimit=?,TimeLimit=?,AgioRate=?,IntegralRadix=?,Remark=? Where ClassifyID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteAssociatorClassify(int ClassifyID)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();

            ParamCollection.Add(MakeInParam("ClassifyID", OleDbType.Integer, 4, ClassifyID));

            if (this.ExecSql("Delete from  tAssociatorClassify where ClassifyID=?", ParamCollection) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetBill(DateTime dtFrom, DateTime dtTo)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("BillTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));

            return this.GetDataTable("Select * from  vBill where BillTime>=? and BillTime<=? ", ParamCollection);
        }

        public DataTable GetBillList(DateTime dtFrom, DateTime dtTo)
        {
            List<OleDbParameter> ParamCollection = new List<OleDbParameter>();
            //ParamCollection.Add(MakeInParam("BillTime", OleDbType.DBTimeStamp, 8, dtFrom));
            //ParamCollection.Add(MakeInParam("BillTime2", OleDbType.DBTimeStamp, 8, dtTo));
            ParamCollection.Add(MakeInParam("RecordTime", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtFrom.ToString())));
            ParamCollection.Add(MakeInParam("RecordTime2", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(dtTo.ToString())));

            return this.GetDataTable("Select * from  vBillList where BillTime>=? and BillTime<=? order by Type", ParamCollection);
        }

    }
}
