using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;



namespace LearNAV_Engine
{
    
  public class LoadData
    {
        static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3"; //Datbase is yet to be finished
     public SQLiteConnection db_cn =new SQLiteConnection(connection_string);
      private SQLiteDataAdapter da = new SQLiteDataAdapter();
      public DataTable dt = new DataTable();
      //Data to return to main application
      public string username_return;
      public string password_return;
      //Data to input in datatable for query
    public  bool log_in_case;
    public string error_message;
      public int rowcount;


      
      public void CheckUserProfile(string username_query, string password_query)
      {
          db_cn.Open();
          try
          {



              try
              {
                  da = new SQLiteDataAdapter("SELECT * FROM ProfileDBSt where FirstN= '" + username_query +
                      "' AND LRN= '" + password_query + "'", db_cn);
                  da.Fill(dt);
                  rowcount = dt.Rows.Count;

                  if (rowcount >= 1)
                  {
                      log_in_case = true;
                  }
                  else
                      log_in_case = false;

                  db_cn.Close();
              }
              catch (Exception e)
              {

              }
          }
          catch (Exception e)
          {

          }
         

        
          
              
          
             

          }
           
      }


    }

