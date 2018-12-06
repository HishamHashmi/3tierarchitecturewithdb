using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER
{
    class querybuilder
    {
        public string myquery(string n, int a)
        {
            string query = "insert into Std(Name, Age)values('" + n + "'," + a + ")";
            return query;
        }
    }
}
