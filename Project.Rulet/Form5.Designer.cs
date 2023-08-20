namespace Project.Rulet
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(288, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Aklındaki Sayi";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(383, 147);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(87, 62);
            this.btnRed.TabIndex = 32;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(288, 147);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(87, 62);
            this.btnBlack.TabIndex = 31;
            this.btnBlack.Text = "Spin Renk";
            this.btnBlack.UseVisualStyleBackColor = false;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(320, 118);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(118, 20);
            this.txtTahmin.TabIndex = 30;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(336, 314);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(87, 62);
            this.btnSpin.TabIndex = 29;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // lbl_deger
            // 
            this.lbl_deger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_deger.Location = new System.Drawing.Point(289, 218);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(181, 89);
            this.lbl_deger.TabIndex = 34;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_deger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.btnSpin);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lbl_deger;
    }
}