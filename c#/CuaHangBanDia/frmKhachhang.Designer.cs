namespace CuaHangBanDia
{
    partial class tblkhachhang
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
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.Linen;
            this.txtdiachi.Location = new System.Drawing.Point(363, 106);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(210, 20);
            this.txtdiachi.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Địa chỉ";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.BackColor = System.Drawing.Color.Linen;
            this.txttenkhachhang.Location = new System.Drawing.Point(414, 72);
            this.txttenkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(159, 20);
            this.txttenkhachhang.TabIndex = 43;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.Linen;
            this.txtsdt.Location = new System.Drawing.Point(145, 106);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(134, 20);
            this.txtsdt.TabIndex = 42;
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.BackColor = System.Drawing.Color.Linen;
            this.txtmakhachhang.Location = new System.Drawing.Point(145, 72);
            this.txtmakhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(134, 20);
            this.txtmakhachhang.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mã khách hàng";
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.dt,
            this.dc});
            this.dgv_khachhang.Location = new System.Drawing.Point(50, 173);
            this.dgv_khachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 62;
            this.dgv_khachhang.RowTemplate.Height = 28;
            this.dgv_khachhang.Size = new System.Drawing.Size(522, 104);
            this.dgv_khachhang.TabIndex = 37;
            this.dgv_khachhang.Click += new System.EventHandler(this.dgv_khachhang_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Linen;
            this.btnthoat.Location = new System.Drawing.Point(502, 302);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(70, 27);
            this.btnthoat.TabIndex = 36;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Linen;
            this.btntim.Location = new System.Drawing.Point(389, 302);
            this.btntim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(70, 27);
            this.btntim.TabIndex = 35;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Linen;
            this.btnxoa.Location = new System.Drawing.Point(275, 302);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 27);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Linen;
            this.btnsua.Location = new System.Drawing.Point(162, 302);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 27);
            this.btnsua.TabIndex = 33;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Linen;
            this.btnthem.Location = new System.Drawing.Point(50, 302);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 27);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makhach";
            this.makh.HeaderText = "Ma khach hang";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkhach";
            this.tenkh.HeaderText = "Ten khach hang";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "dienthoai";
            this.dt.HeaderText = "dienthoai";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            // 
            // dc
            // 
            this.dc.DataPropertyName = "diachi";
            this.dc.HeaderText = "diachi";
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            // 
            // tblkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(625, 354);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenkhachhang);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_khachhang);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tblkhachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.tblkhachhang_Load);
            this.Click += new System.EventHandler(this.tblkhachhang_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblkhachhang_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
    }
}