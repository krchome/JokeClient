//using System.ComponentModel.DataAnnotations;
namespace WebAPIConsume.Models
{
    public class Joke
    {
        public bool error { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string joke { get; set; }
        public Flags flags { get; set; }
        public int id { get; set; }
        public string safe { get; set; }
        public string lang { get; set; }
    }
}
