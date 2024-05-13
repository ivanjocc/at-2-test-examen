using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practicaExamenFinal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //version linq

            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";

            //DataSet ds = new DataSet();
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT UniqueNumber, Password, FinalGrade FROM Students", con);
            //adapter.Fill(ds, "Students");
            //con.Close();

            //var user = ds.Tables["Students"].AsEnumerable()
            //    .FirstOrDefault(row => row.Field<string>("UniqueNumber") == username && row.Field<string>("Password") == password);

            //if (user != null)
            //{
            //    if (user.IsNull("FinalGrade"))
            //    {
            //        Response.Redirect("questions.aspx");
            //    }
            //    else
            //    {
            //        Response.Redirect("result.aspx");
            //    }
            //}
            //else
            //{
            //    txtUsername.Text = "";
            //    lblError.Text = "Invalid username or password.";
            //    lblError.Visible = true;
            //}

            //version foreach

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";

            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT UniqueNumber, Password, FinalGrade FROM Students", con);
            adapter.Fill(ds, "Students");
            con.Close();

            DataRow foundRow = null;
            foreach (DataRow row in ds.Tables["Students"].Rows)
            {
                if ((string)row["UniqueNumber"] == username && (string)row["Password"] == password)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow != null)
            {
                if (foundRow.IsNull("FinalGrade"))
                {
                    Response.Redirect("questions.aspx");
                }
                else
                {
                    Response.Redirect("result.aspx");
                }
            }
            else
            {
                txtUsername.Text = "";
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
            }
        }

    }
}