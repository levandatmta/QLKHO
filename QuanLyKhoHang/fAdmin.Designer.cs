namespace QuanLyKhoHang
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tcGioiThieu = new System.Windows.Forms.TabControl();
            this.tcTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPhanquyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataAdmin = new System.Windows.Forms.DataGridView();
            this.idlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhienthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.tcGioiThieu.SuspendLayout();
            this.tcTaiKhoan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tcGioiThieu
            // 
            this.tcGioiThieu.Controls.Add(this.tcTaiKhoan);
            this.tcGioiThieu.Location = new System.Drawing.Point(12, 12);
            this.tcGioiThieu.Name = "tcGioiThieu";
            this.tcGioiThieu.SelectedIndex = 0;
            this.tcGioiThieu.Size = new System.Drawing.Size(636, 443);
            this.tcGioiThieu.TabIndex = 0;
            this.tcGioiThieu.Tag = "";
            // 
            // tcTaiKhoan
            // 
            this.tcTaiKhoan.BackColor = System.Drawing.Color.RoyalBlue;
            this.tcTaiKhoan.Controls.Add(this.btnXem);
            this.tcTaiKhoan.Controls.Add(this.simpleButton2);
            this.tcTaiKhoan.Controls.Add(this.simpleButton1);
            this.tcTaiKhoan.Controls.Add(this.btnAdd);
            this.tcTaiKhoan.Controls.Add(this.panel3);
            this.tcTaiKhoan.Controls.Add(this.panel2);
            this.tcTaiKhoan.Controls.Add(this.panel4);
            this.tcTaiKhoan.Controls.Add(this.panel1);
            this.tcTaiKhoan.Controls.Add(this.btnExit);
            this.tcTaiKhoan.Controls.Add(this.dataAdmin);
            this.tcTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tcTaiKhoan.Name = "tcTaiKhoan";
            this.tcTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tcTaiKhoan.Size = new System.Drawing.Size(628, 417);
            this.tcTaiKhoan.TabIndex = 0;
            this.tcTaiKhoan.Text = "Tài Khoản";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.txbPhanquyen);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(328, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 45);
            this.panel3.TabIndex = 5;
            // 
            // txbPhanquyen
            // 
            this.txbPhanquyen.Location = new System.Drawing.Point(84, 13);
            this.txbPhanquyen.Name = "txbPhanquyen";
            this.txbPhanquyen.Size = new System.Drawing.Size(167, 20);
            this.txbPhanquyen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phân quyền";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.txbPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 45);
            this.panel2.TabIndex = 4;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(100, 13);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(148, 20);
            this.txbPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.txbTen);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(328, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 48);
            this.panel4.TabIndex = 3;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(84, 12);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(167, 20);
            this.txbTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hiển thị";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.txbMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 48);
            this.panel1.TabIndex = 2;
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(100, 15);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(148, 20);
            this.txbMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(528, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataAdmin
            // 
            this.dataAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogin,
            this.tenhienthi,
            this.pass,
            this.loaitk});
            this.dataAdmin.Location = new System.Drawing.Point(6, 237);
            this.dataAdmin.Name = "dataAdmin";
            this.dataAdmin.Size = new System.Drawing.Size(616, 134);
            this.dataAdmin.TabIndex = 0;
            // 
            // idlogin
            // 
            this.idlogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idlogin.DataPropertyName = "idlogin";
            this.idlogin.HeaderText = "Mã người dùng";
            this.idlogin.Name = "idlogin";
            // 
            // tenhienthi
            // 
            this.tenhienthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhienthi.DataPropertyName = "tenhienthi";
            this.tenhienthi.HeaderText = "Tên hiển thị";
            this.tenhienthi.Name = "tenhienthi";
            // 
            // pass
            // 
            this.pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Mật khẩu";
            this.pass.Name = "pass";
            // 
            // loaitk
            // 
            this.loaitk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaitk.DataPropertyName = "loaitk";
            this.loaitk.HeaderText = "Phân quyền";
            this.loaitk.Name = "loaitk";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(161, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(328, 175);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 31);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(479, 173);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 33);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Xóa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnXem
            // 
            this.btnXem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(21, 175);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 31);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(660, 455);
            this.Controls.Add(this.tcGioiThieu);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.tcGioiThieu.ResumeLayout(false);
            this.tcTaiKhoan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcGioiThieu;
        private System.Windows.Forms.TabPage tcTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.TextBox txbPhanquyen;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbTen;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
    }
}