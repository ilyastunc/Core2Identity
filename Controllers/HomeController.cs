using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Core2Identity.Controllers
{
    public class HomeController : Controller
    {
        // [Authorize] //bu ifadeyi eklediğimizde anasayfada login yapılmış olmasını bekleyecek.
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")] //bu sayfaya sadece Admin rolündeki login olmuş kullanıcı girebilir.
        public IActionResult Sample()
        {
            return View();
        }
    }
}