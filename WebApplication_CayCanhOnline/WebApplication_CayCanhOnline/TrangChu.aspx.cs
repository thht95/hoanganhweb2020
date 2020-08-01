using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CayCanhOnline
{
    public partial class TrangChu1 : System.Web.UI.Page
    {
        TaiKhoan tk;
        List<SanPham> sp;
        Label lblTitle;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            loadData();
        }

        public void loadData()
        {
            lblTitle = (Label)this.Master.FindControl("lblTitle");
            List<SanPham> all = (List<SanPham>)Application["sanpham"];
            string type = Request.QueryString["type"];
            List<SanPham> sp = new List<SanPham>();
            if (type == null)
            {
                type = "noibat";
            }
            foreach (SanPham item in all)
            {
                if (item.type.Equals(type))
                {
                    sp.Add(item);
                }
            }
            myRepeater.DataSource = sp;
            myRepeater.DataBind();
            if (type.Equals("thuysinh"))
            {
                Page.Title = lblTitle.Text = "Cây thủy sinh";
            }
            else if (type.Equals("hoa"))
            {
                Page.Title = lblTitle.Text = "Cây hoa";
            }
            else if (type.Equals("deban"))
            {
                Page.Title = lblTitle.Text = "Cây để bàn";
            }
            else
            {
                Page.Title = "Cây cảnh online - Trang chủ";
                lblTitle.Text = "Sản phẩm nổi bật nhất";
            }
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            sp = (List<SanPham>)Application["sanpham"];
            tk = (TaiKhoan)Session["taikhoan"];
            string id = ((Button)sender).CommandArgument;
            foreach (SanPham item in sp)
            {
                if (item.id.Equals(id))
                {
                    tk.themSanPham(item);
                    break;
                }
            }
            Session["taikhoan"] = tk;
            List<TaiKhoan> users = (List<TaiKhoan>)Application["taikhoan"];
            foreach (TaiKhoan item in users)
            {
                if (item.TenTaiKhoan.Equals(tk.TenTaiKhoan))
                {
                    item.GioHang = tk.GioHang;
                    break;
                }
            }
            Application.Lock();
            Application["taikhoan"] = users;
            Application.UnLock();
            Response.Redirect("GioHang.aspx");
        }
    }
}