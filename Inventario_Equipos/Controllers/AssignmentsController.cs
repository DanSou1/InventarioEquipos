using Microsoft.AspNetCore.Mvc;
using Inventario_Equipos.Models;
using Inventario_Equipos.Data;
using Microsoft.EntityFrameworkCore;

namespace Inventario_Equipos.Controllers
{
    [ApiController]
    [Route("inventario/[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly InventaryDbContext _context;
        public AssignmentsController(InventaryDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Assignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
            return Ok();
        }
    }
}
