using System;
namespace MyEventsProject.Services
{
    public interface ILocationService
    {
        System.Collections.Generic.IList<MyEventsProject.Models.City> GetCities(int? stateId);
        System.Collections.Generic.IList<MyEventsProject.Models.State> GetStates();
    }
}