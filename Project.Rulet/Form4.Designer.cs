namespace Project.Rulet
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.txt_Isim = new System.Windows.Forms.TextBox();
            this.tmr_spin = new System.Windows.Forms.Timer(this.components);
            this.txt_kart_numarasi = new System.Windows.Forms.TextBox();
            this.txt_guvenlik_no = new System.Windows.Forms.TextBox();
            this.btn_ode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.txt_ay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Isim
            // 
            this.txt_Isim.Location = new System.Drawing.Point(25, 103);
            this.txt_Isim.Name = "txt_Isim";
            this.txt_Isim.Size = new System.Drawing.Size(118, 20);
            this.txt_Isim.TabIndex = 25;
            this.txt_Isim.Text = "Dsa";
            // 
            // txt_kart_numarasi
            // 
            this.txt_kart_numarasi.Location = new System.Drawing.Point(159, 103);
            this.txt_kart_numarasi.Name = "txt_kart_numarasi";
            this.txt_kart_numarasi.Size = new System.Drawing.Size(144, 20);
            this.txt_kart_numarasi.TabIndex = 25;
            this.txt_kart_numarasi.Text = "1111 1111 1111 1111 1111";
            // 
            // txt_guvenlik_no
            // 
            this.txt_guvenlik_no.Location = new System.Drawing.Point(313, 103);
            this.txt_guvenlik_no.Name = "txt_guvenlik_no";
            this.txt_guvenlik_no.Size = new System.Drawing.Size(118, 20);
            this.txt_guvenlik_no.TabIndex = 25;
            this.txt_guvenlik_no.Text = "3169";
            // 
            // btn_ode
            // 
            this.btn_ode.Location = new System.Drawing.Point(188, 189);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(87, 23);
            this.btn_ode.TabIndex = 26;
            this.btn_ode.Text = "Öde";
            this.btn_ode.UseVisualStyleBackColor = true;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kart Mumarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kart Üzerindeki Isim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Şifre";
            // 
            // txt_Cash
            // 
            this.txt_Cash.Location = new System.Drawing.Point(313, 147);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.Size = new System.Drawing.Size(118, 20);
            this.txt_Cash.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(147, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bakiye Ekleme Sayfası";
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(171, 147);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(121, 20);
            this.txt_yil.TabIndex = 31;
            this.txt_yil.Text = "2085";
            // 
            // txt_ay
            // 
            this.txt_ay.Location = new System.Drawing.Point(25, 147);
            this.txt_ay.Name = "txt_ay";
            this.txt_ay.Size = new System.Drawing.Size(121, 20);
            this.txt_ay.TabIndex = 31;
            this.txt_ay.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Yil";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 253);
            this.Controls.Add(this.txt_ay);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.txt_guvenlik_no);
            this.Controls.Add(this.txt_kart_numarasi);
            this.Controls.Add(this.txt_Isim);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Isim;
        private System.Windows.Forms.Timer tmr_spin;
        private System.Windows.Forms.TextBox txt_kart_numarasi;
        private System.Windows.Forms.TextBox txt_guvenlik_no;
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.TextBox txt_ay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}