using CoderCamps;
using MyEventsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MyEventsProject.Views.Events;
using System.Security.Principal;
using Microsoft.AspNet.Identity;

namespace MyEventsProject.Services
{
    public class EventService : MyEventsProject.Services.IEventService
    {
        private IGenericRepository _repo;
        public EventService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<Event> ListEvents()
        {

          
              

            return (from m in _repo.Query<Event>().Include(d => d.City)
                    select m).ToList();

            //if (!String.IsNullOrEmpty(id))
            //{
            //    m = m.Where(s => s.EventName.Contains(id));
            //}
        }


        public IList<Event> UserSearchInput(Filter filter)
        {
            var SResults = _repo.Query<Event>().Include(d => d.City);
            if (filter.StateId.HasValue)
            {
                SResults = SResults.Where(s => s.City.State.Id == filter.StateId);
            }
            if (filter.CityId.HasValue)
            {
                SResults = SResults.Where(c => c.City.Id == filter.CityId);
            }
            if (filter.Category.HasValue)
            {
                SResults = SResults.Where(c => c.Category == filter.Category);
            }
            if (!string.IsNullOrEmpty(filter.Search))
            {
                SResults = SResults.Where(s => s.EventName.Contains(filter.Search));
            }
            var results = SResults.ToList();
                return results;
                //== searchInput).ToList(); 

            //return _repo.Query<Event>().Where(x => x.EventName == searchInput).ToArray();
        }

        //public IList<Event> FindFiltered(string opr)
        //{
        //    //Category rrr = opr;
        //    var filtered = _repo.Query<IndexVM>().Where(s => s.Cities == ).Include(s => s.Events).FirstOrDefault();
        //    //return filtered;
        //}

        //public IList<Event> SearchResults()
        //{ 
        
        //    return???
        //}

        // Get User's Events
        public ApplicationUser ListUserEvents(string UserId)
        {
            //return (from e in _repo.Query<Event>() select e).Where(e => e.Id == UserId).ToList();

            //return _repo.Query<Event>().Where(ApplicationUser == UserId).ToList();

            //.Where(ApplicationUser == UserId);

            var model = _repo.Query<ApplicationUser>().Include(c => c.UserEvents.Select(u => u.City)).Where(u => u.Id == UserId).Include(u => u.UserEvents).FirstOrDefault();
            return model;

        }

        public Event Find(int id)
        {
            return _repo.Query<Event>().Include(c => c.City).Include(s => s.City.State).Where(u => u.Id == id).FirstOrDefault();
            
            //Find<Event>(id);
        }

        public void Create(IPrincipal user, Event newEvent)
        {
            newEvent.ApplicationUserId = user.Identity.GetUserId();
            newEvent.City = null;
            _repo.Add(newEvent);
            _repo.SaveChanges();
        }

        public void Edit(Event event2)
        {
            var original = this.Find(event2.Id);
            original.EventName = event2.EventName;
            original.EventOrganizer = event2.EventOrganizer;
            //original.State = event2.State;
            //original.City = event2.City;
            original.Category = event2.Category;
            original.Date = event2.Date;
            original.Description = event2.Description;
            original.PictureURL = event2.PictureURL;
            //original.Phone = event2.Phone;
            //original.Email = event2.Email;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Event>(id);
            _repo.SaveChanges();
        }
    }
}