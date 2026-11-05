using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 類別層級變數:累計總額(單位:美元)
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // 把指定金額加進總額並更新顯示
        private void AddCoin(decimal amount)
        {
            total += amount;
            totalLabel.Text = total.ToString("c");   // 貨幣格式
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddCoin(0.05m);
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddCoin(0.10m);
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddCoin(0.25m);
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddCoin(0.50m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
