using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCC.BLL.Data;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrebovanjeController : ControllerBase
    {

        private TrebovanjeService _trebovanjeService;

        public TrebovanjeController(TrebovanjeService trebovanjeService)
        {
            _trebovanjeService = trebovanjeService;
        }


        [HttpGet("get-trebovanje-by-id/{id}")]
        public IActionResult GetTrebovanjeById(int id)
        {
            _trebovanjeService.GetTrebovanjeById(id);
            return Ok(_trebovanjeService);
        }

        [HttpPost("add-trebovanje")]
        public IActionResult AddTrebovanje([FromBody] TrebovanjeVM treb)
        {
            _trebovanjeService.AddTrebovanje(treb);
            return Ok();
        }


    }
}
