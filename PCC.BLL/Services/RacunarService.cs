using PCC.BLL.Data;
using PCC.BLL.ViewModels;
using PCC.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Services
{
    public class RacunarService
    {

        private AppDbContext _context;

        public RacunarService(AppDbContext context)
        {
            _context = context;
        }

        public void AddRacunar(RacunarVM racunar)
        {
            var _racunar = new Racunar()
            {
                RacunarID = racunar.RacunarID,
                Ime = racunar.Ime,
                Cena = racunar.Cena
            };
            _context.Racunari.Add(_racunar);
            _context.SaveChanges();

            foreach(var kompid in racunar.KomponenteID)
            {
                var _rackomp = new Racunar_Komponenta()
                {
                    RacunarID = _racunar.RacunarID,
                    KomponentaID = kompid
                };
                _context.Racunari_Komponente.Add(_rackomp);
                _context.SaveChanges();
            }

        }

        public List<Racunar> GetAllRacunars()
        {
            return _context.Racunari.ToList();
        }


        public RacunarVM GetRacunarById(int id)
        {
            var _racunarSaKomponentama = _context.Racunari.Where(n=>n.RacunarID==id).Select(racunar => new RacunarVM()
            {
                RacunarID = racunar.RacunarID,
                Ime = racunar.Ime,
                Cena = racunar.Cena,
                KomponenteID = racunar.Racunar_Komponentas.Select(id => id.KomponentaID).ToList()
            }).FirstOrDefault();
            return _racunarSaKomponentama;
        }

        public Racunar UpdateRacunar(RacunarVM racunar, int id)
        {
            var _racunar = _context.Racunari.FirstOrDefault(n => n.RacunarID == id);
            if (_racunar != null)
            {
                _racunar.RacunarID=racunar.RacunarID;
                _racunar.Ime=racunar.Ime;
                _racunar.Cena=racunar.Cena;
                _context.SaveChanges();
            }
            return _racunar;
        }

        public void DeleteRacunar(int id)
        {
            var _racunar = _context.Racunari.FirstOrDefault(n => n.RacunarID == id);
            if (_racunar != null)
            {
                _context.Remove(_racunar);
                _context.SaveChanges();

            }

        }




    }
}
