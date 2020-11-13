using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutri.Data;
using Nutri.Models;


namespace Nutri.Controllers
{
    public class FichaTecnicaController : Controller
    {
        private readonly DataContext _context;

        public FichaTecnicaController(DataContext context)

        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


    }
}