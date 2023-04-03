using System.ComponentModel.DataAnnotations;

namespace MVC_FOOTBALL_TEAM.Models;

public class Player
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    public string? Position { get; set; }
    public decimal Value { get; set; }
}