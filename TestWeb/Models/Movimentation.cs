
        
using System.ComponentModel.DataAnnotations;

namespace TestWeb.Models
{
    public class Movimentation
    {
        public int MovimentationID { get; set; }

        
        public MovimentationType Type { get; set; }

        
        public DateTime StartTime { get; set; }

      
        public DateTime EndTime { get; set; }

    }
}
