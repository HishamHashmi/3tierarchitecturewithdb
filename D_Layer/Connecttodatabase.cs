using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Web;
using System.Data.OleDb;
namespace D_LAYER
{
    public class Connecttodatabase
    {
        private SqlConnection DBConnection;
        private SqlDataAdapter DataAdapter;
        private DataSet ResultSet;
        private SqlCommand QueryCommand;

        public Connecttodatabase()
        { }
        public void ConnectToDB()
        {
            // DBConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Khushal Shah\documents\visual studio 2013\Projects\AppLayer\DataLayer\Database1.mdf;Integrated Security=True");
            DBConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hasnain\source\repos\A_Layer\D_Layer\Database1.mdf;Integrated Security=True");


            DBConnection.Open();

            ResultSet = new DataSet();
        }
        public DataSet ExceuteQuerySet(String Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet, "Std");
            DataAdapter.Dispose();
            return ResultSet;
        }
        public int UpdateQuery(String Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            int Result = QueryCommand.ExecuteNonQuery();
            QueryCommand.Dispose();
            return Result;
        }
        public void CloseConnection()
        {
            DBConnection.Close();
        }
    }
}
