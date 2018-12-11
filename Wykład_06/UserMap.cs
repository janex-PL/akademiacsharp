using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace Wykład_06
{
    public sealed class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Name).Name("User Name");
            Map(m => m.Surname).Name("User Surname");
        }
    }
}
