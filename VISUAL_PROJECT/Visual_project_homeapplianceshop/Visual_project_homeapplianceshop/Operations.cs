using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Visual_project_homeapplianceshop
{
    internal class Operations
    {
        protected OleDbConnection getCon()
        {
            OleDbConnection Con = new OleDbConnection();
            Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\boras\\OneDrive\\Masaüstü\\VISUAL_PROJECT\\Visual_project_homeapplianceshop\\Visual_project_homeapplianceshop\\EvAletleriDb.accdb";
            return Con;     
        }

        public void insertdata(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Ürün Başarıyla Eklendi");
            Con.Close();
        }
    }
}
