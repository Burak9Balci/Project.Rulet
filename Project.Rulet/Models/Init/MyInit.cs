using Project.Rulet.Models.ContextClass;
using Project.Rulet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Rulet.Models.Init
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            AppUser au = new AppUser
            {
                UserName = "cakal",
                PassWord = "1234",
                Bakiye = 800
            };
            context.AppUsers.Add(au);
            context.SaveChanges();
        }
    }
}
