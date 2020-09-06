﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LearNAV_Engine
{

   public class AdvanceSearching
    {

        static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3"; //Datbase is yet to be finished
        SQLiteConnection db_cn = new SQLiteConnection(connection_string);
       SQLiteDataAdapter da = new SQLiteDataAdapter();
    public DataTable dt = new DataTable();
    public DataTable dt2 = new DataTable();

        public void grade_level_search(string glvl, string what_to, string search_what)
        {
            switch (what_to)
            {
                case "ID":
                    da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] WHERE [GradeLevel]= '" + glvl + "'", db_cn);
                    da.Fill(dt);
                    using (dt)
                    {
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = "ID like '%" + search_what  + "&'";
                        dt2 = dv.ToTable();
                    }
                    break;
                case "Author":
                    da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] WHERE [GradeLevel]= '" + glvl + "'", db_cn);
                    da.Fill(dt);
                    using (dt)
                    {
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = "Author like '%" + search_what + "&'";
                        dt2 = dv.ToTable();
                    }
                    break;
                case "Tags":
                    da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] WHERE [GradeLevel]= '" + glvl + "'", db_cn);
                    da.Fill(dt);
                    using (dt)
                    {
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = "[w_tags] like '%" + search_what + "&'";
                        dt2 = dv.ToTable();
                    }
                    break;
            }
          
        }

        public void perform_search(string search_type, string search_string, string grade_level)
        {
            db_cn.Open();
            if (grade_level == "")
            {
                switch (search_type)
                {
                    case "ID":
                        da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] where ID like '%" + search_string + "%'", db_cn);
                        da.Fill(dt);
                        break;
                    case "Author":
                          da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] where Author like '%" + search_string + "%'", db_cn);
                        da.Fill(dt);
                        break;
                    case "Tags":
                        da = new SQLiteDataAdapter("SELECT * FROM [ResourceDB] where [w_tags] like '%" + search_string + "%'", db_cn);
                        da.Fill(dt);
                        break;
                }
            }
            else
            {
                switch (grade_level)
                {
                    case "G7":
                        grade_level_search("Grade 7", search_type, search_string);
                        break;

                       
                    case "G8":
                         grade_level_search("Grade 8", search_type, search_string);
                        break;

                    case "G9":
                        grade_level_search("Grade 9", search_type, search_string);
                        break;

                    case "G10":
                        grade_level_search("Grade 10", search_type, search_string);
                        break;

                }
            }
        }


    }
}
