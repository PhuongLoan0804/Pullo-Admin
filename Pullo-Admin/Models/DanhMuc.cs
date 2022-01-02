using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pullo_Admin.Models
{
    public class DanhMuc
    {
        private int maDM;
        private string tenDM;

        public DanhMuc()
        {

        }
        public DanhMuc(int madm, string tendm)
        {
            this.maDM = madm;
            this.tenDM = tendm;
        }
        public int MADM
        {
            get { return maDM; }
            set { maDM = value; }
        }
        public string TENDM
        {
            get { return tenDM; }
            set { tenDM = value; }
        }
    }
}
