using PCC.BLL.Data;
using PCC.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Services
{
    public class PorudzbinaService
    {

        private AppDbContext _context;

        public PorudzbinaService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPorudzbina(PorudzbinaVM porudzbina)
        {
            var _porudzbina = new Porudzbina()
            {
                PorudzbinaID = porudzbina.PorudzbinaID,
                LokacijaID = porudzbina.LokacijaID,
                VremePorudzbine = DateTime.Now,
                VremeIsporuke = null,
                

            };
            _context.Porudzbine.Add(_porudzbina);
            _context.SaveChanges();

            foreach(var par in porudzbina.KomponentaIDs.Zip(porudzbina.Kolicine))
            {
                var _komponentaPorudzbina = new Komponenta_Porudzbina()
                {
                    KomponentaID = par.First,
                    PorudzbinaID = _porudzbina.PorudzbinaID,
                    Kolicina= par.Second
                };
                _context.Komponenta_Porudzbine.Add(_komponentaPorudzbina);
                _context.SaveChanges();
             
            }
        }


        public List<PorudzbinaPrikazVM> GetAllNepreuzetPorudzbinas()
        {
            var _porudzbinaSaKomponentama = _context.Porudzbine
                .Where(n => n.VremeIsporuke == null)
                .Select(n => new PorudzbinaPrikazVM()
                {
                    PorudzbinaID = n.PorudzbinaID,
                    VremePorudzbine = n.VremePorudzbine,
                    Adresa = n.Lokacija.Adresa,
                    Grad = n.Lokacija.Grad,
                    Komponente = n.Komponenta_Porudzbinas.Select(kp => new KomponentaPrikazVM()
                    {
                        KomponentaID = kp.KomponentaID,
                        Model = kp.Komponenta.Model,
                        Proizvodjac = kp.Komponenta.Proizvodjac,
                        Cena = kp.Komponenta.Cena,
                        Kolicina = kp.Kolicina
                    }).ToList()

                }).ToList();
            return _porudzbinaSaKomponentama;

        }

        public List<PorudzbinaPrikazVM> GetAllPorudzbinasURasponu(DateTime t1, DateTime t2)
        {
            var _porudzbinaSaKomponentama = _context.Porudzbine
                .Where(n => n.VremePorudzbine<=t1 || n.VremePorudzbine>=t2)
                .Select(n => new PorudzbinaPrikazVM()
                {
                    PorudzbinaID = n.PorudzbinaID,
                    VremePorudzbine = n.VremePorudzbine,
                    Adresa = n.Lokacija.Adresa,
                    Grad = n.Lokacija.Grad,
                    Komponente = n.Komponenta_Porudzbinas.Select(kp => new KomponentaPrikazVM()
                    {
                        KomponentaID = kp.KomponentaID,
                        Model = kp.Komponenta.Model,
                        Proizvodjac = kp.Komponenta.Proizvodjac,
                        Cena = kp.Komponenta.Cena,
                        Kolicina = kp.Kolicina
                    }).ToList()

                }).ToList();
            return _porudzbinaSaKomponentama;

        }

        public PorudzbinaPrikazVM GetPorudzbinaById(int id)
        {
            var _porudzbinaSaKomponentama = _context.Porudzbine
                .Where(n => n.PorudzbinaID == id)
                .Select(n => new PorudzbinaPrikazVM()
                {
                    PorudzbinaID = n.PorudzbinaID,
                    VremePorudzbine = n.VremePorudzbine,
                    
                    Adresa = n.Lokacija.Adresa,
                    Grad = n.Lokacija.Grad,
                    Komponente = n.Komponenta_Porudzbinas.Select(kp => new KomponentaPrikazVM()
                    {
                        KomponentaID = kp.KomponentaID,
                        Model = kp.Komponenta.Model,
                        Proizvodjac = kp.Komponenta.Proizvodjac,
                        Cena = kp.Komponenta.Cena,
                        Kolicina = kp.Kolicina
                    }).ToList()

                }).FirstOrDefault();
            return _porudzbinaSaKomponentama;
        }

        public void PreuzmiPorudzbinu(int id)
        {
            var _porudzbina = _context.Porudzbine.Where(i => i.PorudzbinaID == id).FirstOrDefault();
            if (_porudzbina != null)
            {
                _porudzbina.VremeIsporuke = DateTime.Now;
                _context.SaveChanges();
            }  
        }

        public void DeletePorudzbinaById(int id)
        {
            var _porudzbina = _context.Porudzbine.FirstOrDefault(n => n.PorudzbinaID == id);
            if (_porudzbina != null)
            {
                _context.Remove(_porudzbina);
                _context.SaveChanges();

            }

        }

    }
}
