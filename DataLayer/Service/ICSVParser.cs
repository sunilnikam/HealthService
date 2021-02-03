using HealthService.DataLayer.ModelClass;
using System.Collections.Generic;

namespace HealthService.DataLayer.Service.Interfaces
{
    interface ICSVParser
    {
        IList<ClaimModel> ReadClaimDetail();

        IList<MemberModel> ReadMemberDetail();
    }
}
