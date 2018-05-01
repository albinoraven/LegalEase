using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegalEase.Models
{
    public class Ticket
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TicketNumber { get; set; }
        public string CourtName { get; set; }        
        public string Offense { get; set; }

        public int ID { get; set; }
    }
}
