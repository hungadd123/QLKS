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
    public partial class Device : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public Device()
        {
            InitializeComponent();
        }
        private void Device_Load(object sender, EventArgs e)
        {
            List<DichVu> listdv = context.DichVus.ToList();
            BinGrid(listdv);
        }

        private void BinGrid(List<DichVu> listdv)
        {
            dgvInforDevice.Rows.Clear();
            foreach (var item in listdv)
            {
                int index = dgvInforDevice.Rows.Add();
                dgvInforDevice.Rows[index].Cells[0].Value = item.MaDV;
                dgvInforDevice.Rows[index].Cells[1].Value = item.TenDV;
                dgvInforDevice.Rows[index].Cells[2].Value = item.DonGia;
            }
        }

        private void dgvInforDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string iddevice = dgvInforDevice.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.DichVus.FirstOrDefault(x => x.MaDV.Equals(iddevice));
                if (xet != null)
                {
                    txtIDDevices.Text = xet.MaDV.ToString();
                    txtNameDevices.Text = xet.TenDV.ToString();
                    txtPriceDevices.Text = xet.DonGia.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Note: Nếu chỉnh sửa dv thì ô chọn dv bên form KH đặt phòng vs form tiếp tân luôn cập nhật!
        private void btnAddDevices_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                DichVu dv = new DichVu();
                dv.MaDV = txtIDDevices.Text;
                dv.TenDV = txtNameDevices.Text;
                dv.DonGia = int.Parse(txtPriceDevices.Text);
                context.DichVus.Add(dv);
                context.SaveChanges();
                MessageBox.Show("Thêm mới dịch vụ thành công!", "Thông Báo!", MessageBoxButtons.OK);
                BinGrid(context.DichVus.ToList());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnFixDevices_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string IDdevice = txtIDDevices.Text;
                var sua = context.DichVus.FirstOrDefault(s => s.MaDV.Equals(IDdevice));
                if (sua != null)
                {
                    sua.MaDV = IDdevice;
                    sua.TenDV = txtNameDevices.Text;
                    sua.DonGia = int.Parse(txtPriceDevices.Text);
                    context.DichVus.AddOrUpdate();
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông Báo!", MessageBoxButtons.OK);
                    BinGrid(context.DichVus.ToList());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã dịch vụ cần sửa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDevices_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string ID = txtIDDevices.Text;
                var xoa = context.DichVus.FirstOrDefault(x => x.MaDV.Equals(ID));
                if (xoa != null)
                {
                    xoa.MaDV = txtIDDevices.Text;
                    context.DichVus.Remove(xoa);
                    context.SaveChanges();
                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK);
                    BinGrid(context.DichVus.ToList());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã dịch vụ cần xóa. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tSBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
