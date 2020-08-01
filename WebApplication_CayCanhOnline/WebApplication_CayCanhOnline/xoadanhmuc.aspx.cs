using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services.Description;

namespace WebApplication_CayCanhOnline
{
    public partial class xoadanhmuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            using (SqlCommand cmd = new SqlCommand("xoahd", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32( Request.Params["ma"]));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("1");
        }
    }
}