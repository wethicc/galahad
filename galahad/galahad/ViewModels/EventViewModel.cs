using galahad.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace galahad.ViewModels
{
    public class EventViewModel : BaseViewModel
    {
        private ObservableCollection<Group> m_Groups;
        public ObservableCollection<Group> Groups {
            get => m_Groups;
            set => SetValue(ref m_Groups, value);
        }

        private Group m_SelectedGroup;
        public Group SelectedGroup {
            get => m_SelectedGroup;
            set => SetValue(ref m_SelectedGroup, value);
        }

        public EventViewModel()
        {
            var events = new ObservableCollection<Event>()
            {
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
            };

            var events2 = new ObservableCollection<Event>()
            {
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
                },
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
                },
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
            };

            Groups = new ObservableCollection<Group>()
            {
                new Group
                {
                    Id = new Guid().ToString("N").ToUpper(),
                    Events = events,
                    Name = "Gym Group"
                },
                new Group
                {
                    Id = new Guid().ToString("N").ToUpper(),
                    Events = events2,
                    Name = "Work Group"
                }
            };

            SelectedGroup = Groups.FirstOrDefault();
        }
    }
}
