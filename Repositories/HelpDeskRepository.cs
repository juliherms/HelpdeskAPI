using System.Linq;
using System.Threading.Tasks;
using Helpdesk.API.Data;
using Helpdesk.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Helpdesk.API.Repositories
{
    
    public class HelpDeskRepository : IHelpDeskRepository
    {
        private readonly DataContext _context;

        public HelpDeskRepository(DataContext context)
        {
            this._context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }


        public async Task<Incident[]> GetAllIncidentsAsync()
        {
            //j.a.vasconcelos - query using lambda and linq
            IQueryable<Incident> query = _context.Incidents
            .Include(c => c.Application);

            query = query.OrderByDescending(c => c.Id);

            return await query.ToArrayAsync();
        }

        public Task<Incident> GetAllIncidentsAsyncById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Incident[]> GetAllIncidentsAsyncBySystem(int idSystem)
        {
            throw new System.NotImplementedException();
        }

    }
}