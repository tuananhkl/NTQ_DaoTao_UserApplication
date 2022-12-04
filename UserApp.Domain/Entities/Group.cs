using System.ComponentModel.DataAnnotations;

namespace UserApp.Domain.Entities;

public class Group
{
    [Key] public int Id { get; set; }
    public string GroupName { get; set; } = null!;
    public bool Status { get; set; }
}