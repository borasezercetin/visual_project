using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_project_homeapplianceshop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddProduct p = new AddProduct();    
            p.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewStock stock = new ViewStock();
            stock.Show();   
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login l = new Login();  
            l.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AdminForm adminpanel = new AdminForm();
            adminpanel.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Selling billcrate = new Selling();
            billcrate.Show();
            this.Hide();
        }
    }
}
