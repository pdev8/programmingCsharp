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

namespace CSP.PluralSight.ADO.NET
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBone;Data Source=DEV8";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Colors", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Colors");
            ds.Tables[0].Constraints.Add("ColorId_PK", ds.Tables[0].Columns[0], true);
            DataRow row;
            row = ds.Tables[0].NewRow();
            row["Name"] = txtColorName.Text;
            row["ColorId"] = 0;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Employee Record Added.", this.Text);
        }

    }
}
