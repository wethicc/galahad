using galahad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace galahad.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public Group SelectedGroup { get; set; }
        public string test { get; set; }

        public MainViewModel()
        {
            test = "213";
            List<Event> Events  = new List<Event>();
            List<Event> Events2 = new List<Event>();
            Events.Add(
                new Event
                {
                    Id = Guid.NewGuid().ToString("N").ToUpper(),
                    Name = "Gym",
                    Description = "Leeds City Center",
                    Lat = 41.40338,
                    Lon = 2.17403,
                    Date = new DateTime(2019, 12, 8, 7, 30, 0),
                    Repeated = false,
                    Warning = false,
                    WarningTime = null
                }
            ); 
            Events2.Add(
                new Event
                {
                    Id = Guid.NewGuid().ToString("N").ToUpper(),
                    Name = "Event2",
                    Description = "I made an Event2",
                    Lat = 41.40338,
                    Lon = 2.17403,
                    Date = DateTime.Now,
                    Repeated = false,
                    Warning = false,
                    WarningTime = null
                }
            );
            Events2.Add(
                new Event
                {
                    Id = Guid.NewGuid().ToString("N").ToUpper(),
                    Name = "Event3",
                    Description = "I made an Event3",
                    Lat = 41.40338,
                    Lon = 2.17403,
                    Date = DateTime.Now,
                    Repeated = false,
                    Warning = false,
                    WarningTime = null
                }
            );
            Events2.Add(
                new Event
                {
                    Id = Guid.NewGuid().ToString("N").ToUpper(),
                    Name = "Event4",
                    Description = "I made an Event4",
                    Lat = 41.40338,
                    Lon = 2.17403,
                    Date = DateTime.Now,
                    Repeated = false,
                    Warning = false,
                    WarningTime = null
                }
            );

            Groups.Add(
                new Group
                {
                    Id = new Guid().ToString("N").ToUpper(),
                    Events = Events,
                    Name = "Gym Group"
                }
            );


            Groups.Add(
                new Group
                {
                    Id = new Guid().ToString("N").ToUpper(),
                    Events = Events2,
                    Name = "Work Group"
                }
            );



            SelectedGroup = Groups.FirstOrDefault();
        }
    }
}
