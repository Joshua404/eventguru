using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyEventsProject.Models
{
    public class Filter
    {

        public string Search { get; set; }
        public int? StateId { get; set; }

        public int? CityId { get; set; }

        public Category? Category { get; set; }
    }
}