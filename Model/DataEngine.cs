using HealthService.DataLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthService.Model
{
    public class DataEngine
    {

        public DataEngine()
        {

        }

        public List<Member> GetMemberClaim(Int32 memberID)
        {
            CSVParserService csvParserService = new CSVParserService();

            List<Member> members = (from member in csvParserService.ReadMemberDetail()
                                    join claim in csvParserService.ReadClaimDetail()
                                    on member.MemberID equals claim.MemberID
                                    where member.MemberID == (memberID == 0 ? member.MemberID : memberID)
                                    select new Member
                                    {
                                        MemberID = member.MemberID,
                                        FirstName = member.FirstName,
                                        LastName = member.LastName,
                                        EnrollmentDate = member.EnrollmentDate
                                    }).ToList();
            foreach (Member member in members)
            {
                member.Claims = (from claim in csvParserService.ReadClaimDetail()
                                 where claim.MemberID == member.MemberID
                                 select new Claim
                                 {
                                     MemberID = claim.MemberID,
                                     ClaimDate = claim.ClaimDate,
                                     ClaimAmount = claim.ClaimAmount
                                 }).ToList();
            }

            return members;
        }
    }
}