
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
  [ApiVersion("1.0", Deprecated = false)]
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterAPIContext _db;
    public DogsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(string name, int age, string description, string gender)
    {
      var query = _db.Dogs.AsQueryable();
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
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      var doggy = await _db.Dogs.FindAsync(id);

      if (doggy == null)
      {
        return NotFound();
      }

      return doggy;
    }
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog doggy)
    {
      _db.Dogs.Add(doggy);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetDog), new { id = doggy.DogId }, doggy);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog doggy)
    {
      if (id != doggy.DogId)
      {
        return BadRequest();
      }

      _db.Entry(doggy).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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
    private bool DogExists(int id)
    {
      return _db.Dogs.Any(d => d.DogId == id);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      var doggy = await _db.Dogs.FindAsync(id);
      if (doggy == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(doggy);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}