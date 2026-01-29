using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventario_Equipos.Models;
using Inventario_Equipos.Data;


namespace Inventario_Equipos.Controllers
{
    [ApiController]
    [Route("inventario/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly InventaryDbContext _context;
        public UserController(InventaryDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateUser(User create)
        {
            _context.Users.Add(create);
            _context.SaveChanges();
            return Ok(create);
        }
        [HttpGet]
        public IActionResult AllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
        [HttpGet ("id")]
        public IActionResult GetUserById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }
    }

}
