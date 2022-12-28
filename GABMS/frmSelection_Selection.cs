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
    public partial class frmSelection_Selection : Form
    {

        int rRow0 = 0; 
        string sql = "";
        string r1 = "", r2 = "", r3 = "", r4 = "", r5 = "", r6 = "", r7 = "", r8 = "",r9="";
        private PrintDocument printDoc = new PrintDocument();
        public frmSelection_Selection()
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
            
            sql = " exec s_a301_selection_조회 '1','" + cls_com.GetDate2()  + "','" + cls_com.GetDate2() + "','','','" + txt조회.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr1.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt1.Text = ds.Tables[0].Rows.Count.ToString();
            spr1.Reset();
            spr1.DataSource = ds;

            타이틀1(ds);
            cls_com.Sort표시(spr1.ActiveSheet);
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr1.Sheets[0].Cells.Get(0, 1, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).Locked = true;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr1.Sheets[0].Cells.Get(0, 0, spr1.Sheets[0].RowCount - 1, spr1.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr1.Sheets[0]);
            lblCnt1.Text = spr1.ActiveSheet.RowCount.ToString();
        }

        private void frmSelection_Selection_Load(object sender, EventArgs e)
        {
          //  string d;
        //    d = cls_com.ConfigLoad(this.Name + "_sc_넓이");
         //   sc.SplitterDistance = cls_com.Val(d);
            Add품종();
            조회();
            String d;
            d = cls_com.ConfigLoad(this.Name + "_sc1_높이");
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
            if (!e.ColumnHeader)
            {
                조회(spr1.ActiveSheet.Cells[e.Row, 4].Text);
            }
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

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // cls_com.ConfigSave(this.Name + "_sc_넓이", sc.SplitterDistance.ToString());
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

      


        private void btn취소_Click(object sender, EventArgs e)
        {
            취소();
        }


        private void txt바코드_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                저장();
            }
        }

        private void 저장()
        {
            string knou_id = txt바코드.Text.ToUpper();
            sql = " exec s_a301_selection_저장 '1','" + cls_com.GetDate2() + "','" + cls_com.GetTime() + "','" + knou_id + "','','" +  cls_com.s사용자.성명  + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    포커스();
                    return;
                }
            }
            조회();
            조회(knou_id);
            포커스();

        }
        private void 취소()
        {
            string knou_id = "";
            knou_id = spr2.ActiveSheet.Cells[1, 2].Text;
            if (MessageBox.Show("KNOU_ID : " + knou_id + " 삭제 하시겠습니까 ? ", "삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            sql = " exec s_a301_selection_저장 '3','" + cls_com.GetDate2() + "','" + cls_com.GetTime() + "','" + knou_id + "','','" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    포커스();
                    return;
                }
            }
            조회();
            조회(knou_id);
            포커스();

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
        private void 포커스()
        {
            txt바코드.Text = "";
            txt바코드.Focus();
        }
    }
}
