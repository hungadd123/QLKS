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
    public partial class Convenient : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public Convenient()
        {
            InitializeComponent();
        }
        private void tSBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Convenient_Load(object sender, EventArgs e)
        {
            try
            {
                List<TienNghi> listtn = context.TienNghis.ToList();
                DataConvenient(listtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataConvenient(List<TienNghi> listtn)
        {
            dgvInforConvenient.Rows.Clear();
            foreach (var item in listtn)
            {
                int index = dgvInforConvenient.Rows.Add();
                dgvInforConvenient.Rows[index].Cells[0].Value = item.MaTNghi;
                dgvInforConvenient.Rows[index].Cells[1].Value = item.TenTNghi;
                dgvInforConvenient.Rows[index].Cells[2].Value = item.SoLuong;
            }
        }

        private void dgvInforConvenient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string idconvenient = dgvInforConvenient.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.TienNghis.FirstOrDefault(x => x.MaTNghi.Equals(idconvenient));
                if (xet != null)
                {
                    txtIDConvenient.Text = xet.MaTNghi.ToString();
                    txtNameConvenient.Text = xet.TenTNghi.ToString();
                    txtQuantity.Text = xet.SoLuong.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                TienNghi tn = new TienNghi();
                tn.MaTNghi = txtIDConvenient.Text;
                tn.TenTNghi = txtNameConvenient.Text;
                tn.SoLuong = int.Parse(txtQuantity.Text);
                context.TienNghis.Add(tn);
                context.SaveChanges();
                MessageBox.Show("Thêm tiên nghi mới thành công!", "Thông Báo", MessageBoxButtons.OK);
                DataConvenient(context.TienNghis.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpC_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string IDConvenient = txtIDConvenient.Text;
                var fix = context.TienNghis.FirstOrDefault(f => f.MaTNghi.Equals(IDConvenient));
                if (fix != null)
                {
                    fix.MaTNghi = IDConvenient;
                    fix.TenTNghi = txtNameConvenient.Text;
                    fix.SoLuong = int.Parse(txtQuantity.Text);
                    context.TienNghis.AddOrUpdate();
                    context.SaveChanges();
                    MessageBox.Show("Chỉnh sửa thông tin tiên nghi thành công!", "Thông Báo", MessageBoxButtons.OK);
                    DataConvenient(context.TienNghis.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string ID = txtIDConvenient.Text;
                var xoa = context.TienNghis.FirstOrDefault(x => x.MaTNghi.Equals(ID));
                if (xoa != null)
                {
                    xoa.MaTNghi = ID;
                    context.TienNghis.Remove(xoa);
                    context.SaveChanges();
                    MessageBox.Show("Xóa tiện nghi thành công!", "Thông Báo", MessageBoxButtons.OK);
                    DataConvenient(context.TienNghis.ToList());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã tiện nghi cần xóa. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
