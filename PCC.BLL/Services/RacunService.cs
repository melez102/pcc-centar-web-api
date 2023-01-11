using PCC.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCC.BLL.Data;

namespace PCC.BLL.Services
{
    public class RacunService
    {
        private AppDbContext _context;

        public RacunService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void AddRacun(RacunVM racunVM)
        {
            var _rac = new Racun()
            {
                Cena = racunVM.Cena,
                NaLokaciji = racunVM.Lokacija,
                IzvrsioProdaju = racunVM.Zaposleni,
                Vreme = DateTime.Now,
            };
            _context.Racuni.Add(_rac);
            _context.SaveChanges();

            foreach(var par in racunVM.KomponenteID.Zip(racunVM.KolicineKomponenti))
            {
                var _komp = new Racun_Komponenta()
                {
                    RacunID = _rac.RacunID,
                    KomponentaID = par.First,
                    Kolicina = par.Second

                };
                _context.Racun_Komponenta.Add(_komp);
                _context.SaveChanges();
            }

            foreach(var par in racunVM.RacunariID.Zip(racunVM.KolicineRacunara))
            {
                var _racu = new Racun_Racunar()
                {
                    RacunID = _rac.RacunID,
                    RacunarID = par.First,
                    Kolicina = par.Second
                };

                _context.Racun_Racunar.Add(_racu);
                _context.SaveChanges();
            }
           

            


        }

        public List<RacunBezSadrzajaVM> GetAllRacuniSaLokacije(int id) 
        {
            var _racun = _context.Racuni.
                Where(n => n.LokacijaID == id).
                Select(n => new RacunBezSadrzajaVM()
                {
                    Cena = n.Cena,
                    Adresa = n.NaLokaciji.Adresa,
                    Grad = n.NaLokaciji.Grad,
                    ImeZaposlenog = n.NaLokaciji.Zaposleni.FirstOrDefault().Ime

                }).ToList();
            return _racun;
        }

        public RacunZaGetVM2 GetRacunById(int id)
        {
            var _racun = _context.Racuni.Where(r => r.RacunID == id).Select(r => new RacunZaGetVM2()
            {
                Racunari = r.Racun_Racunars.Select(r => new RacunariVM()
                {
                    Ime = r.Racunar.Ime,
                    RacunarID = r.Racunar.RacunarID,
                }).ToList(),

                Komponente = r.Racun_Komponentas.Select(r => new KomponenteVM()
                {
                    KomponentaID = r.KomponentaID,
                    KomponentaModel = r.Komponenta.Model,
                    Proizvodjac = r.Komponenta.Proizvodjac,
                    Tip = r.Komponenta.Tip
                }).ToList(),

                KolicineRacunara = r.Racun_Racunars.Select(t => t.Kolicina).ToList(),
                KolicineKomponenti = r.Racun_Komponentas.Select(t => t.Kolicina).ToList(),

                ZaposleniIme = r.IzvrsioProdaju.Ime,
                LokacijaAdresa = r.IzvrsioProdaju.Lokacija.Adresa,
                LokacijaGrad = r.IzvrsioProdaju.Lokacija.Grad,
                VremeProdaje = r.Vreme
            }).FirstOrDefault();
            return _racun;
        }

        public void DeleteRacunById(int id)
        {
            var _racun = _context.Racuni.FirstOrDefault(n => n.RacunID == id);
            if (_racun != null)
            {
                _context.Remove(_racun);
                _context.SaveChanges();

            }

        }


    }
}
