using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEMO.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DEMO.Controllers
{
    public class AutoDIController : Controller
    {
        public ITestService _testService { get; set; }
        public IActionResult Index()
        {
            ViewBag.date = _testService.GetList("Name");
            return View();
        }
    }
}