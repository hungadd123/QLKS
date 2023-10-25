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
    public partial class DevicesInfor : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public DevicesInfor()
        {
            InitializeComponent();
        }
        private void DevicesInfor_Load(object sender, EventArgs e)
        {
            try
            {
                List<DichVu> listdv = context.DichVus.ToList();
                DataDevices(listdv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataDevices(List<DichVu> listdv)
        {
            dgvDevicesInfor.Rows.Clear();
            foreach (var item in listdv)
            {
                int index = dgvDevicesInfor.Rows.Add();
                dgvDevicesInfor.Rows[index].Cells[0].Value = item.MaDV;
                dgvDevicesInfor.Rows[index].Cells[1].Value = item.TenDV;
                dgvDevicesInfor.Rows[index].Cells[2].Value = item.DonGia;
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
