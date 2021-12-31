using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class ProductStudController : Controller
    {
        public IActionResult IndexStud()
        {
            return View();
        }
        public IActionResult OneMoreActionStud()
        {
            return View();
        }
        public IActionResult AnotherActionStud()
        {
            return View();
        }
            
    }
}
