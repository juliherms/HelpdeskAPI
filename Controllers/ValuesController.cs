using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpdesk.API.Data;
using Helpdesk.API.model;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.API.Controllers
{
    /*
    * j.a.vasconcelos - classe responsavel por representar uma configuracao de rota
    */
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public DataContext _context { get;}

        public ValuesController(DataContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Application>> Get()
        {
            //lista all applications
            return _context.Applcations.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Application> Get(int id)
        {
            //search applications id
            return _context.Applcations.FirstOrDefault( x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
