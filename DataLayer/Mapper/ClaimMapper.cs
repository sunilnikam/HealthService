using CsvHelper.Configuration;
using HealthService.DataLayer.ModelClass;
using HealthService.Helper;

namespace HealthService.DataLayer.Mapper
{
    public sealed class ClaimMapper : ClassMap<ClaimModel>
    {
        public ClaimMapper()
        {
            Map(m => m.MemberID).Name(Constants.MemberID);
            Map(m => m.ClaimDate).Name(Constants.ClaimDate);
            Map(m => m.ClaimAmount).Name(Constants.ClaimAmount);
        }
    }
}