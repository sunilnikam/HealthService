using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HealthService.Model;

namespace HealthService.Controllers
{
    public class ClaimsController : ApiController
    {
        // GET api/<controller>/5
        public IHttpActionResult Get(int id = 0)
        {
            DataEngine dataEngine = new DataEngine();
            return Json<List<Member>>(dataEngine.GetMemberClaim(id));
        }

        #region Not implimented as not in requirment
        // POST api/<controller>
        /// <summary>
        /// Not implimented as not in requirment
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        /// <summary>
        /// Not implimented as not in requirment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
        #endregion Not implimented as not in requirment
    }
}