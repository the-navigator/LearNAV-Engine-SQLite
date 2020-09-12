using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LearNAV Engine
{
    public class TagSystem
    {
		/*
							TAG SYSTEM
				Tag System Enables Users to obtain a clear 
				relationship between each tags acting as
				identifiers to individual resources 
				linking them as a group.

				NEXT BIG THING. LOLZ idk
		*/

		//VARIABLES
				public int mode;
				/*
				Mode:
				0 - Default Mode
				1 - Sandbox Mode
				*/
		//SQLite Connections

		//DEFAULT MODE
		connectionstring = ""DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";"
		SQLiteConnection default = new SQLiteConnection(connection_string_default);


		//SANDBOX MODE
		connectionstring = ""DataSource=" + Environment.CurrentDirectory + "\\SANDBOX\\LEARNAV.DB;Version=3";"
		SQLiteConnection sandbox_mode = new SQLiteConnection(connection_string_sandbox);

		public Boolean is_tags_enabled;
		public string[] tag_list;

    }
}