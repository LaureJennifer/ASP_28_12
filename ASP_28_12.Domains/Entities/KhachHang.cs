using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class KhachHang
    {
        public Guid KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}
