using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Rulet.Models.Entities
{
    public class Top : BaseEntity
    { 
        
        public int GelenDeger { get; set; }
        public Color Renk { get; set; }
        public int AppUserID { get; set; }
        //Relational property
        public virtual AppUser AppUser { get; set; }
    }
}
