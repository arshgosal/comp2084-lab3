using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplicaton.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone { PhoneID = 1212, PhoneName = "Iphone", Manufacturer = "Apple", MSRP = 1200,ScreenSize = 6.5, DateReleased = DateTime.Parse("09-20-2019")}
                
            };
            return View(phoneList);
        }
    }
}