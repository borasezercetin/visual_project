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
using System.Windows.Forms.DataVisualization.Charting;

namespace Visual_project_homeapplianceshop
{
    public partial class Analiz : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\ProjectDb.accdb";
        public Analiz()
        {
            InitializeComponent();
        }

        private void showInfo()
        {
            listView1.Items.Clear();
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("SELECT ProdNameS FROM BillTbl", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {

                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["ProdNameS"].ToString();
                                


                                listView1.Items.Add(addNew);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veritabanı bağlanamadı. Hata:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        //Analiz
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisX.Title = "Miktar";  

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand("SELECT ProdNameS, COUNT(*) AS ProductNameCount FROM BillTbl GROUP BY ProdNameS", con))
                    {
                        using (OleDbDataReader read = cmd.ExecuteReader())
                        {
                            // Define colour palette
                            chart1.Palette = ChartColorPalette.BrightPastel;

                            while (read.Read())
                            {
                                string productname = read["ProdNameS"].ToString();
                                int ProductNameCount = Convert.ToInt32(read["ProductNameCount"]);

                                // Create Column series
                                Series series = new Series(productname);
                                series.ChartType = SeriesChartType.Column;

                                // Set a unique color for each series
                                series.Points.AddXY(productname, ProductNameCount);

                                // Insert chart series
                                chart1.Series.Add(series);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlanma hatası: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Analiz_Load(object sender, EventArgs e)
        {
            showInfo();
        }
    }
}
