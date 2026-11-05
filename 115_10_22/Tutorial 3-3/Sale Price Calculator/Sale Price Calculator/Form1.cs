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

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice, discountPercentage, discountAmount, salePrice;

            // 驗證原價
            if (!decimal.TryParse(originalPriceTextBox.Text, out originalPrice))
            {
                MessageBox.Show("請輸入有效的原價!");
                originalPriceTextBox.Focus();
                return;
            }

            // 驗證折扣百分比
            if (!decimal.TryParse(discountPercentageTextBox.Text, out discountPercentage))
            {
                MessageBox.Show("請輸入有效的折扣百分比!");
                discountPercentageTextBox.Focus();
                return;
            }

            // 範圍檢查
            if (originalPrice < 0)
            {
                MessageBox.Show("原價不可為負數!");
                originalPriceTextBox.Focus();
                return;
            }

            if (discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("折扣百分比必須介於 0 到 100 之間!");
                discountPercentageTextBox.Focus();
                return;
            }

            // 計算折扣金額與售價
            discountAmount = originalPrice * (discountPercentage / 100);
            salePrice = originalPrice - discountAmount;

            salePriceLabel.Text = salePrice.ToString("c");   // 貨幣格式
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}