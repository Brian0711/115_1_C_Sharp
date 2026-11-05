using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;

            // 驗證里程是否為有效數字
            if (!double.TryParse(milesTextBox.Text, out miles))
            {
                MessageBox.Show("請輸入有效的里程數!");
                milesTextBox.Focus();
                return;
            }

            // 驗證加侖數是否為有效數字
            if (!double.TryParse(gallonsTextBox.Text, out gallons))
            {
                MessageBox.Show("請輸入有效的加侖數!");
                gallonsTextBox.Focus();
                return;
            }

            // 避免負數與除以零
            if (miles < 0 || gallons <= 0)
            {
                MessageBox.Show("里程不可為負數,加侖數必須大於 0!");
                return;
            }

            // MPG = 里程 / 加侖數
            mpg = miles / gallons;
            mpgLabel.Text = mpg.ToString("n1");   // 顯示到小數點後一位
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}