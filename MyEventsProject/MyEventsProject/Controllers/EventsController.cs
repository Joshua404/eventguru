using MyEventsProject.Models;
using MyEventsProject.Services;
using MyEventsProject.Views.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Principal;
//using PagedList;

namespace MyEventsProject.Controllers
{
    public class EventsController : Controller
    {
        private IEventService _eventService;

        private ILocationService _locationService;

        public EventsController(IEventService eventService, ILocationService locationService)
        {
            _locationService = locationService;
            _eventService = eventService;
        }





        // GET: Events
        public ActionResult IndexE()
        {

            // cast the user as a ClaimsIdentity
            var user = User.Identity as ClaimsIdentity;

            // does the user have the CanEditProducts claim?
            ViewBag.CanEditProducts = user.HasClaim("CanEditProducts", "true");

            var vm = new IndexVM
            {
                States = new SelectList(_locationService.GetStates(), "Id", "Name"),
                Cities = new SelectList(new List<City>(), "Id", "Name"),


                

                Events = _eventService.ListEvents()
            };

            return View(vm);
        }

        public ActionResult Search(IndexVM search)
        {
            //public blahName Event<EventName>(object input) {   
            //return (blahName) input;   
            //}

            //var blahName = MyEventsProject.Models.Event
            var vm = new IndexVM
            {
                States = new SelectList(_locationService.GetStates(), "Id", "Name"),
                Cities = new SelectList(_locationService.GetCities(search.Filter.StateId), "Id", "Name"),




            
            Events = _eventService.UserSearchInput(search.Filter)
        };
            return View("IndexE", vm);
        }

        //// POST: IndexE/Filter
        //[HttpPost]
        //public ActionResult IndexE(Object opr)
        //{

        //    return View();
        //}
         

        public ActionResult ManageE()
        {
            var userId = User.Identity.GetUserId();
            var vm = _eventService.ListUserEvents(userId);
            return View(vm);
        }

        // GET: Events/Details/5
        public ActionResult Details(int id)
        {
            var event2 = _eventService.Find(id);
            return View(event2);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            var vm = new IndexVM
            {
                States = new SelectList(_locationService.GetStates(), "Id", "Name"),
                Cities = new SelectList(new List<City>(), "Id", "Name"),




                
            };
            return View(vm);
        }

        // POST: Events/Create
        [HttpPost]
        public ActionResult Create(IndexVM vm)
        {
            //[Bind(Include = "UserId")]
            if (ModelState.IsValid)
            {
                _eventService.Create(this.User, vm.NewEvent);
                return RedirectToAction("IndexE");
            }
            return View();
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            var event2 = _eventService.Find(id);
            return View(event2);
        }

        // POST: Events/Edit/5
        [HttpPost]
        public ActionResult Edit(Event contact)
        {
            if (ModelState.IsValid)
            {
                _eventService.Edit(contact);
                return RedirectToAction("IndexE");
            }

            return View();

        }

        // GET: Events/Delete/5
        public ActionResult Delete(int id)
        {
            var event2 = _eventService.Find(id);
            return View(event2);
        }

        // POST: Events/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _eventService.Delete(id);
            return RedirectToAction("IndexE");

        }
    }
}
