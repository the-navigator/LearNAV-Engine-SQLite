using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace LearNAV_Engine
{
	/*
										SANDBOX MODE
								Sandbox Mode is Created to facilitate
								and allow clients to embed their
								own files/resources within learnav.

								As of now, there is no security protocol
								for checking the files.

				KNOWN VARIABLES:						Assignment in this Library
		0.	ID(AutoIncrement Integer) 							rsc_id
		1.	ResourceName(string)								rsc_name
		2.	ResourceLocation(string)							rsc_loc
		3.	ResourceExtension(string)							rsc_ext
		4.	RAuthor(string)										rsc_auth
		5. 	DateAdded(string)									rsc_dte_ad
		6.	Tags(string)										rsc_tags
		7.	ActualFile(BLOB)									rsc_BLOB

	*/

   public class SANDBOX_DB
    {
    	//VARIABLES//**********************************************************************************************
    	
    	//ORIGINS
       /*
    	 string connectionstring = "DataSource=" + Environment.CurrentDirectory + "\\SandBoxDB\\SANDBOX_DB_v1.DB;Version=3";
    	SQLiteConnection db_commit_connection = new SQLiteConnection(connectionstring); //Commit Connection
    	SQLiteConnection db_read_connection = new SQLiteConnection(connectionstring); //Read Connection
    	SQLiteConnection db_filter_connection = new SQLiteConnection(connectionstring); //FILTER FUNCTIONS Conection
		*/
		//QueryVariables
    	SQLiteCommand insert_func = new SQLiteCommand(); //Insert Command
    	SQLiteCommand read_tbl = new SQLiteCommand (); //Read Command - MULTI-PUPOSE
    	// Used for both reading all data and filter

    	
    	//DatabaseValues
    	public string rsc_name;
    	public string rsc_loc;
    	public string rsc_ext; 
    	public string rsc_auth; 
    	public string rsc_dte_ad; 
    	public string rsctags;
    	public int rsc_file_size;

    	//Binary Reader
    	public FileStream SandBox_FileStream;

    	//Individual Functions Variables
    	//READ DATABASE
    	public DataTable SANDBOX_dt;
    	SQLiteDataAdapter SANDBOX_da;

    	//QUICKSEARCH
    	

    	//COMMANDS
    	const string insertQuery = "INSERT INTO SandBox_Storage(ResourceName, ResourceLocation , ResourceExtension , RAuthor , DateAdded , Tags , ActualFile, FileSize ) VALUES (@Rname,@Rloc,@RExt,@RAuthor,@DateAd,@Tags,@BLOBdata,@BLOBFileSize);";
    	string GeneralreadQuery = "SELECT * FROM (SandBox_Storage)";

    	//VARIABLES//**********************************************************************************************
		/*
    	FUNCTION - ENTER_DATA
    	Enters Data to Database According to User
    	//issues: Add MD5 Checking of Files Added to safecheck them for potential Malware/Exploit Files
    	*/
       /*
    	public void CommitData()
    	{
    		//FileStream
    		SandBox_FileStream = new FileStream(rsc_loc, FileMode.Open, FileAccess.Read());
    		BinaryReader Sandbox_BinRdr = new BinaryReader(SandBox_FileStream);
    		rsc_file_size = Convert.ToInt32(SandBox_FileStream.Length);
    		byte[] SandBox_Byte_BLOB = Sandbox_BinRdr.ReadBytes(rsc_file_size);

    		//Query Function
    		insert_func  = new SQLiteCommand(insertQuery, db_commit_connection);
    		db_commit_connection.Open();
    			insert_func.Parameters.AddWithValue("@Rname", (rsc_name));
    			insert_func.Parameters.AddWithValue("@Rloc", (rsc_loc));
    			insert_func.Parameters.AddWithValue("@RExt", (rsc_ext));
    			insert_func.Parameters.AddWithValue("@RAuthor", (rsc_auth));
    			insert_func.Parameters.AddWithValue("@DateAd", (rsc_dte_ad));
    			insert_func.Parameters.AddWithValue("@Tags", (rsc_tags));
    			insert_func.Parameters.AddWithValue("@BLOBdata", SandBox_Byte_BLOB);	
    			insert_func.Parameters.AddWithValue("@BLOBFileSize", (rsc_f));
    		insert_func.ExecuteNonQuery();
			db_commit_connection.Close();

    	}

    	public void ReadData()
    	{
    		db_read_connection.Open();
    		SANDBOX_da = new SQLiteDataAdapter(GeneralreadQuery);
    		SANDBOX_da.Fill(SANDBOX_dt);
    		db_read_connection.Close();
    	}

    	/*
    	FUNCTION - FILTERS
    	*/
       /*
    	public void QuickSearchName(string search_item)
    	{
    		//db_read_connection.Open();
    		SANDBOX_da = new SQLiteDataAdapter("SELECT * FROM (SandBox_Storage) WHERE ResourceName LIKE '%" + 
    		//	search_item + "%'", db_filter_connection);
    		SANDBOX_da.Fill(SANDBOX_dt);
    	}
		/*
    	FUNCTION - ADVANCE FILTERS
    	*/
    	
    }

}