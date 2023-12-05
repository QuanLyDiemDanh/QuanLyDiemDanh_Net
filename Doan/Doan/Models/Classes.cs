using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Models
{
    class Classes
    {
        public int ClassID { get; set; }
        public TimeSpan ThoiGianBatDau { get; set; }
        public TimeSpan ThoiGianKetThuc { get; set; }
        public int CourseID { get; set; }
        public DateTime NgayHoc { get; set; }
    }
}
