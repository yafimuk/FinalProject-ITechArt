using ORM.DAL.Models;
using ORM.DAL.Models.Entities;

namespace ORM.DAL.Interfaces
{
	public interface IORMUow
	{
		void Commit();

        IUsersRepository<ApplicationUser> Users { get; }
        ITicketsRepository<ApplicationTicket> Tickets { get; }
        IUserTicketsRepository<ApplicationUserTicket> UserTickets { get; }
    }
}
