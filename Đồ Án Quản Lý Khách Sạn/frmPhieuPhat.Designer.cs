namespace Đồ_Án_Quản_Lý_Khách_Sạn
{
    partial class frmPhieuPhat
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
            this.tSBtnExitDR = new System.Windows.Forms.ToolStripButton();
            this.dgvDamageRoom = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnAddDR = new System.Windows.Forms.Button();
            this.btnFixDR = new System.Windows.Forms.Button();
            this.DeleteDR = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageRoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnExitDR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1273, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnExitDR
            // 
            this.tSBtnExitDR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnExitDR.Image = global::Đồ_Án_Quản_Lý_Khách_Sạn.Properties.Resources.exit_toolStrip_cho_các_form_nếu_có_tS;
            this.tSBtnExitDR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnExitDR.Name = "tSBtnExitDR";
            this.tSBtnExitDR.Size = new System.Drawing.Size(29, 24);
            this.tSBtnExitDR.Text = "toolStripButton1";
            // 
            // dgvDamageRoom
            // 
            this.dgvDamageRoom.AllowUserToAddRows = false;
            this.dgvDamageRoom.AllowUserToDeleteRows = false;
            this.dgvDamageRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamageRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapp,
            this.noidungphat,
            this.ngayphat,
            this.sotienphat});
            this.dgvDamageRoom.Location = new System.Drawing.Point(53, 27);
            this.dgvDamageRoom.Name = "dgvDamageRoom";
            this.dgvDamageRoom.ReadOnly = true;
            this.dgvDamageRoom.RowHeadersWidth = 51;
            this.dgvDamageRoom.RowTemplate.Height = 24;
            this.dgvDamageRoom.Size = new System.Drawing.Size(562, 434);
            this.dgvDamageRoom.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nội dung:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(761, 147);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(393, 102);
            this.txtText.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(652, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày phạt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(652, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số tiền phạt:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(761, 78);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(200, 28);
            this.txtMoney.TabIndex = 14;
            // 
            // btnAddDR
            // 
            this.btnAddDR.Location = new System.Drawing.Point(761, 300);
            this.btnAddDR.Name = "btnAddDR";
            this.btnAddDR.Size = new System.Drawing.Size(75, 35);
            this.btnAddDR.TabIndex = 15;
            this.btnAddDR.Text = "Add";
            this.btnAddDR.UseVisualStyleBackColor = true;
            this.btnAddDR.Click += new System.EventHandler(this.btnAddDR_Click);
            // 
            // btnFixDR
            // 
            this.btnFixDR.Location = new System.Drawing.Point(919, 300);
            this.btnFixDR.Name = "btnFixDR";
            this.btnFixDR.Size = new System.Drawing.Size(75, 35);
            this.btnFixDR.TabIndex = 16;
            this.btnFixDR.Text = "Fix";
            this.btnFixDR.UseVisualStyleBackColor = true;
            // 
            // DeleteDR
            // 
            this.DeleteDR.Location = new System.Drawing.Point(1069, 300);
            this.DeleteDR.Name = "DeleteDR";
            this.DeleteDR.Size = new System.Drawing.Size(85, 35);
            this.DeleteDR.TabIndex = 17;
            this.DeleteDR.Text = "Delete";
            this.DeleteDR.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(761, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.DeleteDR);
            this.groupBox2.Controls.Add(this.btnFixDR);
            this.groupBox2.Controls.Add(this.btnAddDR);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvDamageRoom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 477);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Damage Room";
            // 
            // mapp
            // 
            this.mapp.HeaderText = "Mã Phiếu Phạt";
            this.mapp.MinimumWidth = 6;
            this.mapp.Name = "mapp";
            this.mapp.ReadOnly = true;
            this.mapp.Width = 125;
            // 
            // noidungphat
            // 
            this.noidungphat.HeaderText = "Nội Dung Phiếu Phạt";
            this.noidungphat.MinimumWidth = 6;
            this.noidungphat.Name = "noidungphat";
            this.noidungphat.ReadOnly = true;
            this.noidungphat.Width = 125;
            // 
            // ngayphat
            // 
            this.ngayphat.HeaderText = "Ngày Phạt";
            this.ngayphat.MinimumWidth = 6;
            this.ngayphat.Name = "ngayphat";
            this.ngayphat.ReadOnly = true;
            this.ngayphat.Width = 125;
            // 
            // sotienphat
            // 
            this.sotienphat.HeaderText = "Tiền Phạt";
            this.sotienphat.MinimumWidth = 6;
            this.sotienphat.Name = "sotienphat";
            this.sotienphat.ReadOnly = true;
            this.sotienphat.Width = 125;
            // 
            // frmPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1273, 544);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPhieuPhat";
            this.Text = "DamageRoom";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamageRoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnExitDR;
        private System.Windows.Forms.DataGridView dgvDamageRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienphat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnAddDR;
        private System.Windows.Forms.Button btnFixDR;
        private System.Windows.Forms.Button DeleteDR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}