using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonellaDAL;
using DonellaModel;

namespace DonellaBLL
{
  public class ProfileVisitorBLL
  {
    public void SaveProfileVisit(ProfileVisit profileVisit)
    {
      new ProfileVisitProvider().SaveProfileVisit(profileVisit);
    }

    public IList<ProfileVisit> GetMyVisitors(int userId)
    {
      return new ProfileVisitProvider().GetMyVisitors(userId);
    }
  }
}
