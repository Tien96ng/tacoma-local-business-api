using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; }

    [Required]
    [StringLength(255)]
    public string Category { get; set; }

    [Required]
    [StringLength(255)]
    public string Location { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone number.")]
    public string PhoneNumber { get; set; }
    
    [StringLength(255)]
    public string WebsiteUrl { get; set; }
  }
}