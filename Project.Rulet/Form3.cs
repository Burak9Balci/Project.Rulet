using Project.Rulet.DesignPattern.SingletonPattern;
using Project.Rulet.Models.ContextClass;
using Project.Rulet.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Rulet
{
    public partial class Form3 : Form
    {
        MyContext _db;
        public Form3(TextBox isim,TextBox nick)
        {
                        InitializeComponent();
            _db = DBTool.DBInstance;
            //lbl_bakiye.Text = _db.AppUsers.FirstOrDefault(x => x.UserName == txt.Text).Bakiye.ToString();
            //lbl_kullanici.Text = $"Hosgeldin {_db.AppUsers.FirstOrDefault(x => x.UserName == txt.Text).UserName}";
            //u = _db.AppUsers.Find(_db.AppUsers.FirstOrDefault(x => x.UserName == txt.Text).ID);
         
            if (nick.Text != "") u = _db.AppUsers.Find(_db.AppUsers.FirstOrDefault(x => x.NickName == nick.Text).ID);
            else u = _db.AppUsers.Find(_db.AppUsers.FirstOrDefault(x => x.UserName == isim.Text).ID);
            if (u.Bakiye == 0) btn_oyna.Enabled = false;
            lbl_bakiye.Text = u.Bakiye.ToString();
            lbl_kullanici.Text = $"Hosgeldin {u.UserName}";

        }
        AppUser u;
        private void btn_bahis_Click(object sender, EventArgs e)
        {
            
            u.BahisYap(Convert.ToInt32(txt_miktar.Text),lbl_yatırım,lbl_bakiye);        
        }
        
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bakiye_yatir_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(u.Bakiye,u.ID);
            form4.ShowDialog();
            lbl_bakiye.Text = u.Bakiye.ToString();
            
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            u.Arttır(lbl_bakiye, lbl_yatırım);
            
        }

        private void btn_des_Click(object sender, EventArgs e)
        {
            u.Dusur(lbl_bakiye,lbl_yatırım);
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
