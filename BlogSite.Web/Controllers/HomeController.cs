using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogSite.Models;
using BlogSite.Data;
using Microsoft.EntityFrameworkCore;
namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly GenericUnitofWork  _genericUnitofWork;

            public HomeController(BlogContext context)
            {
                    _genericUnitofWork = new GenericUnitofWork(context);
            }
    

        public IActionResult Index()
        { 

            //Partial kategorinin burdan gitmemesi lazım düzeltilecek.  
            return View(_genericUnitofWork.Repository<tblCategory>().GetAll()); 
        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
