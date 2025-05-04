using ClinicApp2.DAL;
using ClinicApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        private readonly AppDbContexts _db;
        public DashBoardController(AppDbContexts db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Department>Dps = _db.Departments.Include(c=>c.DoctorList).ToList();
            return View(Dps);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department d)
        {
            if(d.Title is null)
            {
                return BadRequest("Duzgun department daxil edin");
            }
            _db.Departments.Add(d);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var d =_db.Departments.Find(id);
            if (d == null)
            {
                return NotFound("bele department yoxdur");
            }
                _db.Departments.Remove(d);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
        }
    }
}
