using Đồ_Án_Quản_Lý_Khách_Sạn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    public partial class frmKhachHang : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        string makh;
        public frmKhachHang(string mkh)
        {
            InitializeComponent();
            makh = mkh;
            var x = context.KhachHangs.FirstOrDefault(p => p.MaKH == mkh);
            if (x != null)
            {
                txtMaKH.Text = x.MaKH;
                txtHoTen.Text = x.TenKh;
                txtDiaChi.Text = x.DiaChi;
                txtSDT.Text = x.SDT;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdtKhachHang f1 = new frmUpdtKhachHang(makh);
            f1.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu f1 = new frmDichVu(makh);
            f1.ShowDialog();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong f1 = new frmDatPhong(makh);
            f1.ShowDialog();
        }
    }
}
