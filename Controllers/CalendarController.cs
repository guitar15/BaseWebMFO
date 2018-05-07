using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace test_net_core_mvc.Controllers
{
    public class CalendarController:Controller
    {
         public IActionResult Index()
        {
            return View();
        }
    }
}