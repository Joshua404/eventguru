using MyEventsProject.Views.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEventsProject.Models
{
    public class Event
    {
        //[Key]
        public int Id { get; set; }

        //public string UserId { get; set; }

        //public virtual ApplicationUser ApplicationUser { get; set; }

        public string EventName { get; set; }

        public string EventOrganizer { get; set; }

        //public State State { get; set; }
        //public int StateId { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        //public SL sld { get; set; }

        public Category Category { get; set; }

        public DateTime Date { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string PictureURL { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser APUser { get; set; }

        //public SelectList States { get; set; }

        //public SelectList Cities { get; set; }

        //public MyEventsProject.Models.Filter Filter { get; set; }

        //public SelectList States { get; set; }

        //public SelectList Cities { get; set; }


        //public ICollection<Event> FilteredEvents { get; set; }


        //public int EventGroup_Id { get; set; }
        //[ForeignKey("EventGroup_Id")]
        //public EventGroup EventGroup { get; set; }

    }
}