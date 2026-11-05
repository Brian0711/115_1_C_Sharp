using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double score1, score2, score3, average;

            // 驗證三個分數是否為有效數字
            if (!double.TryParse(test1TextBox.Text, out score1))
            {
                MessageBox.Show("請輸入有效的 Test Score #1!");
                test1TextBox.Focus();
                return;
            }

            if (!double.TryParse(test2TextBox.Text, out score2))
            {
                MessageBox.Show("請輸入有效的 Test Score #2!");
                test2TextBox.Focus();
                return;
            }

            if (!double.TryParse(test3TextBox.Text, out score3))
            {
                MessageBox.Show("請輸入有效的 Test Score #3!");
                test3TextBox.Focus();
                return;
            }

            // 計算平均
            average = (score1 + score2 + score3) / 3;
            averageLabel.Text = average.ToString("n1");   // 顯示到小數點後一位
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = "";
            test1TextBox.Focus();   // 游標回到第一個欄位
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}