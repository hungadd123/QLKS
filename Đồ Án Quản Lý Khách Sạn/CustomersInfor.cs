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
    public partial class CustomersInfor : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public CustomersInfor()
        {
            InitializeComponent();
        }
        private void CustomersInfor_Load(object sender, EventArgs e)
        {
            try
            {
                List<KhachHang> listkh = context.KhachHangs.ToList();
                DataCustomer(listkh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataCustomer(List<KhachHang> listkh)
        {
            dgvCustomerInfor.Rows.Add();
            foreach (var item in listkh)
            {
                int index = dgvCustomerInfor.Rows.Add();
                dgvCustomerInfor.Rows[index].Cells[0].Value = item.MaKH;
                dgvCustomerInfor.Rows[index].Cells[1].Value = item.TenKh;
                dgvCustomerInfor.Rows[index].Cells[2].Value = item.SDT;
                dgvCustomerInfor.Rows[index].Cells[3].Value = item.DiaChi;
                dgvCustomerInfor.Rows[index].Cells[4].Value = item.PassWord;
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
