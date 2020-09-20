using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LearNAV_Engine
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
        /*
		string connectionstring_default = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";
		SQLiteConnection default_cn = new SQLiteConnection(connectionstring_default);
        */

		//SANDBOX MODE
        /*
		string connectionstring_sandbox = "DataSource=" + Environment.CurrentDirectory + "\\SandBoxDB\\SANDBOX_DB_v1.DB;Version=3";
		SQLiteConnection sandbox_mode = new SQLiteConnection(connectionstring_sandbox);
        */



			//Tags Insert
			static SQLiteCommand insert_data_tags;
			//DatabaseValues
			string d_Table = "TagDirectory";
			string d_PrimayTags = "PrimaryTag";
			string d_dAdded = "dAdded";
			string d_dModified = "dModified";
			string d_RelatedTags = "dRelatedTags";
			string d_ResourceWithinTags = "ResourceWithinTags";

		public Boolean is_tags_enabled;
		public string[] tag_list;

		/*
			>Read by Tag
			For each tag, the engine should generate a new string(object) that will hold all tags within it
			1. Read All Available Tags in the database
			2. Take the value of the ID's 

			>Input Tags into the Database:
			1. Get the tags entered in a textbox from the main program
			2. Enter the values into an stirng array variable
			3. Take the value of the string array variable to a Tag Table in the Database
			4. Take the random generated ID number from the system, and place into into the
			   Generated ID column in the database.
			5. 


			
		*/

			static void Separate_Input_Tags(string input_string)
			{
				string[] split_tags = input_string.Split(',');
				foreach (string inv_tags in split_tags) 
				{
					
				}
				//!!MISSING!! : i_dAdded, i_dModified
				// Reference : INSERT INTO TagDirectory (PrimaryTag, dAdded, dModified, RelatedTags, ResourceWithinTags) values ("lol", "ol", "ol", "op", "po")
				string insertTagsCommand = "INSERT INTO {d_Table} ({d_PrimaryTag}, {d_dAdded}, {d_dModified}, {d_RelatedTags}, {d_ResourceWithinTags} values (@i_PrimaryTag, @i_dAdded, @i_dModifed, @i_RelatedTags, @i_ResourceWithinTags)";
			//	insert_data_tags = new SQLiteCommand(insertTagsCommand, sandbox_mode);
			//	sandbox_mode.Open();
					insert_data_tags.Parameters.AddWithValue("@i_PrimaryTag", split_tags[0]);
					//insert_data_tags.Parameters.AddWithValue("@i_PrimaryTag", NULL); //insert date code here


			}

    }
}
