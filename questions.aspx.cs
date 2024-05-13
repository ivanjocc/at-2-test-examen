using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practicaExamenFinal
{
    public partial class questions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuestion1();
                LoadAnswer1();
                LoadQuestion2();
                LoadAnswer2();
                LoadQuestion3();
                LoadAnswer3();
            }
        }

        private void LoadAnswer3()
        {
            //version databind

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            lbAnswers3.DataSource = dt;
            lbAnswers3.DataTextField = "AnswerText";
            lbAnswers3.DataValueField = "AnswerID";
            lbAnswers3.DataBind();


            //version foreach

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 3", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //lbAnswers3.Items.Clear();

            //foreach (DataRow row in dt.Rows)
            //{
            //    string text = row["AnswerText"].ToString();
            //    string value = row["AnswerID"].ToString();
            //    ListItem item = new ListItem(text, value);
            //    lbAnswers3.Items.Add(item);
            //}

            //version linq
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 3", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //var items = from DataRow row in dt.Rows
            //            select new ListItem
            //            {
            //                Text = row["AnswerText"].ToString(),
            //                Value = row["AnswerID"].ToString()
            //            };

            //lbAnswers3.Items.Clear();
            //foreach (ListItem item in items)
            //{
            //    lbAnswers3.Items.Add(item);
            //}
        }

        private void LoadQuestion3()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT QuestionText FROM Questions WHERE QuestionID = 3", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblQuestion3.Text = reader["QuestionText"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void LoadAnswer2()
        {
            //version databind

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 2", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //ddlAnswers2.DataSource = dt;
            //ddlAnswers2.DataTextField = "AnswerText";
            //ddlAnswers2.DataValueField = "AnswerID";
            //ddlAnswers2.DataBind();


            //version foreach

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 2", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            ddlAnswers2.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string text = row["AnswerText"].ToString();
                string value = row["AnswerID"].ToString();
                ListItem item = new ListItem(text, value);
                ddlAnswers2.Items.Add(item);
            }

            //version linq
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 2", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //var items = from DataRow row in dt.Rows
            //            select new ListItem
            //            {
            //                Text = row["AnswerText"].ToString(),
            //                Value = row["AnswerID"].ToString()
            //            };

            //ddlAnswers2.Items.Clear();
            //foreach (ListItem item in items)
            //{
            //    ddlAnswers2.Items.Add(item);
            //}

        }

        private void LoadQuestion2()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT QuestionText FROM Questions WHERE QuestionID = 2", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblQuestion2.Text = reader["QuestionText"].ToString();
            }

            reader.Close();
            con.Close();

        }

        private void LoadAnswer1()
        {
            //version databind
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 1", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //rblAnswers1.DataSource = dt;
            //rblAnswers1.DataTextField = "AnswerText";
            //rblAnswers1.DataValueField = "AnswerID";
            //rblAnswers1.DataBind();

            //version foreach
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 1", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //rblAnswers1.Items.Clear();
            //foreach (DataRow row in dt.Rows)
            //{
            //    string text = row["AnswerText"].ToString();
            //    string value = row["AnswerID"].ToString();
            //    ListItem item = new ListItem(text, value);
            //    rblAnswers1.Items.Add(item);
            //}

            //version linq
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT AnswerID, AnswerText FROM Answers WHERE QuestionID = 1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            var items = from DataRow row in dt.Rows
                        select new ListItem
                        {
                            Text = row["AnswerText"].ToString(),
                            Value = row["AnswerID"].ToString()
                        };

            rblAnswers1.Items.Clear();
            foreach (ListItem item in items)
            {
                rblAnswers1.Items.Add(item);
            }
        }

        private void LoadQuestion1()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at\\practicaExamenFinal\\App_Data\\ExamenDB.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT QuestionText FROM Questions WHERE QuestionID = 1", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                lblQuestion1.Text = reader["QuestionText"].ToString();
            }
            reader.Close();
            con.Close();
        }

        protected void btnValidate1_Click(object sender, EventArgs e)
        {

        }

        protected void btnValidate2_Click(object sender, EventArgs e)
        {

        }

        protected void btnValidate3_Click(object sender, EventArgs e)
        {

        }

        protected void btnFinalize_Click(object sender, EventArgs e)
        {

        }
    }
}