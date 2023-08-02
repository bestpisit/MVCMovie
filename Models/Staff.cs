using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Staff
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Specialist { get; set; }
    public decimal Price { get; set; }
}