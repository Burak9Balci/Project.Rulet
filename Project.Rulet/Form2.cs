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
    public partial class Form2 : Form
    {
        MyContext _db;
        public Form2()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }

        private void btn_uye_ol_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text != "" && txt_sifre.Text != "" && txt_nick.Text != "")
            {
                AppUser au = new AppUser();
                au.UserName = txt_isim.Text;
                au.PassWord = txt_sifre.Text;
                au.NickName = txt_nick.Text;
                _db.AppUsers.Add(au);
                _db.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen girilmeyen bilgileri giriniz");
            }
            
        }
    }
}
