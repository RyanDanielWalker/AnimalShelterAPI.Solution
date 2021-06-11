
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly AnimalShelterAPIContext _db;
    public CatsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string name, int age, string description, string gender)
    {
      var query = _db.Cats.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      return await query.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      var kitty = await _db.Cats.FindAsync(id);

      if (kitty == null)
      {
        return NotFound();
      }

      return kitty;
    }
    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat kitty)
    {
      _db.Cats.Add(kitty);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCat), new { id = kitty.CatId }, kitty);
    }
  }
}