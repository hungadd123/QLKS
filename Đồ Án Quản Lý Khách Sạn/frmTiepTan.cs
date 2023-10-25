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
    public partial class frmTiepTan : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        string manv;
        public frmTiepTan(string mNV)
        {
            InitializeComponent();
            manv = mNV;
        }
        private void btnInfor1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Phong> listp = context.Phongs.ToList();
                DataRoom(listp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load data room 
        private void DataRoom(List<Phong> listp)
        {
            dgvAllRoom.Rows.Clear();
            foreach (var item in listp)
            {
                int index = dgvAllRoom.Rows.Add();
                dgvAllRoom.Rows[index].Cells[0].Value = item.MaPhong;
                dgvAllRoom.Rows[index].Cells[1].Value = item.MaLoaiPhong;
                if (item.LoaiPhong != null)
                {
                    dgvAllRoom.Rows[index].Cells[2].Value = item.LoaiPhong.MoTa;
                    dgvAllRoom.Rows[index].Cells[3].Value = item.LoaiPhong.GiaPhong;
                }
            }
        }

        //Show thông tin room
        private void dgvAllRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhachSanmodels context = new KhachSanmodels();
                string id = dgvAllRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
                var xet = context.Phongs.FirstOrDefault(x => x.MaPhong.Equals(id));
                if (xet != null)
                {
                    txtMaPhong.Text = xet.MaPhong.ToString();
                    txtMaLoai.Text = xet.MaLoaiPhong.ToString();
                    if (xet.LoaiPhong != null)
                    {
                        txtLoaiPhong.Text = xet.LoaiPhong.MoTa.ToString();
                        txtGia.Text = xet.LoaiPhong.GiaPhong.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Show thông tin dịch vụ khách sạn
        private void tSBtnDevices_Click(object sender, EventArgs e)
        {
            DevicesInfor di = new DevicesInfor();
            di.ShowDialog();
        }

        //Show thông tin khách hàng
        private void tSBtnCustomer_Click(object sender, EventArgs e)
        {
            CustomersInfor ci = new CustomersInfor();
            ci.ShowDialog();
        }

        //Show thông tin nhân viên "Lễ Tân"
        private void tSBtnPersonalInfor_Click(object sender, EventArgs e)
        {
            PersonalInfor pi = new PersonalInfor();
            pi.ShowDialog();
        }

        //Room Hired
        private void btnRoomHire_Click(object sender, EventArgs e)
        {
            var list = context.Phongs.ToList();
            var pdp = context.PhieuDatPhongs.ToList();
            foreach (var item in list)
            {
                var x = context.PhieuDatPhongs.FirstOrDefault(p => p.MaPhong == item.MaPhong);
                if(x != null)
                {
                    if(x.DaThanhToan == false)
                    {
                        int a = dgvRoomHire.Rows.Add();
                        dgvRoomHire.Rows[a].Cells[0].Value = x.MaPhong ;
                        dgvRoomHire.Rows[a].Cells[1].Value = x.MaPDP;
                        var s = context.Phongs.FirstOrDefault(p => p.MaPhong == item.MaPhong);
                        if(s != null)
                        {
                            dgvRoomHire.Rows[a].Cells[2].Value = s.LoaiPhong.MoTa;
                            dgvRoomHire.Rows[a].Cells[3].Value = s.LoaiPhong.GiaPhong;
                        }
                        
                    }
                }
            }
        }


        // RoomEmpty
        private void button2_Click(object sender, EventArgs e)
        {
            dgvRoomEmpty.Rows.Clear();
            var list1 = context.Phongs.ToList();
            foreach (var item in list1)
            {
                if(item.TinhTrang == false)
                {
                    int i = dgvRoomEmpty.Rows.Add();
                    dgvRoomEmpty.Rows[i].Cells[0].Value = item.MaPhong;
                    dgvRoomEmpty.Rows[i].Cells[1].Value = item.MaLoaiPhong;
                    if (item.LoaiPhong != null)
                    {
                        dgvRoomEmpty.Rows[i].Cells[2].Value = item.LoaiPhong.MoTa;
                        dgvRoomEmpty.Rows[i].Cells[3].Value = item.LoaiPhong.GiaPhong;
                    }           
                }
            }
        }

        // RoomEmpty
        private void dgvRoomEmpty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtIDRoomEmpty.Text = dgvRoomEmpty.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDRoomTypeE.Text = dgvRoomEmpty.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRoomTypeE.Text = dgvRoomEmpty.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPriceE.Text = dgvRoomEmpty.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //RoomHired
        private void dgvRoomHire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDRoomHire.Text = dgvRoomHire.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPDPHire.Text = dgvRoomHire.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLPHire.Text = dgvRoomHire.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGiaHire.Text = dgvRoomHire.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void tSBtnBills_Click(object sender, EventArgs e)
        {
            frmHoaDon f4 = new frmHoaDon(manv);
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIDRoomEmpty.Text ==""|| txtIDRoomTypeE.Text =="" || txtRoomTypeE.Text == ""|| txtPriceE.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc muốn sử dụng phòng này !","Yes/No",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dlg == DialogResult.Yes)
                {
                    var x = context.Phongs.FirstOrDefault(p=>p.MaPhong == txtIDRoomEmpty.Text);
                    if(x != null)
                    {
                        x.TinhTrang = true;
                    }
                    context.SaveChanges();
                }
            }
        }


        //Tiếp tân chỉ còn phòng đã thuê vs chưa thuê (ko bt code shao ko có form KH đặt phòng bro code phụ vs ét o ét)
        // À còn thêm bill của tiếp tân cũng như note trên nhá bro:)))
    }
}
