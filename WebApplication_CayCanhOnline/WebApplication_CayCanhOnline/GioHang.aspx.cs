using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CayCanhOnline
{
    public partial class GioHang1 : System.Web.UI.Page
    {
        TaiKhoan tk;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Page.Title = "Giỏ hàng - Cây cảnh online";
                Label title = (Label)this.Page.Master.FindControl("lblTitle");
                title.Text = "Giỏ hàng";
                tk = (TaiKhoan)Session.Contents["taikhoan"];
                List<TaiKhoan> users = (List<TaiKhoan>)Application["taikhoan"];
                if (!Page.IsPostBack)
                {
                    gridviewGioHang.DataSource = ((TaiKhoan)Session.Contents["taikhoan"]).GioHang;
                    gridviewGioHang.DataBind();
                }
            }
            
        }
        protected void btnThanhToan_Click(object sender, EventArgs e)
        {

            TaiKhoan tk = (TaiKhoan)Session["taikhoan"];
            tk.GioHang = new List<SanPham>();
            Session["taikhoan"] = tk;
            List<TaiKhoan> users = (List<TaiKhoan>)Application["taikhoan"];
            foreach (TaiKhoan item in users)
            {
                if (item.TenTaiKhoan.Equals(tk.TenTaiKhoan))
                {
                    item.GioHang = new List<SanPham>();
                    break;
                }
            }
            Application.Lock();
            Application["taikhoan"] = users;
            Application.UnLock();
            loadData();
        }

        public void loadData()
        {
            TaiKhoan tk = (TaiKhoan)Session.Contents["taikhoan"];
            gridviewGioHang.DataSource = tk.GioHang;
            gridviewGioHang.DataBind();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            int index = -1;
            TaiKhoan tk = (TaiKhoan)Session["taikhoan"];
            Session["taikhoan"] = tk;
            List<TaiKhoan> users = (List<TaiKhoan>)Application["taikhoan"];
            string id = ((Button)sender).CommandArgument;
            foreach (SanPham item in tk.GioHang)
            {
                if (item.id.Equals(id))
                {
                    item.sl = item.sl - 1;
                }
                if (item.sl == 0)
                    index = tk.GioHang.IndexOf(item);
            }
            if (index != -1)
                tk.GioHang.RemoveAt(index);

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
            loadData();
        }
    }
}   