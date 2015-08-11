using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEventsProject.Models
{
    public class EventVM
    {
        public Event Events { get; set; }

        public Filter Filter { get; set; }
    }
}