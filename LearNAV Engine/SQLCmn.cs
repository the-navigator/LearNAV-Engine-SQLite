using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LearNAV_Engine
{
    public class SQLCmn
    {
    	static string command;
		static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";
    	SQLiteConnection db_commit_connection = new SQLiteConnection(connection_string); //Commit Connection
      SQLiteConnection db_read_connection = new SQLiteConnection(connection_string); //Read Connection
    	SQLiteConnection db_filter_connection = new SQLiteConnection(connection_string); //FILTER FUNCTIONS Conection
    	SQLiteDataAdapter cmn = new SQLiteDataAdapter();
    	public DataTable dt = new DataTable();



    	public void SearchForRecord(string command_string)
    	{
            try
            {

                    command = command_string;
                    cmn = new SQLiteDataAdapter(command, db_read_connection);
                    cmn.Fill(dt);

                } catch (Exception e)
                {

                }



    	}
    }
}
