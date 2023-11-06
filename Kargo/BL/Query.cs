using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BL
{
    public class Query
    {
        public static bool CustomerQueries(Customers customers)
        {
            SqlCommand customer = new SqlCommand("CustomerQuery",Tools.con);
            customer.CommandType = CommandType.StoredProcedure;
            customer.Parameters.AddWithValue("@NameSurname", customers.NameSurname);
            return Tools.CoonectSet(customer);  
        }

        public static bool CarQueries(Cars cars)
        {
            SqlCommand car = new SqlCommand("CarQuery", Tools.con);
            car.CommandType = CommandType.StoredProcedure;
            car.Parameters.AddWithValue("@CarNo", cars.CarNo);
            return Tools.CoonectSet(car);
        }

        public static bool PersonnelQueries(Personnels personnels)
        {
            SqlCommand personel = new SqlCommand("PersonelNo",Tools.con);
            personel.CommandType = CommandType.StoredProcedure;
            personel.Parameters.AddWithValue("@PersonelNo", personnels.PersonnelNo);
            return Tools.CoonectSet(personel);
        }
    }
}
