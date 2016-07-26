namespace MyWebsite.Services
{
    using MyWebsite.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ServiceFactory : IServiceFactory
    {
        public IGolfService GetGolfService()
        {
            return new GolfService();
        }
    }
}
