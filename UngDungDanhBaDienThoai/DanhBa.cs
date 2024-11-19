using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungDanhBaDienThoai
{
    public partial class DanhBaDienThoai : Form
    {
        private HashSet<string> danhBa= new HashSet<string>();
        public DanhBaDienThoai()
        {
            InitializeComponent();
        }

        private void DanhBaDienThoai_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MucYeuThich mucYT=new MucYeuThich();
            mucYT.Show();
        }

        private void btnDanhSachDen_Click(object sender, EventArgs e)
        {
            //this.Hide();
            DanhSachDen danhSachDen = new DanhSachDen();
            danhSachDen.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string text = "Ban Co Muon Luu Khong? ";
            string caption = "THONG BAO";
            DialogResult rs=MessageBox.Show(text,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {

                this.Close();
            }
            else
            {
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string text = "Ban Co Muon Thoat Chuong Trinh? ";
            string caption = "THONG BAO";
            DialogResult rs = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
