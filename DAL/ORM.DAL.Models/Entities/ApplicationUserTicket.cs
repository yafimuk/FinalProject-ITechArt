using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Models.Entities {

   public class ApplicationUserTicket {

        [Key]
        public int UserTicketsId { get; set; }
        public ApplicationUser User { get; set; }
        public ApplicationTicket Ticket { get; set; }
        public int TicketsCount { get; set; }
    }

}
