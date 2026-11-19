using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
            // TODO 1：新增優惠結果標籤後，每次試算也要將它重設為「—」。

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                // TODO 2：範圍檢查
                if (days >= 1 && days <= 7)
                {
                    // TODO 3：每日費用
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    // 社團優惠（巢狀 if）
                    int discount;
                    string discountText;
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            discountText = "折抵 30 元";
                        }
                        else
                        {
                            discount = 0;
                            discountText = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discount = 0;
                        discountText = "無優惠";
                    }

                    // TODO 4：應付金額與顯示
                    int total = days * dailyRate - discount;
                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabel.Text = discountText;
                    totalLabel.Text = total.ToString() + " 元";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            feedbackLabel.Text = "";
            clubCheckBox.Checked = false;
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
        }

        private void feedbackLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
