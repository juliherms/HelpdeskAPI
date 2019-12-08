using Helpdesk.API.model;
using Helpdesk.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Helpdesk.API.Data
{
    //j.a.vasconcelos - this class responsible mapping model to database
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        //j.a.vasconcelos -- adding collections in the class
        public DbSet<Application> Applcations { get; set; }

        public DbSet<Incident> Incidents { get; set; }
    }
}