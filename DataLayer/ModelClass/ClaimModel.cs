using System;
using CsvHelper.Configuration.Attributes;
using HealthService.Helper;


namespace HealthService.DataLayer.ModelClass
{
    public class ClaimModel
    {
        public Int32 MemberID { get; set; }

        public DateTime ClaimDate { get; set; }

        public Double ClaimAmount { get; set; }
    }
}