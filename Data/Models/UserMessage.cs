using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee.Data.Models
{
    public class UserMessage
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public bool CurrentUser { get; set; }
        public DateTime DateSent { get; set; }
    }
}
