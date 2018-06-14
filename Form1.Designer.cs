namespace trendrakuten
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.kakaku1 = new System.Windows.Forms.Label();
            this.zeikomi = new System.Windows.Forms.Label();
            this.itempic1A = new System.Windows.Forms.PictureBox();
            this.itempic1B = new System.Windows.Forms.PictureBox();
            this.itempic1C = new System.Windows.Forms.PictureBox();
            this.biko1 = new System.Windows.Forms.TextBox();
            this.souryo1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itempic1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itempic1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itempic1C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Twitterへ接続";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "PIN送信";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(195, 520);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listboxselect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(233, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(233, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "に関連する商品（楽天）";
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.link1.Location = new System.Drawing.Point(233, 72);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(73, 16);
            this.link1.TabIndex = 5;
            this.link1.TabStop = true;
            this.link1.Text = "linkLabel1";
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1click);
            // 
            // kakaku1
            // 
            this.kakaku1.AutoSize = true;
            this.kakaku1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kakaku1.Location = new System.Drawing.Point(318, 95);
            this.kakaku1.Name = "kakaku1";
            this.kakaku1.Size = new System.Drawing.Size(49, 20);
            this.kakaku1.TabIndex = 6;
            this.kakaku1.Text = "価格";
            // 
            // zeikomi
            // 
            this.zeikomi.AutoSize = true;
            this.zeikomi.Location = new System.Drawing.Point(277, 96);
            this.zeikomi.Name = "zeikomi";
            this.zeikomi.Size = new System.Drawing.Size(29, 12);
            this.zeikomi.TabIndex = 7;
            this.zeikomi.Text = "税込";
            // 
            // itempic1A
            // 
            this.itempic1A.Location = new System.Drawing.Point(233, 122);
            this.itempic1A.Name = "itempic1A";
            this.itempic1A.Size = new System.Drawing.Size(128, 126);
            this.itempic1A.TabIndex = 8;
            this.itempic1A.TabStop = false;
            // 
            // itempic1B
            // 
            this.itempic1B.Location = new System.Drawing.Point(501, 122);
            this.itempic1B.Name = "itempic1B";
            this.itempic1B.Size = new System.Drawing.Size(128, 126);
            this.itempic1B.TabIndex = 8;
            this.itempic1B.TabStop = false;
            // 
            // itempic1C
            // 
            this.itempic1C.Location = new System.Drawing.Point(367, 122);
            this.itempic1C.Name = "itempic1C";
            this.itempic1C.Size = new System.Drawing.Size(128, 126);
            this.itempic1C.TabIndex = 8;
            this.itempic1C.TabStop = false;
            // 
            // biko1
            // 
            this.biko1.Location = new System.Drawing.Point(233, 254);
            this.biko1.Multiline = true;
            this.biko1.Name = "biko1";
            this.biko1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biko1.Size = new System.Drawing.Size(396, 127);
            this.biko1.TabIndex = 9;
            // 
            // souryo1
            // 
            this.souryo1.AutoSize = true;
            this.souryo1.Location = new System.Drawing.Point(234, 96);
            this.souryo1.Name = "souryo1";
            this.souryo1.Size = new System.Drawing.Size(29, 12);
            this.souryo1.TabIndex = 7;
            this.souryo1.Text = "送料";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 577);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(396, 127);
            this.textBox3.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(233, 443);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(367, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 128);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(501, 443);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 128);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(318, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "商品名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "税込";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(237, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "送料";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel2.Location = new System.Drawing.Point(233, 394);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 16);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1072, 820);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.biko1);
            this.Controls.Add(this.itempic1C);
            this.Controls.Add(this.itempic1B);
            this.Controls.Add(this.itempic1A);
            this.Controls.Add(this.souryo1);
            this.Controls.Add(this.zeikomi);
            this.Controls.Add(this.kakaku1);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "トレンド関連商品検索";
            ((System.ComponentModel.ISupportInitialize)(this.itempic1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itempic1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itempic1C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.Label kakaku1;
        private System.Windows.Forms.Label zeikomi;
        private System.Windows.Forms.PictureBox itempic1A;
        private System.Windows.Forms.PictureBox itempic1B;
        private System.Windows.Forms.PictureBox itempic1C;
        private System.Windows.Forms.TextBox biko1;
        private System.Windows.Forms.Label souryo1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

