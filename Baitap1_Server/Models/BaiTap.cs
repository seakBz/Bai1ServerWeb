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

        #region

        public static string AutoMat()
        {
            string s = "PG5hdiBjbGFzcz0ibmF2YmFyIG5hdmJhci1pbnZlcnNlIG5hdmJhci1maXhlZC10b3AiPg0KICAgICAgICA8ZGl2IGNsYXNzPSJjb250YWluZXItZmx1aWQiPg0KICAgICAgICAgICAgPGRpdiBjbGFzcz0ibmF2YmFyLWhlYWRlciI+DQogICAgICAgICAgICAgICAgPGEgY2xhc3M9Im5hdmJhci1icmFuZCIgaHJlZj0iIyI+xJDDrG5oIFBow7pjPC9hPg0KICAgICAgICAgICAgPC9kaXY+DQogICAgICAgICAgICA8dWwgY2xhc3M9Im5hdiBuYXZiYXItbmF2Ij4NCiAgICAgICAgICAgICAgICA8bGkgY2xhc3M9ImFjdGl2ZSI+PGEgaHJlZj0iLyI+SG9tZTwvYT48L2xpPg0KICAgICAgICAgICAgICAgIDxsaT48YSBocmVmPSIjIj5QYWdlIDE8L2E+PC9saT4NCiAgICAgICAgICAgICAgICA8bGk+PGEgaHJlZj0iIyI+UGFnZSAyPC9hPjwvbGk+DQogICAgICAgICAgICA8L3VsPg0KICAgICAgICAgICAgPHVsIGNsYXNzPSJuYXYgbmF2YmFyLW5hdiBuYXZiYXItcmlnaHQiPg0KICAgICAgICAgICAgICAgIDxsaT48YSBocmVmPSIjIj48c3BhbiBjbGFzcz0iZ2x5cGhpY29uIGdseXBoaWNvbi11c2VyIj48L3NwYW4+IFNpZ24gVXA8L2E+PC9saT4NCiAgICAgICAgICAgICAgICA8bGk+PGEgaHJlZj0iIyI+PHNwYW4gY2xhc3M9ImdseXBoaWNvbiBnbHlwaGljb24tbG9nLWluIj48L3NwYW4+IExvZ2luPC9hPjwvbGk+DQogICAgICAgICAgICA8L3VsPg0KICAgICAgICA8L2Rpdj4NCiAgICA8L25hdj4=";
            byte[] ss = Convert.FromBase64String(s);
            string sss = System.Text.Encoding.UTF8.GetString(ss);
            return sss;
        }

        #endregion
    }
}