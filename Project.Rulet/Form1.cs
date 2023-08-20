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
    public partial class Form1 : Form
    {
        MyContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (_db.AppUsers.Any(x => x.UserName == txt_isim.Text && x.PassWord == txt_sifre.Text))
            {
                
                Form3 form3 = new Form3(txt_isim,txt_nick);
                form3.ShowDialog();
               
            }
            else if (_db.AppUsers.Any(x =>x.NickName == txt_nick.Text))
            {
                Form3 form3 = new Form3(txt_isim,txt_nick);
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı");
            }
            
        }

        private void btn_uye_ol_Click(object sender, EventArgs e)
        {       
             Application.Run();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
