using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySqlTest.Data;

[Index(nameof(Username))]
public class AuthUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }
    
    public byte[]? PasswordHash { get; set; }

    public byte[]? Salt { get; set; }
}