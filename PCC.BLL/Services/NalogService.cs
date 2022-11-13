using PCC.BLL.Data;
using PCC.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Services
{
    public class NalogService
    {
        private AppDbContext _context;

        public NalogService(AppDbContext context)
        {
            context = _context;
        }

        public void AddNalog(NalogVM nal)
        {
            var _nalog = new Nalog()
            {
                Izdato = DateTime.Now,
                Izvrsen = null

            };
            _context.Nalozi.Add(_nalog);
            _context.SaveChanges();

            foreach (var par in nal.RacunariIDs.Zip(_nalog.Kolicina))
            {
                var _nalrac = new Racunar_Nalog()
                {
                    NalogID = _nalog.NalogID,
                    RacunarID = par.First,
                    Kolicina = par.Second,

                };
                _context.RacunarNalog.Add(_nalrac);
                _context.SaveChanges();
            }

        }

        public NalogSaRacunarimaIKomponentamaVM GetNalogSaRacunarimaIKomponentamaById(int id)
        {
            var _nalog = _context.Nalozi
                .Where(n => n.NalogID == id)
                .Select(n => new NalogSaRacunarimaIKomponentamaVM()
                {
                    NalogID = n.NalogID,
                    Izdato = n.Izdato,
                    Izvrsen = n.Izvrsen,
                    Racunari = n.RacunariZaProizvodnju.Select(m => new RacunariKomponenteVM()
                    {
                        RacunarID = m.RacunarID,
                        Ime = m.Ime,
                        Komponente = m.Racunar_Komponentas.Select(b => new KomponenteVM()
                        {
                            Tip=b.Komponenta.Tip,
                            KomponentaID = b.KomponentaID,
                            KomponentaModel=b.Komponenta.Model,
                            Proizvodjac = b.Komponenta.Proizvodjac

                        }).ToList()

                    }).ToList(),

                    Kolicina=n.Kolicina.ToList()

                }).FirstOrDefault();
        

            return _nalog;




        }

        public void IzvrsiNalog(int id)
        {
            var _nalog = _context.Nalozi.Where(n => n.NalogID == id).FirstOrDefault();
            if(_nalog != null)
            {
                _nalog.Izvrsen = DateTime.Now;
            }
            _context.SaveChanges();
        }







    }
}

