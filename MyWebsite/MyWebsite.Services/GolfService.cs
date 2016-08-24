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
        private MainDbContext golfContext;

        public GolfService()
        {
            this.golfContext = new MainDbContext();
        }

        public void CreateGolfCompetition(GolfCompetition golfComp)
        {
            this.golfContext.GolfCompetitions.Add(golfComp);
            
        }

        public List<GolfCompetition> GetCompetitions()
        {
            return this.golfContext.GolfCompetitions.ToList();            
        }

        public List<GolfCompetition> GetCompetitions(int year)
        {
            return this.golfContext.GolfCompetitions.Where(x => x.Date.Year == year).ToList();
        }
    }
}
