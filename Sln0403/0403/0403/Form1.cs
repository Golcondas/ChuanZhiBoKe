using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0403
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //不安全的方式进行操作
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Count();
        }

        public void Count()
        {
            for (int i = 0; i < 99999999; i++)
            {

            }
            MessageBox.Show("计算完毕");
        }

        private void btn_ThreadCount_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(new ThreadStart(Count));
            //将线程调用可以使用
            thr.Start();
        }

        private void btn_CountAndShow_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(CountAndShow);
            th.Start();

        }

        public void CountAndShow()
        {
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 9999; i++)
            {
                Random rd = new Random();
                txt_Num.Text = rd.Next(9999) + "";
                txt_Num2.Text = rd.Next(9999) + "";
                txt_Num3.Text = rd.Next(9999) + "";
                txt_Num4.Text = rd.Next(9999) + "";

            }
            txt_Num.Text = GenerateRandomNumber(6);
            DateTime enDt = DateTime.Now;
            TimeSpan ts = enDt.Subtract(dt);
            MessageBox.Show("计算完毕" + ts.TotalMinutes + "s");
        }

        private static char[] constant =   
      {   
        '0','1','2','3','4','5','6','7','8','9',  
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',   
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'   
      };
        public static string GenerateRandomNumber(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
    }
    public class MyThread
    {
        ThreadStart TsStart;
        public MyThread(ThreadStart TsStart)
        {
            this.TsStart = TsStart;
        }

        public void Run()
        {
            TsStart();
        }
    }
}
