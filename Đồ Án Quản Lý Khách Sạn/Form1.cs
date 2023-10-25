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
    public partial class Form1 : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textPW.UseSystemPasswordChar == true)
            {
                pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword2;
                textPW.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword;
                textPW.UseSystemPasswordChar = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textUsername.Text == ""|| textPW.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            }
            else
            {
                int flag = 0;
                var nv = context.NhanViens.ToList();
                foreach (var item in nv)
                {
                    if(item.MaNV == textUsername.Text && item.PassWord == textPW.Text)
                    {
                        
                        if(item.ChucVu.Contains("Lễ tân"))
                        {
                            flag = 1;
                            //Show giao diện của Nhân viên
                            frmTiepTan f1 = new frmTiepTan(item.MaNV);
                            f1.ShowDialog();
                        }
                        else
                        {
                            flag = 1;
                            //Show giao diện của Quản lý
                            frmQuanLy f2 = new frmQuanLy(item.MaNV);
                            f2.ShowDialog();
                        }
                        
                    }
                }
                var kh = context.KhachHangs.ToList();
                foreach (var item in kh)
                {
                    if(item.MaKH.Equals(textUsername.Text)  && item.PassWord.Equals(textPW.Text))
                    {
                        flag = 1;
                        //Show giao diện của Khách hàng
                        //MessageBox.Show("Khách hàng! ");
                        frmKhachHang f3 = new frmKhachHang(item.MaKH);
                        f3.ShowDialog();
                    }
                }
                if(flag == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng ! ");
                }
                
            }
        }

        private void buttonFPassW_Click(object sender, EventArgs e)
        {
            //Show giao dien Quen mat khau
            frmQuenMK f1 = new frmQuenMK();
            f1.ShowDialog();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            //Show giao dien Dang ki
            frmDangKy f1 = new frmDangKy();
            f1.ShowDialog();
        }
    }
}
