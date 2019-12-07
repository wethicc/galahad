using System;
using System.Collections.Generic;
using System.Text;

namespace galahad.Models
{
    public class Group
    {
        public string Id { get; set; }
        public List<Event> Events { get; set; }
        public string Name { get; set; }
            
    }
}
