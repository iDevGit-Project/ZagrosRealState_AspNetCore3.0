using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZagrosRealState.SMS.Services
{
    public interface ISmsSender
    {
        Task<string> SendAuthSmsAsync(string Code, string PhoneNumber);
    }
}
