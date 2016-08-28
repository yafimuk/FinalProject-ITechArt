using ORM.BusinessLogic.Common;
using System.Web.Mvc;
using ORM.Web.Models;
using ORM.DAL.Models.Entities;
using PagedList;

namespace ORM.Web.Controllers { 
    public class HomeController : Controller {
    private readonly ITicketManager _ticketManager;

    public HomeController(ITicketManager ticketManager) {
        this._ticketManager = ticketManager;
    }

    [HttpGet]
    public ActionResult Index(int? page, int size = 20) {
        var tickets = this._ticketManager.GetAll();

        int pageNumber = (page ?? 1);

        if (size == 0) {
            size = 3;
        }

        if (Request.IsAjaxRequest()) {
            return PartialView("_PartialTicketList", tickets.ToPagedList(pageNumber, size));
        }

        return View(tickets.ToPagedList(pageNumber, size));
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public ActionResult AddTicket() {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public ActionResult AddTicket(AddTicketModel model) {
        if (!ModelState.IsValid) {
            return View(model);
        }

        var ticket = new ApplicationTicket { DateTime = model.DateTime, Cost = model.Cost, Count = model.Count, Description = model.Description };

        this._ticketManager.AddTicket(ticket);

        return RedirectToAction("Index");
    }
}
}