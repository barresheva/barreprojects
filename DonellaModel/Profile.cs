using System.ComponentModel.DataAnnotations;
namespace DonellaModel
{
  public class Profile
  {
    public virtual int Id { get; set; }

    [Required]
    public virtual int UserId { get; set; }

    [Required]
    [MaxLength(20,ErrorMessage ="Max length can be 20 characters")]
    [Display(Name ="First name")]
    public virtual string FirstName { get; set; }

    [MaxLength(20, ErrorMessage = "Max length can be 20 characters")]
    [Display(Name = "Middle name")]
    public virtual string MiddleName { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Max length can be 20 characters")]
    [Display(Name = "Last name")]
    public virtual string LastName { get; set; }

    [Required]
    public virtual string PhotoPath { get; set; }

    [Required(ErrorMessage ="Select gender")]
    [Display(Name = "Gender")]
    public virtual int GenderId { get; set; }

    [Required]
    [Display(Name = "Location")]
    public virtual string Location { get; set; }

    [Required]
    [Display(Name = "Zip code")]
    public virtual string ZipCode { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage ="Provide email address")]
    [EmailAddress(ErrorMessage = "Provide email address in valid format")]
    public virtual string EmailAddress { get; set; }

    public virtual int IsActive { get; set; }

    [Display(Name = "Make profile Active/Inactive")]
    public virtual bool Active { get; set; }
  }
}
