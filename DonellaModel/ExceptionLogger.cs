using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonellaModel
{
  public class ExceptionLogger
  {
    public virtual int ExceptionId { get; set; }

    public virtual string ExceptionMessage { get; set; }

    public virtual string ControllerName { get; set; }

    public virtual string ActionName { get; set; }

    public virtual string ExceptionStackTrack { get; set; }

    public virtual DateTime ExceptionLogTime { get; set; }
  }
}
