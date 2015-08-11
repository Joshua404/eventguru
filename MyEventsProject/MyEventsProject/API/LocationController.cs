using CoderCamps;
using MyEventsProject.Models;
using MyEventsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyEventsProject.API
{
    public class LocationController : ApiController
    {
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public IList<City> Get(int id)
        {

            if (id != null)
            {
                return _locationService.GetCities(id);
            }

            return null;

        }
    }
}
