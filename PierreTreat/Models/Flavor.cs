using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreat.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Flavor name can't be empty.")]
    public string FlavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}