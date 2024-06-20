using System.ComponentModel.DataAnnotations;

namespace Zad10.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
    public string Password { get; set; }
}