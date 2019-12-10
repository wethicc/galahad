using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace galahad.Models
{
    public class Group
    {
        public string Id { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
