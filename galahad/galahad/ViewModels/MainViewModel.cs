using galahad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;
using galahad.Utils;

namespace galahad.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Group> m_Groups;
        public ObservableCollection<Group> Groups {
            get { return m_Groups; }
            set {
                if (m_Groups != value) {
                    m_Groups = value;
                    OnPropertyChanged(nameof(Groups));
                }
            }
        }

        private Group m_SelectedGroup;
        public Group SelectedGroup {
            get { return m_SelectedGroup; }
            set {
                if (m_SelectedGroup != value) {
                    m_SelectedGroup = value;
                    OnPropertyChanged(nameof(SelectedGroup));
                }
            }
        }


        public string test { get; set; }

        public MainViewModel()
        {
            Groups = new ObservableCollection<Group>();


            test = "213";
            ObservableCollection<Event> Events  = new ObservableCollection<Event>();
            ObservableCollection<Event> Events2 = new ObservableCollection<Event>();
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


        #region Commands
        
        public ICommand NextCommand { get { return new RelayCommand(OnNextCommand, AlwaysTrue); } }
        private bool AlwaysTrue() { return true; }
        public void OnNextCommand()
        {
            SelectedGroup = Groups.Last();
            OnPropertyChanged(nameof(SelectedGroup));
        }


        #endregion Commands

    }
}
