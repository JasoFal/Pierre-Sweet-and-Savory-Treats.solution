using Microsoft.AspNetCore.Mvc;
using PierreTreat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierreTreat.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreTreatContext _db;

    public FlavorsController(PierreTreatContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
  }
}