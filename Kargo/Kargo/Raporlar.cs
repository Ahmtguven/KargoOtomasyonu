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

namespace Kargo
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.NameSurname = textBox1.Text;
            Query.CustomerQueries(customer);
            dataGridView1.DataSource = Query.CustomerQueries(customer); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnels personel = new Personnels();
            personel.NameSurname = textBox1.Text;
            Query.PersonnelQueries(personel);
            dataGridView1.DataSource = Query.PersonnelQueries(personel).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.CarNo = Convert.ToInt32(textBox1.Text);
            Query.CarQueries(car);
            dataGridView1.DataSource = Query.CarQueries(car);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccessToPage go = new AccessToPage(); go.Show(); this.Hide();
        }
    }
}
