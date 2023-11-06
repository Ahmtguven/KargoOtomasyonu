using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BL
{
    public class PersonnelsCrud
    {
        public static DataTable PersonnelList()
        {
            SqlDataAdapter adp = new SqlDataAdapter("PersonnelList", Tools.con);

            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool PersonnelAdd(Personnels personnel)
        {
            SqlCommand sqlcommand = new SqlCommand("PersonnelAdd", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@NameSurname", personnel.NameSurname);
            sqlcommand.Parameters.AddWithValue("@Task", personnel.Task);
            sqlcommand.Parameters.AddWithValue("@Caption", personnel.Caption);
            sqlcommand.Parameters.AddWithValue("@Phone", personnel.Phone);
            sqlcommand.Parameters.AddWithValue("@Salary", personnel.Salary);
            sqlcommand.Parameters.AddWithValue("@CarNo", personnel.CarNo);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool PersonnelDell(Personnels personnel)
        {
            SqlCommand sqlcommand = new SqlCommand("PesonnelDell", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;

            sqlcommand.Parameters.AddWithValue("@PersonnelNo", personnel.PersonnelNo);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool PersonnelUpdate(Personnels personnel)
        {
            SqlCommand sqlCommand = new SqlCommand("PersonnelUpdate", Tools.con);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@PersonnelNo", personnel.PersonnelNo);
            sqlCommand.Parameters.AddWithValue("@NameSurname", personnel.NameSurname);
            sqlCommand.Parameters.AddWithValue("@Task", personnel.Task);
            sqlCommand.Parameters.AddWithValue("@Caption", personnel.Caption);
            sqlCommand.Parameters.AddWithValue("@Phone", personnel.Phone);
            sqlCommand.Parameters.AddWithValue("@Salary", personnel.Salary);
            sqlCommand.Parameters.AddWithValue("@CarNo", personnel.CarNo);

            return Tools.CoonectSet(sqlCommand);
        }
    }
}
