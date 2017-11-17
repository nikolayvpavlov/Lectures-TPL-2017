using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMethods
{
    class SomeClass
    {
        public async Task<string> GetSomeData()
        {
            string data = await GetDataFromWeb();
            return data.ToUpper();
        }

        private async Task<string> GetDataFromWeb()
        {
            var client = new HttpClient();
            string result = await client.GetStringAsync(@"http://nvp-playground.azurewebsites.net/api/quotes/random/txt");
            return result;
        }
    }
}
