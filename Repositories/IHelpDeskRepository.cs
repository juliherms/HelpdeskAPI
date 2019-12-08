using System.Threading.Tasks;
using Helpdesk.API.Model;

namespace Helpdesk.API.Repositories
{
    public interface IHelpDeskRepository
    {
        //j.a.vasconcelos - interface responsible to contract for generic repository
         void Add<T>(T entity) where T : class;

         void Update<T>(T entity) where T : class;

         void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<Incident[]> GetAllIncidentsAsyncBySystem(int idSystem);

        Task<Incident[]> GetAllIncidentsAsync();

        Task<Incident> GetAllIncidentsAsyncById(int IndicentId);
    }
}