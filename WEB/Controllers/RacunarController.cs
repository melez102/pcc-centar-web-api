using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RacunarController : ControllerBase
    {
        private RacunarService _racunarService;

        public RacunarController(RacunarService racunarService)
        {
            _racunarService = racunarService;
        }



        [HttpPost("add-racunar")]
        public IActionResult AddRacunar([FromBody] RacunarVM racunar)
        {
            _racunarService.AddRacunar(racunar);
            return Ok();
        }

        [HttpGet("get-all-racunars")]
        public IActionResult GetAllRacunars()
        {
            var racunari = _racunarService.GetAllRacunars();
            return Ok(racunari);
        }

        [HttpGet("get-racunar-by-id/{id}")]
        public IActionResult GetRacunarById(int id)
        {
            var racunar = _racunarService.GetRacunarById(id);
            return Ok(racunar);
        }

        [HttpPut("update-racunar/{id}")]
        public IActionResult UpdateRacunar([FromBody]RacunarVM racvm, int id)
        {
            _racunarService.UpdateRacunar(racvm, id);
            return Ok();
        }

        [HttpDelete("delete-racunar/{id}")]
        public IActionResult DeleteRacunar(int id)
        {
            _racunarService.DeleteRacunar(id);
            return Ok();
        }



    }
}
