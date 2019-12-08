using System.Collections.Generic;

namespace galahad.Models
{
    public class Group : Model
    {
        public IEnumerable<string> EventIds { get; } = new List<string>();
    }
}
