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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visual_project_homeapplianceshop
{
    public partial class Selling : Form
    {
        private readonly string connection = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={Application.StartupPath}\\ProjectDb.accdb";
        public Selling()
        {
            InitializeComponent();
        }
        private void ShowInfo()
        {
            listView1.Items.Clear();
            using(var con  = new OleDbConnection(connection))
            {
                con.Open();
                using(var cmd =  new OleDbCommand("SELECT * FROM Billtbl", con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["BillId"].ToString();
                                addNew.SubItems.Add(dr["ProdNameS"].ToString());
                                addNew.SubItems.Add(dr["ProdPriceS"].ToString());
                                addNew.SubItems.Add(dr["ProdQtyS"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch(Exception ex)
                        {

                            MessageBox.Show("Database cannot connect. Error:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connection))
            {
                con.Open();
                using (var cmd = new OleDbCommand("INSERT INTO BillTbl(ProdNameS,ProdPriceS,ProdQtyS) VALUES(@ProdNameS,@ProdPriceS,@ProdQtyS)", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ProdNameS", Uruntxt.Text);
                        cmd.Parameters.AddWithValue("@ProdPriceS", fiyattxt.Text);
                        cmd.Parameters.AddWithValue("@ProdQtyS", miktartxt.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("faturaya Başarıyla Eklendi");

                        ShowInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün Eklenemedi! Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedPrice = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedQty = listView1.SelectedItems[0].SubItems[3].Text;

                BillId.Text = selectedId;
                Uruntxt.Text = selectedName;
                fiyattxt.Text = selectedPrice;  
                miktartxt.Text = selectedQty;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Analiz a = new Analiz();
            a.Show();
            this.Hide();
        }
    }
}
