using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthService.Model
{
    public class Claim
    {
        public Int32 MemberID { get; set; }

        public DateTime ClaimDate { get; set; }

        public Double ClaimAmount { get; set; }
    }
}