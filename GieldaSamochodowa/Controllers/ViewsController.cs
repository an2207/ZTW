using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GieldaSamochodowa.Controllers
{
    public class ViewsController : Controller
    {
        private MarketContext dbase;

        public ViewsController(MarketContext dbase)
        {
            this.dbase = dbase;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {


            return View(dbase.Views.ToList());
        }
    }
}
