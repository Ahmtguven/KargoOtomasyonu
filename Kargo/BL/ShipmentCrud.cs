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
    public class ShipmentCrud
    {
        public static DataTable ShipmentListe()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ShipmentList", Tools.con);

            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static bool ShipmentAdd(Shipment shipment)
        {
            SqlCommand sqlcommand = new SqlCommand("ShipmentAdd", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;

            sqlcommand.Parameters.AddWithValue("@SipmentName", shipment.ShipmentName);
            sqlcommand.Parameters.AddWithValue("@ShipmentSP", shipment.ShipmentSP);
            sqlcommand.Parameters.AddWithValue("@ShipmentFP", shipment.ShipmenFP);
            sqlcommand.Parameters.AddWithValue("@Distance", shipment.Distance);
            sqlcommand.Parameters.AddWithValue("@TotalPrice", shipment.TotalPrice);
            sqlcommand.Parameters.AddWithValue("@CarNo", shipment.CarNo);
            sqlcommand.Parameters.AddWithValue("@CustomerNo", shipment.CustomerNo);
            sqlcommand.Parameters.AddWithValue("@PersonelNo", shipment.PersonelNo);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool ShipmentDell(Shipment shipment)
        {
            SqlCommand sqlcommand = new SqlCommand("Shipmen", Tools.con);

            sqlcommand.CommandType = CommandType.StoredProcedure;

            sqlcommand.Parameters.AddWithValue("@shipmentNo",shipment.ShipmentNo);

            return Tools.CoonectSet(sqlcommand);
        }

        public static bool ShipmentUpdate(Shipment shipment)
        {
            SqlCommand sqlCommand = new SqlCommand("ShipmentUpdate", Tools.con);

            sqlCommand.CommandType= CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@ShipmentNo", shipment.ShipmentNo);
            sqlCommand.Parameters.AddWithValue("@Shipmentname", shipment.ShipmentName);
            sqlCommand.Parameters.AddWithValue("@ShipmentSP", shipment.ShipmentSP);
            sqlCommand.Parameters.AddWithValue("@ShipmentFP", shipment.ShipmenFP);
            sqlCommand.Parameters.AddWithValue("@Distance", shipment.Distance);
            sqlCommand.Parameters.AddWithValue("@TotalPrice", shipment.TotalPrice);
            sqlCommand.Parameters.AddWithValue("@CarNo", shipment.CarNo);
            sqlCommand.Parameters.AddWithValue("@CustomerNo", shipment.CustomerNo);
            sqlCommand.Parameters.AddWithValue("@PersonnelNo", shipment.PersonelNo);

            return Tools.CoonectSet(sqlCommand);
        }
    }
}
