using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrandBlueResortandSpa.Models;

namespace GrandBlueResortandSpa.Controllers
{
    public class ReservationController : Controller
    {
        GrandBlueEntities grandBlue = new GrandBlueEntities();
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RoomBooking roomBooking)
        {
            grandBlue.RoomBookings.Add(roomBooking);
            grandBlue.SaveChanges();
            return View();
        }
        public ActionResult Book()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Book(BOOKING booking)
        {
            grandBlue.BOOKINGs.Add(booking);
            grandBlue.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}