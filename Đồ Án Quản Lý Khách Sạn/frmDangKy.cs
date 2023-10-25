using Đồ_Án_Quản_Lý_Khách_Sạn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo;

namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    public partial class frmDangKy : Form
    {
        KhachSanmodels context = new KhachSanmodels();
        System.Web.UI.WebControls.Login T;
        public frmDangKy()
        {
            InitializeComponent();
            T = new System.Web.UI.WebControls.Login();
            labelLogIn.Text = T.TitleText;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword2;
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox1.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtConfirmP.UseSystemPasswordChar == true)
            {
                pictureBox2.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword2;
                txtConfirmP.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox2.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.iconpassword;
                txtConfirmP.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            labelPass.Text = "";
        }

        private void txtConfirmP_Click(object sender, EventArgs e)
        {
            labelConfirmP.Text = "";
        }

        private void txtNumb_Click(object sender, EventArgs e)
        {
            labelNumb.Text = "";
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            labelUserName.Text = "";
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            labelAddress.Text = "";
        }

        private void txtFullName_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "";
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.TextBox text = new System.Web.UI.WebControls.TextBox();
            text.Text = labelLogIn.Text;
            this.Close();
        }

        //Ktr username tối ta 10 kí tự
        public bool CheckUserName(string username)
        {
            return Regex.IsMatch(username, "^[a-zA-Z0-9]{1,10}");
        }

        //Check name only chữ không số và có dấu
        public bool CheckFullName(string name)
        {
            return Regex.IsMatch(name, "[a-zA-Z]$");
        }

        //Ktr sdt chỉ nhập số tối đa 10 số
        public bool CheckPhoneNumb(string numb)
        {
            return Regex.IsMatch(numb, "[0-9]{1,10}");
        }

        //Ktr địa chỉ 
        public bool CheckAddress(string place)
        {
            return Regex.IsMatch(place, "[a-zA-Z0-9]$");
        }

        //Ktr PassWord chỉ nhập tối đa 10 kí tự bao gồm số
        public bool CheckPass(string pass)
        {
            return Regex.IsMatch(pass, "[a-zA-Z0-9]{1,10}");
        }

        private void btnLogIN_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text;
            string fullname = txtFullName.Text;
            string phonenumb = txtNumb.Text;
            string address = txtAddress.Text;
            string pass = txtPass.Text;
            string confirmpass = txtConfirmP.Text;
            if (txtNumb.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtConfirmP.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin!");
            }
            else
            {
                if (!CheckUserName(tk))
                {
                    MessageBox.Show("UserName không được hơn 10 kí tự và không có kí tự đặc biệt!");
                    return;
                }
                if (!CheckFullName(fullname))
                {
                    MessageBox.Show("Họ tên không được nhập số chỉ được nhập chữ không phân biệt hoa thường!");
                    return;
                }
                if (!CheckPhoneNumb(phonenumb))
                {
                    MessageBox.Show("Số điện thoại yêu cầu nhập chính xác và không được nhập chữ!");
                    return;
                }
                if (!CheckAddress(address))
                {
                    MessageBox.Show("Vui lòng nhập đúng địa chỉ!");
                    return;
                }
                if (!CheckPass(pass))
                {
                    MessageBox.Show("Mật khẩu chỉ được tối đa 10 kí tự bao gồm kí tự, số");
                    return;
                }
                if (!CheckPass(confirmpass))
                {
                    MessageBox.Show("Xác nhận mật khẩu không đúng.Vui lòng nhập lại!");
                    return;
                }
                try
                {
                    List<KhachHang> listkh = context.KhachHangs.ToList();
                    Add(listkh);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Thêm tài khoản khách hàng
        public void Add(List<KhachHang> listkh)
        {
            KhachSanmodels context = new KhachSanmodels();
            KhachHang kh = new KhachHang();
            kh.MaKH = txtUserName.Text;
            kh.TenKh = txtFullName.Text;
            kh.SDT = txtNumb.Text;
            kh.DiaChi = txtAddress.Text;
            kh.PassWord = txtPass.Text;
            kh.PassWord = txtConfirmP.Text;
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            MessageBox.Show("Đăng kí thành công!", "Thông Báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void checkBoxInforDevies_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInforDevies.Enabled == true)
            {
                //Click có thì form khách hàng đặt phòng phần chọn dịch vụ tự động cập nhật dịch vụ mới ý tưởng ok ko:)) 
            }
        }
    }
}
