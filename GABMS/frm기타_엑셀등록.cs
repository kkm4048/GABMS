using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GABMS
{
    public partial class frm기타_엑셀등록 : Form
    {
        string sql = "";
        string r품종 = "" ;
        public string rFileName = "";
        public frm기타_엑셀등록()
        {
            InitializeComponent();
        }
        public frm기타_엑셀등록(string iFileName)
        {
            InitializeComponent();
            rFileName = iFileName;
        }
        public frm기타_엑셀등록(string iFileName ,string 품종)
        {
            InitializeComponent();
            rFileName = iFileName;
            r품종 = 품종;
        }
        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {

        }
        private void LoadExcel()
        {

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // sprList.ActiveSheet.OpenExcel(rfileName, 0);
                spr1.OpenExcel(rFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Cursor.Current = Cursors.Default;

        }

        private void frm기타_엑셀불러오기_Load(object sender, EventArgs e)
        {
            Add품종();
            LoadExcel();
            조회0();
            조회();

        }

        private void 조회0()
        {
            int 총수량 = 0 ;
            int 시작, 끝, 수량;
            spr.ActiveSheet.RowCount = 6;
            spr.ActiveSheet.ColumnCount = 4;
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "시작";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "끝";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "수량";


            spr.ActiveSheet.Cells[0, 0].Text = "General info";
            spr.ActiveSheet.Cells[1, 0].Text = "DNA extraction";
            spr.ActiveSheet.Cells[2, 0].Text = "Plantings";
            spr.ActiveSheet.Cells[3, 0].Text = "Seedling Selection";
            spr.ActiveSheet.Cells[4, 0].Text = "Plant selection";
            spr.ActiveSheet.Cells[5, 0].Text = "Seed managements";

            sql = "";
            시작 = 0;
            for (int i = 0; i < spr.ActiveSheet.RowCount; i++) {
                sql =  " SELECT dbo.f_항목수량('" + cmd품종.Text + "','" + spr.ActiveSheet.Cells[i, 0].Text  +"' ) 수량 " ;
                DataSet ds = cls_com.Select_Query(sql);
                수량 = cls_com.Val(ds.Tables[0].Rows[0]["수량"].ToString()) ;
                총수량 = 총수량 + 수량;
                끝 = 시작 + 수량;
                spr.ActiveSheet.Cells[i, 1].Text = 시작.ToString();
                spr.ActiveSheet.Cells[i, 2].Text = (끝-1).ToString();
                spr.ActiveSheet.Cells[i, 3].Text = 수량.ToString();
                시작 = 시작 + 수량;
            }

            spr1.ActiveSheet.ColumnCount = 총수량;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1,0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            spr.Sheets[0].Cells.Get(0, 1, spr.Sheets[0].RowCount - 1, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;

        }

        private void 초기화()
        {
            /*
            spr1.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "관리번호";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "구분";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "제조사";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "모델명";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "시리얼번호";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "사용자";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "직원번호";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "부서";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "직위";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "근무처";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "취득일자";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 11].Text = "상태";
            spr1.ActiveSheet.ColumnHeader.Cells[0, 12].Text = "기타";
            */
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }

        
        private void 저장()
        {
            int i,  k;
            int i시작, i끝;
            int icnt = 0, icnt2 = 0;
            int i수량 = 0;
            DataSet ds;
            string 코드 = "";
            try
            {

                icnt2 = 0;
                for (i = 1; i < spr1.ActiveSheet.RowCount; i++)
                {

                    코드 = spr1.ActiveSheet.Cells[i, 0].Text.Trim();
                    if ((코드.IndexOf("KNOU") >= 0) && (코드.Length == 12))
                    {
                        icnt2 = 0;

                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[0, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[0, 2].Text);
                        sql = " exec s_a201_data1_저장 '1', '','','" + cls_com.s사용자.성명 + "' ";
                        for (k= i시작; k <= i끝; k++ )
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text.Trim()  + "'  ";
                        }
                        ds = cls_com.Select_Query(sql);

                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[1, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[1, 2].Text);
                        sql = " exec s_a201_data2_저장 '1', '" + 코드 + "' ";
                        for (k = i시작; k <= i끝; k++)
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text + "' ";
                        }
                        ds = cls_com.Select_Query(sql);


                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[2, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[2, 2].Text);
                        sql = " exec s_a201_data3_저장 '1' ,'" + 코드 + "' ";
                        for (k = i시작; k <= i끝; k++)
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text + "' ";
                        }
                        ds = cls_com.Select_Query(sql);

                        icnt = 0;
                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[3, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[3, 2].Text);
                        sql = " exec s_a201_data4_저장 '1','" + 코드 + "',''  ";
                        for (k = i시작; k <= i끝; k++)
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text + "' ";
                            icnt++;
                        }

                        for (k = icnt; k < 20; k++)
                        {
                            sql = sql + ",'" + "" + "' ";
                        }
                        ds = cls_com.Select_Query(sql);

                        icnt = 0;
                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[4, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[4, 2].Text);
                        sql = " exec s_a201_data5_저장 '11','" + 코드 + "','','',''  ";
                        for (k = i시작; k <= i끝; k++)
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text + "' ";
                            icnt++;
                        }

                        for (k = icnt; k < 20; k++)
                        {
                            sql = sql + ",'" + "" + "' ";
                        }
                        ds = cls_com.Select_Query(sql);

                        i시작 = cls_com.Val(spr.ActiveSheet.Cells[5, 1].Text);
                        i끝 = cls_com.Val(spr.ActiveSheet.Cells[5, 2].Text);
                        sql = " exec s_a201_data6_저장 '1','" + 코드 + "'  ";
                        for (k = i시작; k <= i끝; k++)
                        {
                            sql = sql + ",'" + spr1.ActiveSheet.Cells[i, k].Text + "' ";
                        }
                        ds = cls_com.Select_Query(sql);


                        i수량++;
                        lblCnt1.Text = i수량.ToString();
                        Application.DoEvents();

                    }
                    else  {
                        icnt2++;
                    }
                    if (icnt2 >  10 )
                    {
                        MessageBox.Show(i수량.ToString() + " 건 저장 완료");
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }
        private void 조회()
        {
            //SPEC


            sql = " exec s_a201_data_조회 '1','','" + cmd품종.Text + "','타이틀 가져오기' ";
            DataSet ds = cls_com.Select_Query(sql);
           
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            타이틀1(ds);
           

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

                }
                else
                {
                    spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text = ds.Tables[0].Columns[i].ColumnName.ToString();
                }
            }
            string d = "";
            int i1 = 0, i2 = 0;
            d = spr1.ActiveSheet.ColumnHeader.Cells[0, 0].Text;

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {

                if (d.Equals(spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text))
                {
                    i2 = i;
                }
                else
                {
                    d = spr1.ActiveSheet.ColumnHeader.Cells[0, i].Text;

                    spr1.ActiveSheet.AddColumnHeaderSpanCell(0, i1, 1, i2 - i1 + 1);
                    i1 = i;
                    i2 = i;
                }
            }

            spr1.ActiveSheet.AddColumnHeaderSpanCell(0, i1, 1, i2 - i1 + 2);



        }


        private void Add품종()
        {
            sql = " exec s_a101_품종_조회 '1','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmd품종.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmd품종.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }

            try
            {
                cmd품종.Text = cls_com.ConfigLoad(this.Name + "_품종");
            }
            catch
            {

            }
            cmd품종.Text = r품종;


        }
    }

}
