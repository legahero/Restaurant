using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace UserModule
{
    public partial class FormEmployeeInfo : Form
    {
        public CPersonnel m_Personnel;
        public CPersonnelResume m_PersonnelResume;

        public UserDbAdaHelper m_DbAdaHelper = null;
        public FormEmployeeInfo()
        {
            m_Personnel = new CPersonnel();
            m_PersonnelResume = new CPersonnelResume();
            InitializeComponent();
        }

        private void FormEmployeeInfo_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void checkBoxOnJob_Click(object sender, EventArgs e)
        {
            if (checkBoxOnJob.Checked == true)
            {
                dateTimePickerDimissionDate.Visible = true;
            }
            else
            {
                dateTimePickerDimissionDate.Visible = false;
            }

        }

        public void ShowData()
        {
            editWorkID.Text = m_Personnel.WorkID;
            editName.Text = m_Personnel.Name;
            editAlias.Text = m_Personnel.Alias;
            cbSex.Text = m_Personnel.Sex;
            dtBirth.Value = m_Personnel.Birth;
            editIdentityCard.Text = m_Personnel.IdentityCard;
            cbEduLevel.Text = m_Personnel.EduLevel;
            dateTimePickerHoldDate.Value = m_Personnel.HoldDate;
            dateTimePickerContract.Value = m_Personnel.ContractDate;
            dateTimePickerDimissionDate.Value = m_Personnel.DimissionDate;

            editWorkAddress.Text = m_Personnel.WorkAddress;
            editWorkPhone.Text = m_Personnel.WorkPhone;
            editQQ.Text = m_Personnel.QQ;
            editMSN.Text = m_Personnel.MSN;
            editEMail.Text = m_Personnel.EMail;
            tbFax.Text = m_Personnel.Fax;
            editMobilePhone.Text = m_Personnel.MobilePhone;
            editAddrees.Text = m_Personnel.Addrees;
            editHomePhone.Text = m_Personnel.HomePhone;

            if (m_Personnel.Outjob == 1)
            {
                checkBoxOnJob.Checked = true;
                dateTimePickerDimissionDate.Visible = true;
            }
            else
            {
                checkBoxOnJob.Checked = false;
                dateTimePickerDimissionDate.Visible = false;
            }
            if (m_PersonnelResume != null)
            {
                tbResume.Text = m_PersonnelResume.Resume;

                if (m_PersonnelResume.Portrait != null)
                    this.image(m_PersonnelResume.Portrait);
                else
                {
                    this.picImage.Image = null;
                }
            }
        }

        private void btImgUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyFileDialog = new OpenFileDialog();
            MyFileDialog.ShowDialog();
            if (MyFileDialog.FileName.Trim() != "")
            {
                Stream MyStream = MyFileDialog.OpenFile();
                int length = (int)MyStream.Length;
                m_PersonnelResume.Portrait = new byte[length];
                MyStream.Read(m_PersonnelResume.Portrait, 0, length);
                this.image(m_PersonnelResume.Portrait);
                MyStream.Close();
            }
        }


        //显示图片
        public void image(byte[] bytes)
        {
            MemoryStream memStream = new MemoryStream(bytes);
            try
            {
                Bitmap MyImage = new Bitmap(memStream);
                this.picImage.Image = MyImage;
            }
            catch
            {
                MessageBox.Show(this, "读取数据库中的图像信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.picImage.Image = null;
            }
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            m_Personnel.WorkID = editWorkID.Text;
            m_Personnel.Name = editName.Text;
            m_Personnel.Alias = editAlias.Text;
            m_Personnel.Sex = cbSex.Text;
            m_Personnel.Birth = dtBirth.Value;
            m_Personnel.IdentityCard = editIdentityCard.Text;
            m_Personnel.EduLevel = cbEduLevel.Text;
            m_Personnel.HoldDate = dateTimePickerHoldDate.Value;
            m_Personnel.ContractDate = dateTimePickerContract.Value;
            m_Personnel.DimissionDate = dateTimePickerDimissionDate.Value;

            m_Personnel.WorkAddress = editWorkAddress.Text;
            m_Personnel.WorkPhone = editWorkPhone.Text;
            m_Personnel.QQ = editQQ.Text;
            m_Personnel.MSN = editMSN.Text;
            m_Personnel.EMail = editEMail.Text;
            m_Personnel.Fax = tbFax.Text;
            m_Personnel.MobilePhone = editMobilePhone.Text;
            m_Personnel.Addrees = editAddrees.Text;
            m_Personnel.HomePhone = editHomePhone.Text;


            if (checkBoxOnJob.Checked == true)
            {
                m_Personnel.Outjob = 1;
            }
            else
            {
                m_Personnel.Outjob = 0;
            }

            m_PersonnelResume.Resume = tbResume.Text;

            this.DialogResult = DialogResult.OK;

        }

    }
}