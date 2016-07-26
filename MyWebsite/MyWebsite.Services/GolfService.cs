namespace MyWebsite.Services
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model;

    public class GolfService : IGolfService
    {
        private ApplicationDbContext golfContext;

        public GolfService()
        {
            this.golfContext = new ApplicationDbContext();
        }

        public List<GolfCompetition> GetCompetitions()
        {
            return this.golfContext.GolfCompeitions.ToList();
        }

        public List<GolfCompetition> GetCompetitions(int year)
        {
            return this.golfContext.GolfCompeitions.Where(x => x.Date.Year == year).ToList();
        }
    }
}
