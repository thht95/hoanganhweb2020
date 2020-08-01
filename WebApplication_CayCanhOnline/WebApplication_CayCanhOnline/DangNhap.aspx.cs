using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CayCanhOnline
{
    public partial class DangNhap1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Đăng nhập - Cây cảnh online";
            Label title = (Label)this.Master.FindControl("lblTitle");
            title.Text = "Đăng nhập";
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            Response.Redirect("DangKy.aspx");
        }


        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(kiemTraClient())
            {
                kiemTraServer();
            }
        }
        public bool kiemTraClient()
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (taiKhoan == "" || matKhau == "")
            {
                loiMatKhau.Style.Add("display","block");
                loiTaiKhoan.Style.Add("display", "block");
                if (taiKhoan == "")
                    loiTaiKhoan.InnerText = "Bạn chưa nhập tài khoản!";
                if (matKhau == "")
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
            else
            {
                loiMatKhau.Style.Add("display", "none");
                loiTaiKhoan.Style.Add("display", "none");
                return true;
            }
        }
        public void kiemTraServer()
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            taiKhoan = taiKhoan.ToLower();
            if (!isTaiKhoanDaTonTai(taiKhoan))
            {
                loiTaiKhoan.Style.Add("display", "block");
                loiTaiKhoan.InnerText = "Tài khoản không tồn tại!";
            }
            else
            {
                if (isDungMatKhau(taiKhoan, matKhau))
                {
                    List<TaiKhoan> lsTaiKhoan = (List<TaiKhoan>)Application.Contents["taikhoan"];
                    foreach (TaiKhoan tk in lsTaiKhoan)
                    {
                        tk.TenTaiKhoan = tk.TenTaiKhoan.ToLower();
                        if (tk.TenTaiKhoan.Equals(taiKhoan))
                        {
                            Session["taikhoan"] = tk;
                        }
                    }
                    Response.Redirect("TrangChu.aspx");
                }
                else
                {
                    loiMatKhau.Style.Add("display", "block");
                    loiMatKhau.InnerText = "Mật khẩu sai!";
                }
            }
        }
        private bool isTaiKhoanDaTonTai(string tenTaiKhoan)
        {
            List<TaiKhoan> lsTaiKhoan = (List<TaiKhoan>)Application.Contents["TaiKhoan"];
            string taiKhoan = tenTaiKhoan.ToLower();
            foreach (TaiKhoan item in lsTaiKhoan)
            {
                if (item.TenTaiKhoan.Equals(taiKhoan))
                {
                    return true;
                }
            }
            return false;
        }
        private bool isDungMatKhau(string tenTaiKhoan, string matKhau)
        {
            List<TaiKhoan> lsTaiKhoan = (List<TaiKhoan>)Application.Contents["TaiKhoan"];
            string taiKhoan = tenTaiKhoan.ToLower();
            foreach (TaiKhoan item in lsTaiKhoan)
            {
                if (item.TenTaiKhoan.Equals(taiKhoan))
                {
                    if (item.MatKhau.Equals(matKhau))
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}