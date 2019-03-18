using B2CGraphShell;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    
    public class ValuesController : ApiController
    {
        private static B2CGraphClient client = null;
        // GET api/values
        public object Get()
        {
            client = new B2CGraphClient(Globals.clientId, Globals.clientSecret, Globals.tenant);

            var result = client.GetUserByObjectId("f7e5b82b-1377-4e1e-a9bf-9611d84436b9").Result;
            object formatted = JsonConvert.DeserializeObject(result);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(JsonConvert.SerializeObject(formatted, Formatting.Indented));

            return formatted;
        }




        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

