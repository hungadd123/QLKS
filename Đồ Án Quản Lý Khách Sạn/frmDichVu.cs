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
    public partial class frmDichVu : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        string makh;
        public frmDichVu(string mkh)
        {
            InitializeComponent();
            makh = mkh;
            var list = context.DichVus.ToList();
            foreach (var item in list)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            var x = checkedListBox1.CheckedIndices.Count;
            if (x > 0)
            {
                DialogResult dlg =  MessageBox.Show("Bạn có chắc muốn chọn dịch vụ này ?", "YES/NO", MessageBoxButtons.YesNo);
                if(dlg == DialogResult.Yes)
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var a = context.PhieuDichVus.ToList();
                            int b = a.Count;
                            PhieuDichVu pdv = new PhieuDichVu()
                            {
                                MaPDV = "MPDV" + (b + 1).ToString(),
                                MaKH = makh,
                                TongTien = int.Parse(textTongtien.Text),
                                DaThanhToan = false
                                
                            };
                            context.PhieuDichVus.Add(pdv);
                            context.SaveChanges();
                            foreach (int item in checkedListBox1.CheckedIndices)
                            {
                                var i = (DichVu)checkedListBox1.Items[item];
                                ChiTietDichVu ct = new ChiTietDichVu();
                                ct.MaPDV = pdv.MaPDV;
                                ct.MaDV = i.MaDV;
                                ct.SoLuong = 1;
                                ct.Ngay = DateTime.Now;

                                context.ChiTietDichVus.Add(ct);
                                context.SaveChanges();
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đặt dịch vụ thành công!");
                            transaction.Commit();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            transaction.Rollback();
                        }

                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dịch vụ!");
            }
}

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tt = 0;
            textTongtien.Text = "0";
            foreach (int item in checkedListBox1.CheckedIndices)
            {
                var s = (DichVu)checkedListBox1.Items[item];
                tt = tt + s.DonGia ;
            }
            textTongtien.Text = tt.ToString();
        }
    }
}
