using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers  
{  
    public class XXIBM_PRODUCT_STYLEController : Controller  
    {  
        public IActionResult Index()  
        {  
            ProductStyle context = HttpContext.RequestServices.GetService(typeof(app.Models.ProductStyle)) as ProductStyle;  
  
            return View(context.GetAllXXIBM_PRODUCT_STYLEs());  
        }  
  
  
    }  
}
