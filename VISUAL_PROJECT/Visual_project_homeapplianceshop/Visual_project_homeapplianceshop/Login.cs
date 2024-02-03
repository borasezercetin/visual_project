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
    public partial class Login : Form
    {
        private readonly string connection = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\ProjectDb.accdb";
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Nametxt.Text == "" || Passtxt.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz");
            }
            else
            {
                using(var con = new OleDbConnection(connection))
                {
                    con.Open();
                    string sql = "SELECT AdminPass FROM admin WHERE AdminName=@AdminName";
                    using(var cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@AdminName",Nametxt.Text);

                        object hashedPassword = cmd.ExecuteScalar();

                        if(hashedPassword != null)
                        {
                            string enteredPasswordHash = ComputeHash(Passtxt.Text);
                            if (enteredPasswordHash == hashedPassword.ToString())
                            {
                                MessageBox.Show("Giriş Başarılı");

                                MainForm form = new MainForm();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz kullanıcı adı veya şifre girdiniz");
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre girdiniz");
                            con.Close();
                        }
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

        private void label3_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passtxt.Text = "";
        }
    }
}
