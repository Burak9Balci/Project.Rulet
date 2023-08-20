using Project.Rulet.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Rulet.Models.Entities
{
    public class Bahis : BaseEntity
    {
        public int BahisMiktari { get; set; }
        public OyunSonucu Sonuc { get; set; }
        public int AppUserID { get; set; }
        // Reletional Property
        public virtual AppUser AppUser { get; set; }
        
    }
}
