
using System.ComponentModel.DataAnnotations;

namespace TestWeb.Models
{
    public class Movimentation
    {
        public int MovimentationID { get; set; }

        [Required]
        public MovimentationType Type { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

    }
}
