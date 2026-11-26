using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 驗證起始餘額
            if (!decimal.TryParse(startingBalTextBox.Text, out decimal balance))
            {
                MessageBox.Show("請輸入有效的起始餘額。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startingBalTextBox.Focus();
                startingBalTextBox.SelectAll();
                return;
            }

            // 驗證月份數量
            if (!int.TryParse(monthsTextBox.Text, out int months) || months <= 0)
            {
                MessageBox.Show("月份數量必須是大於 0 的整數。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthsTextBox.Focus();
                monthsTextBox.SelectAll();
                return;
            }

            detailListBox.Items.Clear();
            endingBalanceLabel.Text = "";
            detailListBox.Items.Add("起始餘額：" + balance.ToString("N2"));

            // 逐月輸入存入(正數)或提領(負數)金額
            for (int month = 1; month <= months; month++)
            {
                string input;
                decimal amount;

                while (true)
                {
                    if (!ShowPrompt("第 " + month + " 個月的存入金額（提領請輸入負數）：",
                                    "第 " + month + " / " + months + " 個月", out input))
                    {
                        // 使用者按取消，中止計算
                        detailListBox.Items.Clear();
                        return;
                    }
                    if (decimal.TryParse(input, out amount))
                        break;

                    MessageBox.Show("請輸入有效的數字。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                balance += amount;
                detailListBox.Items.Add("第 " + month + " 月：" +
                    amount.ToString("N2") + "  →  餘額 " + balance.ToString("N2"));
            }

            endingBalanceLabel.Text = balance.ToString("N2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Clear();
            monthsTextBox.Clear();
            detailListBox.Items.Clear();
            endingBalanceLabel.Text = "";
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 簡易輸入對話框（不需額外加入 Microsoft.VisualBasic 參考）
        private static bool ShowPrompt(string text, string title, out string value)
        {
            using (Form prompt = new Form())
            {
                prompt.Text = title;
                prompt.ClientSize = new Size(340, 110);
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;

                Label label = new Label { Text = text, Left = 15, Top = 15, Width = 310, AutoSize = false, Height = 20 };
                TextBox box = new TextBox { Left = 15, Top = 42, Width = 310 };
                Button ok = new Button { Text = "確定", Left = 165, Top = 72, Width = 75, DialogResult = DialogResult.OK };
                Button cancel = new Button { Text = "取消", Left = 250, Top = 72, Width = 75, DialogResult = DialogResult.Cancel };

                prompt.Controls.AddRange(new Control[] { label, box, ok, cancel });
                prompt.AcceptButton = ok;
                prompt.CancelButton = cancel;

                bool accepted = prompt.ShowDialog() == DialogResult.OK;
                value = box.Text;
                return accepted;
            }
        }
    }
}
