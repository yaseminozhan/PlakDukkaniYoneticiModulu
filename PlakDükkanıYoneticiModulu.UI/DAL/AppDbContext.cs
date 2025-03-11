using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlakDükkanıYoneticiModulu.UI.Entities;

namespace PlakDükkanıYoneticiModulu.UI.DAL
{
    //  BENİM OLUŞTURDUĞUM KULLANICI ADI : Rosinante
    //ŞİFRESİ = !RRosinante*123
    public class AppDbContext :DbContext
    {
        //DbSet ler
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Album>Albums{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=JASMINE\\SQLEXPRESS;database=PlakShopDb;trusted_connection=true;trustservercertificate=true;");
        }

    }
}
