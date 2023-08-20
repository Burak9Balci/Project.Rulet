using Project.Rulet.DesignPattern.SingletonPattern;
using Project.Rulet.Models.ContextClass;
using Project.Rulet.Models.Entities;
using Project.Rulet.Models.OuterRequestModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Rulet
{
    public partial class Form4 : Form
    {
        MyContext _db;
        public Form4(decimal bakiye,int id)
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
            Text = bakiye.ToString();
            u = _db.AppUsers.Find(id);
            
        }
        AppUser u;
        

        private void Form4_Load(object sender, EventArgs e)
        {
            
            
            //for (int i = 2023; i <= 2096; i++)
            //{
            //    cmb_son_kullanma_yil.Items.Add(i.ToString());
            //}
            //for (int a = 1; a <= 12; a++)
            //{
            //    cmb_son_kullanma_ay.Items.Add(a.ToString());
            //}
        }
        HttpResponseMessage result;
        private void btn_ode_Click(object sender, EventArgs e)
        {
            //PaymentRequestModel requestModel = new PaymentRequestModel();
            //if (cmb_son_kullanma_ay.SelectedIndex > 0 && cmb_son_kullanma_yil.SelectedIndex > 0)
            //{


            //    requestModel.CardUserName = txt_Isim.Text;
            //    requestModel.SecurityNumber = txt_guvenlik_no.Text;
            //    requestModel.CardNumber = txt_guvenlik_no.Text;
            //    requestModel.Price = Convert.ToDecimal(txt_Cash.Text);
            //    requestModel.CardExpiryMonth = Convert.ToInt32((cmb_son_kullanma_ay.SelectedItem as ComboBox).Text);
            //    requestModel.CardExpiryYear = Convert.ToInt32((cmb_son_kullanma_yil.SelectedItem as ComboBox).Text);
            //    requestModel.CardExpiryMonth = Convert.ToInt32((cmb_son_kullanma_ay.SelectedItem as ComboBox).Text);
            //    requestModel.CardExpiryYear = Convert.ToInt32((cmb_son_kullanma_yil.SelectedItem as ComboBox).Text);


            //}

            PaymentRequestModel paymentRequest = new PaymentRequestModel
            {
                CardUserName = txt_Isim.Text,
                SecurityNumber = txt_guvenlik_no.Text,
                CardNumber = txt_kart_numarasi.Text,
                ShoppingPrice = Convert.ToDecimal(txt_Cash.Text),
                CardExpiryMonth = Convert.ToInt32(txt_ay.Text),
                CardExpiryYear = Convert.ToInt32(txt_yil.Text)
            };
           
            bool sonuc;
            using (HttpClient client= new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58604/api/");
                Task<HttpResponseMessage> postTask = client.PostAsJsonAsync("Payment/RecivePayment", paymentRequest);
                

                try
                {
                   result = postTask.Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Odeme Basarısız");
                    this.Close();
                }

                if (result.IsSuccessStatusCode) sonuc = true;
                else sonuc = false;


                if (sonuc)
                {
                   
                    u.Bakiye += Convert.ToInt32(txt_Cash.Text);
                    _db.SaveChanges();
                    MessageBox.Show("Bakiye Yuklendi");
                    this.Close();


                }
                else
                {
                    Task<string> s = result.Content.ReadAsStringAsync();
                    this.Close();
                }
                

            }
        }
    }
}
