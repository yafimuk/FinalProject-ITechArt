using ORM.DAL.Models.Entities;
using ORM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Web.Models {
    class TicketList {

        public int UserTicketsId { get; set; }
        public ApplicationTicket Ticket { get; set; }
        public int Count { get; set; }

    }
}
