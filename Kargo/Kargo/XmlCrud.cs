using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Kargo
{
    public partial class XmlCrud : Form
    {
        public XmlCrud()
        {
            InitializeComponent();
        }

        void Listele()
        {
            XmlDocument carlist = new XmlDocument();
            DataSet dt = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"xmlCarCrud.xml", new XmlReaderSettings());
            dt.ReadXml(xmlfile);
            dataGridView1.DataSource = dt.Tables[0];
            xmlfile.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument ekle = XDocument.Load(@"xmlCarCrud.xml");
            ekle.Element("cars").Add(new XElement("car", new XElement("CarNo", textBox1.Text), new XElement("CarType", textBox2.Text), new XElement("CarCapacity", textBox3.Text), new XElement("CarDriver", textBox4.Text), new XElement("Spending", textBox5.Text)));
            ekle.Save(@"xmlCarCrud.xml");
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument duzenle = XDocument.Load(@"xmlCarCrud.xml");
            XElement node = duzenle.Element("cars").Elements("car").FirstOrDefault(a => a.Element("CarNo").Value == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("CarType", textBox2.Text);
                node.SetElementValue("CarCapacity", textBox3.Text);
                node.SetElementValue("CarDriver", textBox4.Text);
                node.SetElementValue("Spending", textBox5.Text);
                duzenle.Save(@"xmlCarCrud.xml");
                Listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument sil = XDocument.Load(@"xmlCarCrud.xml");
            sil.Root.Elements().Where(a => a.Element("CarNo").Value == textBox1.Text).Remove();
            sil.Save(@"xmlCarCrud.xml");
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["CarNo"].Value.ToString();
            textBox2.Text = satir.Cells["CarType"].Value.ToString();
            textBox3.Text = satir.Cells["CarCapacity"].Value.ToString();
            textBox4.Text = satir.Cells["CarDriver"].Value.ToString();
            textBox5.Text = satir.Cells["Spending"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
