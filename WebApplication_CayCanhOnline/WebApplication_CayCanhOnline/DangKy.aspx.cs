using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CayCanhOnline
{
    public partial class DangKy1 : System.Web.UI.Page
    {
        List<TaiKhoan> lsTaiKhoan;
        string taiKhoan;
        string matKhau;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label title = (Label)this.Page.Master.FindControl("lblTitle");
                title.Text = "Đăng ký tài khoản";
                Page.Title = "Đăng ký tài khoản - Cây cảnh online";
            }
            
        }

        public bool kiemTraClient()
        {
            taiKhoan = txtTaiKhoan.Text;
            matKhau = txtMatKhau.Text;
            string matKhau2 = txtMatKhau2.Text;
            if (taiKhoan == "" || matKhau == "")
            {
                loiMatKhau.Style.Add("display","block");
                loiTaiKhoan.Style.Add("display", "block");
                if (taiKhoan.Equals(""))
                    loiTaiKhoan.InnerText = "Bạn chưa nhập tài khoản!";
                if (matKhau.Equals(""))
                    loiMatKhau.InnerText = "Bạn chưa nhập mật khẩu";
                return false;
            }
            else if (matKhau.Length < 6)
            {
                loiMatKhau.Style.Add("display", "block");
                loiTaiKhoan.Style.Add("display", "none");
                loiMatKhau.InnerText = "Mật khẩu phải từ 6 ký tự trở lên";
                return false;
            }
            else if (!matKhau.Equals(matKhau2))
            {
                loiMatKhau.Style.Add("display", "none");
                loiTaiKhoan.Style.Add("display", "none");
                loiMatKhau2.Style.Add("display", "block");
                loiMatKhau2.InnerText = "Mật khẩu không khớp";
                return false;
            }
            else
            {
                loiMatKhau.Style.Add("display", "none");
                loiTaiKhoan.Style.Add("display", "none");
                loiMatKhau2.Style.Add("display", "none");
                return true;
            }
        }

        public void kiemTraServer()
        {
            lsTaiKhoan = (List<TaiKhoan>)Application.Contents["TaiKhoan"];
            taiKhoan = txtTaiKhoan.Text.ToLower();
            matKhau = txtMatKhau.Text;
            if (isTaiKhoanDaTonTai(taiKhoan))
            {
                loiTaiKhoan.InnerText = "Tài khoản đã tồn tại";
                loiTaiKhoan.Style.Add("display", "block");
            }
            else
            {
                TaiKhoan taiKhoanMoi = new TaiKhoan(taiKhoan, matKhau);
                lsTaiKhoan.Add(taiKhoanMoi);
                Application.Contents["TaiKhoan"] = lsTaiKhoan;
                Session["taikhoan"] = taiKhoanMoi;
                Response.Redirect("TrangChu.aspx");
            }
        }
        private bool isTaiKhoanDaTonTai(string tenTaiKhoan)
        {
            string taiKhoan = tenTaiKhoan.ToLower();
            lsTaiKhoan = (List<TaiKhoan>)Application.Contents["TaiKhoan"];
            foreach (TaiKhoan item in lsTaiKhoan)
            {
                if (item.TenTaiKhoan.Equals(taiKhoan))
                {
                    return true;
                }
            }
            return false;
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            if(kiemTraClient())
            {
                kiemTraServer();
            }
        }
    }
}