using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZagrosRealState.Data.Models.DbContext;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetailsApartment(int? totalCount)
        {
            var rows = from myRow in _context.Apartments
                       select myRow;
            totalCount = rows.Count();
            return View(totalCount);
        }


    }
}