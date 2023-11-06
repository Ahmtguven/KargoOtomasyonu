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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customers add = new Customers();
            add.NameSurname = textBox2.Text;
            add.Adress= richTextBox1.Text;
            add.Phone= textBox3.Text;
            add.Mail= textBox4.Text;
            add.Payment = Convert.ToDecimal(textBox5);
            CustomersCrud.CustomerAdd(add);
            dataGridView1.DataSource = CustomersCrud.CustomerList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Customers dell = new Customers();
            dell.CustomerNo = Convert.ToInt32(textBox1.Text);
            CustomersCrud.CustomerDell(dell);
            dataGridView1.DataSource = CustomersCrud.CustomerList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers update = new Customers();
            update.CustomerNo = Convert.ToInt32(textBox1.Text);
            update.NameSurname = textBox2.Text;
            update.Adress = richTextBox1.Text;
            update.Phone = textBox3.Text;
            update.Mail = textBox4.Text;
            update.Payment = Convert.ToDecimal(textBox5);
            CustomersCrud.CustomerUpdate(update);
            dataGridView1.DataSource = CustomersCrud.CustomerList();
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

    }
}
