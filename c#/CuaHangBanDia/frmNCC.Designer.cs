namespace CuaHangBanDia
{
    partial class tblncc
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
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.mncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtenncc = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mncc,
            this.tncc,
            this.dc,
            this.dt});
            this.dgv_ncc.Location = new System.Drawing.Point(48, 172);
            this.dgv_ncc.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.RowHeadersWidth = 62;
            this.dgv_ncc.RowTemplate.Height = 28;
            this.dgv_ncc.Size = new System.Drawing.Size(522, 104);
            this.dgv_ncc.TabIndex = 15;
            this.dgv_ncc.Click += new System.EventHandler(this.dgv_ncc_Click);
            // 
            // mncc
            // 
            this.mncc.DataPropertyName = "mancc";
            this.mncc.HeaderText = "Ma nha cung cap";
            this.mncc.Name = "mncc";
            this.mncc.ReadOnly = true;
            // 
            // tncc
            // 
            this.tncc.DataPropertyName = "tenncc";
            this.tncc.HeaderText = "Ten nha cung cap";
            this.tncc.Name = "tncc";
            this.tncc.ReadOnly = true;
            // 
            // dc
            // 
            this.dc.DataPropertyName = "diachi";
            this.dc.HeaderText = "dia chi";
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "dienthoai";
            this.dt.HeaderText = "sdt";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Linen;
            this.btnthoat.Location = new System.Drawing.Point(500, 302);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(70, 27);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Linen;
            this.btntim.Location = new System.Drawing.Point(387, 302);
            this.btntim.Margin = new System.Windows.Forms.Padding(2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(70, 27);
            this.btntim.TabIndex = 13;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Linen;
            this.btnxoa.Location = new System.Drawing.Point(273, 302);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 27);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Linen;
            this.btnsua.Location = new System.Drawing.Point(160, 302);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 27);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Linen;
            this.btnthem.Location = new System.Drawing.Point(48, 302);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 27);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtenncc
            // 
            this.txtenncc.BackColor = System.Drawing.Color.Linen;
            this.txtenncc.Location = new System.Drawing.Point(412, 71);
            this.txtenncc.Margin = new System.Windows.Forms.Padding(2);
            this.txtenncc.Name = "txtenncc";
            this.txtenncc.Size = new System.Drawing.Size(159, 20);
            this.txtenncc.TabIndex = 29;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.Linen;
            this.txtsdt.Location = new System.Drawing.Point(143, 105);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(134, 20);
            this.txtsdt.TabIndex = 28;
            // 
            // txtmancc
            // 
            this.txtmancc.BackColor = System.Drawing.Color.Linen;
            this.txtmancc.Location = new System.Drawing.Point(143, 71);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(2);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(134, 20);
            this.txtmancc.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tên nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.Linen;
            this.txtdiachi.Location = new System.Drawing.Point(361, 105);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(210, 20);
            this.txtdiachi.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Địa chỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(625, 354);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtenncc);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tblncc";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.tblncc_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblncc_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtenncc;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
    }
}