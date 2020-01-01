using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace galahad.Models
{
    public class Group
    {
        public int Index { get; set; }
        public string Id { get; set; }
        public string Guid { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
