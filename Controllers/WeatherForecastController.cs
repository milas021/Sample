using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.Domain;
using Sample.Repository;

namespace Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WeatherForecastController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost()]
        public async Task<IActionResult> AddPerson(Person person)
        {
            _context.People.Add(person);
           await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var result = await _context.People.ToListAsync();
            return Ok(result);
        }

        [HttpPut()]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }
    }
}