using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace DonellaModel
{
  public class WallPost
  {
    public virtual int Id { get; set; }

    public virtual int FromId { get; set; }

    public virtual int ToId { get; set; }

    [Required]
    [Display(Name ="Message")]
    public virtual string Content { get; set; }
  }
}
