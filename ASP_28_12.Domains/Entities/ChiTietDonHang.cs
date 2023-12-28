using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class ChiTietDonHang
    {
        public Guid ChiTietDonHangID { get; set; }
        public Guid DonHangID { get; set; }
        public Guid SanPhamID { get; set; }
        public int SoLuong { get; set; }
    }
}
