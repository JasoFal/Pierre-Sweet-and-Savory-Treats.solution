using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierreTreat.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreTreat.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> userManager, PierreTreatContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Flavor flavor)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        if (!ModelState.IsValid)
        {
          return View(flavor);
        }
        else
        {
          _db.Flavors.Add(flavor);
          _db.SaveChanges();
          return RedirectToAction("Index");
        }
      }
      else
      {
        return View(flavor);
      }
    }

    public ActionResult Details(int id)
    {
      Flavor thisFlavor = _db.Flavors
        .Include(flav => flav.JoinEntities)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(flav => flav.FlavorId == id);
      return View(thisFlavor);
    }

    public ActionResult AddTreat(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flav => flav.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatType");
      return View(thisFlavor);
    }

    [HttpPost]
    public async Task<ActionResult> AddTreat(Flavor flavor, int treatId)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        #nullable enable
        TreatFlavor? joinEntity = _db.TreatFlavors.FirstOrDefault(join => (join.TreatId == treatId && join.FlavorId == flavor.FlavorId));
        #nullable disable
        if (joinEntity == null && treatId != 0)
        {
          _db.TreatFlavors.Add(new TreatFlavor() { TreatId = treatId, FlavorId = flavor.FlavorId });
          _db.SaveChanges();
        }
        return RedirectToAction("Details", new { id = flavor.FlavorId });
      }
      else
      {
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatType");
        return View(flavor);
      }
    }

    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flav => flav.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public async Task<ActionResult> Edit(Flavor flavor)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        if (!ModelState.IsValid)
        {
          return View(flavor);
        }
        else
        {
          _db.Flavors.Update(flavor);
          _db.SaveChanges();
          return RedirectToAction("Index");
        }
      }
      else
      {
        return View(flavor);
      }
    }

    public ActionResult Delete(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flav => flav.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<ActionResult> DeleteConfirmed(int id)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        Flavor thisFlavor = _db.Flavors.FirstOrDefault(flav => flav.FlavorId == id);
        _db.Flavors.Remove(thisFlavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        return View(id);
      }
    }

    [HttpPost]
    public async Task<ActionResult> DeleteJoin(int joinId)
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      if (currentUser != null)
      {
        TreatFlavor joinEntry = _db.TreatFlavors.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
        _db.TreatFlavors.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        return View(joinId);
      }
    }
  }
}