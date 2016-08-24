namespace MyWebsite.Controllers
{
    using Model;
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
            var temp = this.golfService.GetCompetitions();


            return View("Index", temp);
        }

        public ActionResult CreateGolfCompetition()
        {
            return View();
        }

        public ActionResult CreateGolfCompetition(GolfCompetition golfComp)
        {
            this.golfService.CreateGolfCompetition(golfComp);

            return View("Index");
        }

        public static IServiceFactory Factory { get; set; }
    }
}