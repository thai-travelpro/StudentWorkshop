using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ProOnline.Gds.WebServices.Logs.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(Models.SearchModel search)
        {         
            return View(search);
        }
    }

}