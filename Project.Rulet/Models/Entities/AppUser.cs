using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Rulet.Models.Entities
{
    public class AppUser: BaseEntity
    {
        public int Zar()
        {
            Random rnd = new Random();
            return rnd.Next(0,37);
            
        }
        public bool BahisYap(int bahis,Label havuz,Label lBakiye)
        {
            if (Bakiye >= 100)
            {
                Bahis += bahis;
                havuz.Text = Bahis.ToString();
                Bakiye -= bahis;
                lBakiye.Text = Bakiye.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Artık bahis yatıracak kadar bakiyeniz kalmadı");
                return false;
            }
        }
        public bool Dusur(Label labelBakiye, Label text2)
        {
            
            if (Bakiye >= 0 && Bahis >= 20)
            {
                
                Bakiye += 20;
                labelBakiye.Text = Bakiye.ToString();
                Bahis -= 20;
                text2.Text = Bahis.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Eksiltme Yapamazsınız");
                return false;
            }

        }
        public bool Arttır(Label textBakiye, Label text2)
        {
            
            if (Bakiye > 0)
            {
                Bakiye -= 20;
                textBakiye.Text = Bakiye.ToString();
                Bahis += 20;
                text2.Text = Bahis.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Artık bahis yatıracak kadar bakiyeniz kalmadı");
                return false;
            }

        }
        public string NickName { get; set; }
        public int Bahis { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public decimal Bakiye { get; set; }
        

        //Relational Property
        public virtual AppUserProfile AppUserProfile { get; set; }
        public virtual List<Top> Toplar { get; set; }
        public virtual List<Bahis> Bahisler { get; set; }
    }
}
