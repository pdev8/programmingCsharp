using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP.PluralSight.ADO.NET.ConnectionOrientedModel
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBone;Data Source=DEV8";
            conn = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "dbo.Colors_Insert";
            cmd.Parameters.AddWithValue("@ColorId", 0);
            cmd.Parameters.AddWithValue("@Name", txtColorName.Text);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Color successfully added...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "dbo.Colors_Delete";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ColorId", 4);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Color successfully deleted...");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "dbo.Colors_Update";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ColorId", 3);
            cmd.Parameters.AddWithValue("@Name", txtColorName.Text);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Color successfully updated...");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "dbo.Colors_SelectAll";

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "select Name from dbo.Colors where ColorId = @ColorId";
            cmd.Parameters.AddWithValue("@ColorId", txtColorId.Text);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string colorName;
            colorName = (string) cmd.ExecuteScalar();
            txtColorName.Text = colorName.ToString();
        }
    }
}
