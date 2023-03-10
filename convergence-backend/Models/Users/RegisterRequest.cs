using System.ComponentModel.DataAnnotations;

namespace convergence_backend.Models.Users;

public class RegisterRequest
{
    [MaxLength(20)]
    public string Username { get; set; }

    [MaxLength(20)]
    public string Password { get; set; }

    [MaxLength(50)]
    public string Email { get; set; }
}
