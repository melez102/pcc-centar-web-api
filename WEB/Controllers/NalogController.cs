using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NalogController : ControllerBase
    {
        private NalogService _nalogService;

        public NalogController(NalogService nalogService)
        {
            _nalogService = nalogService;
        }

        [HttpGet("get-nalog-saracunarimaikomponentama-by-id/{id}")]
        public IActionResult GetNalogSaRacunarimaIKomponentamaById(int id)
        {
            var nalog = _nalogService.GetNalogSaRacunarimaIKomponentamaById(id);
            return Ok(nalog);
        }

        [HttpGet("get-neizvrsene-naloge")]
        public IActionResult GetNeizvrseneNaloge()
        {
            var nalozi = _nalogService.GetNeizvrseneNaloge();
            return Ok(nalozi);
        }

        [HttpPost("add-nalog")]
        public IActionResult AddNalog([FromBody]NalogVM nalog)
        {
            _nalogService.AddNalog(nalog);
            return Ok();
        }

        [HttpPut("izvrsi-proizvodnju")]
        public IActionResult IzvrsiProizvodnju(int n)
        {
            _nalogService.IzvrsiNalog(n);
            return Ok();
        }




    }
}
