using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Core.Entities;

public class User
{
    [Key]
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}
