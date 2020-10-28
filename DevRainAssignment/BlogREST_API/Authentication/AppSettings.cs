using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API
{
    public class AppSettings
    {
        public string Secret { get; set; } = "mysupersecret_secretkey!123"; // encryption key
    }
}
