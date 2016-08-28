using ORM.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.BusinessLogic.Common {

    public interface IUserTicketManager {
        bool AddToCart(string userId, int ticketId, int count);
        IEnumerable<ApplicationUserTicket> GetAllByUserId(string id);

        bool Delete(int id);
    }
}
