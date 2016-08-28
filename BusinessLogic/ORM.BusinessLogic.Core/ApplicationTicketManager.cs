using ORM.BusinessLogic.Common;
using ORM.DAL.Interfaces;
using ORM.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.BusinessLogic.Core {

    public class ApplicationTicketManager : ITicketManager {
        private readonly IORMUow _uow;
        private readonly ITicketsRepository<ApplicationTicket> _repository;

        object _sync = new object();

        public ApplicationTicketManager(IORMUow uow) {
            this._uow = uow;
            this._repository = this._uow.Tickets;
        }
        public bool AddTicket(ApplicationTicket ticket) {
            try {
                this._repository.Create(ticket);
                this._uow.Commit();


                return true;
            }
            catch {
                return false;
            }
        }

        public IEnumerable<ApplicationTicket> GetAll() {
            try {
                return this._repository.GetAll().ToList();
            }
            catch {
                return null;
            }
        }

        public bool MinuseTickets(int id, int count) {
            try {
                var item = this._repository.GetById(id);

                lock (_sync) {
                    if (item.Count < count) return false;

                    item.Count -= count;

                    this._repository.Update(item);

                    this._uow.Commit();
                }

                return true;
            }
            catch {
                return false;
            }
        }
    }
}
