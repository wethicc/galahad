using System;
using System.Collections.Generic;
using System.Text;

namespace galahad.Models
{
    public class EventState : Model
    {
        public string EventId { get; set; }
        public DateTimeOffset? Alert { get; set; }
        public bool Muted { get; set; }
    }
}
