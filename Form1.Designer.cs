namespace ScadaDeneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(43, 125);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 62);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "BIR";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Location = new System.Drawing.Point(272, 222);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 39);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "DORT";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Location = new System.Drawing.Point(76, 222);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 39);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "UC";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Location = new System.Drawing.Point(272, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 62);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "IKI";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(106, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

