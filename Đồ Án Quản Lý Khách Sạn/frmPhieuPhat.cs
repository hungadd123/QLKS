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
    public partial class frmPhieuPhat : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public frmPhieuPhat(string text)
        {
            InitializeComponent();
        }
        private void loadDGV(KhachSanmodels context)
        {
            dgvDamageRoom.DataSource = context.PhieuPhats;
        }
        private void btnAddDR_Click(object sender, EventArgs e)
        {
            if(txtMoney.Text == "" || txtText.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                try
                {
                    var x = context.PhieuPhats.Count();
                    PhieuPhat pp = new PhieuPhat()
                    {
                        MaPP = "MPP" + (x + 1).ToString(),
                        SoTien = int.Parse(txtMoney.Text),
                        NgayPhat = dateTimePicker1.Value,
                        NoiDung = txtText.Text,
                        DaThanhToan = false
                    };
                    context.PhieuPhats.Add(pp);
                    context.SaveChanges();
                    txtText.Text = "";
                    txtMoney.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
