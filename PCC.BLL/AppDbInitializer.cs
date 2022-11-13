using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PCC.BLL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Komponente.Any())
                {
                    context.Komponente.AddRange(new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.GPU,
                        Model = "Kobra XS 3000",
                        Proizvodjac = "Intel",
                        Info = "Izuzetna graficka karta najnovije tehnologije, potpuno neverovatno od Intel-a",
                        Cena = 250
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.GPU,
                        Model = "Kobra XS 4000",
                        Proizvodjac = "Intel",
                        Info = "Izuzetna graficka karta najnovije tehnologije, potpuno neverovatno na trzistu od Intel-a",
                        Cena = 450
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.GPU,
                        Model = "Kristal 2X46",
                        Proizvodjac = "AMD",
                        Info = "Izuzetna graficka karta najnovije tehnologije, potpuno neverovatno na trzistu od AMD-a",
                        Cena = 900
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.CPU,
                        Model = "MRT VDS 1780",
                        Proizvodjac = "AMD",
                        Info = "Izuzetan procesor najnovije tehnologije, potpuno neverovatno na trzistu od AMD-a",
                        Cena = 900
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.CPU,
                        Model = "MRT VDS 1790",
                        Proizvodjac = "AMD",
                        Info = "Izuzetan procesor najnovije tehnologije, potpuno neverovatno na trzistu od AMD-a",
                        Cena = 1400
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.CPU,
                        Model = "W FAUK 0010",
                        Proizvodjac = "AKLT",
                        Info = "Izuzetan procesor najnovije tehnologije, potpuno neverovatno na trzistu od AKLT-a",
                        Cena = 220
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.Monitor,
                        Model = "LOC 400",
                        Proizvodjac = "LOC",
                        Info = "Izuzetan monitor najnovije tehnologije, potpuno neverovatno na trzistu od LOC-a",
                        Cena = 250
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.Tastatura,
                        Model = "X Genesis 1000",
                        Proizvodjac = "Logitec",
                        Info = "Izuzetna tastatura najnovije tehnologije, potpuno neverovatno na trzistu od Logitec-a",
                        Cena = 900
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.HDD,
                        Model = "Senn 1TB",
                        Proizvodjac = "Fuji",
                        Info = "Izuzetan hard disk od 1TB najnovije tehnologije, potpuno neverovatno na trzistu od Fuji-a",
                        Cena = 400
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.HDD,
                        Model = "Senn 2TB",
                        Proizvodjac = "Fuji",
                        Info = "Izuzetan hard disk od 2TB najnovije tehnologije, potpuno neverovatno na trzistu od Fuji-a",
                        Cena = 750
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.RAM,
                        Model = "Maxwell 8GB",
                        Proizvodjac = "Fuji",
                        Info = "Izuzetna RAM memorija od 8GB najnovije tehnologije, potpuno neverovatno na trzistu od Fuji-a",
                        Cena = 100
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.RAM,
                        Model = "Maxwell 16GB",
                        Proizvodjac = "Fuji",
                        Info = "Izuzetna RAM memorija od 16GB najnovije tehnologije, potpuno neverovatno na trzistu od Fuji-a",
                        Cena = 180
                    },
                    new Komponenta()
                    {
                        Tip = Komponenta.TipEnum.MaticnaPloca,
                        Model = "Ciaphas 2X",
                        Proizvodjac = "AMD",
                        Info = "Izuzetna maticna ploca od 16GB najnovije tehnologije, potpuno neverovatno na trzistu od Fuji-a",
                        Cena = 350
                    });

                }

                if (!context.Racunari.Any())
                {
                    context.Racunari.AddRange(new Racunar()
                    {
                        RacunarID = 30001,
                        Ime = "PCC Tigar 0010",
                        Cena = 980

                    }, new Racunar()
                    {
                        RacunarID = 30002,
                        Ime = "PCC Tigar 0020",
                        Cena = 1050

                    });
                }

                if (!context.Lokacije.Any())
                {
                    context.Lokacije.AddRange(new Lokacija()
                    {
                        Odeljenje = Lokacija.OdeljenjeEnum.Skladiste,
                        Adresa = "Svetog Save 10",
                        Telefon = "06510001",
                        Grad = "Trstenik"
                    },
                    new Lokacija()
                    {
                        Odeljenje = Lokacija.OdeljenjeEnum.Prodaja,
                        Adresa = "Milentija Popovica 25",
                        Telefon = "06510002",
                        Grad = "Trstenik"
                    },
                    new Lokacija()
                    {
                        Odeljenje = Lokacija.OdeljenjeEnum.Racunovodstvo,
                        Adresa = "Cara Dusana 10/4",
                        Telefon = "06510003",
                        Grad = "Trstenik"
                    },
                    new Lokacija()
                    {
                        Odeljenje = Lokacija.OdeljenjeEnum.Prodaja,
                        Adresa = "Svetog Save 15",
                        Telefon = "06510004",
                        Grad = "Trstenik"
                    },
                    new Lokacija()
                    {
                        Odeljenje = Lokacija.OdeljenjeEnum.Proizvodnja,
                        Adresa = "Svetog Save 15",
                        Telefon = "06510005",
                        Grad = "Ugljarevo"
                    });
                }

                context.SaveChanges();


            }
        }


    }
}
