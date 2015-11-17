using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public class ApiHelper
    {

        #region API Common

        public async Task<string> GetAPIResponse(string apiCall)
        {
            var client = new HttpClient();
            var sb = new StringBuilder();
            sb.Append(apiCall);
            var uri = new Uri(sb.ToString());
            var response = await client.GetStringAsync(uri).ConfigureAwait(false);
            return response;
        }

        #endregion
    }
}
