using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacunController : ControllerBase
    {

        private RacunService _racunService; 

        public RacunController(RacunService racunService)
        {
            _racunService = racunService;
        }

        [HttpPost("add-racun")]
        public IActionResult AddRacun([FromBody] RacunVM racunVM)
        {
            _racunService.AddRacun(racunVM);
            return Ok();
        }

        [HttpGet("get-racun-by-id/{id}")]
        public IActionResult GetRacunById(int id)
        {
            var racun = _racunService.GetRacunById(id);
            return Ok(racun);
        }

        [HttpDelete("delete-racun/{id}")]
        public IActionResult DeleteRacun(int id)
        {
            _racunService.DeleteRacunById(id);
            return Ok();
        }



    }
}
