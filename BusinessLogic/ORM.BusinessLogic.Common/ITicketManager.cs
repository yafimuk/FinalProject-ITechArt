using ORM.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.BusinessLogic.Common {
    public interface ITicketManager {
        bool AddTicket(ApplicationTicket ticket);
        IEnumerable<ApplicationTicket> GetAll();

        bool MinuseTickets(int id, int count);

    }
}
