using Đồ_Án_Quản_Lý_Khách_Sạn.Models;
using Microsoft.SqlServer.Management.Smo.Wmi;
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
    public partial class frmQuanLy : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public frmQuanLy(string maNV)
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Device de = new Device();
            de.ShowDialog();
        }

        private void tsTConvenient_Click(object sender, EventArgs e)
        {
            Convenient c = new Convenient();
            c.ShowDialog();
        }

        //Load dữ liệu nhân viên
        private void BinGrid(List<NhanVien> listnv)
        {
            dgvInfor1.Rows.Clear();
            foreach (var item in listnv)
            {
                int index = dgvInfor1.Rows.Add();
                dgvInfor1.Rows[index].Cells[0].Value = item.MaNV;
                dgvInfor1.Rows[index].Cells[1].Value = item.HoTen;
                dgvInfor1.Rows[index].Cells[2].Value = item.SDT;
                dgvInfor1.Rows[index].Cells[3].Value = item.DiaChi;
                dgvInfor1.Rows[index].Cells[4].Value = item.ChucVu;
                dgvInfor1.Rows[index].Cells[5].Value = item.PassWord;
            }
        }

        private void QUẢNLÝ_Load(object sender, EventArgs e)
        {
            List<NhanVien> listnv = context.NhanViens.ToList();
            BinGrid(listnv);
            IdStaffCMB(listnv);
            BinGrid1(listnv);
            List<Phong> listp = context.Phongs.ToList();
            DataRoom(listp);
        }

        //Show infor nhân viên
        private void dgvInfor1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = dgvInfor1.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.NhanViens.FirstOrDefault(x => x.MaNV.Equals(id));
                if (xet != null)
                {
                    txtIDStaff.Text = xet.MaNV.ToString();
                    txtFullName.Text = xet.HoTen.ToString();
                    txtNumb.Text = xet.SDT.ToString();
                    txtAddress.Text = xet.DiaChi.ToString();
                    txtPosition.Text = xet.ChucVu.ToString();
                    txtPass.Text = xet.PassWord.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add new nhân viên
        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {

            KhachSanmodels context = new KhachSanmodels();
            NhanVien nv = new NhanVien();
            nv.MaNV = txtIDStaff.Text;
            nv.HoTen = txtFullName.Text;
            nv.SDT = txtNumb.Text;
            nv.DiaChi = txtAddress.Text;
            nv.ChucVu = txtPosition.Text;
            nv.PassWord = txtPass.Text;
            context.NhanViens.Add(nv);
            context.SaveChanges();
            BinGrid(context.NhanViens.ToList());
            BinGrid1(context.NhanViens.ToList());
            MessageBox.Show("Thêm nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        //Fix infor nhân viên
        private void btnUpDateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = txtIDStaff.Text;
                var find = context.NhanViens.FirstOrDefault(f => f.MaNV == id);
                if (find != null)
                {
                    find.MaNV = id;
                    find.HoTen = txtFullName.Text;
                    find.SDT = txtNumb.Text;
                    find.DiaChi = txtAddress.Text;
                    find.ChucVu = txtPosition.Text;
                    find.PassWord = txtPass.Text;
                    context.NhanViens.AddOrUpdate();
                    context.SaveChanges();
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    BinGrid(context.NhanViens.ToList());
                    BinGrid1(context.NhanViens.ToList());
                }
                else
                {
                    MessageBox.Show("Ko tim thay ma nhan vien can sua!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Chọn mã nv ở combobox
        private void IdStaffCMB(List<NhanVien> listnv)
        {
            this.cmbIDStaff.DataSource = listnv;
            this.cmbIDStaff.DisplayMember = "MaNV";
        }

        //Xuất infor nv theo mã nv đã chọn
        private void BinGrid1(List<NhanVien> listnv)
        {
            dgvInfor2.Rows.Clear();
            foreach (var item in listnv)
            {
                int index = dgvInfor2.Rows.Add();
                dgvInfor2.Rows[index].Cells[0].Value = item.MaNV;
                dgvInfor2.Rows[index].Cells[1].Value = item.HoTen;
                dgvInfor2.Rows[index].Cells[2].Value = item.SDT;
                dgvInfor2.Rows[index].Cells[3].Value = item.DiaChi;
                dgvInfor2.Rows[index].Cells[4].Value = item.ChucVu;
                dgvInfor2.Rows[index].Cells[5].Value = item.PassWord;
            }
        }

        //Xóa infor nv
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = cmbIDStaff.Text;
                var xoa = context.NhanViens.FirstOrDefault(x => x.MaNV.Equals(id));
                if (xoa != null)
                {
                    xoa.MaNV = id;
                    context.NhanViens.Remove(xoa);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK);
                    BinGrid1(context.NhanViens.ToList());
                    BinGrid(context.NhanViens.ToList());
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa được dữ liệu do mã nhân viên bị sai hoặc không có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load data phòng
        private void DataRoom(List<Phong> listp)
        {
            dgvInforRoom.Rows.Clear();
            foreach (var item in listp)
            {
                int index = dgvInforRoom.Rows.Add();
                dgvInforRoom.Rows[index].Cells[0].Value = item.MaPhong;
                dgvInforRoom.Rows[index].Cells[1].Value = item.MaLoaiPhong;
                if (item.LoaiPhong != null)
                {
                    dgvInforRoom.Rows[index].Cells[2].Value = item.LoaiPhong.MoTa;
                    dgvInforRoom.Rows[index].Cells[3].Value = item.LoaiPhong.GiaPhong;
                }

            }
        }

        //Thêm phòng mới vô data
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                Phong p = new Phong();
                p.MaPhong = txtIDRoom.Text;
                p.MaLoaiPhong = txtIDRoomType.Text;
                context.Phongs.Add(p);
                context.SaveChanges();
                MessageBox.Show("Thêm phòng thành công!", "Thông Báo", MessageBoxButtons.OK);
                DataRoom(context.Phongs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Show data phòng
        private void dgvInforRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = dgvInforRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.Phongs.FirstOrDefault(x => x.MaPhong.Equals(id));
                if (xet != null)
                {
                    txtIDRoom.Text = xet.MaPhong.ToString();
                    txtIDRoomType.Text = xet.MaLoaiPhong.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Thay đổi thông tin phòng
        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string idroom = txtIDRoom.Text;
                var fix = context.Phongs.FirstOrDefault(f => f.MaPhong == idroom);
                if (fix != null)
                {
                    fix.MaPhong = txtIDRoom.Text;
                    fix.MaLoaiPhong = txtIDRoomType.Text;
                    context.Phongs.AddOrUpdate();
                    context.LoaiPhongs.AddOrUpdate();
                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK);
                    DataRoom(context.Phongs.ToList());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID Room. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không cập nhật được vì mã phòng bị sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        //Xóa thông tin phòng
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string idroom = txtIDRoom.Text;
                var delete = context.Phongs.FirstOrDefault(d => d.MaPhong == idroom);
                if (delete != null)
                {
                    delete.MaPhong = txtIDRoom.Text;
                    delete.MaLoaiPhong = txtIDRoomType.Text;
                    context.Phongs.Remove(delete);
                    context.SaveChanges();
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK);
                    DataRoom(context.Phongs.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Nút xuất thông tin hóa đơn
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<HoaDon> listhd = context.HoaDons.ToList();
                DataBills(listhd);
                TotalBills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load data hóa đơn
        private void DataBills(List<HoaDon> listhd)
        {
            dgvInforBills.Rows.Clear();
            foreach (var item in listhd)
            {
                int index = dgvInforBills.Rows.Add();
                dgvInforBills.Rows[index].Cells[0].Value = item.MaHD;
                dgvInforBills.Rows[index].Cells[1].Value = item.SoTien;
                dgvInforBills.Rows[index].Cells[2].Value = item.NgayLap;
                dgvInforBills.Rows[index].Cells[3].Value = item.MaPDP;
                dgvInforBills.Rows[index].Cells[4].Value = item.MaNV;
                dgvInforBills.Rows[index].Cells[5].Value = item.MaKH;
                dgvInforBills.Rows[index].Cells[6].Value = item.MaPP;
                dgvInforBills.Rows[index].Cells[7].Value = item.MaPhong;
                dgvInforBills.Rows[index].Cells[8].Value = item.MaPDV;
            }
        }

        //Tính tổng hóa đơn
        public void TotalBills()
        {
            int hd = dgvInforBills.Rows.Cast<DataGridViewRow>().Count();
            txtTotalBills.Text = hd.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PersonalInfor f1 = new PersonalInfor();
            f1.ShowDialog();
        }
    }
}

