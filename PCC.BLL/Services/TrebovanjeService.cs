using PCC.BLL.Data;
using PCC.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Services
{
    public class TrebovanjeService
    {
        private AppDbContext _context;
        public TrebovanjeService(AppDbContext context)
        {
            _context = context;
        }



        public void AddTrebovanje(TrebovanjeVM trebovanje)
        {
            var _trebovanje = new Trebovanje()
            {
                Poslao = trebovanje.Poslao,

                VremeSlanja = DateTime.Now,
                VremePreuzimanja = null,
                
                SaLokacije = trebovanje.SaLokacije,
                NaLokaciju = trebovanje.NaLokaciju,

            };

            _context.Trebovanja.Add(_trebovanje);
            _context.SaveChanges();



            foreach (var par in trebovanje.KomponenteID.Zip(trebovanje.KolicineKomponenti))
            {
                var _komponentaTrebovanje = new Trebovanje_Komponenta()
                {
                    KomponentaID = par.First,
                    TrebovanjeID = _trebovanje.TrebovanjeID,
                    Kolicina = par.Second
                };
                _context.Trebovanje_Komponenta.Add(_komponentaTrebovanje);
                _context.SaveChanges();

            }

            foreach (var par in trebovanje.RacunariID.Zip(trebovanje.KolicineRacunara))
            {
                var _racunarTrebovanje = new Trebovanje_Racunar()
                {
                    RacunarID = par.First,
                    TrebovanjeID = _trebovanje.TrebovanjeID,
                    Kolicina = par.Second
                };
                _context.Trebovanje_Racunar.Add(_racunarTrebovanje);
                _context.SaveChanges();

            }

        }

        public List<TrebovanjeBezSadrzajaVM> GetAllNepreuzetaTrebovanjas()
        {
            var _trebovanja = _context.Trebovanja.
                Where(n => n.VremePreuzimanja != null).
                Select(n => new TrebovanjeBezSadrzajaVM()
                {
                    Poslao = n.Poslao.Ime,
                    VremeSlanja = n.VremeSlanja,
                    SaAdrese = n.SaLokacije.Adresa,
                    IzGrada = n.SaLokacije.Grad,
                    NaAdresu = n.NaLokaciju.Adresa,
                    UGrad = n.NaLokaciju.Grad,

                }).ToList();

            return _trebovanja;
        }

        public List<TrebovanjeBezSadrzajaVM> GetAllTrebovanjaURasponu(DateTime t1, DateTime t2)
        {
            var _trebovanja = _context.Trebovanja.
                Where(n => n.VremePreuzimanja <= t1 || n.VremePreuzimanja>= t2).
                Select(n => new TrebovanjeBezSadrzajaVM()
                {
                    Poslao = n.Poslao.Ime,
                    VremeSlanja = n.VremeSlanja,
                    SaAdrese = n.SaLokacije.Adresa,
                    IzGrada = n.SaLokacije.Grad,
                    NaAdresu = n.NaLokaciju.Adresa,
                    UGrad = n.NaLokaciju.Grad,

                }).ToList();

            return _trebovanja;
        }

        public TrebovanjeGlavnoVM GetTrebovanjeById(int id)
        {
            var _trebovanje = _context.Trebovanja
                .Where(t => t.TrebovanjeID == id)
                .Select(t => new TrebovanjeGlavnoVM()
                {
                    VremeSlanja = t.VremeSlanja,
                    VremePreuzimanja = t.VremePreuzimanja,
                    SaLokacijeAdresa = t.SaLokacije.Adresa,
                    NaLokacijuAdresa = t.NaLokaciju.Adresa,
                    Poslao = t.Poslao.Ime,

                    Racunari = t.Trebovanje_Racunars.Select(r => new RacunariVM()
                    {
                        RacunarID = r.RacunarID,
                        Ime = r.Racunar.Ime,
                        Kolicina = r.Kolicina
                    }).ToList(),

                    Komponente = t.Trebovanje_Komponentas.Select(r => new KomponenteVM()
                    {
                        KomponentaID = r.KomponentaID,
                        KomponentaModel = r.Komponenta.Model,
                        Proizvodjac = r.Komponenta.Proizvodjac,
                        Tip = r.Komponenta.Tip,
                        Kolicina = r.Kolicina
                    }).ToList(),

                    //KolicineKomponenti = t.Trebovanje_Komponentas.Select(t => t.Kolicina).ToList()

                }).FirstOrDefault();
            return _trebovanje;
        }


    }
}
