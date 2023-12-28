using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class DonHang
    {
        public Guid DonHangID { get; set; }
        public int KhachHangID { get; set; }
        public DateTimeOffset NgayDatHang { get; set; } 
    }
}
