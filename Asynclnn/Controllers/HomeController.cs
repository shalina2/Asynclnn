using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asynclnn.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()

        {
            return View(); //telling to get something from the view
        }
    }
}
