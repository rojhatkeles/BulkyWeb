using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Bulky.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public int Number { get; set; }
    
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string Name { get; set; }
}