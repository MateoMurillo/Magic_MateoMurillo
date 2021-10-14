
using Magic_MateoMurillo.Data;
using Magic_MateoMurillo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RandomController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Suerte>> GetCancion()
        {

            var list = await _context.Suerte.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var Suerte = list[index];

            if (Suerte == null)
            {
                return NoContent();
            }

            return Suerte;
        }
    }
}
