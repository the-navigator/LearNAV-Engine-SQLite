using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace LearNAV_Engine
{
    public class EG_SELECT_DATABASE
    {
        public static string LibreDB_Path;
        public static string LibreDB_Name;
        public static string LibreDB_Version;   
        public static string LibreDB_Database;  


        public void EG_SEL_Func_LibreDB_Ini (string Application_Input )
        {
            LibreDB_Path = Application_Input;
            EG_DICTIONARY.DatabasePath = LibreDB_Path;
            
        }
    }
}
