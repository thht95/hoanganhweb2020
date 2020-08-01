using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_CayCanhOnline
{
    public class SanPham
    {
        public string id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public int sl { get; set; }
        public int thanhtien { get => this.sl * this.price; }

        public SanPham(string ID, string IMG, string NAME, int PRICE, string TYPE)
        {
            this.id = ID;
            this.img = IMG;
            this.name = NAME;
            this.price = PRICE;
            this.type = TYPE;
            this.sl = 1;
        }
    }
}