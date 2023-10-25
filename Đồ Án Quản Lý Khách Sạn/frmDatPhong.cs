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
    public partial class frmDatPhong : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        string makh;
        public frmDatPhong(string mkh)
        {
            InitializeComponent();
            makh = mkh;
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            comboBoxLoaiPhong.Items.Clear();
            var loaiphong = context.LoaiPhongs.ToList();
            foreach (var item in loaiphong)
            {
                comboBoxLoaiPhong.Items.Add(item);
            }


        }

        private void comboBoxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxLoaiPhong.SelectedIndex != -1)
            {
                var x = comboBoxLoaiPhong.SelectedItem as LoaiPhong;
                comboBoxPhong.Items.Clear();
                var phong = context.Phongs.ToList();
                foreach (var item in phong)
                {
                    if (item.MaLoaiPhong == x.MaLoaiPhong && item.TinhTrang == false)
                    {
                        comboBoxPhong.Items.Add(item);
                    }
                }
                if (x.MaLoaiPhong.Contains("MLP001"))
                {
                    pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.Phong_Vip;
                    textTiendatcoc.Text = "250000";
                }
                if (x.MaLoaiPhong.Contains("MLP002"))
                {
                    pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.Phong_thuongggg;
                    textTiendatcoc.Text = "125000";
                }
                if (x.MaLoaiPhong.Contains("MLP003"))
                {
                    pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.PhongSvip;
                    textTiendatcoc.Text = "500000";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxLoaiPhong.SelectedIndex == -1 || comboBoxPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và phòng cần đặt trước khi thanh toán!!!!");
            }
            else
            {
                DialogResult dg =  MessageBox.Show("Bạn có chắc muốn thanh toán ?","YES/NO",MessageBoxButtons.YesNo);
                if(dg == DialogResult.Yes)
                {
                    //Tiep den form thanh toan
                    frmThanhToan f1 = new frmThanhToan(comboBoxLoaiPhong.SelectedItem as LoaiPhong, comboBoxPhong.SelectedItem as Phong , pictureBox1.Image,
                        dateTimePicker1, textTiendatcoc.Text,makh);
                    f1.ShowDialog();
                    comboBoxLoaiPhong.SelectedIndex = -1;
                    comboBoxPhong.SelectedIndex = -1;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tra ve man hinh chinh
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if(dateTimePicker1.Value < dateTime )
            {
                MessageBox.Show("Vui lòng chọn này chính xác !");
                dateTimePicker1.Value = dateTime.AddMinutes(1);
            }
        }
    }
}
