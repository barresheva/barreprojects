using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonellaModel
{
  public class FriendRequest
  {
    public virtual int Id { get; set; }

    public virtual int FromId { get; set; }

    public virtual int ToId { get; set; }

    public virtual int StatusId { get; set; }
  }
}
