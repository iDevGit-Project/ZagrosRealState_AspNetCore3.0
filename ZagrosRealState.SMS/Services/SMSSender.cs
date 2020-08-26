using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZagrosRealState.SMS.Services
{
    public class SMSSender : ISmsSender
    {
        public async Task<string> SendAuthSmsAsync(string Code, string PhoneNumber)
        {
            HttpClient httpclient = new HttpClient();
            var httpResponse = await httpclient.GetAsync($"https://api.kavenegar.com/v1/2F4264626C6166586176386A6A613569706363414756693946496B712F6B7236474A6A32756D425044416B3D/verify/lookup.json?receptor={PhoneNumber}&token={Code}&template=AuthVerifySMS");
            if (httpResponse.StatusCode == HttpStatusCode.OK)
                return "Success";
            else
                return "Faild";
        }
    }
}
