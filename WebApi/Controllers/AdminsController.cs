using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AdminsController : ControllerBase
    {
        //demo deta 

        List<AdminEntity> admins = new List<AdminEntity>()
        {
            new AdminEntity(){Id = 1,Role = "admin",FirstName = "John",LastName = "Doe",Email = "JonhDoe@example.come",MobileNo = "9000777444"},
            new AdminEntity(){Id = 2,Role = "sub-admin",FirstName = "Paul",LastName = "Stone",Email = "PaulStone@example.come",MobileNo = "9000799422"}
        };
        public AdminsController()
        {

        }

        [HttpGet]
        public IActionResult GetAdmins()
        {

            return Ok(admins);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdminById(int id)
        {

            return Ok(admins.First(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult CreateAdmin(AdminEntity admin)
        {

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id,AdminEntity admin)
        {

            return Ok();
        }
         [HttpDelete("{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            
            return Ok();
        }


    }
    
}