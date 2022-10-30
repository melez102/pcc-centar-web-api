using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Tip
    {
        public int TipID { get; set; }
        public string Ime { get; set; }
        public bool ZaProdaju { get; set; }

        public static List<Tip> PrikaziSveTipove()
        {
            var SviTipovi = new List<Tip>();
            

            SviTipovi.Add(new Tip() { TipID = 0, Ime = "GPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 1, Ime = "CPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 2, Ime = "Tastatura", ZaProdaju = true });
            SviTipovi.Add(new Tip() { TipID = 3, Ime = "Monitor", ZaProdaju = true });

            return SviTipovi;



        }

        public List<Tip> PrikaziSveTipoveZaProdaju()
        {
            var SviTipovi = new List<Tip>();
            var TrazeniTipovi = new List<Tip>();

            SviTipovi.Add(new Tip() { TipID = 0, Ime = "GPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 1, Ime = "CPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 2, Ime = "Tastatura", ZaProdaju = true });
            SviTipovi.Add(new Tip() { TipID = 3, Ime = "Monitor", ZaProdaju = true });

            foreach (Tip tip in SviTipovi)
            {
                if (tip.ZaProdaju == true)
                    TrazeniTipovi.Add(tip);
            }

            return TrazeniTipovi;



        }

        public static Tip  PrikaziSveTipoveZaProdaju(int id)
        {
            var SviTipovi = new List<Tip>();
            var tipp = new Tip();

            SviTipovi.Add(new Tip() { TipID = 0, Ime = "GPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 1, Ime = "CPU", ZaProdaju = false });
            SviTipovi.Add(new Tip() { TipID = 2, Ime = "Tastatura", ZaProdaju = true });
            SviTipovi.Add(new Tip() { TipID = 3, Ime = "Monitor", ZaProdaju = true });

            foreach (Tip tip in SviTipovi)
            {
                if (tip.TipID == id)
                    tipp = tip;
            }

            return tipp;



        }

    }
}
