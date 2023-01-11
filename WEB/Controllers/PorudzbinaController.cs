using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;
using System;

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

        [HttpGet("get-porudzbina-by-id/{id}")]
        public IActionResult GetPorudzbinaById(int n)
        {
            var porudzbine = _porudzbinaService.GetPorudzbinaById(n);
            return Ok(porudzbine);
        }

        [HttpGet("get-all-porudzbinas-u-rasponu/{t1}{t2}")]
        public IActionResult GetAllPorudzbinasURasponu(DateTime t1, DateTime t2)
        {
            var porudzbine = _porudzbinaService.GetAllPorudzbinasURasponu(t1, t2);
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
