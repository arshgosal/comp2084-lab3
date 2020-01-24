using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplicaton.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneID = 0;
            PhoneName = "";
            Manufacturer = "";
            MSRP = 0;
            ScreenSize = 0;
            DateReleased = DateTime.Now;
        }

        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public double MSRP { get; set; }
        public double ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
    }
}