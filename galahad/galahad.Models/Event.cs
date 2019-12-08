using System;

namespace galahad.Models
{
    public class Event : Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
