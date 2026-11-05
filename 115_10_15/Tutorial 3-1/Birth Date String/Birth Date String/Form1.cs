using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            if (dayOfWeekTextBox.Text.Trim() == "" || monthTextBox.Text.Trim() == "" ||
       dayOfMonthTextBox.Text.Trim() == "" || yearTextBox.Text.Trim() == "")
            {
                MessageBox.Show("請填寫所有欄位!");
                return;
            }

            // 組合成 "Friday, March 5, 2026" 的格式
            dateOutputLabel.Text = dayOfWeekTextBox.Text.Trim() + ", " +
                           monthTextBox.Text.Trim() + " " +
                           dayOfMonthTextBox.Text.Trim() + ", " +
                           yearTextBox.Text.Trim();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = "";
            dayOfWeekTextBox.Focus();   // 游標回到第一個欄位
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
