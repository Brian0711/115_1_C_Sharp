namespace Toturial_2_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Italianbutton = new System.Windows.Forms.Button();
            this.Germanybutton = new System.Windows.Forms.Button();
            this.Spainbutton = new System.Windows.Forms.Button();
            this.translatelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(111, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎摸說\"早安\"";
            // 
            // Italianbutton
            // 
            this.Italianbutton.Location = new System.Drawing.Point(106, 362);
            this.Italianbutton.Name = "Italianbutton";
            this.Italianbutton.Size = new System.Drawing.Size(226, 98);
            this.Italianbutton.TabIndex = 1;
            this.Italianbutton.Text = "義大利";
            this.Italianbutton.UseVisualStyleBackColor = true;
            this.Italianbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Germanybutton
            // 
            this.Germanybutton.Location = new System.Drawing.Point(467, 362);
            this.Germanybutton.Name = "Germanybutton";
            this.Germanybutton.Size = new System.Drawing.Size(226, 98);
            this.Germanybutton.TabIndex = 2;
            this.Germanybutton.Text = "德國";
            this.Germanybutton.UseVisualStyleBackColor = true;
            this.Germanybutton.Click += new System.EventHandler(this.Germanybutton_Click);
            // 
            // Spainbutton
            // 
            this.Spainbutton.Location = new System.Drawing.Point(843, 362);
            this.Spainbutton.Name = "Spainbutton";
            this.Spainbutton.Size = new System.Drawing.Size(226, 98);
            this.Spainbutton.TabIndex = 3;
            this.Spainbutton.Text = "西班牙";
            this.Spainbutton.UseVisualStyleBackColor = true;
            this.Spainbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // translatelabel
            // 
            this.translatelabel.Font = new System.Drawing.Font("新細明體", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translatelabel.Location = new System.Drawing.Point(98, 162);
            this.translatelabel.Name = "translatelabel";
            this.translatelabel.Size = new System.Drawing.Size(759, 134);
            this.translatelabel.TabIndex = 4;
            this.translatelabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 829);
            this.Controls.Add(this.translatelabel);
            this.Controls.Add(this.Spainbutton);
            this.Controls.Add(this.Germanybutton);
            this.Controls.Add(this.Italianbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Italianbutton;
        private System.Windows.Forms.Button Germanybutton;
        private System.Windows.Forms.Button Spainbutton;
        private System.Windows.Forms.Label translatelabel;
    }
}

