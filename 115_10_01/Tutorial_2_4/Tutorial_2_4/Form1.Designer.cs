namespace Tutorial_2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.finlandpictureBox1 = new System.Windows.Forms.PictureBox();
            this.FrancepictureBox = new System.Windows.Forms.PictureBox();
            this.GermanpictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandpictureBox1
            // 
            this.finlandpictureBox1.Image = global::Tutorial_2_4.Properties.Resources.Finland;
            this.finlandpictureBox1.Location = new System.Drawing.Point(91, 260);
            this.finlandpictureBox1.Name = "finlandpictureBox1";
            this.finlandpictureBox1.Size = new System.Drawing.Size(265, 160);
            this.finlandpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finlandpictureBox1.TabIndex = 0;
            this.finlandpictureBox1.TabStop = false;
            this.finlandpictureBox1.Click += new System.EventHandler(this.finlandpictureBox1_Click);
            // 
            // FrancepictureBox
            // 
            this.FrancepictureBox.Image = global::Tutorial_2_4.Properties.Resources.France;
            this.FrancepictureBox.Location = new System.Drawing.Point(460, 260);
            this.FrancepictureBox.Name = "FrancepictureBox";
            this.FrancepictureBox.Size = new System.Drawing.Size(265, 160);
            this.FrancepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrancepictureBox.TabIndex = 1;
            this.FrancepictureBox.TabStop = false;
            this.FrancepictureBox.Click += new System.EventHandler(this.FrancepictureBox_Click);
            // 
            // GermanpictureBox
            // 
            this.GermanpictureBox.Image = global::Tutorial_2_4.Properties.Resources.Germany;
            this.GermanpictureBox.Location = new System.Drawing.Point(819, 260);
            this.GermanpictureBox.Name = "GermanpictureBox";
            this.GermanpictureBox.Size = new System.Drawing.Size(265, 160);
            this.GermanpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GermanpictureBox.TabIndex = 2;
            this.GermanpictureBox.TabStop = false;
            this.GermanpictureBox.Click += new System.EventHandler(this.GermanpictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(401, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "選一個國旗";
            // 
            // countrylabel
            // 
            this.countrylabel.AutoEllipsis = true;
            this.countrylabel.AutoSize = true;
            this.countrylabel.Font = new System.Drawing.Font("新細明體-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countrylabel.Location = new System.Drawing.Point(501, 540);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(166, 72);
            this.countrylabel.TabIndex = 4;
            this.countrylabel.Text = "1111";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 957);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GermanpictureBox);
            this.Controls.Add(this.FrancepictureBox);
            this.Controls.Add(this.finlandpictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandpictureBox1;
        private System.Windows.Forms.PictureBox FrancepictureBox;
        private System.Windows.Forms.PictureBox GermanpictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countrylabel;
    }
}

