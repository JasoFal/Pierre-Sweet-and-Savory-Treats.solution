using Microsoft.AspNetCore.Mvc;
using PierreTreat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreTreat.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
  

    public HomeController(UserManager<ApplicationUser> userManager, PierreTreatContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", flavors);
      Treat[] treats = _db.Treats.ToArray();
      model.Add("treats", treats);
      return View(model);
    }
  }
}