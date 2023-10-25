namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnExitBillPay = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxMaPhieuPhat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaPDVu = new System.Windows.Forms.ComboBox();
            this.comboBoxMaPDP = new System.Windows.Forms.ComboBox();
            this.BtnDeleteBillPay = new System.Windows.Forms.Button();
            this.btnFixBillPay = new System.Windows.Forms.Button();
            this.btnAddBillPay = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPayBills = new System.Windows.Forms.Button();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInforBillsPay = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPPhạt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforBillsPay)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnExitBillPay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnExitBillPay
            // 
            this.tSBtnExitBillPay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnExitBillPay.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.exit_toolStrip_cho_các_form_nếu_có_tS;
            this.tSBtnExitBillPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnExitBillPay.Name = "tSBtnExitBillPay";
            this.tSBtnExitBillPay.Size = new System.Drawing.Size(29, 24);
            this.tSBtnExitBillPay.Text = "toolStripButton1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxMaPhong);
            this.groupBox1.Controls.Add(this.comboBoxMaPhieuPhat);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxMaPDVu);
            this.groupBox1.Controls.Add(this.comboBoxMaPDP);
            this.groupBox1.Controls.Add(this.BtnDeleteBillPay);
            this.groupBox1.Controls.Add(this.btnFixBillPay);
            this.groupBox1.Controls.Add(this.btnAddBillPay);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnPayBills);
            this.groupBox1.Controls.Add(this.txtSumCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvInforBillsPay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 601);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills";
            // 
            // comboBoxMaPhong
            // 
            this.comboBoxMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaPhong.FormattingEnabled = true;
            this.comboBoxMaPhong.Location = new System.Drawing.Point(567, 215);
            this.comboBoxMaPhong.Name = "comboBoxMaPhong";
            this.comboBoxMaPhong.Size = new System.Drawing.Size(145, 30);
            this.comboBoxMaPhong.TabIndex = 34;
            this.comboBoxMaPhong.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPhong_SelectedIndexChanged);
            // 
            // comboBoxMaPhieuPhat
            // 
            this.comboBoxMaPhieuPhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaPhieuPhat.FormattingEnabled = true;
            this.comboBoxMaPhieuPhat.Location = new System.Drawing.Point(567, 59);
            this.comboBoxMaPhieuPhat.Name = "comboBoxMaPhieuPhat";
            this.comboBoxMaPhieuPhat.Size = new System.Drawing.Size(145, 30);
            this.comboBoxMaPhieuPhat.TabIndex = 33;
            this.comboBoxMaPhieuPhat.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPhieuPhat_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 28);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // comboBoxMaPDVu
            // 
            this.comboBoxMaPDVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaPDVu.FormattingEnabled = true;
            this.comboBoxMaPDVu.Location = new System.Drawing.Point(567, 105);
            this.comboBoxMaPDVu.Name = "comboBoxMaPDVu";
            this.comboBoxMaPDVu.Size = new System.Drawing.Size(145, 30);
            this.comboBoxMaPDVu.TabIndex = 31;
            this.comboBoxMaPDVu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPDVu_SelectedIndexChanged);
            // 
            // comboBoxMaPDP
            // 
            this.comboBoxMaPDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaPDP.FormattingEnabled = true;
            this.comboBoxMaPDP.Location = new System.Drawing.Point(248, 215);
            this.comboBoxMaPDP.Name = "comboBoxMaPDP";
            this.comboBoxMaPDP.Size = new System.Drawing.Size(145, 30);
            this.comboBoxMaPDP.TabIndex = 30;
            this.comboBoxMaPDP.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPDP_SelectedIndexChanged);
            // 
            // BtnDeleteBillPay
            // 
            this.BtnDeleteBillPay.Enabled = false;
            this.BtnDeleteBillPay.Location = new System.Drawing.Point(1075, 204);
            this.BtnDeleteBillPay.Name = "BtnDeleteBillPay";
            this.BtnDeleteBillPay.Size = new System.Drawing.Size(83, 35);
            this.BtnDeleteBillPay.TabIndex = 29;
            this.BtnDeleteBillPay.Text = "Delete";
            this.BtnDeleteBillPay.UseVisualStyleBackColor = true;
            // 
            // btnFixBillPay
            // 
            this.btnFixBillPay.Enabled = false;
            this.btnFixBillPay.Location = new System.Drawing.Point(948, 208);
            this.btnFixBillPay.Name = "btnFixBillPay";
            this.btnFixBillPay.Size = new System.Drawing.Size(74, 31);
            this.btnFixBillPay.TabIndex = 28;
            this.btnFixBillPay.Text = "Fix";
            this.btnFixBillPay.UseVisualStyleBackColor = true;
            // 
            // btnAddBillPay
            // 
            this.btnAddBillPay.Location = new System.Drawing.Point(741, 56);
            this.btnAddBillPay.Name = "btnAddBillPay";
            this.btnAddBillPay.Size = new System.Drawing.Size(196, 35);
            this.btnAddBillPay.TabIndex = 27;
            this.btnAddBillPay.Text = "Add phiếu phạt";
            this.btnAddBillPay.UseVisualStyleBackColor = true;
            this.btnAddBillPay.Click += new System.EventHandler(this.btnAddBillPay_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(567, 160);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(145, 28);
            this.txtMaKH.TabIndex = 25;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(429, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Mã Phiếu Dịch Vụ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(433, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "Mã Phòng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(433, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Mã Phiếu Phạt:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(248, 115);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(145, 28);
            this.txtSoTien.TabIndex = 17;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(248, 67);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(145, 28);
            this.txtMaNV.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(433, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Mã Khách Hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mã Nhân Viên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Mã Phiếu đặt Phòng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(93, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Ngày Lập:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số Tiền:";
            // 
            // btnPayBills
            // 
            this.btnPayBills.Location = new System.Drawing.Point(741, 211);
            this.btnPayBills.Name = "btnPayBills";
            this.btnPayBills.Size = new System.Drawing.Size(140, 28);
            this.btnPayBills.TabIndex = 4;
            this.btnPayBills.Text = "Thanh Toán";
            this.btnPayBills.UseVisualStyleBackColor = true;
            this.btnPayBills.Click += new System.EventHandler(this.btnPayBills_Click);
            // 
            // txtSumCost
            // 
            this.txtSumCost.Location = new System.Drawing.Point(1058, 553);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(156, 28);
            this.txtSumCost.TabIndex = 3;
            this.txtSumCost.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Tiền:";
            // 
            // dgvInforBillsPay
            // 
            this.dgvInforBillsPay.AllowUserToAddRows = false;
            this.dgvInforBillsPay.AllowUserToDeleteRows = false;
            this.dgvInforBillsPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforBillsPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.sotien,
            this.ngaylap,
            this.mapdp,
            this.manv,
            this.makh,
            this.maPPhạt,
            this.maphong,
            this.mapdv});
            this.dgvInforBillsPay.Location = new System.Drawing.Point(40, 278);
            this.dgvInforBillsPay.Name = "dgvInforBillsPay";
            this.dgvInforBillsPay.ReadOnly = true;
            this.dgvInforBillsPay.RowHeadersWidth = 51;
            this.dgvInforBillsPay.RowTemplate.Height = 24;
            this.dgvInforBillsPay.Size = new System.Drawing.Size(1174, 263);
            this.dgvInforBillsPay.TabIndex = 1;
            // 
            // mahd
            // 
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            this.mahd.Width = 125;
            // 
            // sotien
            // 
            this.sotien.HeaderText = "Số Tiền";
            this.sotien.MinimumWidth = 6;
            this.sotien.Name = "sotien";
            this.sotien.ReadOnly = true;
            this.sotien.Width = 125;
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày Lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            this.ngaylap.Width = 125;
            // 
            // mapdp
            // 
            this.mapdp.HeaderText = "Mã Phiếu đặt Phòng";
            this.mapdp.MinimumWidth = 6;
            this.mapdp.Name = "mapdp";
            this.mapdp.ReadOnly = true;
            this.mapdp.Width = 125;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã NV";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 125;
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã KH";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 125;
            // 
            // maPPhạt
            // 
            this.maPPhạt.HeaderText = "Mã Phiếu Phạt";
            this.maPPhạt.MinimumWidth = 6;
            this.maPPhạt.Name = "maPPhạt";
            this.maPPhạt.ReadOnly = true;
            this.maPPhạt.Width = 125;
            // 
            // maphong
            // 
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            this.maphong.Width = 125;
            // 
            // mapdv
            // 
            this.mapdv.HeaderText = "Mã Phiếu Dịch Vụ";
            this.mapdv.MinimumWidth = 6;
            this.mapdv.Name = "mapdv";
            this.mapdv.ReadOnly = true;
            this.mapdv.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bills";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1297, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHoaDon";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforBillsPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnExitBillPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInforBillsPay;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPPhạt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapdv;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnDeleteBillPay;
        private System.Windows.Forms.Button btnFixBillPay;
        private System.Windows.Forms.Button btnAddBillPay;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxMaPDVu;
        private System.Windows.Forms.ComboBox comboBoxMaPDP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMaPhieuPhat;
        private System.Windows.Forms.ComboBox comboBoxMaPhong;
    }
}