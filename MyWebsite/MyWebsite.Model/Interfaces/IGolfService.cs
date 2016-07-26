namespace MyWebsite.Interfaces
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IGolfService
    {
        List<GolfCompetition> GetCompetitions();

        List<GolfCompetition> GetCompetitions(int year);
    }
}
