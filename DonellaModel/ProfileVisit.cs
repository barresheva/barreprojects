using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonellaModel
{
  public class ProfileVisit
  {
    public  virtual int Id { get; set; }

    public virtual int ByUserId { get; set; }

    public virtual int MyUserID { get; set; }
  }
}
