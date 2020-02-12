using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBadMitonBooking.Controllers
{
    public class CancelBookCourtController : Controller
    {
        // GET: CancelBookCourt
        public string CancelBooking()
        {
            return "The Booking is cancelled";
        }
    }
}