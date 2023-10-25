using Đồ_Án_Quản_Lý_Khách_Sạn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    public partial class frmUpdtKhachHang : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        string makh;
        public frmUpdtKhachHang(string mkh)
        {
            InitializeComponent();
            makh = mkh;
            var x = context.KhachHangs.FirstOrDefault(p => p.MaKH == makh);
            if (x != null)
            {
                textDiaChi.Text = x.DiaChi;
                textName.Text = x.TenKh;
                textSDT.Text = x.SDT;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textDiaChi.Text == ""|| textName.Text == ""|| textSDT.Text == "")
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin ? ", "Yes/No", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    var x = context.KhachHangs.FirstOrDefault(p => p.MaKH == makh);
                    if (x != null)
                    {
                        x.DiaChi = textDiaChi.Text;
                        x.SDT = textSDT.Text;
                        x.TenKh = textName.Text;
                    }
                    context.KhachHangs.AddOrUpdate(x);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }
            
        }
    }
}
