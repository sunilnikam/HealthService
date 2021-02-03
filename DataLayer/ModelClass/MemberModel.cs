using System;
using CsvHelper.Configuration.Attributes;
using HealthService.Helper;

namespace HealthService.DataLayer.ModelClass
{
    public class MemberModel
    {
        [Name(Constants.MemberID)]
        public Int32 MemberID { get; set; }

        [Name(Constants.EnrollmentDate)]
        public DateTime EnrollmentDate { get; set; }

        [Name(Constants.FirstName)]
        public String FirstName { get; set; }

        [Name(Constants.LastName)]
        public String LastName { get; set; }
    }
}