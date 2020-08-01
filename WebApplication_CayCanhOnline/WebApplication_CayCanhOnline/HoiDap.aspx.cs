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
    public partial class HoiDap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool kt = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            using (SqlCommand cmd = new SqlCommand("inserthd",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@subj", TextBox4.Text);
                cmd.Parameters.AddWithValue("@messenger", TextBox5.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    kt = true;
                }
                catch
                {
                    Label1.Text = "đã có lỗi xảy ra";
                    Label1.Visible = true;
                }
                finally
                {
                    con.Close();
                }
            }    
            if (kt)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label1.Text = "Đã gửi!Hãy kiểm tra mail để nhận được giải đáp";
                Label1.Visible = true;
            }    
        }
    }
}