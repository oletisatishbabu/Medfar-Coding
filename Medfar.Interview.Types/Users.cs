using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medfar.Interview.Types
{
    public class Users : ResponseBaseModel
    {
        public IEnumerable<User> UsersList { get; set; }
        public int TotalRecordsCount { get; set; }
    } 
}
