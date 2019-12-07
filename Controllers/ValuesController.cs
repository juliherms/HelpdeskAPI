using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpdesk.API.Data;
using Helpdesk.API.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Get()
        {
            
            try{
                //lista all applications
                var results = await _context.Applcations.ToListAsync();    
                return Ok(results);//return status code 200

            }catch(System.Exception){
                //return error
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Error access to database");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try{
                //search applications id
                var results = await _context.Applcations.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(results);
            }catch(System.Exception){
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Erro to access database");
            }
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
