using System.ComponentModel.DataAnnotations;

namespace MVC_FOOTBALL_TEAM.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of establishment")]
        public DateTime Date_of_establishment { get; set; }
        public string? Competition { get; set; }
        [Display(Name = "Transfer Budget")]
        public decimal Transfer_budget { get; set; }
    }
}
