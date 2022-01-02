using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pullo_Admin.Models
{
    public class Sach
    {
        private int isBN;
        private int maDM;
        private string tenSach;
        private string tacGia;
        private string moTa;
        private int soLuong;
        private string url;
        private double giaTien;

        public Sach()
        {

        }
        public Sach(int isbn, int madm, string tensach, string tacgia, string mota, int soluong, double giatien, string url)
        {
            this.isBN = isbn;
            this.maDM = madm;
            this.tenSach = tensach;
            this.tacGia = tacgia;
            this.moTa = mota;
            this.soLuong = soluong;
            this.giaTien = giatien;
            this.url = url;
        }
        public int ISBN
        {
            get { return isBN; }
            set { isBN = value; }
        }
        public int MADM
        {
            get { return maDM; }
            set { maDM = value; }
        }
        public string TENSACH
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string TACGIA
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public string MOTA
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public int SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public double GIATIEN
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
    }
}
