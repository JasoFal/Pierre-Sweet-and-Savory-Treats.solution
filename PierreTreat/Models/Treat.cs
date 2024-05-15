using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreat.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Treat name can't be empty.")]
    public string TreatType { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}