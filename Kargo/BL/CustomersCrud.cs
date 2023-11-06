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
    public class CustomersCrud
    {
        public static DataTable CustomerList()
        {
            SqlDataAdapter adp = new SqlDataAdapter("CustomerList", Tools.con);
            
            adp.SelectCommand.CommandType= System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static bool CustomerAdd(Customers customer)
        {
            SqlCommand sqlcommand = new SqlCommand("CustomerAdd", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@NameSurname", customer.NameSurname);
            sqlcommand.Parameters.AddWithValue("@Adress", customer.Adress);
            sqlcommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlcommand.Parameters.AddWithValue("@Mail", customer.Mail);
            sqlcommand.Parameters.AddWithValue("@Payment", customer.Payment);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool CustomerDell(Customers customer)
        {
            SqlCommand sqlcommand = new SqlCommand("CustomerDell", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;

            sqlcommand.Parameters.AddWithValue("@CustomerNo", customer.CustomerNo);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool CustomerUpdate(Customers customer)
        {
            SqlCommand sqlCommand = new SqlCommand("CustomerUpdate", Tools.con);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            
            sqlCommand.Parameters.AddWithValue("@CustomerNo", customer.CustomerNo);
            sqlCommand.Parameters.AddWithValue("@NameSurname", customer.NameSurname);
            sqlCommand.Parameters.AddWithValue("@Adress", customer.Adress);
            sqlCommand.Parameters.AddWithValue("Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("Mail", customer.Mail);
            sqlCommand.Parameters.AddWithValue("Payment",customer.Payment);

            return Tools.CoonectSet(sqlCommand);
        }
    }
}
