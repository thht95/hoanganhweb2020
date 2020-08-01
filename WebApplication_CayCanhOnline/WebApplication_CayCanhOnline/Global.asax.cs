using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication_CayCanhOnline
{
    public class Global : System.Web.HttpApplication
    {
        List<SanPham> spDaMua = new List<SanPham>();
        protected void Application_Start(object sender, EventArgs e)
        {
            //Tài khoản
            Application.Add("taikhoan", new List<TaiKhoan>());
            List<TaiKhoan> lsTaiKhoan = new List<TaiKhoan>();
            lsTaiKhoan.Add(new TaiKhoan("sa", "123456"));
            Application.Contents["taikhoan"] = lsTaiKhoan;
            //END Tài Khoản



            //Sản phẩm
            Application.Add("sanpham", new List<SanPham>());
            List<SanPham> sanPham = new List<SanPham>();

            //Cây hoa
            sanPham.Add(new SanPham("1", "images/hoa/1.jpg", "Cây càng cua", 5000000, "hoa"));
            sanPham.Add(new SanPham("2", "images/hoa/2.jpg", "Cây hải đường", 1400000, "hoa"));
            sanPham.Add(new SanPham("3", "images/hoa/3.jpg", "Cây hẹ hồng", 10000, "hoa"));
            sanPham.Add(new SanPham("4", "images/hoa/4.jpg", "Hoa sen", 80000, "hoa"));
            sanPham.Add(new SanPham("5", "images/hoa/5.jpg", "Hoa giấy", 86000, "hoa"));
            sanPham.Add(new SanPham("6", "images/hoa/6.jpeg", "Hoa hồng môn", 200000, "hoa"));
            sanPham.Add(new SanPham("7", "images/hoa/7.jpeg", "Hoa đồng tiền", 100000, "hoa"));
            sanPham.Add(new SanPham("8", "images/hoa/8.jpg", "Cây thanh tu", 15000, "hoa"));
            sanPham.Add(new SanPham("9", "images/hoa/9.jpg", "Cây diễm châu", 32000, "hoa"));
            sanPham.Add(new SanPham("10", "images/hoa/10.jpg", "Hoa mào gà", 85000, "hoa"));
            sanPham.Add(new SanPham("11", "images/hoa/11.jpg", "Cây sống đời", 55000, "hoa"));
            sanPham.Add(new SanPham("12", "images/hoa/12.jpg", "Cây trâm ổi", 35000, "hoa"));

            //Cây thủy sinh
            sanPham.Add(new SanPham("13", "images/thuysinh/13.jpg", "Bách thủy tiên", 50000, "thuysinh"));
            sanPham.Add(new SanPham("14", "images/thuysinh/14.jpg", "Cây bèo cái", 50000, "thuysinh"));
            sanPham.Add(new SanPham("15", "images/thuysinh/15.jpg", "Cây kim ngân", 300000, "thuysinh"));
            sanPham.Add(new SanPham("16", "images/thuysinh/16.jpg", "Phát tài búp sen", 50000, "thuysinh"));
            sanPham.Add(new SanPham("17", "images/thuysinh/17.jpg", "Tùng đuôi chồn", 50000, "thuysinh"));
            sanPham.Add(new SanPham("18", "images/thuysinh/18.jpg", "Cây đại phát", 50000, "thuysinh"));
            sanPham.Add(new SanPham("19", "images/thuysinh/19.jpg", "Trầu kim thủy", 50000, "thuysinh"));
            sanPham.Add(new SanPham("20", "images/thuysinh/20.jpg", "Trầu bà vàng thủy sinh", 200000, "thuysinh"));
            sanPham.Add(new SanPham("21", "images/thuysinh/21.jpg", "Cây thịnh vượng", 175000, "thuysinh"));
            sanPham.Add(new SanPham("22", "images/thuysinh/22.png", "Nha đam thủy sinh", 115000, "thuysinh"));
            sanPham.Add(new SanPham("23", "images/thuysinh/23.jpg", "Đuôi công xanh thủy sinh", 175000, "thuysinh"));
            sanPham.Add(new SanPham("24", "images/thuysinh/24.jpg", "Đuôi công hồng thủy sinh", 175000, "thuysinh"));

            //Cây để bàn
            sanPham.Add(new SanPham("25", "images/deban/25.png", "Cây trạng nguyên", 300000, "deban"));
            sanPham.Add(new SanPham("26", "images/deban/26.jpg", "Cây si bonsai", 185000, "deban"));
            sanPham.Add(new SanPham("27", "images/deban/27.jpg", "Cây lưỡi hổ", 220000, "deban"));
            sanPham.Add(new SanPham("28", "images/deban/28.jpg", "Hồng phát lộc", 200000, "deban"));
            sanPham.Add(new SanPham("29", "images/deban/29.jpg", "Cây hạnh phúc", 215000, "deban"));
            sanPham.Add(new SanPham("30", "images/deban/30.jpg", "Cây bình vôi", 170000, "deban"));
            sanPham.Add(new SanPham("31", "images/deban/31.jpg", "Hoa sen cạn", 150000, "deban"));
            sanPham.Add(new SanPham("32", "images/deban/32.jpg", "Hoa cúc rơm", 85000, "deban"));
            sanPham.Add(new SanPham("33", "images/deban/33.jpg", "Cây dây nhện", 170000, "deban"));
            sanPham.Add(new SanPham("34", "images/deban/34.jpg", "Cây hương thảo", 190000, "deban"));
            sanPham.Add(new SanPham("35", "images/deban/35.jpg", "Nhất mạt hương", 170000, "deban"));
            sanPham.Add(new SanPham("36", "images/deban/36.jpg", "Phất dụ mảnh", 170000, "deban"));
            sanPham.Add(new SanPham("37", "images/deban/37.jpg", "Cây tài lộc", 150000, "deban"));
            sanPham.Add(new SanPham("38", "images/deban/38.jpg", "Cây tùng thơm", 220000, "deban"));
            sanPham.Add(new SanPham("39", "images/deban/39.jpg", "Vạn niên thanh leo cột", 5000000, "deban"));

            //Nổi bật
            sanPham.Add(new SanPham("5", "images/hoa/5.jpg", "Hoa giấy", 86000, "noibat"));
            sanPham.Add(new SanPham("19", "images/thuysinh/19.jpg", "Trầu kim thủy", 50000, "noibat"));
            sanPham.Add(new SanPham("6", "images/hoa/6.jpeg", "Hoa hồng môn", 200000, "noibat"));
            sanPham.Add(new SanPham("30", "images/deban/30.jpg", "Cây bình vôi", 170000, "noibat"));
            sanPham.Add(new SanPham("7", "images/hoa/7.jpeg", "Hoa đồng tiền", 100000, "noibat"));
            sanPham.Add(new SanPham("8", "images/hoa/8.jpg", "Cây thanh tu", 15000, "noibat"));
            sanPham.Add(new SanPham("32", "images/deban/32.jpg", "Hoa cúc rơm", 85000, "noibat"));
            sanPham.Add(new SanPham("20", "images/thuysinh/20.jpg", "Trầu bà vàng thủy sinh", 200000, "noibat"));
            sanPham.Add(new SanPham("18", "images/thuysinh/18.jpg", "Cây đại phát", 50000, "noibat"));
            sanPham.Add(new SanPham("31", "images/deban/31.jpg", "Hoa sen cạn", 150000, "noibat"));
            sanPham.Add(new SanPham("33", "images/deban/33.jpg", "Cây dây nhện", 170000, "noibat"));
            sanPham.Add(new SanPham("21", "images/thuysinh/21.jpg", "Cây thịnh vượng", 175000, "noibat"));
            Application.Contents["sanpham"] = sanPham;
            //END Sản phẩm

            //Giỏ hàng
            spDaMua = sanPham;
            //END Giỏ hàng

        }

        protected void Session_Start(object sender, EventArgs e)
        {

            List<SanPham> sanPham = new List<SanPham>();

            TaiKhoan tk = new TaiKhoan("", "");
            tk.GioHang = sanPham;
            Session.Add("taikhoan", tk);
            List<SanPham> gioHang = new List<SanPham>();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}