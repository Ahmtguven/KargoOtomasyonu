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
    public class CarsCrud
    {
        public static DataTable CarListe()
        {
            SqlDataAdapter adp = new SqlDataAdapter("CarList", Tools.con);
                 
            adp.SelectCommand.CommandType=System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static bool CarAdd(Cars cars)
        {
            SqlCommand sqlcommand = new SqlCommand("CarAdd", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@CarType", cars.CarType);
            sqlcommand.Parameters.AddWithValue("@CarCapacity", cars.CarCapacity);
            sqlcommand.Parameters.AddWithValue("@CarDriver", cars.CarDriver);
            sqlcommand.Parameters.AddWithValue("@Spending", cars.Spending);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool CarDell(Cars cars)
        {
            SqlCommand sqlcommand = new SqlCommand("CarDell", Tools.con);

            sqlcommand.CommandType=CommandType.StoredProcedure;

            sqlcommand.Parameters.AddWithValue("@CarNo", cars.CarNo);

            return Tools.CoonectSet(sqlcommand);
        }   

        public static bool CarUpdate(Cars cars)
        {
            SqlCommand sqlCommand = new SqlCommand("CarUpdate", Tools.con);
            
            sqlCommand.CommandType=CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("CarNo", cars.CarNo);
            sqlCommand.Parameters.AddWithValue("CarType", cars.CarType);
            sqlCommand.Parameters.AddWithValue("CarCapacity", cars.CarCapacity);
            sqlCommand.Parameters.AddWithValue("CarDriver", cars.CarDriver);
            sqlCommand.Parameters.AddWithValue("Spending", cars.Spending);

            return Tools.CoonectSet(sqlCommand);            
        }
    }
}
