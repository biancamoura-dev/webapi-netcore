using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi_netcore.Models
{
    public class BiancaModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
