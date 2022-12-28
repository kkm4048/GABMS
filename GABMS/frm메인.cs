using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GABMS
{
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void m기초데이타_사용자등록_Click(object sender, EventArgs e)
        {
      //      frm기초데이타_사용자등록 frm기초데이타_사용자등록 = new frm기초데이타_사용자등록();
        //    frm기초데이타_사용자등록.Show();
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void FrmShow2(String formToCall)
        {
            try
            {
                var type = Type.GetType("GABMS." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {

                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.MdiParent = this;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }

        private void m기초데이타_품종등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_품종등록");
        }

        private void m코드관리_코드등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm코드관리_코드등록");
        }

        private void m파일_설정_Click(object sender, EventArgs e)
        {
            FrmShow2("frm파일_설정");
        }

        private void mSelection_Selection_Click(object sender, EventArgs e)
        {
            FrmShow2("frmSelection_Selection");
        }
    }
}
