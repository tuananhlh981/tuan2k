namespace CuaHangBanDia.Forms
{
    partial class frmTheloai
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttentheloai = new System.Windows.Forms.TextBox();
            this.txtmathetloai = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(696, 128);
            this.dataGridView1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã thể loại";
            // 
            // txttentheloai
            // 
            this.txttentheloai.BackColor = System.Drawing.Color.Linen;
            this.txttentheloai.Location = new System.Drawing.Point(351, 104);
            this.txttentheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttentheloai.Name = "txttentheloai";
            this.txttentheloai.Size = new System.Drawing.Size(206, 22);
            this.txttentheloai.TabIndex = 26;
            // 
            // txtmathetloai
            // 
            this.txtmathetloai.BackColor = System.Drawing.Color.Linen;
            this.txtmathetloai.Location = new System.Drawing.Point(351, 67);
            this.txtmathetloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmathetloai.Name = "txtmathetloai";
            this.txtmathetloai.Size = new System.Drawing.Size(206, 22);
            this.txtmathetloai.TabIndex = 25;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Linen;
            this.btnthoat.Location = new System.Drawing.Point(654, 350);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(93, 34);
            this.btnthoat.TabIndex = 24;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Linen;
            this.btntim.Location = new System.Drawing.Point(504, 350);
            this.btntim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(93, 34);
            this.btntim.TabIndex = 23;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Linen;
            this.btnxoa.Location = new System.Drawing.Point(351, 350);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 34);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Linen;
            this.btnsua.Location = new System.Drawing.Point(201, 350);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 34);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Linen;
            this.btnthem.Location = new System.Drawing.Point(52, 350);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 34);
            this.btnthem.TabIndex = 20;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttentheloai);
            this.Controls.Add(this.txtmathetloai);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Name = "frmTheloai";
            this.Text = "Theloai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttentheloai;
        private System.Windows.Forms.TextBox txtmathetloai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
    }
}