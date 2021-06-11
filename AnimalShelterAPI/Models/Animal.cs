using System.ComponentModel.DataAnnotations;

namespace AnimalShelterAPI.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Type { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
  }
}