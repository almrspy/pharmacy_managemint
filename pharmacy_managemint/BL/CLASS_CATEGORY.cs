using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using pharmacy_managemint.DAL;
namespace pharmacy_managemint.BL
{
    class CLASS_CATEGORY
    {
        public static int SP_ADDNEWCATEGORY(string CAT_NAME)
        {
            DataAccessLayer.Open();
            int COUNT = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWCATEGORY", CommandType.StoredProcedure,
              DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar, CAT_NAME));
            DataAccessLayer.Close();
            return COUNT;
        }
        public static DataTable SP_SELECTALLCATEGGORIES()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLCATEGORY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_SEARCHCATEGORIES(String SEARCH)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SEARCHCATEGORY", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.Close();
            return DT;
        }
    }
}
