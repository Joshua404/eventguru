using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyEventsProject.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }

        public State State { get; set; }

        //public int CityId { get; set; }

    }
}