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

        //Get: api/businesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get()
        {
            return await _db.Businesses.ToListAsync();
        }

        //Get: api/businesses/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Business>> GetBusiness(int id)
        {
            Business business = await _db.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return business;
        }

        //Post api/businesses
        [HttpPost]
        public async Task<ActionResult<Business>> Post(Business business)
        {
            _db.Businesses.Add(business);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
        }

        //Put: api/businesses/2
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Business business)
        {
            if (id != business.BusinessId)
            {
                return BadRequest();
            }

            _db.Businesses.Update(business);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool BusinessExists(int id)
        {
            return _db.Businesses.Any(e => e.BusinessId == id);
        }
    }
}