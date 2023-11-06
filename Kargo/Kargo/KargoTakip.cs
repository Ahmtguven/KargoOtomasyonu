using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kargo
{
    public partial class KargoTakip : Form
    {
        public KargoTakip()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccessToPage go = new AccessToPage(); go.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.ShipmentName = textBox2.Text;
            shipment.ShipmentSP= textBox3.Text;
            shipment.ShipmenFP = textBox4.Text;
            shipment.Distance = Convert.ToInt32(textBox5.Text);
            shipment.TotalPrice = Convert.ToDecimal(textBox6.Text);
            shipment.CarNo= Convert.ToInt32(textBox7.Text);
            shipment.CustomerNo= Convert.ToInt32(textBox8.Text);
            shipment.PersonelNo=Convert.ToInt32(textBox9.Text);
            ShipmentCrud.ShipmentDell(shipment);
            dataGridView1.DataSource = ShipmentCrud.ShipmentListe();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Shipment delete = new Shipment();
            delete.ShipmentNo = Convert.ToInt32(textBox1.Text);
            ShipmentCrud.ShipmentDell(delete);
            dataGridView1.DataSource = ShipmentCrud.ShipmentListe();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shipment change = new Shipment();
            change.ShipmentNo = Convert.ToInt32(textBox1.Text);
            change.ShipmentName = textBox2.Text;
            change.ShipmentSP = textBox3.Text;
            change.ShipmenFP = textBox4.Text;
            change.Distance = Convert.ToInt32(textBox5.Text);
            change.TotalPrice = Convert.ToDecimal(textBox6.Text);
            change.CarNo = Convert.ToInt32(textBox7.Text);
            change.CustomerNo = Convert.ToInt32(textBox8.Text);
            change.PersonelNo = Convert.ToInt32(textBox9.Text);
            ShipmentCrud.ShipmentUpdate(change);
            dataGridView1.DataSource = ShipmentCrud.ShipmentListe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }
    }
}
