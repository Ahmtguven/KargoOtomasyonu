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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars add = new Cars();
            add.CarType = textBox2.Text;
            add.CarCapacity = Convert.ToInt32(textBox3.Text);
            add.CarDriver= textBox4.Text;
            add.Spending = Convert.ToDecimal(textBox5.Text);
            CarsCrud.CarAdd(add);
            dataGridView1.DataSource = CarsCrud.CarListe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars dell = new Cars();
            dell.CarNo = Convert.ToInt32(textBox1.Text);
            CarsCrud.CarDell(dell);
            dataGridView1.DataSource = CarsCrud.CarListe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cars update = new Cars();
            update.CarNo = Convert.ToInt32(textBox1.Text);
            update.CarType = textBox2.Text;
            update.CarCapacity = Convert.ToInt32(textBox3.Text);
            update.CarDriver = textBox4.Text;
            update.Spending = Convert.ToDecimal(textBox5.Text);
            CarsCrud.CarUpdate(update);
            dataGridView1.DataSource = CarsCrud.CarListe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccessToPage go = new AccessToPage(); go.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlCrud go = new XmlCrud(); go.Show(); this.Hide();
        }
    }
}
