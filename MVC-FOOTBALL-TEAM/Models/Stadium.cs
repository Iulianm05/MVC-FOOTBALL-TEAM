using System.ComponentModel.DataAnnotations;

namespace MVC_FOOTBALL_TEAM.Models
{
    public class Stadium
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime FoundationDate { get; set; }
        public string? Location { get; set; }
        public string? Team { get; set; }
        public decimal MaxAttendance { get; set; }

    }
}
