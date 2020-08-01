using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication_CayCanhOnline
{
    public partial class article1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindrepeater();
            }
        }

        private void bindrepeater()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "comme";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into [comment](Ten,Email,Binhluan)values(@_ten,@_email,@_binhluan)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@_ten", SqlDbType.NVarChar).Value = txtTen.Text;
            cmd.Parameters.AddWithValue("@_email", SqlDbType.NVarChar).Value = txtEmail.Text;
            cmd.Parameters.AddWithValue("@_binhluan", SqlDbType.NVarChar).Value = txtBinhluan.Text;
            cmd.ExecuteNonQuery();
            bindrepeater();
        }
    }
}