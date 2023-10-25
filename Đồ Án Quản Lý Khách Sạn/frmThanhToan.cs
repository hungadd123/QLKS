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
    public partial class frmThanhToan : Form
    {
        DateTime p;
        string makh;
        Phong ppp;
        KhachSanmodels context = new KhachSanmodels();
        private string manv;

        public frmThanhToan(Models.LoaiPhong loaiPhong, Models.Phong phong, Image image, DateTimePicker dateTimePicker1, string text, string mkh)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            textLoaiPhong.Text = loaiPhong.MoTa;
            textMasoPhong.Text = phong.MaPhong;
            textThoigianNhan.Text = dateTimePicker1.Text;
            textTongtien.Text = text;
            p = dateTimePicker1.Value ;
            ppp = phong;
            makh = mkh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán !!!");
            }
            else
            {
                try
                {
                    //Chuyen den giao dien thanh toan tren ung dung :>>
                    MessageBox.Show("Thanh toán hoàn tất !");
                    //Sau do lưu lại thông tin trong phiếu đặt phòng
                    var a = context.PhieuDatPhongs.Count();
                    PhieuDatPhong b = new PhieuDatPhong()
                    {
                        MaPDP = "MPDP" + (a + 1).ToString(),
                        TienCoc = int.Parse(textTongtien.Text),
                        NgayDat = p,
                        MaPhong = textMasoPhong.Text,
                        MaKh = makh,
                        DaThanhToan = false
                    };
                    context.PhieuDatPhongs.Add(b);
                    context.SaveChanges();
                    //Chỉnh sửa trạng thái của phòng sang đã được đặt
                    var p1 = context.Phongs.FirstOrDefault(p => p.MaPhong == ppp.MaPhong);
                    if (p1 != null)
                        p1.TinhTrang = true;
                    context.SaveChanges();
                    this.Close();
            }
                catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
            }

        }
            

        }
    }
}
