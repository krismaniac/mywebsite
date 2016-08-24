namespace MyWebsite.Model
{
    using System.Data.Entity;

    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("MainDbContext")
        {

        }

        static MainDbContext()
        {
            Database.SetInitializer<MainDbContext>(new MainDbInitializer());
        }

        public virtual DbSet<GolfCompetition> GolfCompetitions { get; set; }
    }


    public class MainDbInitializer : CreateDatabaseIfNotExists<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            base.Seed(context);
        }
    }
}
