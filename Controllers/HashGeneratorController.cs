using Microsoft.AspNetCore.Mvc;
using Banking_CapStone.Service;

namespace Banking_CapStone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HashGeneratorController : ControllerBase
    {
        private readonly PasswordHasher _passwordHasher;

        public HashGeneratorController()
        {
            _passwordHasher = new PasswordHasher();
        }

        [HttpGet("generate")]
        public IActionResult GenerateHashes()
        {
            var hashes = new
            {
                SuperAdminHash = _passwordHasher.HashPassword("Admin@123"),
                BankUserHash = _passwordHasher.HashPassword("Bank@123"),
                ClientHash = _passwordHasher.HashPassword("Client@123")
            };

            return Ok(hashes);
        }
    }
}