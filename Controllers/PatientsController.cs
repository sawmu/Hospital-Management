using Hms.Web.Data;
using Hms.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hms.Web.Controllers;

[Authorize]
public class PatientsController : Controller
{
    private readonly AppDbContext _db;
    public PatientsController(AppDbContext db) => _db = db;

    public async Task<IActionResult> Index(string? search)
    {
        var q = _db.Patients.AsQueryable();
        if (!string.IsNullOrWhiteSpace(search))
        {
            q = q.Where(p => p.MRN.Contains(search) || p.FirstName.Contains(search) || p.LastName.Contains(search));
        }
        var list = await q.OrderByDescending(p => p.Id).ToListAsync();
        ViewBag.Search = search;
        return View(list);
    }

    public IActionResult Create() => View(new Patient());

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Patient model)
    {
        if (!ModelState.IsValid) return View(model);
        _db.Patients.Add(model);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Patient created";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var p = await _db.Patients.FindAsync(id);
        return p is null ? NotFound() : View(p);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var p = await _db.Patients.FindAsync(id);
        return p is null ? NotFound() : View(p);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Patient model)
    {
        if (id != model.Id) return BadRequest();
        if (!ModelState.IsValid) return View(model);
        _db.Entry(model).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        TempData["Success"] = "Patient updated";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var p = await _db.Patients.FindAsync(id);
        return p is null ? NotFound() : View(p);
    }

    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var p = await _db.Patients.FindAsync(id);
        if (p is null) return NotFound();
        _db.Patients.Remove(p);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Patient deleted";
        return RedirectToAction(nameof(Index));
    }
}
