using Microsoft.EntityFrameworkCore;
using login_api.Models;
using Microsoft.AspNetCore.Mvc;
namespace login_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class LoginController: ControllerBase
    {
        private readonly Logincontext _context;
        public LoginController(Logincontext context)
        {
            _context = context;
        }


        // ✅ Signup Endpoint
        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromBody] User user)
        {
            if (await _context.Logins.AnyAsync(u => u.Email == user.Email))
                return BadRequest("Email already exists.");

            _context.Logins.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User registered successfully.");
        }

        // ✅ Login Endpoint
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User loginUser)
        {
            var user = await _context.Logins
                .FirstOrDefaultAsync(u => u.Email == loginUser.Email && u.Password == loginUser.Password);

            if (user == null)
                return BadRequest("Invalid email or password.");

            return Ok("Login successful!");
        }

        // ✅ Get all users
        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Logins.ToListAsync();
            return Ok(users);
        }
    }
}
