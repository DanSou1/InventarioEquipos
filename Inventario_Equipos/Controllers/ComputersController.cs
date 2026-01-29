using Microsoft.AspNetCore.Mvc;
using Inventario_Equipos.Models;
using Inventario_Equipos.Data;

namespace Inventario_Equipos.Controllers
{
    [ApiController]
    [Route("inventario/[controller]")]
    public class ComputersController : ControllerBase
    {
        private readonly InventaryDbContext _context;

        public ComputersController(InventaryDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Computer create)
        {
            _context.Computers.Add(create);
            _context.SaveChanges();
            return Ok(create);
        }
        [HttpGet]
        public IActionResult GetAllComputers()
        {
            var computers = _context.Computers.ToList();
            return Ok(computers);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var computer = _context.Computers.Find(id);
            if (computer == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(computer);
            }
        }
    }
}
