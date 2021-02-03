using CsvHelper;
using HealthService.DataLayer.Mapper;
using HealthService.DataLayer.ModelClass;
using HealthService.DataLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HealthService.DataLayer.Service
{
    public class CSVParserService : ICSVParser
    {
        public CSVParserService()
        {

        }
        public IList<ClaimModel> ReadClaimDetail()
        {
            String csvFilePath = Helper.ConfigHelper.GetCSVPath("Claim");

            try
            {
                using (var reader = new StreamReader(csvFilePath, Encoding.Default))
                {
                    using (var csv = new CsvReader(reader))
                    {
                        csv.Configuration.RegisterClassMap<ClaimMapper>();
                        var records = csv.GetRecords<ClaimModel>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception ex) // This is plain catch all
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<MemberModel> ReadMemberDetail()
        {
            String csvFilePath = Helper.ConfigHelper.GetCSVPath("Member");

            try
            {
                using (var reader = new StreamReader(csvFilePath, Encoding.Default))
                {
                    using (var csv = new CsvReader(reader))
                    {
                        csv.Configuration.RegisterClassMap<MemberMapper>();
                        var records = csv.GetRecords<MemberModel>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception ex) // This is plain catch all
            {
                throw new Exception(ex.Message);
            }
        }
    }
}