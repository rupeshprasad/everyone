using B2CGraphShell;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static B2CGraphClient client = null;
        static void Main(string[] args)
        {
            client = new B2CGraphClient(Globals.clientId, Globals.clientSecret, Globals.tenant);

            var result = client.GetUserByObjectId("f7e5b82b-1377-4e1e-a9bf-9611d84436b9").Result;
            object formatted = JsonConvert.DeserializeObject(result);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(JsonConvert.SerializeObject(formatted, Formatting.Indented));
        }
    }
}
