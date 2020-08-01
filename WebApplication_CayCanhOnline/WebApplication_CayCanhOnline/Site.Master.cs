using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CayCanhOnline
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        TaiKhoan tk;
        List<SanPham> sp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tk = (TaiKhoan)Session["taikhoan"];
                sp = (List<SanPham>)Application["sanpham"];
                if (tk.TenTaiKhoan.Equals(""))
                {
                    btnDangNhap.Text = "Đăng nhập";
                }
                else
                {
                    btnDangNhap.Text = tk.TenTaiKhoan + " (đăng xuất)";
                }
            }
        }
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            tk = (TaiKhoan)Session["taikhoan"];
            if (tk.TenTaiKhoan.Equals(""))
            {
                Response.Redirect("DangNhap.aspx");
            }
            else
            {
                Session["admin"] = true;
                Session["taikhoan"] = new TaiKhoan("", "");
                Response.Redirect("TrangChu.aspx");
            }
        } 
    }
}