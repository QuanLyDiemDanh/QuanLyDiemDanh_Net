using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Doan
{
    class Dbconnect
    {
        string str = "Data Source=LAPTOP-GSL3DJO2;Initial Catalog=QuanLyDiemDanhSV;Integrated Security=True";
        
        public Dbconnect()
        {
            SqlConnection db = new SqlConnection(str);
        }
        
    }
}
