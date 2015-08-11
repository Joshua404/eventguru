using CoderCamps;
using MyEventsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyEventsProject.Services
{
    public class LocationService : MyEventsProject.Services.ILocationService
    {
        private IGenericRepository _repo;

        public LocationService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<State> GetStates()
        {
            return _repo.Query<State>().ToList();


        }

        public IList<City> GetCities(int? id)
        {
            return _repo.Query<City>().Where(m => m.StateId == id).ToList();


        }
    }
}