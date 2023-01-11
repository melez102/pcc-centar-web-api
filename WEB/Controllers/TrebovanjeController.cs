using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using PCC.BLL.Data;
using PCC.BLL.Services;
using PCC.BLL.ViewModels;
using System;

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
            var trebid =_trebovanjeService.GetTrebovanjeById(id);
            return Ok(trebid);
        }

        [HttpGet("get-all-nepreuzeta-trebovanjas")]
        public IActionResult GetAllNepreuzetaTrebovanjas()
        {
            var nepreuzeta = _trebovanjeService.GetAllNepreuzetaTrebovanjas();
            return Ok(nepreuzeta);
        }

        [HttpGet("get-all-trebovanja-u-rasponu")]
        public IActionResult GetTrebovanjaURasponu(DateTime t1, DateTime t2)
        {
            var nepreuzeta = _trebovanjeService.GetAllTrebovanjaURasponu(t1,t2);
            return Ok(nepreuzeta);
        }

        [HttpPost("add-trebovanje")]
        public IActionResult AddTrebovanje([FromBody] TrebovanjeVM treb)
        {
            _trebovanjeService.AddTrebovanje(treb);
            return Ok();
        }


    }
}
