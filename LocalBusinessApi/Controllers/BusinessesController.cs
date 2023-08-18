using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

namespace LocalBusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private readonly LocalBusinessApiContext _db;

        public BusinessesController(LocalBusinessApiContext db)
        {
            _db = db;
        }

        //Get api/businesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get()
        {
            return await _db.Businesses.ToListAsync();
        }
    }
}