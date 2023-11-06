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
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnels add = new Personnels();
            add.NameSurname = textBox2.Text;
            add.Task = textBox3.Text;
            add.Caption = textBox4.Text;
            add.Phone = textBox5.Text;
            add.Salary = Convert.ToDecimal(textBox6.Text);
            add.CarNo = Convert.ToInt32(textBox7.Text);
            PersonnelsCrud.PersonnelAdd(add);
            dataGridView1.DataSource = PersonnelsCrud.PersonnelList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personnels dell = new Personnels();
            dell.PersonnelNo = Convert.ToInt32(textBox1.Text);
            PersonnelsCrud.PersonnelDell(dell);
            dataGridView1.DataSource= PersonnelsCrud.PersonnelList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personnels update = new Personnels();
            update.PersonnelNo= Convert.ToInt32(textBox1.Text);
            update.NameSurname = textBox2.Text;
            update.Task = textBox3.Text;
            update.Caption = textBox4.Text;
            update.Phone = textBox5.Text;
            update.Salary = Convert.ToDecimal(textBox6.Text);
            update.CarNo = Convert.ToInt32(textBox7.Text);
            PersonnelsCrud.PersonnelUpdate(update);
            dataGridView1.DataSource=PersonnelsCrud.PersonnelList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar(); go.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccessToPage go = new AccessToPage(); go.Show(); this.Hide();
        }
    }
}
