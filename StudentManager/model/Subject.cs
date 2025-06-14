using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.model
{
    public class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }

        public MonHoc() { }

        public MonHoc(string maMon, string tenMon, int soTinChi)
        {
            MaMon = maMon;
            TenMon = tenMon;
            SoTinChi = soTinChi;
        }
    }
}
