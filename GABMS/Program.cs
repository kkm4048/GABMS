using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GABMS
{
    static class Program
    {
        static string sql = "";
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] d;
            int 테스트 = 1;
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length <= 1)
            {

                if (테스트 == 1)
                {
                    Array.Resize(ref args, 1);
                    args[0] = "1";
                    cls_com.g아이디 = "1";
                    cls_com.g암호 = "1";

                }
                else
                {
                    MessageBox.Show("로그인을 실행하세요");
                    Application.Exit();
                    return;
                }
            }
            else
            {
                d = args[1].Split(',');
                cls_com.g아이디 = d[0];
            }


            if (로그인())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frm메인());
            }
            else
            {
                Application.Exit();
            }

        }
        private static bool 로그인()
        {



            sql = "exec  S_a101_사용자_조회  '11','" + cls_com.g아이디 + "',''  ";

            DataSet ds = cls_com.Select_Query(sql);



            if (ds.Tables[0].Rows.Count > 0)
            {
                cls_com.s사용자.아이디 = ds.Tables[0].Rows[0]["아이디"].ToString();
                cls_com.s사용자.암호 = ds.Tables[0].Rows[0]["암호"].ToString();
                cls_com.s사용자.성명 = ds.Tables[0].Rows[0]["성명"].ToString();
                cls_com.s사용자.연락처 = ds.Tables[0].Rows[0]["연락처"].ToString();
                cls_com.s사용자.등급 = ds.Tables[0].Rows[0]["등급"].ToString();
                cls_com.s사용자.비고 = ds.Tables[0].Rows[0]["비고"].ToString();
                return true;
            }
            else
            {
                MessageBox.Show("아이디 및 암호 확인하세요. ");
                return false;
            }
        }
    }
}
