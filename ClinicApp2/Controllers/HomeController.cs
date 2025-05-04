using ClinicApp2.DAL;
using ClinicApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContexts _contexts;
        public HomeController(AppDbContexts Db)
        {
            _contexts = Db;
        }
        public IActionResult Index()
        {
            List<Doctor>Doctors=_contexts.Doctors.Include(d=>d.Department).ToList();
            return View(Doctors);
        }
    }
}
