using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungDanhBaDienThoai
{
    public class CPhoneBook
    {
        private string ten;
        private int sdt;
        private string coQuan;
        private string diaChi;
        private string eMail;
        private string ghiChu;

        public string Ten { get => ten; set => ten = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string CoQuan { get => coQuan; set => coQuan = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
