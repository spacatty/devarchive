using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://api.icndb.com/jokes/random";
            string response;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            using (StreamReader sr = new StreamReader(res.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }
            valueJSON val = JsonConvert.DeserializeObject<valueJSON>(response);
            Console.WriteLine("We got a joke for you:\n{0}", val.Value.Joke);
            Console.ReadLine();
        }
    }
}
