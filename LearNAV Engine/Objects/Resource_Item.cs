using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SQLite;


namespace LearNAV_Engine
{
    public class Resource_Item
    {
      public int Resource_ID;
      public string Resource_Name;
      public string Resource_Author;
      public string Resource_Loc;
      public string[] Resource_Tags;

      public Resource_Item(int r_id, string r_name, string r_auth, string r_loc, string[] r_tags)
      {
          Resource_ID = r_id;
          Resource_Name = r_name;
          Resource_Author = r_auth;
          Resource_Loc = r_loc;
          Resource_Tags = r_tags;

      }

      public static string Object_Info
      {

      }

  
    }
}

