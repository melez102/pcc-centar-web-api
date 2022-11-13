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
                Preuzeto = false,
                VremeSlanja = DateTime.Now,
                
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
                        Ime = r.Racunar.Ime
                    }).ToList(),

                    Komponente = t.Trebovanje_Komponentas.Select(r => new KomponenteVM()
                    {
                        KomponentaID = r.KomponentaID,
                        KomponentaModel = r.Komponenta.Model,
                        Proizvodjac = r.Komponenta.Proizvodjac,
                        Tip = r.Komponenta.Tip
                    }).ToList(),

                    KolicineRacunara = t.Trebovanje_Komponentas.Select(t => t.Kolicina).ToList(),
                    KolicineKomponenti = t.Trebovanje_Komponentas.Select(t => t.Kolicina).ToList()

                }).FirstOrDefault();
            return _trebovanje;
        }


    }
}
