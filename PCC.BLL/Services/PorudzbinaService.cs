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
                Preuzeto = false,

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
                .Where(n => n.Preuzeto == false)
                .Select(n => new PorudzbinaPrikazVM()
                {
                    PorudzbinaID = n.PorudzbinaID,
                    VremePorudzbine = n.VremePorudzbine,
                    Adresa = n.Lokacija.Adresa,
                    Grad = n.Lokacija.Grad,
                    Preuzeto = n.Preuzeto,
                    KomponentaIDs = n.Komponenta_Porudzbinas.Select(n => n.KomponentaID).ToList(),
                    KomponentaModel = n.ListaKomponenta.Select(n => n.Model).ToList(),
                    KomponentaCena = n.ListaKomponenta.Select(n => n.Cena).ToList(),
                    KomponentaProizvodjac = n.ListaKomponenta.Select(n => n.Proizvodjac).ToList(),
                    Kolicine = n.Komponenta_Porudzbinas.Select(n => n.Kolicina).ToList()

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
                    Preuzeto = n.Preuzeto,
                    KomponentaIDs = n.Komponenta_Porudzbinas.Select(n => n.KomponentaID).ToList(),
                    KomponentaModel = n.ListaKomponenta.Select(n=>n.Model).ToList(),
                    KomponentaCena = n.ListaKomponenta.Select(n=>n.Cena).ToList(),
                    KomponentaProizvodjac = n.ListaKomponenta.Select(n => n.Proizvodjac).ToList(),
                    Kolicine = n.Komponenta_Porudzbinas.Select(n => n.Kolicina).ToList()

                }).FirstOrDefault();
            return _porudzbinaSaKomponentama;
            




        }

        public void PreuzmiPorudzbinu(int id)
        {
            var _porudzbina = _context.Porudzbine.Where(i => i.PorudzbinaID == id).FirstOrDefault();
            if (_porudzbina != null)
            {
                _porudzbina.Preuzeto = true;
                _porudzbina.VremeIsporuke = DateTime.Now;
                _context.SaveChanges();
            }  
        }



    }
}
