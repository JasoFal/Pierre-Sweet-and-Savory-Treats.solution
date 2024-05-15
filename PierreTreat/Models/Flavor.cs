using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreat.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Flavor type can't be empty.")]
    public string FavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}