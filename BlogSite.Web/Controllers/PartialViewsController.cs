using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class PartialViewsController : Controller
    {
    
      


       
        public IActionResult GetCategoryList()
        {
        
              
            return View();
        }
        public IActionResult GetPopularArticle()
        {
            

            return View();
        }


         

    }
}