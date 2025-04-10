using AutoMapper;
using HotelManagement.API.Data;
using HotelManagement.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AdminUsersController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAdmin()
        {
            var result = _context.AdminUsers.ToList();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdminById(int id)
        {
            var admin = await _context.AdminUsers.FindAsync(id);

            if (admin == null)
            {
                return NotFound($"Admin user with ID {id} not found.");
            }

            return Ok(admin);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdmin([FromBody] AdminUser adminUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.AdminUsers.AddAsync(adminUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAdminById), new { id = adminUser.Id }, adminUser);
        }

       
    }
}