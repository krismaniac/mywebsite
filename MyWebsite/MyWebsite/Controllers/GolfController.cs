namespace MyWebsite.Controllers
{
    using MyWebsite.Interfaces;
    using MyWebsite.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;


    public class GolfController : Controller
    {
        private IGolfService golfService;

        public GolfController()
        {
            Factory = new ServiceFactory();
            this.golfService = Factory.GetGolfService();
        }

        // GET: Golf
        public ActionResult Index()
        {
            return View();
        }

        public static IServiceFactory Factory { get; set; }
    }
}