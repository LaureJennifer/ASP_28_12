using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class SanPham
    {
        public Guid SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public double Gia { get; set; }
    }
}
