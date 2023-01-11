
using MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using PCC.BLL.Data;
using Microsoft.EntityFrameworkCore;

namespace PCC.BLL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Komponenta - Porudzbina

            modelBuilder.Entity<Komponenta_Porudzbina>()
                .HasOne(k => k.Komponenta)
                .WithMany(kp => kp.Komponenta_Porudzbinas)
                .HasForeignKey(kf => kf.KomponentaID);

            modelBuilder.Entity<Komponenta_Porudzbina>()
                .HasOne(p => p.Porudzbina)
                .WithMany(kp => kp.Komponenta_Porudzbinas)
                .HasForeignKey(kf => kf.PorudzbinaID);

            //Racun - Komponenta

            modelBuilder.Entity<Racun_Komponenta>()
                .HasOne(k => k.Komponenta)
                .WithMany(kr => kr.Racun_Komponentas)
                .HasForeignKey(kf => kf.KomponentaID);

            modelBuilder.Entity<Racun_Komponenta>()
                .HasOne(r => r.Racun)
                .WithMany(kr => kr.Racun_Komponentas)
                .HasForeignKey(rf => rf.RacunID);

            //Racun - Racunar

            modelBuilder.Entity<Racun_Racunar>()
                .HasOne(k => k.Racunar)
                .WithMany(kr => kr.Racun_Racunars)
                .HasForeignKey(kf => kf.RacunarID);

            modelBuilder.Entity<Racun_Racunar>()
                .HasOne(r => r.Racun)
                .WithMany(kr => kr.Racun_Racunars)
                .HasForeignKey(rf => rf.RacunID);

            //Trebovanje - Komponenta

            modelBuilder.Entity<Trebovanje_Komponenta>()
                .HasOne(k => k.Komponenta)
                .WithMany(kr => kr.Trebovanje_Komponentas)
                .HasForeignKey(kf => kf.KomponentaID);

            modelBuilder.Entity<Trebovanje_Komponenta>()
                .HasOne(r => r.Trebovanje)
                .WithMany(kr => kr.Trebovanje_Komponentas)
                .HasForeignKey(rf => rf.TrebovanjeID);

            //Trebovanje - Racunar

            modelBuilder.Entity<Trebovanje_Racunar>()
                .HasOne(k => k.Racunar)
                .WithMany(kr => kr.Trebovanje_Racunars)
                .HasForeignKey(kf => kf.RacunarID);

            modelBuilder.Entity<Trebovanje_Racunar>()
                .HasOne(r => r.Trebovanje)
                .WithMany(kr => kr.Trebovanje_Racunars)
                .HasForeignKey(rf => rf.TrebovanjeID);

            //Racunar - Komponenta

            modelBuilder.Entity<Racunar_Komponenta>()
                .HasOne(r=>r.Racunar)
                .WithMany(kr=>kr.Racunar_Komponentas)
                .HasForeignKey(rf => rf.RacunarID);

            modelBuilder.Entity<Racunar_Komponenta>()
                .HasOne(r => r.Komponenta)
                .WithMany(kr => kr.Racunar_Komponentas)
                .HasForeignKey(rf => rf.KomponentaID);

            



        }

        public DbSet<Komponenta> Komponente { get; set; }
        public DbSet<Lokacija> Lokacije { get; set; }
        public DbSet<Nalog> Nalozi { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Racunar> Racunari { get; set; }
        public DbSet<Trebovanje> Trebovanja { get; set; }
        public DbSet<Porudzbina> Porudzbine { get; set; }
        public DbSet<Komponenta_Porudzbina> Komponenta_Porudzbine { get; set; }
        public DbSet<Racunar_Komponenta> Racunari_Komponente { get; set; }

        public DbSet<Racunar_Nalog> RacunarNalog { get; set; }
        public DbSet<Trebovanje_Komponenta> Trebovanje_Komponenta { get; set; }
        public DbSet<Trebovanje_Racunar> Trebovanje_Racunar { get; set; }
        public DbSet<Racun_Komponenta> Racun_Komponenta { get; set; }
        public DbSet<Racun_Racunar> Racun_Racunar { get; set; }





    }

   

}
