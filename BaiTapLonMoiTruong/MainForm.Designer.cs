namespace BaiTapLonMoiTruong
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.familyname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.TextBox();
            this.nganh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhap = new System.Windows.Forms.Button();
            this.xuat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.chinhsua = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.Button();
            this.finding = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.ften = new System.Windows.Forms.RadioButton();
            this.flop = new System.Windows.Forms.RadioButton();
            this.fms = new System.Windows.Forms.RadioButton();
            this.fkhoa = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.xoaall = new System.Windows.Forms.Button();
            this.smale = new System.Windows.Forms.RadioButton();
            this.sfemale = new System.Windows.Forms.RadioButton();
            this.clearsametime = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ, Lót :";
            // 
            // familyname
            // 
            this.familyname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.familyname.Location = new System.Drawing.Point(97, 51);
            this.familyname.Name = "familyname";
            this.familyname.Size = new System.Drawing.Size(174, 25);
            this.familyname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN SINH VIÊN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(457, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp :";
            // 
            // classes
            // 
            this.classes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.classes.Location = new System.Drawing.Point(508, 80);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(90, 25);
            this.classes.TabIndex = 8;
            this.classes.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(604, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "MSSV :";
            // 
            // ids
            // 
            this.ids.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ids.Location = new System.Drawing.Point(668, 80);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(90, 25);
            this.ids.TabIndex = 9;
            this.ids.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // nganh
            // 
            this.nganh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nganh.Location = new System.Drawing.Point(508, 50);
            this.nganh.Name = "nganh";
            this.nganh.Size = new System.Drawing.Size(250, 25);
            this.nganh.TabIndex = 7;
            this.nganh.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(448, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khoa :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(24, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ :";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateofbirth.Location = new System.Drawing.Point(181, 82);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(54, 22);
            this.dateofbirth.TabIndex = 3;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.address.Location = new System.Drawing.Point(97, 110);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(349, 25);
            this.address.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(242, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới Tính :";
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchbox.Location = new System.Drawing.Point(493, 166);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(169, 25);
            this.searchbox.TabIndex = 16;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(8, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "DANH SÁCH :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.holot,
            this.ten,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.khoa,
            this.lop,
            this.mssv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(746, 249);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stt
            // 
            this.stt.Frozen = true;
            this.stt.HeaderText = "STT.";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 40;
            // 
            // holot
            // 
            this.holot.Frozen = true;
            this.holot.HeaderText = "Họ, Lót";
            this.holot.Name = "holot";
            this.holot.ReadOnly = true;
            this.holot.Width = 110;
            // 
            // ten
            // 
            this.ten.Frozen = true;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 60;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Frozen = true;
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 70;
            // 
            // gioitinh
            // 
            this.gioitinh.Frozen = true;
            this.gioitinh.HeaderText = "G.T";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 40;
            // 
            // diachi
            // 
            this.diachi.Frozen = true;
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 120;
            // 
            // khoa
            // 
            this.khoa.Frozen = true;
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            // 
            // lop
            // 
            this.lop.Frozen = true;
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            this.lop.Width = 80;
            // 
            // mssv
            // 
            this.mssv.Frozen = true;
            this.mssv.HeaderText = "MSSV";
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            this.mssv.Width = 83;
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(602, 452);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(75, 23);
            this.nhap.TabIndex = 21;
            this.nhap.Text = "Nhập File";
            this.nhap.UseVisualStyleBackColor = true;
            this.nhap.Click += new System.EventHandler(this.nhap_Click);
            // 
            // xuat
            // 
            this.xuat.Location = new System.Drawing.Point(683, 452);
            this.xuat.Name = "xuat";
            this.xuat.Size = new System.Drawing.Size(75, 23);
            this.xuat.TabIndex = 22;
            this.xuat.Text = "Xuất File";
            this.xuat.UseVisualStyleBackColor = true;
            this.xuat.Click += new System.EventHandler(this.xuat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(277, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name.Location = new System.Drawing.Point(326, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 25);
            this.name.TabIndex = 2;
            // 
            // chinhsua
            // 
            this.chinhsua.Enabled = false;
            this.chinhsua.Location = new System.Drawing.Point(668, 110);
            this.chinhsua.Name = "chinhsua";
            this.chinhsua.Size = new System.Drawing.Size(90, 25);
            this.chinhsua.TabIndex = 11;
            this.chinhsua.Text = "Chỉnh Sửa";
            this.chinhsua.UseVisualStyleBackColor = true;
            this.chinhsua.Click += new System.EventHandler(this.chinhsua_Click);
            // 
            // adding
            // 
            this.adding.Location = new System.Drawing.Point(452, 110);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(210, 25);
            this.adding.TabIndex = 10;
            this.adding.Text = "Lưu Vào Danh Sách";
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // finding
            // 
            this.finding.Location = new System.Drawing.Point(668, 166);
            this.finding.Name = "finding";
            this.finding.Size = new System.Drawing.Size(90, 25);
            this.finding.TabIndex = 17;
            this.finding.Text = "Tim Kiếm";
            this.finding.UseVisualStyleBackColor = true;
            this.finding.Click += new System.EventHandler(this.finding_Click);
            // 
            // xoa
            // 
            this.xoa.Enabled = false;
            this.xoa.Location = new System.Drawing.Point(12, 452);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(108, 23);
            this.xoa.TabIndex = 19;
            this.xoa.Text = "Xóa từng dòng";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Visible = false;
            // 
            // ften
            // 
            this.ften.AutoSize = true;
            this.ften.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ften.Location = new System.Drawing.Point(274, 169);
            this.ften.Name = "ften";
            this.ften.Size = new System.Drawing.Size(46, 19);
            this.ften.TabIndex = 12;
            this.ften.TabStop = true;
            this.ften.Text = "Tên";
            this.ften.UseVisualStyleBackColor = true;
            // 
            // flop
            // 
            this.flop.AutoSize = true;
            this.flop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.flop.Location = new System.Drawing.Point(326, 169);
            this.flop.Name = "flop";
            this.flop.Size = new System.Drawing.Size(46, 19);
            this.flop.TabIndex = 13;
            this.flop.TabStop = true;
            this.flop.Text = "Lớp";
            this.flop.UseVisualStyleBackColor = true;
            // 
            // fms
            // 
            this.fms.AutoSize = true;
            this.fms.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fms.Location = new System.Drawing.Point(378, 169);
            this.fms.Name = "fms";
            this.fms.Size = new System.Drawing.Size(59, 19);
            this.fms.TabIndex = 14;
            this.fms.TabStop = true;
            this.fms.Text = "MSSV";
            this.fms.UseVisualStyleBackColor = true;
            // 
            // fkhoa
            // 
            this.fkhoa.AutoSize = true;
            this.fkhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fkhoa.Location = new System.Drawing.Point(439, 169);
            this.fkhoa.Name = "fkhoa";
            this.fkhoa.Size = new System.Drawing.Size(54, 19);
            this.fkhoa.TabIndex = 15;
            this.fkhoa.TabStop = true;
            this.fkhoa.Text = "Khoa";
            this.fkhoa.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(301, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "-------====o0o====-------";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xoaall
            // 
            this.xoaall.Location = new System.Drawing.Point(126, 452);
            this.xoaall.Name = "xoaall";
            this.xoaall.Size = new System.Drawing.Size(105, 23);
            this.xoaall.TabIndex = 20;
            this.xoaall.Text = "Xóa Toàn Bộ";
            this.xoaall.UseVisualStyleBackColor = true;
            this.xoaall.Click += new System.EventHandler(this.xoaall_Click);
            // 
            // smale
            // 
            this.smale.AutoSize = true;
            this.smale.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smale.Location = new System.Drawing.Point(326, 81);
            this.smale.Name = "smale";
            this.smale.Size = new System.Drawing.Size(55, 21);
            this.smale.TabIndex = 4;
            this.smale.TabStop = true;
            this.smale.Text = "Nam";
            this.smale.UseVisualStyleBackColor = true;
            // 
            // sfemale
            // 
            this.sfemale.AutoSize = true;
            this.sfemale.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfemale.Location = new System.Drawing.Point(387, 81);
            this.sfemale.Name = "sfemale";
            this.sfemale.Size = new System.Drawing.Size(45, 21);
            this.sfemale.TabIndex = 5;
            this.sfemale.TabStop = true;
            this.sfemale.Text = "Nữ";
            this.sfemale.UseVisualStyleBackColor = true;
            // 
            // clearsametime
            // 
            this.clearsametime.Enabled = false;
            this.clearsametime.Location = new System.Drawing.Point(12, 452);
            this.clearsametime.Name = "clearsametime";
            this.clearsametime.Size = new System.Drawing.Size(108, 23);
            this.clearsametime.TabIndex = 23;
            this.clearsametime.Text = "Xóa";
            this.clearsametime.UseVisualStyleBackColor = true;
            this.clearsametime.Click += new System.EventHandler(this.clearsametime_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormatString = "N2";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(97, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(36, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox2.FormatString = "N2";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(139, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(36, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(770, 483);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearsametime);
            this.Controls.Add(this.sfemale);
            this.Controls.Add(this.smale);
            this.Controls.Add(this.xoaall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fms);
            this.Controls.Add(this.flop);
            this.Controls.Add(this.fkhoa);
            this.Controls.Add(this.ften);
            this.Controls.Add(this.xuat);
            this.Controls.Add(this.finding);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.chinhsua);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.nganh);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.address);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.familyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(786, 522);
            this.MinimumSize = new System.Drawing.Size(786, 522);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeform);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox familyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.TextBox nganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateofbirth;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nhap;
        private System.Windows.Forms.Button xuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button chinhsua;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Button finding;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.RadioButton ften;
        private System.Windows.Forms.RadioButton flop;
        private System.Windows.Forms.RadioButton fms;
        private System.Windows.Forms.RadioButton fkhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button xoaall;
        private System.Windows.Forms.RadioButton smale;
        private System.Windows.Forms.RadioButton sfemale;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn holot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.Button clearsametime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

