using MyEventsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEventsProject.Views.Events
{
    public class IndexVM
    {
        //[Key]
        //public int Id { get; set; }

        public IEnumerable<Event> Events { get; set; }
        public Event NewEvent { get; set; }

        public MyEventsProject.Models.Filter Filter { get; set; }

        public SelectList States { get; set; }

        public SelectList Cities { get; set; }


        //public IList<EventGroup> EventGroups { get; set; }
        //public EventGroup EventGroup { get; set; }
        //public IndexVM()
        //{
        //    this.EventGroup = new EventGroup();
        //    this.EventGroups = new List<EventGroup>();
        //}



    }
}