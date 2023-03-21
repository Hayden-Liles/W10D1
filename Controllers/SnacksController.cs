using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace W10D1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SnacksController : ControllerBase
    {
        private readonly SnacksService _snacksService;

        public SnacksController(SnacksService snacksService)
        {
            _snacksService = snacksService;
        }

        [HttpGet]
        public ActionResult<List<Snack>> getAllSnacks()
        {
            try
            {
                return Ok(_snacksService.getAllSnacks());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Snack> GetOneSnack(int id)
        {
            try
            {
                Snack snack = _snacksService.getOneSnack(id);
                return Ok(snack);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Snack> CreateSnack([FromBody] Snack snackData)
        {
            try
            {
                Snack snack = _snacksService.createSnack(snackData);
                return Ok(snack);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> removeSnack(int id)
        {
            try
            {
                string res = _snacksService.removeSnack(id);
                return Ok(res);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}