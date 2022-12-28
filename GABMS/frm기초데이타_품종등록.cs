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
    public partial class frm기초데이타_품종등록 : Form
    {

        string sql = "";
        string r타이틀1 = "Seedling Selection", r타이틀2 = "Plant Selection";
        string[] rarr = { "문자", "선택","일자" };
        public frm기초데이타_품종등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_구분등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            조회();
            조회2();
            조회3();

        }


        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
            조회3();

        }

        private void 조회()
        {
            //SPEC


            sql = " exec s_a101_품종_조회 '1','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 조회2()
        {
            //SPEC
            string d; 
            FarPoint.Win.Spread.CellType.ComboBoxCellType cc = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            cc.Items = rarr;

            sql = " exec s_a101_data_format_조회 '1','" + txt21.Text +"','" + r타이틀1 + "',''  ";
            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.EditModeReplace = true;
                FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
                im = spr2.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRowWrap);

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

                spr2.Sheets[0].Cells.Get(0, 3, spr2.Sheets[0].RowCount - 1, 4).BackColor = cls_color.gColor_수정;
                spr2.Sheets[0].Cells.Get(0, 3, spr2.Sheets[0].RowCount - 1 ,4 ).Locked = false;
                spr2.Sheets[0].Cells.Get(0, 3, spr2.Sheets[0].RowCount - 1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 4, spr2.Sheets[0].RowCount - 1, 4).CellType = cc;


                for (int i = 0; i < spr2.ActiveSheet.RowCount; i++)
                {
                    d = spr2.ActiveSheet.Cells[i, 4].Text;
                    if (d.Equals("선택"))
                    {
                        spr2.ActiveSheet.Cells[i, 5].Locked = false;
                        spr2.ActiveSheet.Cells[i, 5].BackColor = cls_color.gColor_수정;
                    }
                    else
                    {
                        spr2.ActiveSheet.Cells[i, 5].Locked = true;
                        spr2.ActiveSheet.Cells[i, 5].BackColor = Color.White;
                    }
                }


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }
        private void 조회3()
        {
            string d;
            FarPoint.Win.Spread.CellType.ComboBoxCellType cc = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            cc.Items = rarr;

            sql = " exec s_a101_data_format_조회 '1','" + txt21.Text + "','" + r타이틀2 + "',''  ";
            DataSet ds = cls_com.Select_Query(sql);
            spr3.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt3.Text = ds.Tables[0].Rows.Count.ToString();
            spr3.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.EditModeReplace = true;
                FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
                im = spr2.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRowWrap);

                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).Locked = true;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

                spr3.Sheets[0].Cells.Get(0, 3, spr3.Sheets[0].RowCount - 1, 4).BackColor = cls_color.gColor_수정;
                spr3.Sheets[0].Cells.Get(0, 3, spr3.Sheets[0].RowCount - 1, 4).Locked = false;
                spr3.Sheets[0].Cells.Get(0, 3, spr3.Sheets[0].RowCount - 1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr3.Sheets[0].Cells.Get(0, 4, spr3.Sheets[0].RowCount - 1, 4).CellType = cc;


                for (int i = 0; i < spr3.ActiveSheet.RowCount; i++)
                {
                    d = spr3.ActiveSheet.Cells[i, 4].Text;
                    if (d.Equals("선택"))
                    {
                        spr3.ActiveSheet.Cells[i, 5].Locked = false;
                        spr3.ActiveSheet.Cells[i, 5].BackColor = cls_color.gColor_수정;
                    }
                    else
                    {
                        spr3.ActiveSheet.Cells[i, 5].Locked = true;
                        spr3.ActiveSheet.Cells[i, 5].BackColor = Color.White;
                    }
                }


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr3.Sheets[0]);
            lblCnt3.Text = spr3.ActiveSheet.RowCount.ToString();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_품종_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품종_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "데이타 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품종_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt21.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt31.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;

            등록2();
            조회2();
            등록3();
            조회3();


        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";

        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;

        }

        private void t시작_Tick(object sender, EventArgs e)
        {
            t시작.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void 등록2()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_data_format_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + r타이틀1  + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }


    
        private void 저장2()
        {
            string species="",type="",번호="",항목 = "", 형태 = "", 값 = "";

            for (int i = 0; i < spr2.ActiveSheet.RowCount; i ++)
            {
                if (spr2.ActiveSheet.Cells[i,3].Text.Trim().Equals(""))
                {
                    if (i==0 )
                    {
                        MessageBox.Show("항목은 1개 이상 입력 하셔야 합니다.");
                        return;
                    }
                    break;
                }
                if (spr2.ActiveSheet.Cells[i, 4].Text.Equals("선택"))
                {
                    if (spr2.ActiveSheet.Cells[i, 5].Text.Trim().Equals(""))
                    {
                        MessageBox.Show("선택시 반드시 값을 넣어야 합니다.");
                        return;
                    }
           
                }
            }

            DialogResult dr = MessageBox.Show("저장 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;

            for (int i = 0; i < spr2.ActiveSheet.RowCount; i++)
            {
                species = spr2.ActiveSheet.Cells[i, 0].Text.Trim();
                type = spr2.ActiveSheet.Cells[i, 1].Text.Trim();
                번호 = spr2.ActiveSheet.Cells[i, 2].Text.Trim();
                항목 = spr2.ActiveSheet.Cells[i, 3].Text.Trim();
                형태 = spr2.ActiveSheet.Cells[i, 4].Text.Trim();
                값 = spr2.ActiveSheet.Cells[i, 5].Text;

                if (항목.Equals(""))
                {
                    형태 = "";
                    값 = "";
                }
                sql = " ";
                sql = sql + "EXEC [s_a101_data_format_저장] '2'";
                sql = sql + "   ,'" + species + "' ";
                sql = sql + "   ,'" + type + "' ";
                sql = sql + "   ,'" + 번호 + "' ";
                sql = sql + "   ,'" + 항목 + "' ";
                sql = sql + "   ,'" + 형태 + "' ";
                sql = sql + "   ,'" + 값 + "' ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    }

                }
                
            }
            조회2();
        }
        private void 삭제2()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "데이타 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_data_format_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + r타이틀1 + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }




        private void 등록3()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_data_format_저장] '1'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + r타이틀2  + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }



        private void 저장3()
        {

            string species = "", type = "", 번호 = "", 항목 = "", 형태 = "", 값 = "";

            for (int i = 0; i < spr3.ActiveSheet.RowCount; i++)
            {
                if (spr3.ActiveSheet.Cells[i, 3].Text.Trim().Equals(""))
                {
                    if (i == 0)
                    {
                        MessageBox.Show("항목은 1개 이상 입력 하셔야 합니다.");
                        return;
                    }
                    break;
                }
                if (spr3.ActiveSheet.Cells[i, 4].Text.Equals("선택"))
                {
                    if (spr3.ActiveSheet.Cells[i, 5].Text.Trim().Equals(""))
                    {
                        MessageBox.Show("선택시 반드시 값을 넣어야 합니다.");
                        return;
                    }

                }
            }

            DialogResult dr = MessageBox.Show("저장 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;

            for (int i = 0; i < spr3.ActiveSheet.RowCount; i++)
            {
                species = spr3.ActiveSheet.Cells[i, 0].Text.Trim();
                type = spr3.ActiveSheet.Cells[i, 1].Text.Trim();
                번호 = spr3.ActiveSheet.Cells[i, 2].Text.Trim();
                항목 = spr3.ActiveSheet.Cells[i, 3].Text.Trim();
                형태 = spr3.ActiveSheet.Cells[i, 4].Text.Trim();
                값 = spr3.ActiveSheet.Cells[i, 5].Text;

                if (항목.Equals(""))
                {
                    형태 = "";
                    값 = "";
                }
                sql = " ";
                sql = sql + "EXEC [s_a101_data_format_저장] '2'";
                sql = sql + "   ,'" + species + "' ";
                sql = sql + "   ,'" + type + "' ";
                sql = sql + "   ,'" + 번호 + "' ";
                sql = sql + "   ,'" + 항목 + "' ";
                sql = sql + "   ,'" + 형태 + "' ";
                sql = sql + "   ,'" + 값 + "' ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    }

                }

            }
            조회3();
        }
        private void 삭제3()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "데이타 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_data_format_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + r타이틀2  + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }


        private void btn수정2_Click(object sender, EventArgs e)
        {
            //수정2();
        }

        private void btn삭제2_Click(object sender, EventArgs e)
        {
            삭제2();
        }

        private void btn초기화2_Click(object sender, EventArgs e)
        {
            초기화2();
        }
        private void 초기화2()
        {
            txt21.Text = "";
            
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt21.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            
        }

        private void spr3_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr3.ActiveSheet);
        }

        private void btn저장3_Click(object sender, EventArgs e)
        {
            저장3();
        }

        private void btn저장2_Click(object sender, EventArgs e)
        {
            저장2();
        }


        private void spr2_ComboCloseUp(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            int row, col;
            string d;
            row = spr2.ActiveSheet.ActiveRow.Index;
            col = spr2.ActiveSheet.ActiveColumn.Index;
            d = spr2.ActiveSheet.Cells[row, 4].Text;
            if (d.Equals("선택"))
            {
                spr2.ActiveSheet.Cells[row, 5].Locked = false;
                spr2.ActiveSheet.Cells[row, 5].BackColor = cls_color.gColor_수정;
            }
            else
            {
                spr2.ActiveSheet.Cells[row, 5].Locked = true;
                spr2.ActiveSheet.Cells[row, 5].BackColor = Color.White;
            }
        }

        private void spr3_ComboCloseUp(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            int row, col;
            string d;
            row = spr3.ActiveSheet.ActiveRow.Index;
            col = spr3.ActiveSheet.ActiveColumn.Index;
            d = spr3.ActiveSheet.Cells[row, 4].Text;
            if (d.Equals("선택"))
            {
                spr3.ActiveSheet.Cells[row, 5].Locked = false;
                spr3.ActiveSheet.Cells[row, 5].BackColor = cls_color.gColor_수정;
            }
            else
            {
                spr3.ActiveSheet.Cells[row, 5].Locked = true;
                spr3.ActiveSheet.Cells[row, 5].BackColor = Color.White;
            }
        }
    }
}
