using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GABMS
{
    public partial class frm코드관리_코드등록 : Form
    {

        int rRow0 = 0; 
        string sql = "";
        string r1 = "", r2 = "", r3 = "", r4 = "", r5 = "", r6 = "", r7 = "", r8 = "",r9="";
        private PrintDocument printDoc = new PrintDocument();
        Image r그림;
        public frm코드관리_코드등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }



        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }
        private void 조회()
        {
            //SPEC
            FarPoint.Win.Spread.CellType.CheckBoxCellType cb = new FarPoint.Win.Spread.CellType.CheckBoxCellType();


            sql = " exec s_a201_data_조회 '1','','" + cmb품종.Text + "','" + txt조회.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr1.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt1.Text = ds.Tables[0].Rows.Count.ToString();
            spr1.Reset();
            spr1.DataSource = ds;
            타이틀1(ds);

            spr1.ActiveSheet.AddColumns(0, 1);
            spr1.ActiveSheet.AddColumnHeaderSpanCell(0, 0, 2, 1);
            spr1.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "선택";

            cls_com.Sort표시(spr1.ActiveSheet);
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, 0).CellType = cb;

                spr1.Sheets[0].Cells.Get(0, 1, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).Locked = true;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr1.Sheets[0]);
            lblCnt1.Text = spr1.ActiveSheet.RowCount.ToString();
        }

        private void frm코드관리_코드등록_Load(object sender, EventArgs e)
        {
          //  string d;
        //    d = cls_com.ConfigLoad(this.Name + "_sc_넓이");
         //   sc.SplitterDistance = cls_com.Val(d);
            Add품종();
            조회();
            조회("");
            조회2("");
            조회3("");
            String d;
            d = cls_com.ConfigLoad(this.Name + "_sc1_높이");
            sc1.SplitterDistance = cls_com.Val(d);
        }

        private void Add품종()
        {
            sql = " exec s_a101_품종_조회 '1','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb품종.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i ++)
            {
                cmb품종.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }

            try
            {
                cmb품종.Text = cls_com.ConfigLoad(this.Name + "_품종");
            } catch
            {

            }
            
            
        }
        private void spr1_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr1.ActiveSheet);
        }

        private void cmd품종_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
            cls_com.ConfigSave(this.Name + "_품종", cmb품종.Text);
        }

        private void btn엑셀_등록_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    frm기타_엑셀등록 frm기타_엑셀등록 = new frm기타_엑셀등록(openFileDialog.FileName,cmb품종.Text);
                    frm기타_엑셀등록.ShowDialog();
                    조회();

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void 타이틀1(DataSet ds)
        {
            spr1.ActiveSheet.ColumnHeader.RowCount = 2;
            spr1.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            spr1.ActiveSheet.ColumnHeader.Rows[1].Height = 60;

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                string[] arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                if (arr.Length == 2)
                {
                    spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[0];
                    spr1.ActiveSheet.ColumnHeader.Cells[1, i].Text = arr[1];

                } else
                {
                    spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text = ds.Tables[0].Columns[i].ColumnName.ToString();
                }
            }
            string d = "";
            int i1 = 0, i2 = 0;
            d = spr1.ActiveSheet.ColumnHeader.Cells[0, 0].Text;
            
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {

                if (d.Equals(spr1.ActiveSheet.ColumnHeader.Cells[0,i].Text))
                {
                    i2 = i;
                } else
                {
                    d = spr1.ActiveSheet.ColumnHeader.Cells[0,i].Text;
                    
                    spr1.ActiveSheet.AddColumnHeaderSpanCell(0, i1, 1, i2 - i1 + 1);
                    i1 = i;
                    i2 = i;
                }
            }

            spr1.ActiveSheet.AddColumnHeaderSpanCell(0, i1, 1, i2 - i1 + 2);



        }

        private void spr1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            조회(spr1.ActiveSheet.Cells[e.Row,1].Text );
            조회2(spr1.ActiveSheet.Cells[e.Row, 1].Text);
            조회3(spr1.ActiveSheet.Cells[e.Row, 1].Text);
        }

        private void 조회(String knou_id)
        {
            int irow = 0;
            int iheight = 30;
            DataSet ds;
            Font font = new Font("굴림체", 12, FontStyle.Bold);

            string[] arr; 
            spr2.ActiveSheet.RowCount = 0 ;
            spr2.ActiveSheet.ColumnCount = 3;
            ds = cls_com.Select_Query(" s_a201_data1_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' "  );

            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            spr2.ActiveSheet.RowCount = irow +1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);

            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow+1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try
                {
                    spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                } catch
                {

                }
            }


            ds = cls_com.Select_Query(" s_a201_data2_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' ");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            irow++;
            spr2.ActiveSheet.RowCount = irow + 1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow+1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try
                {
                    spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                } catch
                {

                }
            }

            ds = cls_com.Select_Query(" s_a201_data3_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' ");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            irow++;
            spr2.ActiveSheet.RowCount = irow + 1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow + 1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try { 
                spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                }
                catch
                {

                }

            }

            ds = cls_com.Select_Query(" s_a201_data4_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' ");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            irow++;
            spr2.ActiveSheet.RowCount = irow + 1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow + 1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try { 
                   
                    spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                }
                catch
                {

                }

            }

            ds = cls_com.Select_Query(" s_a201_data5_조회 '4','" + knou_id + "','" + cmb품종.Text + "','' ,'',''");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            irow++;
            spr2.ActiveSheet.RowCount = irow + 1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow + 1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try {
                    if (i == 0)
                    {
                        FarPoint.Win.Spread.CellType.ImageCellType ic = new FarPoint.Win.Spread.CellType.ImageCellType( FarPoint.Win.RenderStyle.Stretch);
                        spr2.ActiveSheet.Cells[irow, 2].CellType = ic;
                        spr2.ActiveSheet.Cells[irow, 2].Value = (byte[])ds.Tables[0].Rows[0][i];
                        spr2.ActiveSheet.Rows[irow].Height = 100;
                    } else
                    {
                        spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                    }
                }
                catch
                {

                }

            }

            ds = cls_com.Select_Query(" s_a201_data6_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' ");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            irow++;
            spr2.ActiveSheet.RowCount = irow + 1;
            spr2.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr2.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr2.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr2.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr2.ActiveSheet.RowCount = irow + 1;
                spr2.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try { 
                spr2.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                }
                catch
                {

                }

            }

            spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
            spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


            cls_com.SpreadLoad(this, spr2.ActiveSheet);

        }

        private void 조회2(String knou_id)
        {
            int irow = 0;
            int iheight = 30;
            DataSet ds;
            Font font = new Font("굴림체", 12, FontStyle.Bold);
            string[] arr;


            FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
            im = spr2.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
            im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRowWrap);


            txtKnouid.Text = knou_id;
            ds = cls_com.Select_Query(" s_a201_data5_조회 '1','" + knou_id + "','" + cmb품종.Text + "','' ,'','' ");
            arr = ds.Tables[0].Columns[0].ColumnName.ToString().Split('_');
            spr3.ActiveSheet.ColumnCount = 4;
            spr3.ActiveSheet.RowCount = irow + 1;

            spr3.ActiveSheet.Cells[irow, 0].Text = arr[0].ToString();
            spr3.ActiveSheet.AddSpanCell(irow, 0, 1, 3);
            spr3.ActiveSheet.Cells.Get(irow, 0, irow, 0).Font = font;
            spr3.ActiveSheet.Rows[irow].Height = iheight;
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                irow++;
                arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                spr3.ActiveSheet.RowCount = irow + 1;
                spr3.ActiveSheet.Cells[irow, 1].Text = arr[1].ToString();
                try
                {
                    spr3.ActiveSheet.Cells[irow, 2].Text = ds.Tables[0].Rows[0][i].ToString();
                }
                catch
                {
                }
            }
            spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).Locked = true;
            spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

            spr3.Sheets[0].Cells.Get(0, 2, spr3.Sheets[0].RowCount - 1, 2).Locked = false;
            spr3.Sheets[0].Cells.Get(0, 2, spr3.Sheets[0].RowCount - 1, 2).BackColor = cls_color.gColor_수정;
            cls_com.SpreadLoad(this, spr3.ActiveSheet);

            spr3.ActiveSheet.AddSpanCell(0, 3, spr3.ActiveSheet.RowCount , 1);
        }

        private void 조회3(String knou_id)
        {
            DataSet ds;
            Font font = new Font("굴림체", 12, FontStyle.Bold);
            FarPoint.Win.Spread.CellType.ImageCellType ic = new FarPoint.Win.Spread.CellType.ImageCellType( FarPoint.Win.RenderStyle.Stretch );
            ds = cls_com.Select_Query(" s_a201_data5_조회 '2','" + knou_id + "','" + cmb품종.Text + "','' ,'','' ");
            spr4.DataSource = ds;
            spr4.ActiveSheet.ColumnHeader.Rows[0].Height = 50;

            if (ds.Tables[0].Rows.Count > 0) {
                spr4.Sheets[0].Rows.Get(0, spr4.ActiveSheet.RowCount-1).Height = 100;
                spr4.Sheets[0].Cells.Get(0, 2, spr4.Sheets[0].RowCount - 1, 2).CellType = ic;
                spr4.Sheets[0].Cells.Get(0, 0, spr4.Sheets[0].RowCount - 1, spr4.Sheets[0].ColumnCount - 1).Locked = true;
                spr4.Sheets[0].Cells.Get(0, 0, spr4.Sheets[0].RowCount - 1, spr4.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr4.Sheets[0].Cells.Get(0, 0, spr4.Sheets[0].RowCount - 1, spr4.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            cls_com.SpreadLoad(this, spr4.ActiveSheet);
        }
        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // cls_com.ConfigSave(this.Name + "_sc_넓이", sc.SplitterDistance.ToString());
        }

        private void spr3_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr3.ActiveSheet);
        }

        private void spr4_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr4.ActiveSheet);
        }

        private void sc1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc1_높이", sc1.SplitterDistance.ToString());
        }

        private void btn등록2_Click(object sender, EventArgs e)
        {
            등록2();
        }

        private void btn수정2_Click(object sender, EventArgs e)
        {
            수정2();
        }

        private void btn수정3_Click(object sender, EventArgs e)
        {
            삭제2();
        }

        private void spr1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            String d;
            if (e.ColumnHeader)
            {
                if (e.Column == 0)

                {
                    if (spr1.ActiveSheet.Rows.Count > 0)
                    {
                        d = spr1.ActiveSheet.Cells[0, 0].Text;
                        if (d.Equals("True"))
                        {
                            for (int i = 0; i < spr1.ActiveSheet.RowCount; i++)
                            {
                                spr1.ActiveSheet.Cells[i, 0].Text = "False";
                            }
                        }
                        else
                        {
                            for (int i = 0; i < spr1.ActiveSheet.RowCount; i++)
                            {
                                spr1.ActiveSheet.Cells[i, 0].Text = "True";
                            }

                        }

                    }
                }
            }
        }

        private void spr4_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            string d;
            FarPoint.Win.Spread.CellType.ImageCellType ic = new FarPoint.Win.Spread.CellType.ImageCellType( FarPoint.Win.RenderStyle.Stretch);

            if (e.Row < 0) return;

            txt일자.Text = spr4.ActiveSheet.Cells[e.Row, 0].Text;
            txt시간.Text = spr4.ActiveSheet.Cells[e.Row, 1].Text;
            for (int i = 2; i < spr4.ActiveSheet.ColumnCount; i++)
            {
                d = spr4.ActiveSheet.Cells[e.Row, i].Text;
                spr3.ActiveSheet.Cells[i-1, 2].Text = d ;
            }

            Image 그림;
            그림 = 그림_조회(txtKnouid.Text, txt일자.Text, txt시간.Text);

            spr3.ActiveSheet.Cells[0, 3].CellType = ic;
            spr3.ActiveSheet.Cells[0, 3].Value = 그림;
        }

        private Image 그림_조회(string knou_id,string 일자,string 시간)
        {
            Image 그림 = null ;
            sql = " s_a201_data5_조회 '3','" + knou_id + "','" + cmb품종.Text + "' ,'" + 일자 + "' ,'" + 시간 + "',''";
            DataSet ds = cls_com.Select_Query(sql);

            try
            {
                byte[] rawData = new byte[0];
                rawData = (byte[])ds.Tables[0].Rows[0][2];

                그림 = cls_com.byteArrayToImage(rawData);
            } catch

            {

            }
            return 그림;
        }

        private void spr1_MouseUp(object sender, MouseEventArgs e)
        {
            마우스선택();
        }
        private void 마우스선택()
        {
            int I1, i2;
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr1.ActiveSheet.GetSelections();

            if (cr.Length > 0)
            {
                I1 = cr[0].Row;
                i2 = cr[0].Row + cr[0].RowCount;
                for (int i = I1; i < i2; i++)
                {
                    if (spr1.ActiveSheet.Cells[i, 0].Text.Equals("True"))
                    {
                        spr1.ActiveSheet.Cells[i, 0].Value = false;
                    }
                    else
                    {
                        spr1.ActiveSheet.Cells[i, 0].Value = true;

                    }
                }
            }
        }

        private void btn엑셀_업로드_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "데이타_" + String.Format("{0:yyyyMMdd}", DateTime.Now);
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    spr1.ActiveSheet.RemoveColumns(0, 1);
                    cls_com.엑셀_저장(spr1, saveFileDialog.FileName,spr1.ActiveSheet.ColumnHeader.Rows.Count);
                    조회();



                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void 수정()
        {
            for (int i = 3; i < spr2.ActiveSheet.RowCount;i++)
            {
                if ( !spr2.ActiveSheet.Cells[i,1].Text.Equals(""))
                {
                    spr2.ActiveSheet.Cells[i, 2].BackColor = cls_color.gColor_수정;
                    spr2.ActiveSheet.Cells[i, 2].Locked = false;
                }
            }
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }
        private void 저장()
        {
            string d;
            int k = 0;
            int n = 0; 
            int irow = 2 ; 
            string knou_id = spr2.ActiveSheet.Cells[1, 2].Text;
            for (int i = 1; i < spr2.ActiveSheet.RowCount; i++) {
                d = spr2.ActiveSheet.Cells[i, 1].Text.ToString();
                if (d.Equals("")) { 
                    
                    if (k == 0 )
                    {
                        sql = " exec s_a201_data1_저장 '2','','','" + cls_com.s사용자.성명 + "','" + knou_id + "' ";
                        for (int j= irow ; j <  i; j++  )
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                        }
                        cls_com.ExcuteNonQuery(sql);
                        irow = i+1;
                    }
                    else if (k == 1)
                    {
                        sql = " exec s_a201_data2_저장 '2','" + knou_id + "' ";
                        for (int j = irow; j < i  ; j++)
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                        }
                        cls_com.ExcuteNonQuery(sql);
                        irow = i+1;
                    }
                    else if (k == 2)
                    {
                        sql = " exec s_a201_data3_저장 '2','" + knou_id + "' ";
                        for (int j = irow; j < i  ; j++)
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                        }
                        cls_com.ExcuteNonQuery(sql);
                        irow = i+1;
                    }
                    else if (k == 3)
                    {
                        n = 0;
                        sql = " exec s_a201_data4_저장 '2','" + knou_id + "' ";
                        for (int j = irow; j < i ; j++)
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                            n++;
                        }

                        for (int j = n; j <= 20; j ++ )
                        {
                            sql = sql + ",'' ";
                        }
                        cls_com.ExcuteNonQuery(sql);
                        irow = i + 1;
                    }
                    else if (k == 4)
                    {
                        n = 0;
                        sql = " exec  s_a201_data5_저장 '2','" + knou_id + "' ";
                        for (int j = irow; j < i ; j++)
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                            n++;
                        }
                        for (int j = n; j <= 20; j++)
                        {
                            sql = sql + ",'' ";
                        }
                   //      cls_com.ExcuteNonQuery(sql);
                        irow = i + 1;
                    }
                    else if (k == 5)
                    {
                        sql = " exec s_a201_data6_저장 '2','" + knou_id + "' ";
                        for (int j = irow; j < i ; j++)
                        {
                            sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
                        }
                        irow = i + 1;
                    }
                    k++;
                }

            }
            sql = " exec s_a201_data6_저장 '2','" + knou_id + "' ";
            for (int j = irow; j < spr2.ActiveSheet.RowCount; j++)
            {
                sql = sql + ",'" + spr2.ActiveSheet.Cells[j, 2].Text + "' ";
            }
            cls_com.ExcuteNonQuery(sql);

            조회(knou_id);

        }

        private void btn사진_Click(object sender, EventArgs e)
        {
            사진();
        }

        private void 사진()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " Image File|*.JPG;*.JPEG;*.BMP;*.ICO;*.EMF;*.GIF;";
            openFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    사진_불러오기(openFileDialog.FileName);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }
        private void 사진_불러오기(string file)
        {

            Image 그림;
            그림 = Image.FromFile(file);
            그림 = cls_com.사진_해상도_저장(그림);
            r그림 = 그림;

            FarPoint.Win.Spread.CellType.ImageCellType ic = new FarPoint.Win.Spread.CellType.ImageCellType(FarPoint.Win.RenderStyle.Stretch);
            
            spr3.ActiveSheet.AddSpanCell(0, 3, spr3.ActiveSheet.RowCount, 1);
            spr3.ActiveSheet.Cells[0, 3].CellType = ic;
            spr3.ActiveSheet.Cells[0, 3].Value = Image.FromFile(file);


        }

        private void btn등록_Click(object sender, EventArgs e)
        {

        }

        private void btn삭제_Click(object sender, EventArgs e)
        {

        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            바코드출력();
        }
        private void 바코드출력()
        {
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g프린터);


            PrinterSettings settings = new PrinterSettings();

            settings.Copies = 1; //I put number 2 here




            printDoc.PrinterSettings = settings;

            Application.DoEvents();



            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr1.ActiveSheet.GetSelections();

            rRow0 = 0;
            for (int i = 0; i < spr1.ActiveSheet.RowCount; i++)
            {
                rRow0 = i;
                if (spr1.ActiveSheet.Cells[rRow0, 0].Text.Equals("True"))
                {
                    printDoc.Print();
                    Application.DoEvents();
                }
            }
            //      Application.DoEvents();
            //            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string 데이타 = "";
            int 가로 = 0, 세로 = 0;
            int i가로, i세로, i사이즈;
            string i글꼴 = "";
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;

            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 12, GraphicsUnit.Pixel);

           
            r1 = spr1.ActiveSheet.Cells[rRow0, 1].Text;    // KNOU ID
            r2 = spr1.ActiveSheet.Cells[rRow0, 2].Text;   // Species
            r3 = spr1.ActiveSheet.Cells[rRow0, 9].Text;   // season
            r4 = spr1.ActiveSheet.Cells[rRow0, 5].Text;    // pg
            r5 = spr1.ActiveSheet.Cells[rRow0, 4].Text;   // cross
            r6 = spr1.ActiveSheet.Cells[rRow0, 15].Text;    //TSB 
            r7 = spr1.ActiveSheet.Cells[rRow0, 16].Text;    // TSP
            r8 = spr1.ActiveSheet.Cells[rRow0, 26].Text;   // PL
            r9 = spr1.ActiveSheet.Cells[rRow0, 27].Text;   // comment



            데이타 = "바코드";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "5"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "7"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "100"));
            cls_com.PrintBarcode(e, r1, 가로 + i가로, 세로 + i세로, i사이즈, i사이즈, "0", "False", ifont2, bcType);

            데이타 = "R1";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "40"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "5"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈 ,FontStyle.Bold , GraphicsUnit.Pixel);
            cls_com.PrintText(e, "KNOU ID:" + r1, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            
            데이타 = "R2";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "40"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "15"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold,GraphicsUnit.Pixel);
            cls_com.PrintText(e, "Species:" + r2, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            데이타 = "R3";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "40"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "25"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "Season:" + r3, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            데이타 = "R4";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "110"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "25"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "PG:" + r4, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);
            데이타 = "R5";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "5"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "45"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "6"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "" + r5, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            데이타 = "R6";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "5"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "55"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "TSB:" + r6, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            데이타 = "R7";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "85"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "55"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "TSP:" + r7, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            데이타 = "R8";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "125"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "55"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "PL:" + r8, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);
            데이타 = "R9";
            i가로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "가로", "5"));
            i세로 = cls_com.Val2(cls_com.ConfigLoad(데이타, "세로", "65"));
            i사이즈 = cls_com.Val2(cls_com.ConfigLoad(데이타, "사이즈", "8"));
            i글꼴 = cls_com.ConfigLoad(데이타, "글꼴", "돋음체");
            ifont = new Font(i글꼴, i사이즈, FontStyle.Bold, GraphicsUnit.Pixel);
            cls_com.PrintText(e, "Comment:" + r9, ifont, "LEFT", "0", 가로 + i가로, 세로 + i세로, 1, 1);

            //        e.HasMorePages = true;
            //     } else
            //     {
            //         e.HasMorePages = false;
            //     }
            //  }
            //  e.HasMorePages = false;
            //  return;
        }
        private void 등록2()
        {
            int icnt, i시작, i끝;
            int k;
            string 코드;
            DataSet ds;
            코드 = txtKnouid.Text;
            icnt = 0;
            i시작 = cls_com.Val(spr3.ActiveSheet.Cells[4, 1].Text);
            i끝 = cls_com.Val(spr3.ActiveSheet.Cells[4, 2].Text);
            sql = " exec s_a201_data5_저장 '1','" + 코드 + "','','',''  ";
            for (k = 1; k < spr3.ActiveSheet.RowCount; k++)
            {
                sql = sql + ",'" + spr3.ActiveSheet.Cells [k,2].Text + "' ";
                icnt++;
            }

            for (k = icnt; k < 20; k++)
            {
                sql = sql + ",'" + "" + "' ";
            }
            ds = cls_com.Select_Query(sql);
            txt일자.Text = "";
            txt시간.Text = "";
            그림_저장(코드, txt일자.Text, txt시간.Text, r그림);
            조회2(코드);
            조회3(코드);
        }

        private void 수정2()
        {
            int icnt, i시작, i끝;
            int k;
            string 코드;
            DataSet ds;
            코드 = txtKnouid.Text;
            icnt = 0;
            i시작 = cls_com.Val(spr3.ActiveSheet.Cells[4, 1].Text);
            i끝 = cls_com.Val(spr3.ActiveSheet.Cells[4, 2].Text);
            sql = " exec s_a201_data5_저장 '2','" + 코드 + "','" + txt일자.Text + "','" + txt시간.Text + "',''  ";
            for (k = 1; k < spr3.ActiveSheet.RowCount; k++)
            {
                sql = sql + ",'" + spr3.ActiveSheet.Cells[k, 2].Text + "' ";
                icnt++;
            }

            for (k = icnt; k < 20; k++)
            {
                sql = sql + ",'" + "" + "' ";
            }
            ds = cls_com.Select_Query(sql);
            그림_저장(코드, txt일자.Text,txt시간.Text, r그림);
            조회2(코드);
            조회3(코드);
        }
        private void 그림_저장(string knou_id,string 일자,string 시간,Image 그림 )
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlParameter ptp = null;
            SqlParameter pknou_id = null;
            SqlParameter pdt = null;
            SqlParameter ptm = null;
            SqlParameter ppic = null;
            SqlParameter p가로 = null;
            SqlParameter p세로 = null;

            byte[] bytes; ;
            // byte[] result = null;
            bytes = cls_com.imageToByteArray(그림);



            //   int i, j;

            try
            {
                conn = new SqlConnection(cls_com.gConn_String);
                conn.Open();

                cmd = new SqlCommand("S_a201_data5_사진_저장", conn);
                // UploadFile이라는 이름의 스토어드 프로시져인것으로 가정합니다.

                cmd.CommandType = CommandType.StoredProcedure;
                ptp = new SqlParameter("@v_tp", SqlDbType.VarChar, 250);
                ptp.Value = "1";
                pknou_id  = new SqlParameter("@v_knou_id", SqlDbType.VarChar, 250);
                pknou_id.Value = knou_id;
                pdt = new SqlParameter("@v_dt", SqlDbType.VarChar, 250);
                pdt.Value = 일자;
                ptm = new SqlParameter("@v_tm", SqlDbType.VarChar, 250);
                ptm.Value = 시간;

                ppic = new SqlParameter("@v_pic", SqlDbType.Binary);
                ppic.Value = bytes;
                p가로 = new SqlParameter("@v_가로", SqlDbType.VarChar, 250);
                p가로.Value = 그림.Width;
                p세로 = new SqlParameter("@v_세로", SqlDbType.VarChar, 250);
                p세로.Value = 그림.Height;


                cmd.Parameters.Add(ptp);
                cmd.Parameters.Add(pknou_id);
                cmd.Parameters.Add(pdt);
                cmd.Parameters.Add(ptm);
                cmd.Parameters.Add(ppic);
                cmd.Parameters.Add(p가로);
                cmd.Parameters.Add(p세로);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            catch
            {
            }
        }

        private void 삭제2()
        {
            int icnt, i시작, i끝;
            int k;
            string 코드;
            DataSet ds;


            코드 = txtKnouid.Text;
            icnt = 0;
            i시작 = cls_com.Val(spr3.ActiveSheet.Cells[4, 1].Text);
            i끝 = cls_com.Val(spr3.ActiveSheet.Cells[4, 2].Text);

            DialogResult dr = MessageBox.Show("코드:" + 코드 + " 일자:" + txt일자.Text + " 시간:" + txt시간.Text + "   삭제 하시겠습니까  ? ", "데이타 삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            sql = " exec s_a201_data5_저장 '3','" + 코드 + "','" + txt일자.Text + "','" + txt시간.Text + "',''  ";
            for (k = 1; k < spr3.ActiveSheet.RowCount; k++)
            {
                sql = sql + ",'" + spr3.ActiveSheet.Cells[k, 2].Text + "' ";
                icnt++;
            }

            for (k = icnt; k < 20; k++)
            {
                sql = sql + ",'" + "" + "' ";
            }
            ds = cls_com.Select_Query(sql);
            조회2(코드);
            조회3(코드);
        }
    }
}
