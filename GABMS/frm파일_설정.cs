using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GABMS
{
    public partial class frm파일_설정 : Form
    {
        public frm파일_설정()
        {
            InitializeComponent();
        }

        private void frm파일_설정_Load(object sender, EventArgs e)
        {
            Add프린터();
        }

        private void Add프린터()
        {
            //프린터리스트
            this.cmb프린터.Items.Clear();
            PrinterSettings.StringCollection AllPrinters = PrinterSettings.InstalledPrinters;

            for (int i = 0; i < AllPrinters.Count; i++)
            {
                this.cmb프린터.Items.Add(AllPrinters[i].ToString());
            }
            cmb프린터.Text = cls_com.g프린터;

        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }
        private void 저장()
        {
            cls_com.ConfigSave("프린터", cmb프린터.Text);
            cls_com.g프린터 = cmb프린터.Text;
            Close();
        }
    }
}
