using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using DAL;

namespace Kargo
{
    public partial class xmlRaporları : Form
    {
        public xmlRaporları()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server =AHMET\\SQLKODLAB ;Database=Kargo ;Integrated Security=true;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Cars");

            

            SqlCommand command = new SqlCommand("select * from Cars", con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                XmlElement car = xmlDocument.CreateElement("Arac Bilgileri");

                XmlAttribute type = xmlDocument.CreateAttribute("CarType");
                type.Value = reader["CarType"].ToString();

                XmlAttribute capacity = xmlDocument.CreateAttribute("CarCapacity");
                capacity.Value = reader["CarCapacity"].ToString();

                XmlAttribute spending = xmlDocument.CreateAttribute("Spending");
                spending.Value = reader["Spending"].ToString();

                car.Attributes.Append(type);
                car.Attributes.Append(capacity);
                car.Attributes.Append(spending);
                root.AppendChild(car);
            }
            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("CarsVeri.xml");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Customers");



            SqlCommand command = new SqlCommand("select * from Customers", con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                XmlElement customer = xmlDocument.CreateElement("Müşteri Bilgileri");

                XmlAttribute namesurname = xmlDocument.CreateAttribute("NameSurname");
                namesurname.Value = reader["NameSurname"].ToString();

                XmlAttribute adress = xmlDocument.CreateAttribute("Adress");
                adress.Value = reader["Adress"].ToString();

                XmlAttribute spending = xmlDocument.CreateAttribute("Payment");
                spending.Value = reader["Payment"].ToString();

                customer.Attributes.Append(namesurname);
                customer.Attributes.Append(adress);
                customer.Attributes.Append(spending);
                root.AppendChild(customer);
            }
            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("CustomerVeri.xml");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Personnels");

            SqlCommand command = new SqlCommand("select * from Personnels", con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                XmlElement Personnel = xmlDocument.CreateElement("Personel Bilgileri");

                XmlAttribute namesurname = xmlDocument.CreateAttribute("NameSurname");
                namesurname.Value = reader["NameSurname"].ToString();

                XmlAttribute task = xmlDocument.CreateAttribute("Task");
                task.Value = reader["Task"].ToString();

                XmlAttribute caption = xmlDocument.CreateAttribute("Caption");
                caption.Value = reader["Caption"].ToString();

                Personnel.Attributes.Append(namesurname);
                Personnel.Attributes.Append(task);
                Personnel.Attributes.Append(caption);
                root.AppendChild(Personnel);
            }
            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("PersonnelVeri.xml");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Shipment");

            SqlCommand command = new SqlCommand("select * from Shipment", con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                XmlElement Shipment = xmlDocument.CreateElement("Kargo Bilgileri");

                XmlAttribute name = xmlDocument.CreateAttribute("ShipmentName");
                name.Value = reader["ShipmentName"].ToString();

                XmlAttribute cıkıs = xmlDocument.CreateAttribute("ShipmentSP");
                cıkıs.Value = reader["ShipmentSP"].ToString();

                XmlAttribute varis = xmlDocument.CreateAttribute("SipmentFP");
                varis.Value = reader["ShipmentFP"].ToString();

                XmlAttribute mesafe = xmlDocument.CreateAttribute("Distance");
                mesafe.Value = reader["Distance"].ToString();

                Shipment.Attributes.Append(name);
                Shipment.Attributes.Append(cıkıs);
                Shipment.Attributes.Append(varis);
                Shipment.Attributes.Append(mesafe);
                root.AppendChild(Shipment);
            }
            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("ShipmentVeri.xml");
        }
    }
}
