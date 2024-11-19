namespace UngDungDanhBaDienThoai
{
    partial class DienThoai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDienThoai = new System.Windows.Forms.DataGridView();
            this.pcbDienThoai = new System.Windows.Forms.PictureBox();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.ofdlDienThoai = new System.Windows.Forms.OpenFileDialog();
            this.btnXoaHinhAnh = new System.Windows.Forms.Button();
            this.cmsDienThoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDienThoai)).BeginInit();
            this.cmsDienThoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(654, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 43);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(654, 167);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 43);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(654, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 43);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDienThoai
            // 
            this.dgvDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienThoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.SDT,
            this.CoQuan,
            this.DiaChi,
            this.Email,
            this.GhiChu});
            this.dgvDienThoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDienThoai.Location = new System.Drawing.Point(0, 261);
            this.dgvDienThoai.Name = "dgvDienThoai";
            this.dgvDienThoai.Size = new System.Drawing.Size(800, 189);
            this.dgvDienThoai.TabIndex = 11;
            // 
            // pcbDienThoai
            // 
            this.pcbDienThoai.BackColor = System.Drawing.Color.Gray;
            this.pcbDienThoai.ContextMenuStrip = this.cmsDienThoai;
            this.pcbDienThoai.Location = new System.Drawing.Point(12, 12);
            this.pcbDienThoai.Name = "pcbDienThoai";
            this.pcbDienThoai.Size = new System.Drawing.Size(222, 183);
            this.pcbDienThoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDienThoai.TabIndex = 12;
            this.pcbDienThoai.TabStop = false;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 106;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // CoQuan
            // 
            this.CoQuan.HeaderText = "Tên Cơ Quan";
            this.CoQuan.Name = "CoQuan";
            this.CoQuan.Width = 200;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(259, 48);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(181, 38);
            this.btnChonAnh.TabIndex = 13;
            this.btnChonAnh.Text = "Chọn Hình Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // ofdlDienThoai
            // 
            this.ofdlDienThoai.FileName = "openFileDialog1";
            // 
            // btnXoaHinhAnh
            // 
            this.btnXoaHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHinhAnh.Location = new System.Drawing.Point(259, 113);
            this.btnXoaHinhAnh.Name = "btnXoaHinhAnh";
            this.btnXoaHinhAnh.Size = new System.Drawing.Size(181, 38);
            this.btnXoaHinhAnh.TabIndex = 13;
            this.btnXoaHinhAnh.Text = "Xóa Hình Ảnh";
            this.btnXoaHinhAnh.UseVisualStyleBackColor = true;
            this.btnXoaHinhAnh.Click += new System.EventHandler(this.btnXoaHinhAnh_Click);
            // 
            // cmsDienThoai
            // 
            this.cmsDienThoai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOpen,
            this.cmsDelete,
            this.cmsExit});
            this.cmsDienThoai.Name = "cmsDienThoai";
            this.cmsDienThoai.Size = new System.Drawing.Size(150, 70);
            // 
            // cmsOpen
            // 
            this.cmsOpen.Name = "cmsOpen";
            this.cmsOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cmsOpen.Size = new System.Drawing.Size(180, 22);
            this.cmsOpen.Text = "Open ";
            this.cmsOpen.Click += new System.EventHandler(this.cmsOpen_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmsDelete.Size = new System.Drawing.Size(180, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsExit
            // 
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cmsExit.Size = new System.Drawing.Size(180, 22);
            this.cmsExit.Text = "Exit";
            this.cmsExit.Click += new System.EventHandler(this.cmsExit_Click);
            // 
            // DienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaHinhAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.pcbDienThoai);
            this.Controls.Add(this.dgvDienThoai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "DienThoai";
            this.Text = "DienThoai";
            this.Load += new System.EventHandler(this.DienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDienThoai)).EndInit();
            this.cmsDienThoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDienThoai;
        private System.Windows.Forms.PictureBox pcbDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.OpenFileDialog ofdlDienThoai;
        private System.Windows.Forms.Button btnXoaHinhAnh;
        private System.Windows.Forms.ContextMenuStrip cmsDienThoai;
        private System.Windows.Forms.ToolStripMenuItem cmsOpen;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
    }
}