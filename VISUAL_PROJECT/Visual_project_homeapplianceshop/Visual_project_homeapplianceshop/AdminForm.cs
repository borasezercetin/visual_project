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
using System.Security.Cryptography;

namespace Visual_project_homeapplianceshop
{
    public partial class AdminForm : Form
    {
        private readonly string connection = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source ={Application.StartupPath}\\ProjectDb.accdb";
        public AdminForm()
        {
            InitializeComponent();
        }


        //Showing Info

        private void showInfo()
        {
            listView1.Items.Clear();
            using(var con  = new OleDbConnection(connection))
            {
                con.Open();
                using(var cmd =  new OleDbCommand("SELECT * FROM admin", con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["AdminId"].ToString();
                                addNew.SubItems.Add(dr["AdminName"].ToString());
                                addNew.SubItems.Add(dr["AdminPass"].ToString());

                                listView1.Items.Add(addNew);
                               
                            }

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error loading data into ListView:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }

        }

        //Inserting Data
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using(var con = new OleDbConnection(connection))
            {
                con.Open() ;
                using(var cmd = new OleDbCommand("INSERT INTO admin(AdminId,AdminName,AdminPass) VALUES(@AdminId,@AdminName,@AdminPass)", con))
                {
                    try
                    {
                        string ID = AdminIdtxt.Text;
                        string NAME = AdminNametxt.Text;    
                        string PASSWORD = Passtxt.Text;

                        string hashedPassword = ComputeHash(PASSWORD);

                        cmd.Parameters.AddWithValue("@AdminId", ID);
                        cmd.Parameters.AddWithValue("@AdminName", NAME);
                        cmd.Parameters.AddWithValue("@AdminPass", hashedPassword);

                        cmd.ExecuteNonQuery();

                        ListViewItem newItem = new ListViewItem(ID);
                        newItem.SubItems.Add(NAME);
                        newItem.SubItems.Add(hashedPassword);

                        MessageBox.Show("Admin successfully added");

                        showInfo();

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Cannot insert data. Error: " + ex.Message);

                    }
                    finally
                    {
                        con.Close() ;
                    }
                }
            }
        }

        private string ComputeHash(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        //Updating Data
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connection))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE admin SET AdminName=?,AdminPass=? WHERE AdminId=?", con))
                {
                    try
                    {
                        string adminName = AdminName.Text;
                        string newPassword = Passtxt.Text;
                        string hashedPassword = ComputeHash(newPassword);

                        cmd.Parameters.AddWithValue("@AdminName", adminName);
                        cmd.Parameters.AddWithValue("@AdminPass", hashedPassword);  
                        cmd.Parameters.AddWithValue("@AdminId", AdminId.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Admin updated successfully");
                            showInfo();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot update data. Error: " + ex.Message);
                    }
                    finally { con.Close(); }
                }
            }
        }



        //Deleting Data
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(AdminIdtxt.Text == "")
            {
                MessageBox.Show("Please enter admin Id");
            }
            else
            {
                using(var con = new OleDbConnection(connection))
                {
                    con.Open() ;
                    using(var cmd = new OleDbCommand("DELETE FROM admin WHERE AdminId=@AdminId", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@AdminId",AdminIdtxt.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin successfully deleted");
                                showInfo();
                            }
                            else
                            {
                                MessageBox.Show("No matching record found with the provided Doctor Id");
                            }

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Cannot delete data. Error: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            showInfo(); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedPassword = listView1.SelectedItems[0].SubItems[2].Text;

                AdminIdtxt.Text = selectedId;
                AdminNametxt.Text = selectedName;   
                Passtxt.Text = selectedPassword;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
