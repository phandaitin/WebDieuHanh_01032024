using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Areas.Admin.Data
{
    public partial class TDieudong
    {
        public int DieudongId { get; set; }
        public string MaDv { get; set; }
        public string TenDv { get; set; }
        public DateTime NgayDk { get; set; }
        public DateTime NgayTh { get; set; }
        public string Tenloaixe { get; set; }
        public string Tenloaicongtrinh { get; set; }
        public string Noidung { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string Soxe { get; set; }
        public string Hoten { get; set; }
        public string Trangthaiduyet { get; set; }
        public string Ghichu { get; set; }
    }
}
