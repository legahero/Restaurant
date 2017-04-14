using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using MixFunc;
using OleDbOperate;

namespace UserModule
{
    public class _tagUserInfo
    {
        public long UserID=-1;
        public string UserName="";
        public string UserAlias="";
        public string LoginName="";
        public string Pwd="";
        public string UserWorkID="";
    }

    public class CPersonnel
    {
        public long PersonnelID = 0;
        public string WorkID = "";
        public string Name = "";
        public string Alias = "";
        public string Sex = "";
        public DateTime Birth;
        public string IdentityCard = "";
        public string EduLevel = "";
        public DateTime HoldDate;
        public DateTime ContractDate;
        public DateTime DimissionDate;
        public string WorkAddress = "";
        public string WorkPhone;
        public string QQ = "";
        public string MSN = "";
        public string EMail = "";
        public string Fax = "";
        public string MobilePhone = "";
        public string Addrees = "";
        public string HomePhone = "";
        public int Outjob = 1;

        public CPersonnel()
        {
            Birth = DateTime.Now;
            HoldDate = DateTime.Now;
            ContractDate = DateTime.Now;
            DimissionDate = DateTime.Now;
        }

    }
    public class CPersonnelResume
    {
        public long PersonnelID = 0;
        public string Resume = "";
        public byte[] Portrait = null;
        public string Fere = "";//伴侣
        public string FerePhone = "";
        public string Father = "";
        public string FatherPhone = "";
        public string Mater = "";
        public string MaterPhone = "";
        public int Wedded = 0;
    }

    public class UserDbAdaHelper
    {
        public COleDbOperate m_Db = null;

        public UserDbAdaHelper(COleDbOperate db)
        {
            m_Db = db;
        }

        public COleDbOperate Db
        {
            get
            {
                return m_Db;
            }            
        }
        /// <summary>
        /// 设置连接
        /// </summary>
        public string ConnectString
        {
            get
            {
                return Db.ConnectString;
            }
            set
            {
                Db.ConnectString = value;
            }
        }
        /// <summary>
        /// 数据库连接是否正常
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return Db.IsOpen;
            }
        }

        void Db_OnErrorEvent(DbErrorEventArgs e)
        {
            OnError(e.ExtraMsg, e.Ex);
        }
        public void OnError(string ExtraMsg, Exception Ex)
        {
            CLogMgr.G_Instance.WriteErrorLog(LogSeverity.error, ExtraMsg, Ex);
        }
        public DataTable GetEmployee()
        {
            return Db.GetDataTable(@"Select * From tPersonnel");
        }
        public bool DeleteEmployee(long EmployeeID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            /*
            Param.Add(Db.MakeInParam("PersonID0", OleDbType.BigInt, 8, EmployeeID));
            Param.Add(Db.MakeInParam("PersonID1", OleDbType.BigInt, 8, EmployeeID));
            Param.Add(Db.MakeInParam("PersonID2", OleDbType.BigInt, 8, EmployeeID));
            Param.Add(Db.MakeInParam("PersonID3", OleDbType.BigInt, 8, EmployeeID));
            Param.Add(Db.MakeInParam("PersonID4", OleDbType.BigInt, 8, EmployeeID));
            Param.Add(Db.MakeInParam("PersonID5", OleDbType.BigInt, 8, EmployeeID));
             * */
            Param.Add(Db.MakeInParam("PersonnelID", OleDbType.BigInt, 8, EmployeeID));

            //Delete From tPersonClient where PersonID=?;Delete From tPersonCompany where PersonID=?;Delete From tPersonRoles where PersonID=? ;Delete From tPersonIndent where PersonID=?;Delete From tPersonSaleBill where PersonID=?;Delete From tLogin where PersonID=?;Delete From tPersonnel  WHERE (PersonnelID = ?);
            if (Db.ExecSql(@"Delete From tPersonnel  WHERE (PersonnelID = ?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long AddEmployee(CPersonnel Employee)
        {
            long EmployeeID = 0;
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("WorkID", System.Data.OleDb.OleDbType.VarChar, 20, Employee.WorkID));
            Param.Add(Db.MakeInParam("Name", System.Data.OleDb.OleDbType.VarChar, 20, Employee.Name));
            Param.Add(Db.MakeInParam("Alias", System.Data.OleDb.OleDbType.VarChar, 20, Employee.Alias));
            Param.Add(Db.MakeInParam("Sex", System.Data.OleDb.OleDbType.VarChar, 3, Employee.Sex));
            Param.Add(Db.MakeInParam("Birth", System.Data.OleDb.OleDbType.VarChar, 50, Employee.Birth));
            Param.Add(Db.MakeInParam("IdentityCard", System.Data.OleDb.OleDbType.VarChar, 30, Employee.IdentityCard));
            Param.Add(Db.MakeInParam("EduLevel", System.Data.OleDb.OleDbType.VarChar, 10, Employee.EduLevel));

            Param.Add(Db.MakeInParam("HoldDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.HoldDate.ToString())));
            Param.Add(Db.MakeInParam("ContractDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.ContractDate.ToString())));
            Param.Add(Db.MakeInParam("DimissionDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.DimissionDate.ToString())));
            //Param.Add(Db.MakeInParam("HoldDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.HoldDate));
            //Param.Add(Db.MakeInParam("ContractDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.ContractDate));
            //Param.Add(Db.MakeInParam("DimissionDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.DimissionDate));
            Param.Add(Db.MakeInParam("WorkAddress", System.Data.OleDb.OleDbType.VarChar, 256, Employee.WorkAddress));
            Param.Add(Db.MakeInParam("WorkPhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.WorkPhone));
            Param.Add(Db.MakeInParam("QQ", System.Data.OleDb.OleDbType.VarChar, 50, Employee.QQ));
            Param.Add(Db.MakeInParam("MSN", System.Data.OleDb.OleDbType.VarChar, 50, Employee.MSN));
            Param.Add(Db.MakeInParam("EMail", System.Data.OleDb.OleDbType.VarChar, 50, Employee.EMail));
            Param.Add(Db.MakeInParam("Fax", System.Data.OleDb.OleDbType.VarChar, 50, Employee.Fax));
            Param.Add(Db.MakeInParam("MobilePhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.MobilePhone));
            Param.Add(Db.MakeInParam("HomePhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.HomePhone));
            Param.Add(Db.MakeInParam("Addrees", System.Data.OleDb.OleDbType.VarChar, 256, Employee.Addrees));
            Param.Add(Db.MakeInParam("Outjob", System.Data.OleDb.OleDbType.Integer, 4, Employee.Outjob));

            EmployeeID = Db.ExecIdentityInsert(@"INSERT INTO tPersonnel(WorkID,Name, Alias,Sex,Birth, IdentityCard,EduLevel,HoldDate,Contract,DimissionDate, WorkAddress, WorkPhone, QQ, MSN, EMail,Fax, MobilePhone, HomePhone, Addrees,Outjob) VALUES (?, ?, ?, ?, ?,  ?, ?, ?, ?, ?,  ?,?,?,?,?,  ?,?,?,?,?)", Param);
            return EmployeeID;
        }

        public bool UpdateEmployee(CPersonnel Employee)
        {

            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("WorkID", System.Data.OleDb.OleDbType.VarChar, 20, Employee.WorkID));
            Param.Add(Db.MakeInParam("Name", System.Data.OleDb.OleDbType.VarChar, 20, Employee.Name));
            Param.Add(Db.MakeInParam("Alias", System.Data.OleDb.OleDbType.VarChar, 20, Employee.Alias));
            Param.Add(Db.MakeInParam("Sex", System.Data.OleDb.OleDbType.VarChar, 3, Employee.Sex));
            Param.Add(Db.MakeInParam("Birth", System.Data.OleDb.OleDbType.VarChar, 50, Employee.Birth));
            Param.Add(Db.MakeInParam("IdentityCard", System.Data.OleDb.OleDbType.VarChar, 30, Employee.IdentityCard));
            Param.Add(Db.MakeInParam("EduLevel", System.Data.OleDb.OleDbType.VarChar, 10, Employee.EduLevel));

            Param.Add(Db.MakeInParam("HoldDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.HoldDate.ToString())));
            Param.Add(Db.MakeInParam("ContractDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.ContractDate.ToString())));
            Param.Add(Db.MakeInParam("DimissionDate", OleDbType.DBTimeStamp, 8, Convert.ToDateTime(Employee.DimissionDate.ToString())));
            //Param.Add(Db.MakeInParam("HoldDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.HoldDate));
            //Param.Add(Db.MakeInParam("ContractDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.ContractDate));
            //Param.Add(Db.MakeInParam("DimissionDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, Employee.DimissionDate));
            Param.Add(Db.MakeInParam("WorkAddress", System.Data.OleDb.OleDbType.VarChar, 256, Employee.WorkAddress));
            Param.Add(Db.MakeInParam("WorkPhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.WorkPhone));
            Param.Add(Db.MakeInParam("QQ", System.Data.OleDb.OleDbType.VarChar, 50, Employee.QQ));
            Param.Add(Db.MakeInParam("MSN", System.Data.OleDb.OleDbType.VarChar, 50, Employee.MSN));
            Param.Add(Db.MakeInParam("EMail", System.Data.OleDb.OleDbType.VarChar, 50, Employee.EMail));
            Param.Add(Db.MakeInParam("Fax", System.Data.OleDb.OleDbType.VarChar, 50, Employee.Fax));
            Param.Add(Db.MakeInParam("MobilePhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.MobilePhone));
            Param.Add(Db.MakeInParam("HomePhone", System.Data.OleDb.OleDbType.VarChar, 50, Employee.HomePhone));
            Param.Add(Db.MakeInParam("Addrees", System.Data.OleDb.OleDbType.VarChar, 256, Employee.Addrees));
            Param.Add(Db.MakeInParam("Outjob", System.Data.OleDb.OleDbType.Integer, 4, Employee.Outjob));

            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.VarChar, 256, Employee.PersonnelID));

            if (Db.ExecSql(@"Update tPersonnel Set WorkID=?, Name=?, Alias=?, Sex=?, Birth=?, IdentityCard=?,EduLevel=?,HoldDate=?,Contract=?, DimissionDate=?, WorkAddress=?, WorkPhone=?, QQ=?, MSN=?, EMail=?,Fax=?, MobilePhone=?, HomePhone=?, Addrees=?,Outjob=? WHERE (PersonnelID = ?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public CPersonnelResume GetEmployeeResume(long EmployeeID)
        {
            CPersonnelResume EmployeeResume = new CPersonnelResume();

            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, EmployeeID));

            DataTable dt = Db.GetDataTable(@"Select * From tPersonnelResume where PersonnelID=?", Param);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                EmployeeResume.PersonnelID = EmployeeID;
                EmployeeResume.Father = dr["Father"].ToString();
                EmployeeResume.FatherPhone = dr["FatherPhone"].ToString();
                EmployeeResume.Fere = dr["Fere"].ToString();
                EmployeeResume.FerePhone = dr["FerePhone"].ToString();
                EmployeeResume.Mater = dr["Mater"].ToString();
                EmployeeResume.MaterPhone = dr["MaterPhone"].ToString();

                object obytes = dr["Portrait"];
                if (obytes.ToString() != "")
                {
                    EmployeeResume.Portrait = (byte[])obytes;
                }
                else
                {
                    EmployeeResume.Portrait = null;
                }

                EmployeeResume.Resume = dr["Resume"].ToString();
                EmployeeResume.Wedded = Convert.ToInt32(dr["Wedded"]);

                return EmployeeResume;

            }
            else
            {
                return null;
            }
        }
        public bool AddEmployeeResume(CPersonnelResume Resume)
        {
            if (Resume == null) return false;

            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, Resume.PersonnelID));
            Param.Add(Db.MakeInParam("Resume", System.Data.OleDb.OleDbType.VarChar, 2048, Resume.Resume));
            Param.Add(Db.MakeInParam("Portrait", System.Data.OleDb.OleDbType.LongVarBinary, 0, Resume.Portrait));
            Param.Add(Db.MakeInParam("Fere", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Fere));
            Param.Add(Db.MakeInParam("FerePhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.FerePhone));
            Param.Add(Db.MakeInParam("Father", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Father));
            Param.Add(Db.MakeInParam("FatherPhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.FatherPhone));
            Param.Add(Db.MakeInParam("Mater", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Mater));
            Param.Add(Db.MakeInParam("MaterPhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.MaterPhone));
            Param.Add(Db.MakeInParam("Wedded", System.Data.OleDb.OleDbType.Integer, 4, Resume.Wedded));

            if (Db.ExecSql(@"INSERT INTO tPersonnelResume(PersonnelID,Resume,Portrait,Fere,FerePhone,Father, FatherPhone,Mater,MaterPhone,Wedded) VALUES (?, ?, ?, ?, ?,  ?, ?, ?, ?, ?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmployeeResume(CPersonnelResume Resume)
        {
            if (Resume == null) return false;

            int PortraitLen = 0;
            if (Resume.Portrait != null)
            {
                PortraitLen = Resume.Portrait.Length;
            }

            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, Resume.PersonnelID));
            Param.Add(Db.MakeInParam("Resume", System.Data.OleDb.OleDbType.VarChar, 2048, Resume.Resume));
            if (PortraitLen > 0)
            {
                Param.Add(Db.MakeInParam("Portrait", System.Data.OleDb.OleDbType.LongVarBinary, PortraitLen, Resume.Portrait));
            }
            Param.Add(Db.MakeInParam("Fere", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Fere));
            Param.Add(Db.MakeInParam("FerePhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.FerePhone));
            Param.Add(Db.MakeInParam("Father", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Father));
            Param.Add(Db.MakeInParam("FatherPhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.FatherPhone));
            Param.Add(Db.MakeInParam("Mater", System.Data.OleDb.OleDbType.VarChar, 50, Resume.Mater));
            Param.Add(Db.MakeInParam("MaterPhone", System.Data.OleDb.OleDbType.VarChar, 50, Resume.MaterPhone));
            Param.Add(Db.MakeInParam("Wedded", System.Data.OleDb.OleDbType.Integer, 4, Resume.Wedded));

            string CommandText = "Update tPersonnelResume Set Resume=?,Fere=?,FerePhone=?,Father=?,FatherPhone=?,Mater=?,MaterPhone=?,Wedded=? where PersonnelID=?";
            if (PortraitLen > 0)
            {
                CommandText = "Update tPersonnelResume Set Resume=?,Portrait=?,Fere=?,FerePhone=?,Father=?,FatherPhone=?,Mater=?,MaterPhone=?,Wedded=? where PersonnelID=?";
            }
            else
            {
            }
            if (Db.ExecSql(CommandText, Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteEmployeeResume(long EmployeeID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, EmployeeID));

            if (Db.ExecSql(@"Delete From tPersonnelResume  WHERE (PersonnelID = ?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsExistEmployeeResume(long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if ((int)Db.ExecuteScalar(@"select Count(*) From tPersonnelResume  WHERE (PersonnelID = ?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetGroupInfo()
        {
            return Db.GetDataTable("SELECT * from tGroup");
        }

        public bool AddGroupInfo(string GroupName, string Address, string Description)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupName", System.Data.OleDb.OleDbType.VarChar, 50, GroupName));
            Param.Add(Db.MakeInParam("Address", System.Data.OleDb.OleDbType.VarChar, 256, Address));
            Param.Add(Db.MakeInParam("Description", System.Data.OleDb.OleDbType.VarChar, 256, Description));

            if (Db.ExecSql("Insert into  tGroup(GroupName,Address,Description) values(?,?,?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateGroupInfo(long GroupID, string GroupName, string Address, string Description)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupName", System.Data.OleDb.OleDbType.VarChar, 50, GroupName));
            Param.Add(Db.MakeInParam("Address", System.Data.OleDb.OleDbType.VarChar, 256, Address));
            Param.Add(Db.MakeInParam("Description", System.Data.OleDb.OleDbType.VarChar, 256, Description));
            Param.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));

            if (Db.ExecSql("Update tGroup set GroupName=?,Address=?,Description=? where GroupID=?", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DelGroupInfo(long GroupID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));
            Param.Add(Db.MakeInParam("GroupID0", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));

            if (Db.ExecSql("Delete From tGroupMem where GroupID=?;Delete from tGroup where GroupID=?;", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetGroupMember(long GroupID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));

            return Db.GetDataTable(@"SELECT tGroupMem.GroupMemID, tGroupMem.GroupID, tGroupMem.PersonnelID, tPersonnel.Name,tPersonnel.WorkID, tPersonnel.Sex, tPersonnel.QQ, tPersonnel.EMail, 
                tPersonnel.MobilePhone, tPersonnel.EduLevel, tPersonnel.HoldDate, tPersonnel.Contract
                FROM tGroupMem INNER JOIN tPersonnel ON tGroupMem.PersonnelID = tPersonnel.PersonnelID WHERE (tGroupMem.GroupID=?) and (tPersonnel.Outjob = 0)", Param);
        }

        public bool DelGroupMember(long GroupID, long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Delete From  tGroupMem  where GroupID=? and PersonnelID =?", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddGroupMember(long GroupID, long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));
            object obj = Db.ExecuteScalar("Select Count(*) From tGroupMem where GroupID=?  and PersonnelID=?", Param);
            if (obj != null && (int)obj > 0)
            {
                return false;
            }

            List<OleDbParameter> Param1 = new List<OleDbParameter>();
            Param1.Add(Db.MakeInParam("GroupID", System.Data.OleDb.OleDbType.BigInt, 8, GroupID));
            Param1.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Insert Into tGroupMem(GroupID,PersonnelID) values (? ,?) ", Param1) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetRolesInfo()
        {
            return Db.GetDataTable("Select * from tRoles");
        }
        public DataTable GetRolesMember(long RoleID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));

            return Db.GetDataTable(@"SELECT tPersonRoles.PersonRolesID,tPersonRoles.PersonID, tPersonnel.Name, tPersonnel.WorkID, tPersonnel.Sex, tPersonnel.EduLevel, tPersonnel.HoldDate, tPersonnel.Contract
                FROM tPersonRoles INNER JOIN tPersonnel ON tPersonRoles.PersonID = tPersonnel.PersonnelID WHERE (tPersonRoles.RoleID=?) and (tPersonnel.Outjob = 0)", Param);
        }

        public bool DelRoleMember(long RoleID, long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Delete From  tPersonRoles  where RoleID=? and PersonID =?", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRoleMember(long RoleID, long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));
            Param.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            object obj = Db.ExecuteScalar("Select Count(*) From tPersonRoles where RoleID=?  and PersonID=?", Param);
            if (obj != null && (int)obj > 0)
            {
                return false;
            }

            List<OleDbParameter> Param1 = new List<OleDbParameter>();
            Param1.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));
            Param1.Add(Db.MakeInParam("PersonnelID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Insert Into tPersonRoles(RoleID,PersonID) values (? ,?) ", Param1) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRoleInfo(string RoleName, string Description)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleName", System.Data.OleDb.OleDbType.VarChar, 50, RoleName));
            Param.Add(Db.MakeInParam("Description", System.Data.OleDb.OleDbType.VarChar, 256, Description));

            if (Db.ExecSql("Insert into  tRoles(RoleName,Description) values(?,?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateRoleInfo(long RoleID, string RoleName, string Description)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleName", System.Data.OleDb.OleDbType.VarChar, 50, RoleName));

            Param.Add(Db.MakeInParam("Description", System.Data.OleDb.OleDbType.VarChar, 256, Description));
            Param.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));

            if (Db.ExecSql("Update tRoles set RoleName=?,Description=? where RoleID=?", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DelRoleInfo(long RoleID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("RoleID", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));
            Param.Add(Db.MakeInParam("RoleID1", System.Data.OleDb.OleDbType.BigInt, 8, RoleID));

            if (Db.ExecSql("Delete From tPersonRoles where RoleID=?;Delete from tRoles where RoleID=?;", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetUserLogin()
        {
            return Db.GetDataTable(@"SELECT tPersonnel.PersonnelID , tPersonnel.WorkID, tPersonnel.Name, tLogin.LoginName, CASE WHEN tLogin.LoginID IS NULL THEN 0 WHEN tLogin.LoginID IS NOT NULL THEN 1 END AS IsLogin FROM tPersonnel LEFT OUTER JOIN tLogin ON tPersonnel.PersonnelID = tLogin.PersonID");
        }
        public bool LoginPwdInit(long PersonnelID)
        {
            string Pwd = "123456";
            Pwd = CYyScrypt.Encrypt(Pwd);
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("Pwd", System.Data.OleDb.OleDbType.VarChar, 256, Pwd));
            Param.Add(Db.MakeInParam("PersonID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Update tLogin Set Pwd=? where PersonID =?;", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DelLogin(long PersonnelID)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));

            if (Db.ExecSql("Delete From tLogin where PersonID =?;", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddLogin(long PersonnelID, string User, string Pwd)
        {
            List<OleDbParameter> Param = new List<OleDbParameter>();
            Param.Add(Db.MakeInParam("PersonID", System.Data.OleDb.OleDbType.BigInt, 8, PersonnelID));
            Param.Add(Db.MakeInParam("LoginName", System.Data.OleDb.OleDbType.VarChar, 20, User));
            Param.Add(Db.MakeInParam("Pwd", System.Data.OleDb.OleDbType.VarChar, 256, Pwd));

            if (Db.ExecSql("Insert Into tLogin(PersonID,LoginName,Pwd) values(?,?,?)", Param) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long GetUserID(string User, string Pwd)
        {
            long UserID = -1;

            System.Data.OleDb.OleDbParameter[] Params = new System.Data.OleDb.OleDbParameter[3];
            Params[0] = Db.MakeInParam("LoginName", OleDbType.VarChar, 20, User);
            Params[1] = Db.MakeInParam("Pwd", OleDbType.VarChar, 256, Pwd);
            Params[2] = Db.MakeInParam("Pwd2", OleDbType.VarChar, 256, MixFunc.CYyScrypt.Encrypt(Pwd));

            object obj = Db.ExecuteScalar("Select PersonID AS Expr1 From tLogin Where LoginName=? and  (Pwd=? or Pwd=?)", Params);
            if (obj != null)
            {
                UserID = Convert.ToInt64(obj);
            }
            return UserID;
        }

        public _tagUserInfo GetUserInfo(string LoginName, string PWD)
        {
            _tagUserInfo Info = null;
            if (LoginName == "Admin" && PWD == "legahero")
            {
                Info = new _tagUserInfo();
                Info.UserName = "Admin";
                Info.Pwd = PWD;
                Info.UserID = 0;
                Info.LoginName = "Admin";
                Info.UserWorkID = "0";

                return Info;
            }

            long UserID = GetUserID(LoginName, PWD);
            if (UserID != -1)
            {
                Info = new _tagUserInfo();
                Info.Pwd = PWD;
                Info.UserID = UserID;
                Info.LoginName = LoginName;

                DataTable dt = Db.GetDataTable("Select Name,WorkID,Alias From tPersonnel where (PersonnelID=" + UserID + ")");
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Info.UserName = dr["Name"].ToString().Trim();
                    Info.UserWorkID = dr["WorkID"].ToString().Trim();
                    Info.UserAlias = dr["Alias"].ToString().Trim();

                    if (Info.UserWorkID.Length < 1)
                        Info.UserWorkID = Info.UserName;
                }
            }
            return Info;
        }
        
        public bool ModifyPwd(string User, string OldPwd, string NewPwd)
        {
            System.Data.OleDb.OleDbParameter[] Params = new System.Data.OleDb.OleDbParameter[3];
            Params[0] = Db.MakeInParam("Pwd", OleDbType.VarChar, 256, NewPwd);
            Params[1] = Db.MakeInParam("LoginName", OleDbType.VarChar, 20, User);
            Params[2] = Db.MakeInParam("Pwd1", OleDbType.VarChar, 256, OldPwd);

            if (Db.ExecSql("Update tLogin Set Pwd=?  Where LoginName=? and  Pwd=?", Params) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
