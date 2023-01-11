using Microsoft.EntityFrameworkCore;
using PCC.BLL;
using NUnit.Framework;
using PCC.BLL.Data;
using PCC.BLL.Services;

namespace PCC.Tests
{
    public class Tests
    {
        private static DbContextOptions<AppDbContext> dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "PccDbContext").Options;

        AppDbContext context;
        KomponentaService komponentaService;

        [OneTimeSetUp]
        public void Setup()
        {

            context = new AppDbContext(dbContextOptions);

            context.Database.EnsureCreated();

            SeedDatabase();


            komponentaService = new KomponentaService(context);

        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            context.Database.EnsureDeleted();
        }


        private void SeedDatabase()
        {
            var komponentaList = new List<Komponenta>();

            komponentaList.Add(new Komponenta()
            {
                KomponentaID = 1,
                Cena = 2500,
                Tip = Komponenta.TipEnum.CPU,
                Model = "GNX 2000",
                Proizvodjac = "Sagrotan",
                Info = "Nije los procesor, vidite",
                ProdajnaCena = 5000
                
            });

            komponentaList.Add(new Komponenta()
            {
                KomponentaID = 2,
                Cena = 2000,
                Tip = Komponenta.TipEnum.GPU,
                Model = "Faulkner X",
                Proizvodjac = "Sagrotan",
                Info = "Nije losa graficka, vidite",
                ProdajnaCena = 50000
            });

            komponentaList.Add(new Komponenta()
            {
                KomponentaID = 3,
                Cena = 3500,
                Tip = Komponenta.TipEnum.CPU,
                Model = "GNX 2000",
                Proizvodjac = "Sagrotan",
                Info = "Nije los procesor, vidite",
                ProdajnaCena = 5000
            });

            context.AddRange(komponentaList);
        }


        [Test]
        public void KomponentaPrebrojKomponenteTest()
        {
            //arrange
            var result = komponentaService.GetAllKomponentas();



           //act

            Assert.That(result.Count, Is.EqualTo(3));
           //assert

        }
    }
}