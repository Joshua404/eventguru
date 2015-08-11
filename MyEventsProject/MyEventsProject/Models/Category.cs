using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyEventsProject.Models
{
    public enum Category
    {
        Parties = 1,
        Political = 2,
        Technology = 3,
        Programming = 4,
        [Display(Name = "Sustainable Living")]
        SustainableLiving = 5,
        Entrepreneurship = 6

    }
}