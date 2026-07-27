using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string Organizer { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public string Venue { get; set; }

        [Range(1, 10000)]
        public int Participants { get; set; }
    }
}