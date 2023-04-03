using System.ComponentModel.DataAnnotations;

namespace MVC_FOOTBALL_TEAM.Models
{
    public class Coach
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string? Team { get; set; }
        public string? Tactic  { get; set; }
        public decimal PointsPerMatch { get; set; }

    }
}
