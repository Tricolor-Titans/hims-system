using Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi
{
    public class DoctorControoler :ControllerBase
    {
        List<DoctorEntity> admins = new List<DoctorEntity>();
        public DoctorControoler()
        {
            
        }
        [HttpGet]
        public IActionResult List()
        {
            return Ok();
        }
    }
}