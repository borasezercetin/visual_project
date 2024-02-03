using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_project_homeapplianceshop
{
    public partial class AddProduct : Form
    {
        private readonly string connection = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={Application.StartupPath}\\ProjectDb.accdb";

        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new OleDbConnection(connection))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (var cmd = new OleDbCommand("INSERT INTO ProductTbl(ProdName, ProdBrand, ProdCat, ProdQty, ProdPrice) VALUES (@ProdName, @ProdBrand, @ProdCat, @ProdQty, @ProdPrice)", conn))
                    {


                        cmd.Parameters.AddWithValue("@ProdName", ProdNametxt.Text);
                        cmd.Parameters.AddWithValue("@ProdBrand", BrandCbtxt.Text);
                        cmd.Parameters.AddWithValue("@ProdCat", CategoryCbtxt.Text);
                        cmd.Parameters.AddWithValue("@ProdQty", ProdQtytxt.Text);
                        cmd.Parameters.AddWithValue("@ProdPrice", PriceTbtxt.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün Başarıyla Eklendi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün Eklenemedi! Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}