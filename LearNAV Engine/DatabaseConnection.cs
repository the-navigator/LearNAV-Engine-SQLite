using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace LearNAV_Engine
{
    public class DatabaseConnection
    {
        static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3"; //Datbase is yet to be finished
        static string connection_string_test = "DataSource=" + EG_DICTIONARY.DatabasePath;
        
        SQLiteConnection db_cn = new SQLiteConnection(connection_string);
        SQLiteCommand list_Con = new SQLiteCommand();
        SQLiteCommand comn = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        public DataTable dt = new DataTable();


        //VARIABLES
        /*
        
        SQLiteCommand da;
        SQLiteDataAdapter dataAdapter;
        public DataTable dt;
        */
        //DATABASE VARIABLES
        string table_src = "ResourceDB";

         //command
           string selectQuery = ("SELECT * FROM {table_src}");
        // Variables to show for ListView Items

        public int rowcount;
       
       public void ShowFiltered()
       {
           
               db_cn.Open();
               da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB]", db_cn);
              // da = new SQLiteCommand(selectQuery, comn);
       
           /*
               SQLiteDataAdapter = new SQLiteDataAdapter(da);
               DataTable dt = new DataTable();
           */

               da.Fill(dt);
               rowcount = dt.Rows.Count;
               db_cn.Close();
           

       }

      


            
        }
    }

