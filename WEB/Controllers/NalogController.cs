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
            _nalogService.GetNalogSaRacunarimaIKomponentamaById(id);
            return Ok(_nalogService);
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
