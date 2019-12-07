using System.Collections.Generic;
using Helpdesk.API.Model;

namespace Helpdesk.API.model
{

    //model for Applcations
    public class Application
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Incident> Incidents { get; set; }
    }
}