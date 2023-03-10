using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace convergence_backend.Entities;

public class User
{
    public int Id { get; set; }

    [MaxLength(20)]
    public string Username { get; set; }

    [JsonIgnore]
    [MaxLength(20)]
    public string Password { get; set; }

    [MaxLength(50)]
    public string Email { get; set; }
}
