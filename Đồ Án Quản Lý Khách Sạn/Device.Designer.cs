namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    partial class Device
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInforDevice = new System.Windows.Forms.DataGridView();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteDevices = new System.Windows.Forms.Button();
            this.btnFixDevices = new System.Windows.Forms.Button();
            this.btnAddDevices = new System.Windows.Forms.Button();
            this.txtIDDevices = new System.Windows.Forms.TextBox();
            this.txtPriceDevices = new System.Windows.Forms.TextBox();
            this.txtNameDevices = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDevice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvInforDevice);
            this.groupBox1.Location = new System.Drawing.Point(38, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "INFOR DEVICES";
            // 
            // dgvInforDevice
            // 
            this.dgvInforDevice.AllowUserToAddRows = false;
            this.dgvInforDevice.AllowUserToDeleteRows = false;
            this.dgvInforDevice.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInforDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madv,
            this.tendv,
            this.gia});
            this.dgvInforDevice.Location = new System.Drawing.Point(0, 94);
            this.dgvInforDevice.Name = "dgvInforDevice";
            this.dgvInforDevice.ReadOnly = true;
            this.dgvInforDevice.RowHeadersWidth = 51;
            this.dgvInforDevice.RowTemplate.Height = 24;
            this.dgvInforDevice.Size = new System.Drawing.Size(585, 260);
            this.dgvInforDevice.TabIndex = 0;
            this.dgvInforDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforDevice_CellClick);
            // 
            // madv
            // 
            this.madv.HeaderText = "ID ";
            this.madv.MinimumWidth = 6;
            this.madv.Name = "madv";
            this.madv.ReadOnly = true;
            this.madv.Width = 135;
            // 
            // tendv
            // 
            this.tendv.HeaderText = "Name Devices";
            this.tendv.MinimumWidth = 6;
            this.tendv.Name = "tendv";
            this.tendv.ReadOnly = true;
            this.tendv.Width = 200;
            // 
            // gia
            // 
            this.gia.HeaderText = "Price";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnDeleteDevices);
            this.groupBox2.Controls.Add(this.btnFixDevices);
            this.groupBox2.Controls.Add(this.btnAddDevices);
            this.groupBox2.Controls.Add(this.txtIDDevices);
            this.groupBox2.Controls.Add(this.txtPriceDevices);
            this.groupBox2.Controls.Add(this.txtNameDevices);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(680, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 452);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "DEVICES";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(472, 35);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDevices
            // 
            this.btnDeleteDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDevices.Location = new System.Drawing.Point(345, 366);
            this.btnDeleteDevices.Name = "btnDeleteDevices";
            this.btnDeleteDevices.Size = new System.Drawing.Size(108, 35);
            this.btnDeleteDevices.TabIndex = 8;
            this.btnDeleteDevices.Text = "Delete Devices";
            this.btnDeleteDevices.UseVisualStyleBackColor = true;
            this.btnDeleteDevices.Click += new System.EventHandler(this.btnDeleteDevices_Click);
            // 
            // btnFixDevices
            // 
            this.btnFixDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixDevices.Location = new System.Drawing.Point(198, 366);
            this.btnFixDevices.Name = "btnFixDevices";
            this.btnFixDevices.Size = new System.Drawing.Size(109, 35);
            this.btnFixDevices.TabIndex = 7;
            this.btnFixDevices.Text = "Fix Devices";
            this.btnFixDevices.UseVisualStyleBackColor = true;
            this.btnFixDevices.Click += new System.EventHandler(this.btnFixDevices_Click);
            // 
            // btnAddDevices
            // 
            this.btnAddDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevices.Location = new System.Drawing.Point(47, 366);
            this.btnAddDevices.Name = "btnAddDevices";
            this.btnAddDevices.Size = new System.Drawing.Size(109, 35);
            this.btnAddDevices.TabIndex = 6;
            this.btnAddDevices.Text = "Add Devices";
            this.btnAddDevices.UseVisualStyleBackColor = true;
            this.btnAddDevices.Click += new System.EventHandler(this.btnAddDevices_Click);
            // 
            // txtIDDevices
            // 
            this.txtIDDevices.Location = new System.Drawing.Point(145, 127);
            this.txtIDDevices.Name = "txtIDDevices";
            this.txtIDDevices.Size = new System.Drawing.Size(136, 22);
            this.txtIDDevices.TabIndex = 5;
            // 
            // txtPriceDevices
            // 
            this.txtPriceDevices.Location = new System.Drawing.Point(96, 280);
            this.txtPriceDevices.Name = "txtPriceDevices";
            this.txtPriceDevices.Size = new System.Drawing.Size(136, 22);
            this.txtPriceDevices.TabIndex = 4;
            // 
            // txtNameDevices
            // 
            this.txtNameDevices.Location = new System.Drawing.Point(174, 203);
            this.txtNameDevices.Name = "txtNameDevices";
            this.txtNameDevices.Size = new System.Drawing.Size(136, 22);
            this.txtNameDevices.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Devices:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Devices:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1203, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnExit
            // 
            this.tSBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnExit.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.exit_toolStrip_cho_các_form_nếu_có_tS;
            this.tSBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnExit.Name = "tSBtnExit";
            this.tSBtnExit.Size = new System.Drawing.Size(29, 24);
            this.tSBtnExit.Text = "toolStripButton1";
            this.tSBtnExit.Click += new System.EventHandler(this.tSBtnExit_Click);
            // s
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.formQL_device;
            this.ClientSize = new System.Drawing.Size(1203, 619);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Device";
            this.Text = "Device";
            this.Load += new System.EventHandler(this.Device_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDevice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteDevices;
        private System.Windows.Forms.Button btnFixDevices;
        private System.Windows.Forms.Button btnAddDevices;
        private System.Windows.Forms.TextBox txtIDDevices;
        private System.Windows.Forms.TextBox txtPriceDevices;
        private System.Windows.Forms.TextBox txtNameDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInforDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnExit;
    }
}