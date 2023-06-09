using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreDepartman.Controllers
{
    public class personelController : Controller
    {
        Context c=new Context();    
        public IActionResult Index()
        {
            var degerler = c.personels.ToList();
            return View(degerler);
        }
    }
}
