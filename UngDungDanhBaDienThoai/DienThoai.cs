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
    public partial class DienThoai : Form
    {
        public DienThoai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhBaDienThoai danhbaDT=new DanhBaDienThoai();
            danhbaDT.ShowDialog();
            this.Close();
            
        }

        private void DienThoai_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlDienThoai = new OpenFileDialog();
            ofdlDienThoai.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";// chi chon cac tep anh
            // Kiểm tra nếu người dùng chọn tệp và nhấn Open
            if (ofdlDienThoai.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc và hiển thị ảnh vào PictureBox
                    pcbDienThoai.Image = new System.Drawing.Bitmap(ofdlDienThoai.FileName);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có vấn đề khi đọc ảnh
                    MessageBox.Show("Co loi xay ra khi chon anh: " + ex.Message);                 
                }
            }

        }

        private void btnXoaHinhAnh_Click(object sender, EventArgs e)
        {
            //xoa anh hien tai trong picture box
            pcbDienThoai.Image = null;           
        }

        private void cmsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlDienThoai = new OpenFileDialog();
            ofdlDienThoai.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";// chi chon cac tep anh
            // Kiểm tra nếu người dùng chọn tệp và nhấn Open
            if (ofdlDienThoai.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc và hiển thị ảnh vào PictureBox
                    pcbDienThoai.Image = new System.Drawing.Bitmap(ofdlDienThoai.FileName);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có vấn đề khi đọc ảnh
                    MessageBox.Show("Co loi xay ra khi chon anh: " + ex.Message);
                }
            }
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            pcbDienThoai.Image = null;
        }

        private void cmsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
