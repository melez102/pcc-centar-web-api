using PCC.BLL.Data;
using PCC.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Services
{
    public class KomponentaService
    {

        private AppDbContext _context;

        public KomponentaService(AppDbContext context)
        {
            _context = context;

        }

        public void AddKomponenta(KomponentaVM komponenta)
        {
            var _komponenta = new Komponenta()
            {
                Tip = komponenta.Tip,
                Model = komponenta.Model,
                Proizvodjac = komponenta.Proizvodjac,
                Info = komponenta.Info,
                Cena = komponenta.Cena,
                ProdajnaCena = komponenta.ProdajnaCena,
            };
            _context.Komponente.Add(_komponenta);
            _context.SaveChanges();
        }

        public List<Komponenta> GetAllKomponentas()
        {
            return _context.Komponente.ToList();
        }
        

        public Komponenta GetKomponentaById(int id)
        {
            return _context.Komponente.FirstOrDefault(n => n.KomponentaID == id);

        }

        public Komponenta UpdateKomponentaById(int id, KomponentaVM komponenta)
        {
            var _komponenta = _context.Komponente.FirstOrDefault(n => n.KomponentaID == id);
            if(_komponenta!= null)
            {
                _komponenta.Tip = komponenta.Tip;
                _komponenta.Model = komponenta.Model;
                _komponenta.Proizvodjac = komponenta.Proizvodjac;
                _komponenta.Info = komponenta.Info;
                _komponenta.Cena = komponenta.Cena;
                _komponenta.ProdajnaCena = komponenta.ProdajnaCena;

                _context.SaveChanges();
            }
            return _komponenta;
        }

        public void DeleteKomponentaById(int id)
        {
            var _komponenta = _context.Komponente.FirstOrDefault(n => n.KomponentaID == id);
            if (_komponenta != null)
            {
                _context.Remove(_komponenta);
                _context.SaveChanges();

            }
            
        }


    }
}
