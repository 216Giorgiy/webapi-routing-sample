using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class OrderController : ApiController
    {
        // GET api/order
        [ActionName("DefaultAction")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/order/5
        [ActionName("DefaultAction")]
        public string GetDefaultAction(int id)
        {
            return "value";
        }
        // POST api/order
        [ActionName("DefaultAction")]
        public void Post([FromBody]string value)
        {
        }
        // PUT api/order/5
        [ActionName("DefaultAction")]
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/order/5
        [ActionName("DefaultAction")]
        public void Delete(int id)
        {
        }
        // GET api/order/5/vendors
        [HttpGet]
        public IEnumerable<string> Vendors(int id)
        {
            //id is the order id
            return new string[] { "vendor1", "vendor2" };
        }
        // PUT api/order/5/reject
        [ActionName("Reject")]
        public void PutReject(int id)
        {
        }
    }
}