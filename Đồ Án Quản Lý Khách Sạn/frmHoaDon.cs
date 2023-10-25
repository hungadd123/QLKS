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
    public partial class frmHoaDon : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public frmHoaDon(string manv)
        {
            InitializeComponent();
            txtMaNV.Text = manv;
            import_CMBmapdp(context);
            import_CMBMaPDV(context);
            var listpp = context.PhieuPhats.ToList();
            foreach (var item in listpp)
            {
                if(item.DaThanhToan == false)
                {
                    comboBoxMaPhieuPhat.Items.Add(item);
                }
            }
            LoadDGV(context);
            var lis111 = context.Phongs.ToList();
            foreach (var item in lis111)
            {
                if(item.TinhTrang == true)
                {
                    comboBoxMaPhong.Items.Add(item);
                }
            }

        }

        private void LoadDGV(KhachSanmodels context)
        {
            dgvInforBillsPay.Rows.Clear();
            var hoad = context.HoaDons.ToList();
            foreach (var item in hoad)
            {
                DateTime a = DateTime.Today;
                if(item.NgayLap.Day == a.Day && item.NgayLap.Month == a.Month && item.NgayLap.Year == a.Year)
                {
                    int mm = dgvInforBillsPay.Rows.Add(item);
                    dgvInforBillsPay.Rows[mm].Cells[0].Value = item.MaHD;
                    dgvInforBillsPay.Rows[mm].Cells[1].Value = item.SoTien;
                    dgvInforBillsPay.Rows[mm].Cells[2].Value = item.NgayLap.ToString();
                    if(item.MaPDP != null)
                         dgvInforBillsPay.Rows[mm].Cells[3].Value = item.MaPDP;
                    dgvInforBillsPay.Rows[mm].Cells[4].Value = item.MaNV;
                    dgvInforBillsPay.Rows[mm].Cells[5].Value = item.MaKH;
                    if(item.MaPP != null)
                        dgvInforBillsPay.Rows[mm].Cells[6].Value = item.MaPP;
                    if(item.MaPDV != null)
                        dgvInforBillsPay.Rows[mm].Cells[7].Value = item.MaPDV;
                }
            }
        }
        private void import_CMBmapdp(KhachSanmodels context)
        {
            comboBoxMaPDP.Items.Clear();
            var listpdp = context.PhieuDatPhongs.ToList();
            if(txtMaKH.Text == "")
            {
                foreach (var item in listpdp)
                {
                    if (item.DaThanhToan == false)
                    {
                        comboBoxMaPDP.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in listpdp)
                {
                    if (item.DaThanhToan == false  && item.MaKh == txtMaKH.Text)
                    {
                        comboBoxMaPDP.Items.Add(item);
                    }
                }
            }
            
        }
        private void import_CMBMaPDV(KhachSanmodels context)
        {
            comboBoxMaPDVu.Items.Clear();
            var listpdv = context.PhieuDichVus.ToList();
            if (txtMaKH.Text == "")
            {
                foreach (var item in listpdv)
                {
                    if (item.DaThanhToan == false)
                    {
                        comboBoxMaPDVu.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in listpdv)
                {
                    if (item.DaThanhToan == false && item.MaKH == txtMaKH.Text)
                    {
                        comboBoxMaPDVu.Items.Add(item);
                    }
                }
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBillPay_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text == "")
            {
                MessageBox.Show("Hãy nhập mã KH trước !");
            }
            else
            {
                frmPhieuPhat f1 = new frmPhieuPhat(txtMaNV.Text);
                f1.ShowDialog();
            }
            
        }

        private void btnPayBills_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text ==""||txtSoTien.Text ==""||comboBoxMaPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                try
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn thanh toán?", "Yes/No", MessageBoxButtons.YesNo);
                    if(dlg == DialogResult.Yes)
                    {
                        var x = context.HoaDons.Count();
                        HoaDon hd = new HoaDon()
                        {
                            MaHD = "MHD" + (x + 1).ToString(),
                            SoTien = int.Parse(txtSumCost.Text),
                            NgayLap = dateTimePicker1.Value,
                            MaNV = txtMaNV.Text,
                            MaKH = txtMaKH.Text  
                        };
                        var t = (Phong)comboBoxMaPhong.SelectedItem;
                        if (t == null)
                            hd.MaPhong = t.MaPhong;
                        if (comboBoxMaPDP.SelectedIndex != -1)
                        {
                            var a = (PhieuDatPhong)comboBoxMaPDP.SelectedItem;
                            hd.MaPDP = a.MaPDP;
                        }
                        if (comboBoxMaPDVu.SelectedIndex != -1)
                        {
                            var b = (PhieuDichVu)comboBoxMaPDVu.SelectedItem;
                            hd.MaPDV = b.MaPDV;
                        }
                        if (comboBoxMaPhieuPhat.SelectedIndex != -1)
                        {
                            var c = (PhieuPhat)comboBoxMaPhieuPhat.SelectedItem;
                            hd.MaPP = c.MaPP;
                        }
                        context.HoaDons.Add(hd);
                        context.SaveChanges();
                        LoadDGV(context);
                        txtSumCost.Text = "";
                        if (comboBoxMaPDP.SelectedIndex != -1)
                        {
                            var a1 = (PhieuDatPhong)comboBoxMaPDP.SelectedItem;
                            var x1 = context.PhieuDatPhongs.FirstOrDefault(p => p.MaPDP == a1.MaPDP);
                            if(x1!= null)
                            {
                                x1.DaThanhToan = true;
                            }    
                        }
                        if (comboBoxMaPDVu.SelectedIndex != -1)
                        {
                            var b1 = (PhieuDichVu)comboBoxMaPDVu.SelectedItem;
                            var x2 = context.PhieuDichVus.FirstOrDefault(p=>p.MaPDV == b1.MaPDV);
                            if(x2 != null)
                            {
                                x2.DaThanhToan = true;
                            }
                        }
                        if (comboBoxMaPhieuPhat.SelectedIndex != -1)
                        {
                            var c1 = (PhieuPhat)comboBoxMaPhieuPhat.SelectedItem;
                            var x3 = context.PhieuPhats.FirstOrDefault(p=>p.MaPP == c1.MaPP);
                            if (x3 != null)
                            {
                                x3.DaThanhToan = true;
                            }     
                        }
                        var room = context.Phongs.FirstOrDefault(p=>p.MaPhong == t.MaPhong);
                        if (room != null)
                        {
                            room.TinhTrang = false;
                        }
                        context.SaveChanges();
                        comboBoxMaPDP.SelectedIndex = -1;
                        comboBoxMaPDVu.SelectedIndex = -1;
                        comboBoxMaPhieuPhat.SelectedIndex = -1;
                        txtSoTien.Text = "";
                        txtSumCost.Text = "0";
                        comboBoxMaPhong.SelectedIndex = -1;
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if(txtSoTien.Text != "")
                txtSumCost.Text = txtSoTien.Text;
        }

        private void comboBoxMaPDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMaPDP.SelectedIndex != -1)
            {
                var a = (PhieuDatPhong)comboBoxMaPDP.SelectedItem;
                txtSumCost.Text = (int.Parse(txtSumCost.Text) - a.TienCoc).ToString();
            }
        }

        private void comboBoxMaPhieuPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMaPhieuPhat.SelectedIndex != -1)
            {
                var b = (PhieuPhat)comboBoxMaPhieuPhat.SelectedItem;
                txtSumCost.Text = (int.Parse(txtSumCost.Text) + b.SoTien).ToString();
            }
        }

        private void comboBoxMaPDVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMaPDVu.SelectedIndex != -1)
            {
                var c = (PhieuDichVu)comboBoxMaPDVu.SelectedItem;
                txtSumCost.Text = (int.Parse(txtSumCost.Text) + c.TongTien).ToString();
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            import_CMBmapdp(context);
            import_CMBMaPDV(context);
        }

        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
