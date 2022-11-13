using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PorudzbinaController : ControllerBase
    {

        private PorudzbinaService _porudzbinaService;
        public PorudzbinaController(PorudzbinaService porudzbinaService)
        {
            _porudzbinaService = porudzbinaService;

        }

        [HttpPost("add-porudzbina")]
        public IActionResult AddPorudzbina([FromBody] PorudzbinaVM porudzbina)
        {
            _porudzbinaService.AddPorudzbina(porudzbina);
            return Ok();
        }

        [HttpGet("get-all-nepreuzet-porudzbinas")]
        public IActionResult GetAllNepreuzetPorudzbinas()
        {
           var porudzbine = _porudzbinaService.GetAllNepreuzetPorudzbinas();
           return Ok(porudzbine);
        }

        [HttpGet("get-all-nepreuzet-porudzbinas")]
        public IActionResult GetAllPorudzbina(int n)
        {
            var porudzbine = _porudzbinaService.GetPorudzbinaById(n);
            return Ok(porudzbine);
        }

        [HttpPut("preuzmi-porudzbinu")]
        public IActionResult PreuzmiPorudzbinu(int n)
        {
            _porudzbinaService.PreuzmiPorudzbinu(n);
            return Ok();
        }

    }
}
