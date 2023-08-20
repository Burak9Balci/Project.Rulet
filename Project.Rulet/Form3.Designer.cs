namespace Project.Rulet
{
    partial class Form3
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
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.lbl_yatırım = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.btn_bahis = new System.Windows.Forms.Button();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_bakiye_yatir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_des = new System.Windows.Forms.Button();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Location = new System.Drawing.Point(75, 26);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(96, 13);
            this.lbl_kullanici.TabIndex = 0;
            this.lbl_kullanici.Text = "Hosgeldin Kullanici";
            // 
            // lbl_yatırım
            // 
            this.lbl_yatırım.AutoSize = true;
            this.lbl_yatırım.Location = new System.Drawing.Point(123, 120);
            this.lbl_yatırım.Name = "lbl_yatırım";
            this.lbl_yatırım.Size = new System.Drawing.Size(0, 13);
            this.lbl_yatırım.TabIndex = 1;
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(123, 55);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(0, 13);
            this.lbl_bakiye.TabIndex = 2;
            // 
            // btn_bahis
            // 
            this.btn_bahis.Location = new System.Drawing.Point(35, 138);
            this.btn_bahis.Name = "btn_bahis";
            this.btn_bahis.Size = new System.Drawing.Size(88, 46);
            this.btn_bahis.TabIndex = 3;
            this.btn_bahis.Text = "Bahis Yatir";
            this.btn_bahis.UseVisualStyleBackColor = true;
            this.btn_bahis.Click += new System.EventHandler(this.btn_bahis_Click);
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(73, 84);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 20);
            this.txt_miktar.TabIndex = 4;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(205, 260);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(58, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_bakiye_yatir
            // 
            this.btn_bakiye_yatir.Location = new System.Drawing.Point(126, 138);
            this.btn_bakiye_yatir.Name = "btn_bakiye_yatir";
            this.btn_bakiye_yatir.Size = new System.Drawing.Size(88, 46);
            this.btn_bakiye_yatir.TabIndex = 6;
            this.btn_bakiye_yatir.Text = "Bakiye Tazele";
            this.btn_bakiye_yatir.UseVisualStyleBackColor = true;
            this.btn_bakiye_yatir.Click += new System.EventHandler(this.btn_bakiye_yatir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bakiye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eldeki Para";
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(35, 190);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(36, 23);
            this.btn_plus.TabIndex = 8;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_des
            // 
            this.btn_des.Location = new System.Drawing.Point(87, 190);
            this.btn_des.Name = "btn_des";
            this.btn_des.Size = new System.Drawing.Size(36, 23);
            this.btn_des.TabIndex = 8;
            this.btn_des.Text = "-";
            this.btn_des.UseVisualStyleBackColor = true;
            this.btn_des.Click += new System.EventHandler(this.btn_des_Click);
            // 
            // btn_oyna
            // 
            this.btn_oyna.Location = new System.Drawing.Point(126, 190);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(88, 23);
            this.btn_oyna.TabIndex = 9;
            this.btn_oyna.Text = "Oyna";
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.btn_des);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bakiye_yatir);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.btn_bahis);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.lbl_yatırım);
            this.Controls.Add(this.lbl_kullanici);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label lbl_yatırım;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Button btn_bahis;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_bakiye_yatir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_des;
        private System.Windows.Forms.Button btn_oyna;
    }
}