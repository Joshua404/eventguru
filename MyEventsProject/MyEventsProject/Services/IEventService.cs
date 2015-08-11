using MyEventsProject.Models;
using System;
namespace MyEventsProject.Services
{
    public interface IEventService
    {
        void Create(System.Security.Principal.IPrincipal user, Event newEvent);
        void Delete(int id);
        void Edit(MyEventsProject.Models.Event event2);
        MyEventsProject.Models.Event Find(int id);
        System.Collections.Generic.IList<MyEventsProject.Models.Event> ListEvents();
        MyEventsProject.Models.ApplicationUser ListUserEvents(string UserId);
        System.Collections.Generic.IList<MyEventsProject.Models.Event> UserSearchInput(MyEventsProject.Models.Filter filter);
    }
}
