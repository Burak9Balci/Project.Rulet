namespace Project.Rulet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblHavuz = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_uye_ol = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Location = new System.Drawing.Point(30, 93);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(100, 23);
            this.lblBakiye.TabIndex = 19;
            this.lblBakiye.Text = "Isim";
            // 
            // lblHavuz
            // 
            this.lblHavuz.BackColor = System.Drawing.Color.Transparent;
            this.lblHavuz.Location = new System.Drawing.Point(30, 119);
            this.lblHavuz.Name = "lblHavuz";
            this.lblHavuz.Size = new System.Drawing.Size(100, 23);
            this.lblHavuz.TabIndex = 18;
            this.lblHavuz.Text = "Sifre";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(109, 142);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(87, 44);
            this.btn_giris.TabIndex = 15;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_uye_ol
            // 
            this.btn_uye_ol.Location = new System.Drawing.Point(109, 192);
            this.btn_uye_ol.Name = "btn_uye_ol";
            this.btn_uye_ol.Size = new System.Drawing.Size(87, 27);
            this.btn_uye_ol.TabIndex = 15;
            this.btn_uye_ol.Text = "Uye Ol";
            this.btn_uye_ol.UseVisualStyleBackColor = true;
            this.btn_uye_ol.Click += new System.EventHandler(this.btn_uye_ol_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(102, 116);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 23;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(102, 90);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rulet 2K";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nick
            // 
            this.txt_nick.Location = new System.Drawing.Point(102, 64);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(100, 20);
            this.txt_nick.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "NickName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 265);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uye_ol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblHavuz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblHavuz;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_uye_ol;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.Label label2;
    }
}

