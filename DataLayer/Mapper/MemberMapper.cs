using CsvHelper.Configuration;
using HealthService.DataLayer.ModelClass;
using HealthService.Helper;

namespace HealthService.DataLayer.Mapper
{
    public sealed class MemberMapper : ClassMap<MemberModel>
    {
        public MemberMapper()
        {
            Map(m => m.MemberID).Name(Constants.MemberID);
            Map(m => m.EnrollmentDate).Name(Constants.EnrollmentDate);
            Map(m => m.FirstName).Name(Constants.FirstName);
            Map(m => m.LastName).Name(Constants.LastName);
        }
    }
}