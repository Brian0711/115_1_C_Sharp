namespace Toturial2_5
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
            this.CardFacepictureBox = new System.Windows.Forms.PictureBox();
            this.CardBackpictureBox = new System.Windows.Forms.PictureBox();
            this.Showfacebutton1 = new System.Windows.Forms.Button();
            this.Showbackbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardFacepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBackpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CardFacepictureBox
            // 
            this.CardFacepictureBox.Image = global::Toturial2_5.Properties.Resources.Joker_Red;
            this.CardFacepictureBox.Location = new System.Drawing.Point(456, 66);
            this.CardFacepictureBox.Name = "CardFacepictureBox";
            this.CardFacepictureBox.Size = new System.Drawing.Size(506, 704);
            this.CardFacepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardFacepictureBox.TabIndex = 0;
            this.CardFacepictureBox.TabStop = false;
            this.CardFacepictureBox.Visible = false;
            // 
            // CardBackpictureBox
            // 
            this.CardBackpictureBox.Image = global::Toturial2_5.Properties.Resources.Backface_Red;
            this.CardBackpictureBox.Location = new System.Drawing.Point(514, 58);
            this.CardBackpictureBox.Name = "CardBackpictureBox";
            this.CardBackpictureBox.Size = new System.Drawing.Size(516, 712);
            this.CardBackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardBackpictureBox.TabIndex = 1;
            this.CardBackpictureBox.TabStop = false;
            // 
            // Showfacebutton1
            // 
            this.Showfacebutton1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Showfacebutton1.Location = new System.Drawing.Point(119, 871);
            this.Showfacebutton1.Name = "Showfacebutton1";
            this.Showfacebutton1.Size = new System.Drawing.Size(283, 167);
            this.Showfacebutton1.TabIndex = 2;
            this.Showfacebutton1.Text = "顯示正面";
            this.Showfacebutton1.UseVisualStyleBackColor = true;
            this.Showfacebutton1.Click += new System.EventHandler(this.Showfacebutton1_Click);
            // 
            // Showbackbutton2
            // 
            this.Showbackbutton2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Showbackbutton2.Location = new System.Drawing.Point(689, 871);
            this.Showbackbutton2.Name = "Showbackbutton2";
            this.Showbackbutton2.Size = new System.Drawing.Size(283, 167);
            this.Showbackbutton2.TabIndex = 3;
            this.Showbackbutton2.Text = "顯示背面";
            this.Showbackbutton2.UseVisualStyleBackColor = true;
            this.Showbackbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 1254);
            this.Controls.Add(this.Showbackbutton2);
            this.Controls.Add(this.Showfacebutton1);
            this.Controls.Add(this.CardBackpictureBox);
            this.Controls.Add(this.CardFacepictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CardFacepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBackpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CardFacepictureBox;
        private System.Windows.Forms.PictureBox CardBackpictureBox;
        private System.Windows.Forms.Button Showfacebutton1;
        private System.Windows.Forms.Button Showbackbutton2;
    }
}

