using MyEventsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEventsProject.Views.Events
{
    public class CreateVM
    {
        public Event NewEvent { get; set; }

        //public MyEventsProject.Models.Filter Filter { get; set; }

        public SelectList States { get; set; }

        public SelectList Cities { get; set; }

    }
}