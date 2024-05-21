using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierreTreat.Models;
using System.Threading.Tasks;
using PierreTreat.ViewModels;

namespace PierreTreat.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierreTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierreTreatContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}