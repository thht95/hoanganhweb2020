using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_CayCanhOnline
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private List<SanPham> gioHang;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public List<SanPham> GioHang { get => gioHang; set => gioHang = value; }

        public TaiKhoan(string taiKhoan, string matKhau)
        {
            this.TenTaiKhoan = taiKhoan.ToLower();
            this.MatKhau = matKhau;
            this.gioHang = new List<SanPham>();
        }
        public void themSanPham(SanPham sanPham)
        {
            bool isDaCo = false;
            sanPham.id = sanPham.id.ToLower();
            foreach(SanPham sp in gioHang)
            {
                if(sp.id.ToLower().Equals(sanPham.id))
                {
                    isDaCo = true;
                    sp.sl++;
                    break;
                }
            }
            if (!isDaCo)
            {
                GioHang.Add(sanPham);
            }
        }
    }
}