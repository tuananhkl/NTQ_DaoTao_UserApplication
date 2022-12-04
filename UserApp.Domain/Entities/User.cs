using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApp.Domain.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    
    public string UserName { get; set; } = null!;
    
    public string Password { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }
    
    [Column(TypeName = "nvarchar(250)")]
    public string? Address { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string? Email { get; set; }
    
    public int? Age { get; set; }

    public bool Gender { get; set; }
    public int GroupId { get; set; }
    public bool Status { get; set; }
}