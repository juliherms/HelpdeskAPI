using System;
using Helpdesk.API.model;

namespace Helpdesk.API.Model
{
    //j.a.vasconcelos - this class responsible persist Incident in a database
    public class Incident
    {
        public int Id { get; set;}

        public int Decription { get; set;}

        public DateTime? createDate { get; set;}

        public int ApplicationId { get; set;}

        public Application Application { get; set; }
    }
}