namespace galahad.Models
{
    public class User : Model
    {
        public string Name { get; set; }
        
        public int[] EventIds { get; set; }
    }
}
