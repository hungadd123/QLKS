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
        KhachSanModels context = new KhachSanModels();
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
                var nv = context.NhanViens.ToList();
                foreach (var item in nv)
                {
                    if(item.MaNV == textUsername.Text && item.PassWord == textPW.Text)
                    {
                        
                        if(item.ChucVu == "Tiếp tân")
                        {
                            //Show giao diện của Nhân viên
                        }
                        else
                        {
                            //Show giao diện của Quản lý
                        }
                        return;
                    }
                }
                var kh = context.KhachHangs.ToList();
                foreach (var item in kh)
                {
                    if(item.UserName == textUsername.Text && item.PassWord == textPW.Text)
                    {
                        //Show giao diện của Khách hàng
                        return;
                    }
                }
                MessageBox.Show("Tài khoản hoặc mật khẩu không dúng vui lòng nhập lại!!");
            }
        }

        private void buttonFPassW_Click(object sender, EventArgs e)
        {
            //Show giao dien Quen mat khau
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            //Show giao dien Dang ki
        }
    }
}
