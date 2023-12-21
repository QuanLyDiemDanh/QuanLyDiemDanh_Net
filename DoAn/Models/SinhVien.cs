using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Models
{
    class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string Password { get; set; }
        public string HoTenSinhVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string LopNienChe { get; set; }
        public SinhVien()
        {

        }
    }
}
