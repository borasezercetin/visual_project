using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Visual_project_homeapplianceshop
{
    public partial class ViewStock : Form
    {

        private readonly string connection = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={Application.StartupPath}\\ProjectDb.accdb";
        public ViewStock()
        {
            InitializeComponent();
        }

        private void showInfo()
        {
            guna2DataGridView1.Rows.Clear();
            using (var con = new OleDbConnection(connection))
            {
                con.Open();
                using (var cmd = new OleDbCommand("SELECT * FROM ProductTbl", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                guna2DataGridView1.Rows.Add(dr["ProdId"],dr["ProdName"], dr["ProdQty"], dr["ProdBrand"], dr["ProdCat"], dr["ProdPrice"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database connection error. Error: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Updating Data
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connection))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE ProductTbl SET ProdName=?, ProdBrand=?,ProdCat=?,ProdQty=?,ProdPrice=? WHERE ProdId=?", con))
                {
                    try
                    {

                        cmd.Parameters.AddWithValue("@ProdName", Urunisimtxt.Text);
                        cmd.Parameters.AddWithValue("@ProdBrand",Markatxt.Text);
                        cmd.Parameters.AddWithValue("@ProdCat", Kategoritxt.Text);
                        cmd.Parameters.AddWithValue("@ProdQty", UrunMiktxt.Text);
                        cmd.Parameters.AddWithValue("@ProdPrice", Fiyattxt.Text);
                        cmd.Parameters.AddWithValue("@ProdId",ProdIdtxt.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Ürün güncellendi");
                            showInfo();
                        }
                        else
                        {
                            MessageBox.Show("Verilen Ürün ismi için eşleşen bir kayıt bulunamadı");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri güncellenemiyor Hata: " + ex.Message);
                    }
                    finally { con.Close(); }
                }
            }
        }


        //Deleting Data
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Urunisimtxt.Text == "")
            {
                MessageBox.Show("Lütfen ürün ismi giriniz");
            }
            else
            {
                using (var con = new OleDbConnection(connection))
                {
                    con.Open();
                    using (var cmd = new OleDbCommand("DELETE FROM ProductTbl WHERE ProdId=@ProdId", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@ProdId", ProdIdtxt.Text);
                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Ürün başarıyla silindi");
                                showInfo();
                            }
                            else
                            {
                                MessageBox.Show("Verilen Ürün ismi için eşleşen bir kayıt bulunamadı");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veri silinemedi Hata: " + ex.Message);
                        }
                        finally
                        {
                            con?.Close();
                        }
                    }
                }
            }
        }



        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            showInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdtxt.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Urunisimtxt.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            UrunMiktxt.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Markatxt.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Kategoritxt.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Fiyattxt.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analiz a = new Analiz();    
            a.Show();
            this.Hide();
        }
    }
}

