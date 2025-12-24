namespace DoAnWD
{
    partial class frmGhepLop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvGiaSu;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.GroupBox gbGiaSu;
        private System.Windows.Forms.GroupBox gbLopHoc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThongTinGiaSu;
        private System.Windows.Forms.Label lblMaGS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblChuyenMon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoLop;
        private System.Windows.Forms.TextBox txtMaGS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSoLop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnGhepLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splitter1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gbGiaSu = new System.Windows.Forms.GroupBox();
            this.dgvGiaSu = new System.Windows.Forms.DataGridView();
            this.lblThongTinGiaSu = new System.Windows.Forms.Label();
            this.lblMaGS = new System.Windows.Forms.Label();
            this.txtMaGS = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblChuyenMon = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblSoLop = new System.Windows.Forms.Label();
            this.txtSoLop = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.gbLopHoc = new System.Windows.Forms.GroupBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnGhepLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.gbGiaSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSu)).BeginInit();
            this.panelRight.SuspendLayout();
            this.gbLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏫 QUẢN LÝ LỚP HỌC THEO GIA SƯ";

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelLeft.Controls.Add(this.gbGiaSu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15, 15, 7, 15);
            this.panelLeft.Size = new System.Drawing.Size(450, 590);
            this.panelLeft.TabIndex = 1;

            // 
            // gbGiaSu
            // 
            this.gbGiaSu.BackColor = System.Drawing.Color.White;
            this.gbGiaSu.Controls.Add(this.dgvGiaSu);
            this.gbGiaSu.Controls.Add(this.lblThongTinGiaSu);
            this.gbGiaSu.Controls.Add(this.lblMaGS);
            this.gbGiaSu.Controls.Add(this.txtMaGS);
            this.gbGiaSu.Controls.Add(this.lblHoTen);
            this.gbGiaSu.Controls.Add(this.txtHoTen);
            this.gbGiaSu.Controls.Add(this.lblChuyenMon);
            this.gbGiaSu.Controls.Add(this.txtChuyenMon);
            this.gbGiaSu.Controls.Add(this.lblTrangThai);
            this.gbGiaSu.Controls.Add(this.txtTrangThai);
            this.gbGiaSu.Controls.Add(this.lblSoLop);
            this.gbGiaSu.Controls.Add(this.txtSoLop);
            this.gbGiaSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGiaSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbGiaSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gbGiaSu.Location = new System.Drawing.Point(15, 15);
            this.gbGiaSu.Name = "gbGiaSu";
            this.gbGiaSu.Padding = new System.Windows.Forms.Padding(15);
            this.gbGiaSu.Size = new System.Drawing.Size(428, 560);
            this.gbGiaSu.TabIndex = 0;
            this.gbGiaSu.TabStop = false;
            this.gbGiaSu.Text = "👨‍🏫 Danh Sách Gia Sư";

            // 
            // dgvGiaSu
            // 
            this.dgvGiaSu.AllowUserToAddRows = false;
            this.dgvGiaSu.AllowUserToDeleteRows = false;
            this.dgvGiaSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaSu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaSu.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaSu.EnableHeadersVisualStyles = false;
            this.dgvGiaSu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgvGiaSu.Location = new System.Drawing.Point(18, 30);
            this.dgvGiaSu.Name = "dgvGiaSu";
            this.dgvGiaSu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaSu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaSu.RowHeadersVisible = false;
            this.dgvGiaSu.RowTemplate.Height = 30;
            this.dgvGiaSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaSu.Size = new System.Drawing.Size(392, 320);
            this.dgvGiaSu.TabIndex = 0;
            this.dgvGiaSu.SelectionChanged += new System.EventHandler(this.dgvGiaSu_SelectionChanged);

            // 
            // lblThongTinGiaSu
            // 
            this.lblThongTinGiaSu.AutoSize = true;
            this.lblThongTinGiaSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTinGiaSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblThongTinGiaSu.Location = new System.Drawing.Point(18, 360);
            this.lblThongTinGiaSu.Name = "lblThongTinGiaSu";
            this.lblThongTinGiaSu.Size = new System.Drawing.Size(150, 19);
            this.lblThongTinGiaSu.TabIndex = 1;
            this.lblThongTinGiaSu.Text = "📋 Thông Tin Chi Tiết";

            // 
            // lblMaGS
            // 
            this.lblMaGS.AutoSize = true;
            this.lblMaGS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaGS.Location = new System.Drawing.Point(18, 390);
            this.lblMaGS.Name = "lblMaGS";
            this.lblMaGS.Size = new System.Drawing.Size(70, 15);
            this.lblMaGS.Text = "Mã Gia Sư:";

            // 
            // txtMaGS
            // 
            this.txtMaGS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtMaGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaGS.Location = new System.Drawing.Point(120, 387);
            this.txtMaGS.Name = "txtMaGS";
            this.txtMaGS.ReadOnly = true;
            this.txtMaGS.Size = new System.Drawing.Size(100, 23);
            this.txtMaGS.TabIndex = 2;

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(18, 420);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 15);
            this.lblHoTen.Text = "Họ Tên:";

            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.txtHoTen.Location = new System.Drawing.Point(120, 417);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(290, 23);
            this.txtHoTen.TabIndex = 3;

            // 
            // lblChuyenMon
            // 
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChuyenMon.Location = new System.Drawing.Point(18, 450);
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.Size = new System.Drawing.Size(82, 15);
            this.lblChuyenMon.Text = "Chuyên Môn:";

            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtChuyenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChuyenMon.Location = new System.Drawing.Point(120, 447);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.ReadOnly = true;
            this.txtChuyenMon.Size = new System.Drawing.Size(290, 23);
            this.txtChuyenMon.TabIndex = 4;

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.Location = new System.Drawing.Point(18, 480);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 15);
            this.lblTrangThai.Text = "Trạng Thái:";

            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.Location = new System.Drawing.Point(120, 477);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(150, 23);
            this.txtTrangThai.TabIndex = 5;

            // 
            // lblSoLop
            // 
            this.lblSoLop.AutoSize = true;
            this.lblSoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLop.Location = new System.Drawing.Point(18, 510);
            this.lblSoLop.Name = "lblSoLop";
            this.lblSoLop.Size = new System.Drawing.Size(91, 15);
            this.lblSoLop.Text = "Số Lớp Đang Dạy:";

            // 
            // txtSoLop
            // 
            this.txtSoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtSoLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoLop.ForeColor = System.Drawing.Color.White;
            this.txtSoLop.Location = new System.Drawing.Point(120, 507);
            this.txtSoLop.Name = "txtSoLop";
            this.txtSoLop.ReadOnly = true;
            this.txtSoLop.Size = new System.Drawing.Size(100, 23);
            this.txtSoLop.TabIndex = 6;
            this.txtSoLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.splitter1.Location = new System.Drawing.Point(450, 60);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 590);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;

            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelRight.Controls.Add(this.gbLopHoc);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(453, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(7, 15, 15, 15);
            this.panelRight.Size = new System.Drawing.Size(747, 590);
            this.panelRight.TabIndex = 3;

            // 
            // gbLopHoc
            // 
            this.gbLopHoc.BackColor = System.Drawing.Color.White;
            this.gbLopHoc.Controls.Add(this.dgvLopHoc);
            this.gbLopHoc.Controls.Add(this.panelButtons);
            this.gbLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gbLopHoc.Location = new System.Drawing.Point(7, 15);
            this.gbLopHoc.Name = "gbLopHoc";
            this.gbLopHoc.Padding = new System.Windows.Forms.Padding(15);
            this.gbLopHoc.Size = new System.Drawing.Size(725, 560);
            this.gbLopHoc.TabIndex = 0;
            this.gbLopHoc.TabStop = false;
            this.gbLopHoc.Text = "📚 Danh Sách Lớp Học";

            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.AllowUserToDeleteRows = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLopHoc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHoc.EnableHeadersVisualStyles = false;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgvLopHoc.Location = new System.Drawing.Point(15, 29);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowTemplate.Height = 30;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(695, 446);
            this.dgvLopHoc.TabIndex = 0;

            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnGhepLop);
            this.panelButtons.Controls.Add(this.btnXoaLop);
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 475);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelButtons.Size = new System.Drawing.Size(695, 70);
            this.panelButtons.TabIndex = 1;

            // 
            // btnGhepLop
            // 
            this.btnGhepLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGhepLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhepLop.FlatAppearance.BorderSize = 0;
            this.btnGhepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhepLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGhepLop.ForeColor = System.Drawing.Color.White;
            this.btnGhepLop.Location = new System.Drawing.Point(15, 15);
            this.btnGhepLop.Name = "btnGhepLop";
            this.btnGhepLop.Size = new System.Drawing.Size(150, 40);
            this.btnGhepLop.TabIndex = 0;
            this.btnGhepLop.Text = "➕ Ghép Lớp Mới";
            this.btnGhepLop.UseVisualStyleBackColor = false;
            this.btnGhepLop.Click += new System.EventHandler(this.btnGhepLop_Click);

            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(180, 15);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(150, 40);
            this.btnXoaLop.TabIndex = 1;
            this.btnXoaLop.Text = "🗑️ Xóa Lớp";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(345, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // frmGhepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmGhepLop";
            this.Text = "Quản lý Lớp Học theo Gia Sư";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.gbGiaSu.ResumeLayout(false);
            this.gbGiaSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSu)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.gbLopHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}