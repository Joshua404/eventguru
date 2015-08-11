namespace MyEventsProject.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MyEventsProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<MyEventsProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyEventsProject.Models.ApplicationDbContext context)
        {
            var WA = new State { Name = "Washington"};
            var OR = new State { Name = "Oregon"};
            var ID = new State { Name = "Idaho"};

            var states = new State[] { WA, OR, ID };
            context.States.AddOrUpdate(s => s.Name, states);


            //Washington Cities
            var Seattle = new City { Name = "Seattle", StateId = WA.Id };
            var Bellevue = new City { Name = "Bellevue", StateId = WA.Id };
            var Redmond = new City { Name = "Redmond", StateId = WA.Id };
            var Renton = new City { Name = "Renton", StateId = WA.Id };

            //Oregon Cities
            var Portland = new City { Name = "Portland", StateId = OR.Id };
            var Salem = new City { Name = "Salem", StateId = OR.Id };
            var Beaverton = new City { Name = "Beaverton", StateId = OR.Id };
            var Bend = new City { Name = "Bend", StateId = OR.Id };

            //Idaho Cities
            var Boise = new City { Name = "Boise", StateId = ID.Id };
            var Nampa = new City { Name = "Nampa", StateId = ID.Id };
            var Caldwell = new City { Name = "Caldwell", StateId = ID.Id };
            var Lewiston = new City { Name = "Lewiston", StateId = ID.Id };


            //var cities = new City[] { Seattle, Bellevue, Redmond, Renton};
            //context.Cities.AddOrUpdate(c => c.Name, cities);

            var cities = new City[] { Seattle, Bellevue, Redmond, Renton, Portland, Salem, Beaverton, Bend, Boise, Nampa, Caldwell, Lewiston };
            context.Cities.AddOrUpdate(c => c.Name, cities);


           


            var events = new Event[] {
                

                new Event {EventName="Growing Your Own Food", 
                           EventOrganizer="Christina",
                           CityId=Seattle.Id,
                           Category= Category.SustainableLiving,
                           Date= new DateTime(2016, 2, 5, 12, 30, 00), 
                           PictureURL="http://www.foundationfarm.com/_borders/Picture%20011.jpg",
                           Description="Come and grow your knowledge about Sustainable Living" },

                new Event {EventName="Learn Windows 10", 
                           EventOrganizer="Alex",
                           CityId=Seattle.Id,
                           Category= Category.Technology,
                           Date= new DateTime(2015, 8, 2, 16, 00, 00), 
                           PictureURL="http://i.ytimg.com/vi/kiZXZG-_oLs/maxresdefault.jpg",
                           Description="This is a workshop on Windows 10 and how it differs from previous versions of windows" },

                new Event {EventName="Learn Bootstrap", 
                           EventOrganizer="Dan",
                           CityId=Seattle.Id,
                           Category= Category.Programming,
                           Date= new DateTime(2015, 10, 26, 17, 00, 00), 
                           PictureURL="http://ollomedia.com/wp-content/uploads/Bootstrap-2-1-Is-the-Latest-Update-to-Twitter-s-Popular-Open-Source-Project.png",
                           Description="Come prepared to learn Bootstrap" },

                new Event {EventName="Sharepoint 101", 
                           EventOrganizer="Marisa",
                           CityId=Portland.Id,
                           Category= Category.Technology,
                           Date= new DateTime(2016, 4, 28, 15, 00, 00), 
                           PictureURL="http://www.trainingconcepts.com/wp-content/uploads/2013/03/msSharePoint2013-inverse.jpg",
                           Description="If you don't know how Sharepoint work then come prepared to learn!" },

                new Event {EventName="Emerging Technologies", 
                           EventOrganizer="Robert Downy-jr",
                           CityId=Salem.Id,
                           Category= Category.Technology,
                           Date= new DateTime(2016, 5, 1, 13, 00, 00), 
                           PictureURL="http://images.gizmag.com/hero/world_technology.jpg",
                           Description="This is an extensive seminar on the emerging technologies of today put on by none other than Iron-Man himself!" },

                new Event {EventName="Public Awareness for Startups", 
                           EventOrganizer="Chris Evans",
                           CityId=Boise.Id,
                           Category= Category.Entrepreneurship,
                           Date= new DateTime(2015, 12, 3, 8, 00, 00), 
                           PictureURL="http://www.thepracticingmind.com/wp-content/uploads/2012/07/Awareness-Road-Sign.jpg",
                           Description="Come and learn how you can make sure that the public knows about your business" },

                new Event {EventName="Self Defense 101", 
                           EventOrganizer="Phil Coulson",
                           CityId=Nampa.Id,
                           Category= Category.SustainableLiving,
                           Date= new DateTime(2016, 2, 14, 9, 00, 00), 
                           PictureURL="http://www.advancedbkj.com/wp-content/uploads/sd.jpg",
                           Description="Learn how to defend yourself, Taught by a 'Fictional' world renowned professional"},


            };
            //context.Events.AddOrUpdate(e => e.EventName, events);



            //var user = new ApplicationUser
            //{
            //    UserName = "StephenW",
            //    Email = "stephen.walther@codercamps.com"
            //};

            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new ApplicationUserManager(userStore);

            //if (userManager.FindByName(user.UserName) == null)
            //{
            //    userManager.Create(user, "Secret123!");
            //    userManager.AddClaim(user.Id, new Claim("CanEditCars", "true"));
            //}

            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new ApplicationUserManager(userStore);
            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new ApplicationRoleManager(roleStore);

            //// Ensure Stephen
            //var user = userManager.FindByName("StephenRox");
            //if (user == null)
            //{
            //    // create user
            //    user = new ApplicationUser
            //    {
            //        UserName = "StephenRox",
            //        FirstName = "Stephen",
            //        LastName = "Walther",
            //        Email = "Stephen.Walther@CoderCamps.com",
            //        UserEvents = new List<Event> { 

            //                new Event {
            //                   EventName="Halapoluza the 2nd",
            //                   EventOrganizer="Stephen",
            //                   City=Bellevue, 
            //                   Category= Category.Parties,
            //                   Date= new DateTime(2015, 8, 20, 11, 00, 00), 
            //                   PictureURL="http://ohindustry.com/wp-content/uploads/2014/11/Modern-fashion-party.jpeg",
            //                   Description="Come and have a great time with family and friends, You Will Be Glad You Did!" 
            //                },
            //                new Event {
            //                   EventName="Lake Float", 
            //                   EventOrganizer="Keanu Reaves",
            //                   City=Redmond,
            //                   Category= Category.Parties,
            //                   Date= new DateTime(2015, 7, 14, 13, 00, 00), 
            //                   PictureURL="http://i.ebayimg.com/00/s/NDE4WDUwMA==/z/IXgAAOSwstxVX2OU/$_35.JPG",
            //                   Description="Enjoy Yourself a float down the river on a nice hot day. Anyone who can swim or has a life jacket welcome, You will be Glad you came!" 
            //                },


            //        new Event {
            //            EventName="Coding Sprint", 
            //                   EventOrganizer="Joshua Graves",
            //                   City=Redmond,
            //                   Category= Category.Programming,
            //                   Date= new DateTime(2015, 9, 22, 15, 00, 00), 
            //                   PictureURL="http://cdn.wonderfulengineering.com/wp-content/uploads/2014/04/code-wallpaper-23.jpg",
            //                   Description="Lets Code ourselves some nice! shit" 
            //        },

            //        new Event {
            //            EventName="Gaming Extravanganza", 
            //                   EventOrganizer="J.R.",
            //                   City=Renton,
            //                   Category= Category.Parties,
            //                   Date= new DateTime(2015, 11, 3, 10, 00, 00), 
            //                   PictureURL="https://e-sports-square.com/stadium/wp-content/uploads/2014/03/SGP_HS2_1.jpg",
            //                   Description="Come prepared to game your heart out" 
            //        },

            //        new Event {
            //            EventName="Democratic Bashing", 
            //                   EventOrganizer="Laurence Fishburne",
            //                   City=Renton,
            //                   Category= Category.Political,
            //                   Date= new DateTime(2016, 1, 12, 17, 00, 00), 
            //                   PictureURL="http://i.imgur.com/g894dnY.jpg",
            //                   Description="Come and diss some democrats" 
            //        },



            //            }


            //    };
            //    userManager.Create(user, "Secret123!");

            //    //context.Events.AddOrUpdate(m => m.EventName, events);

            //    // add claims
            //    userManager.AddClaim(user.Id, new Claim("CanEditProducts", "true"));
            //    userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "12/25/1966"));
            //}
        }
    }
}