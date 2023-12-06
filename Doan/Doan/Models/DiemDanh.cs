using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Models
{
    class DiemDanh
    {
        public string StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime NgayHoc { get; set; }
        public string Status { get; set; }
        public DiemDanh()
        { }
    }
}
