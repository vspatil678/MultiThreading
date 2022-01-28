using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class AsyncAndAwait
    {
        static void Mains(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string data = await client.GetStringAsync("http://www.microsoft.com");
                return data;
            }
        }
    }
}
