using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Register
{
    public class CityList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string [] values = {"Ankara","İzmir","İstanbul" } ;
            return View(values);
        }
    }
}
