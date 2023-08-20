using Project.Rulet.Models.Entities;
using Project.Rulet.Models.Init;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Rulet.Models.ContextClass
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Top> Toplar { get; set; }
        public DbSet<Bahis> Bahisler { get; set; }
    }
}
