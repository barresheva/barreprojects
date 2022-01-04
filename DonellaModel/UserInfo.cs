using System.ComponentModel.DataAnnotations;
namespace DonellaModel
{
  public class UserInfo
  {
    public virtual int UseID { get; set; }

    [Required]
    [MinLength(6, ErrorMessage ="Minimum length should be 6")]
    [MaxLength(15, ErrorMessage = "Maximum length should be 15")]
    [Display(Name ="User name")]
    public virtual string UserName { get; set; }

    [Required]
    [MinLength(8,ErrorMessage ="Minimum length should be 8 character")]
    [MaxLength(20,ErrorMessage ="Maximum lenght should  be of 20 characters")]
    [Display(Name ="Password")]
    public virtual string Password { get; set; }


    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage ="Password and confirm password should match")]
    public virtual string ConfirmPassword { get; set; }
    public virtual int RoleId { get; set; }

    public virtual int IsActive { get; set; }

    public virtual int IsProfileCreated { get; set; }
  }
}
