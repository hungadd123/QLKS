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
    public partial class PersonalInfor : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public PersonalInfor()
        {
            InitializeComponent();
        }
        private void PersonalInfor_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhanVien> listnv = context.NhanViens.ToList();
                DataStaffLeTan(listnv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load data chỉ nhân viên lễ tân
        private void DataStaffLeTan(List<NhanVien> listnv)
        {
            dgvInforLeTan.Rows.Clear();
            foreach (var item in listnv)
            {
                
                
                    int index = dgvInforLeTan.Rows.Add();
                    dgvInforLeTan.Rows[index].Cells[0].Value = item.MaNV;
                    dgvInforLeTan.Rows[index].Cells[1].Value = item.HoTen;
                    dgvInforLeTan.Rows[index].Cells[2].Value = item.SDT;
                    dgvInforLeTan.Rows[index].Cells[3].Value = item.DiaChi;
                    dgvInforLeTan.Rows[index].Cells[4].Value = item.ChucVu;
                    dgvInforLeTan.Rows[index].Cells[5].Value = item.PassWord;
                
            }
        }

        private void tsBtnExitLeTan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInforLeTan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = dgvInforLeTan.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.NhanViens.FirstOrDefault(x => x.MaNV.Equals(id));
                if (xet != null)
                {
                    txtIDLeTan.Text = xet.MaNV.ToString();
                    txtTenLeTan.Text = xet.HoTen.ToString();
                    txtSDTLeTan.Text = xet.SDT.ToString();
                    txtDiaChiLeTan.Text = xet.DiaChi.ToString();
                    txtChucVuLeTan.Text = xet.ChucVu.ToString();
                    txtPassLeTan.Text = xet.PassWord.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
