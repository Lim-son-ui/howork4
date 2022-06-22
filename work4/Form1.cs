using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work4
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //struct Stati
        //{
        //    //public string name;
        //    //public string name_store;
        //    //public string chinese;
        //    //public string chinese_store;
        //    //public string english;
        //    //public string english_store;
        //    //public string math;
        //    //public string math_store;
        //    public string[] stu;
        //}

        //Stati[] st = new Stati[3];

        Stati st = new Stati();
        private void button1_Click(object sender, EventArgs e)      //儲存輸入資料
        {
            //Stati[] st = new Stati[3];
            //Stati[][] st = new Stati[4][];
            //int[][] stu = new int[3][];
            //str[0] = textBox1.Text;
            //MessageBox.Show(str[0]);
            //MessageBox.Show(st[0].stu.ToString());

            //st.name = textBox1.Text;
            //st.chinese = textBox2.Text;
            //st.english = textBox3.Text;
            //st.math = textBox4.Text;

            st.stu[0] = textBox1.Text;
            st.stu[1] = textBox2.Text;
            st.stu[2] = textBox3.Text;
            st.stu[3] = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)  //顯示儲存內容
        {
            textBox6.Text = "姓名:" + st.stu[0] + "\r\n" +
                            "國文:" + st.stu[1] + "\r\n" +
                            "英文:" + st.stu[2] + "\r\n" +
                            "數學:" + st.stu[3] + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)  //最高分最低分
        {
            int max = 0, min = 0;
            int[] score = new int[3];
            string[] course = new string[3] { "國文", "英文", "數學" };

            for(int i = 0; i < 3; i++)      //分數字串轉換為數字
            {
                score[i] = Convert.ToInt32(st.stu[i + 1]);
            }
            int j, k;
            for( j = 0, k = 0; j < 3 ; j++,k++)
            {
                if (j == 0) max = min = score[j];
                else
                {
                    if(max < score[j]) max = score[j];
                    if(min > score[k]) min = score[k];
                }


            }

            //MessageBox.Show("最高分" + max + "最低分" + min);
            textBox7.Text = "最高科目成績為:"+course[j]+""+score[j];
        }
    }
}
