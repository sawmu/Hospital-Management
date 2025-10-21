using System.ComponentModel.DataAnnotations;

namespace Hms.Web.Models;

public class Patient
{
    public int Id { get; set; }
    [Required, StringLength(20)] public string MRN { get; set; } = default!;
    [Required, StringLength(80)] public string FirstName { get; set; } = default!;
    [Required, StringLength(80)] public string LastName { get; set; } = default!;
    [DataType(DataType.Date)] public DateTime? DOB { get; set; }
    [StringLength(20)] public string? Gender { get; set; }
    [Phone, StringLength(40)] public string? Phone { get; set; }
    [EmailAddress, StringLength(120)] public string? Email { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public string FullName => $"{FirstName} {LastName}";
}
