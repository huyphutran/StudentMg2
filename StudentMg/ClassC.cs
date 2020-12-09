using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMg
{
    class ClassC
    {
        private string sMalop;
        private string sKhoa;
        private string sHeDaoTao;
        

        public string Malop
        {
            get { return sMalop; }
            set { sMalop = value; }
        }
        public string Khoa
        {
            get { return sKhoa; }
            set { sKhoa = value; }
        }
        public string HeDaoTao
        {
            get { return sHeDaoTao; }
            set { sHeDaoTao = value; }
        }
        public ClassC()
        {
            sMalop = "";
            sKhoa = "";
            sHeDaoTao = "";
        }
        public ClassC(string malop, string khoa, string hdt)
        {
            sMalop = malop;
            sKhoa = khoa;
            sHeDaoTao = hdt;
        }

    }
}

