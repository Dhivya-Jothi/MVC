using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineBadMitonBooking
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "BookCourt",
				url: "Book",
				defaults: new { controller = "BookCourt", action = "Booking", id = UrlParameter.Optional }
			);
			routes.MapRoute(
                name: "CancelBookCourt",
                url: "Cancel",
                defaults: new { controller = "CancelBookCourt", action = "CancelBooking", id = UrlParameter.Optional }
            );
			routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",




                defaults: new { controller = "BookCourt", action = "Booking", id = UrlParameter.Optional }
            );
        }
    }
}
