using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace D_LAYER
{
    public class data_handler
    {
        public string datasave(string n, int a)
        {
            querybuilder qb = new querybuilder();
            string query = qb.myquery(n, a);
            Connecttodatabase con = new Connecttodatabase();
            con.ConnectToDB();
            con.UpdateQuery(query);
            con.CloseConnection();
            return "DATA SAVED";
        }
    }
}
