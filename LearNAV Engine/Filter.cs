using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
namespace LearNAV_Engine
{

    public class Filter
    {
      /*
        private OleDbConnection db_cn = new
           OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.14.0; Data Source = " +
           Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
           */
        static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3"; //Datbase is yet to be finished
        SQLiteConnection db_cn = new SQLiteConnection(connection_string);

        SQLiteDataAdapter da;
           public DataTable dt;
      //string table_src = "ResourceDB";

        public void FilterName(string to_filter) 
        {
           db_cn.Open();
           da = new SQLiteDataAdapter("SELECT * FROM ResourceDB WHERE ResourceN like '%" + to_filter + "%'", db_cn);
           da.Fill(dt);
           db_cn.Close();
     
        }

    }
}
