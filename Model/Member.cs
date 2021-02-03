using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthService.Model
{
    public class Member
    {
        public Int32 MemberID { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }
        
        public  List<Claim> Claims { get; set; }
    }
}