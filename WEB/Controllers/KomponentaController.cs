using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomponentaController : ControllerBase
    {


        public KomponentaService _komponentaService;
        public KomponentaController(KomponentaService komponentaService)
        {
            _komponentaService = komponentaService;

        }

        [HttpPost("add-komponenta")]
        public IActionResult AddKomponenta([FromBody]KomponentaVM komponenta)
        {
            _komponentaService.AddKomponenta(komponenta);
            return Ok();
        }

        [HttpGet("get-all-komponenta")]
        public IActionResult GetAllKomponenta()
        {
            var SveKomponente = _komponentaService.GetAllKomponentas();
            return Ok(SveKomponente);
        }


        [HttpGet("get-komponenta-by-id/{id}")]
        public IActionResult GetKomponentaById(int id)
        {
            var KomponentaById = _komponentaService.GetKomponentaById(id);
            return Ok(KomponentaById);
        }


        [HttpPut("update-komponenta-by-id/{id}")]
        public IActionResult UpdateKomponentaById(int id, [FromBody]KomponentaVM komponenta)
        {
            _komponentaService.UpdateKomponentaById(id, komponenta);
            return Ok();
        }


        [HttpDelete("delete-komponenta-by-id/{id}")]
        public IActionResult DeleteKomponentaById(int id)
        {
            _komponentaService.DeleteKomponentaById(id);
            return Ok();
        }




    }
}
