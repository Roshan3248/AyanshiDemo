using AyanshiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AyanshiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CountriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCountry()
        {
            return Ok(_context.Countries.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            return Ok(_context.Countries.Find(id));
        }

        [HttpPost]
        public ActionResult AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCountry(Country country)
        {
            _context.Update(country);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            var country = _context.Countries.Find(id);
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}
