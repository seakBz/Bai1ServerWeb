using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baitap1_Server.Models
{
    public class BaiTap
    {
        public string HocKi { get; set; }
        public string NamHoc { get; set; }
        public double DiemHK { get; set; }
        public string LinkImg { get; set; }
        public string LinkFileDestrip { get; set; }

        public BaiTap()
        {
            HocKi = "";
            NamHoc = "";
            DiemHK = 0.0;
            LinkImg = "";
            LinkFileDestrip = "";
        }

        public BaiTap(string _HocKi, string _NamHoc, double _DiemHK, string _LinkImg, string _LinkFileDestrip)
        {
            HocKi = _HocKi;
            NamHoc = _NamHoc;
            DiemHK = _DiemHK;
            LinkImg = _LinkImg;
            LinkFileDestrip = _LinkFileDestrip;
        }

        public static List<BaiTap> initData()
        {
            List<BaiTap> Data = new List<BaiTap>();
            Data.Add(new BaiTap { HocKi = "HỌC KỲ 1", NamHoc = "2017-2018", DiemHK = 3.43, LinkImg = "img/1.png", LinkFileDestrip = "file/1.txt" });
            Data.Add(new BaiTap { HocKi = "HỌC KỲ 2", NamHoc = "2016-2017", DiemHK = 2.83, LinkImg = "img/2.png", LinkFileDestrip = "file/2.txt" });
            Data.Add(new BaiTap { HocKi = "HỌC KỲ 1", NamHoc = "2016-2017", DiemHK = 2.52, LinkImg = "img/3.png", LinkFileDestrip = "file/3.txt" });
            Data.Add(new BaiTap { HocKi = "HỌC KỲ 2", NamHoc = "2015-2016", DiemHK = 2.07, LinkImg = "img/4.png", LinkFileDestrip = "file/4.txt" });
            Data.Add(new BaiTap { HocKi = "HỌC KỲ 1", NamHoc = "2015-2016", DiemHK = 2.34, LinkImg = "img/5.png", LinkFileDestrip = "file/5.txt" });
            return Data;
        }
    }
}