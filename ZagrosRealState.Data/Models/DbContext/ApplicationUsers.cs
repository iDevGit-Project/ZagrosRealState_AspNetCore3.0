using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZagrosRealState.Data.Models.Data
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
