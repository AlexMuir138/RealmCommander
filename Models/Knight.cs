using System.ComponentModel.DataAnnotations;

namespace RealmCommander.Models
{
  public class Knight
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
  }
}