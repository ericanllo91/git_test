using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mtg_lib.Services;
using mtg_lib.Library.Services;

namespace mtg_app.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View(ColorS);
        }
    }
}