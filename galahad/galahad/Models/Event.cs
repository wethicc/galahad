using System;
using System.Collections.Generic;
using System.Text;

namespace galahad.Models
{
    class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double lonX { get; set; }
        public double lonY { get; set; }
        public DateTime Date { get; set; }
        public bool Repeated { get; set; }
        public bool Warning { get; set; }
        public DateTime WarningTime { get; set; }
    }
}
