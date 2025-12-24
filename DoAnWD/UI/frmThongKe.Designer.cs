namespace DoAnWD
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbGiaSu;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.DataGridView dgvGiaSu;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Panel pnlTongGS;
        private System.Windows.Forms.Panel pnlTongHV;
        private System.Windows.Forms.Panel pnlTongLop;
        private System.Windows.Forms.Panel pnlGSRanh;
        private System.Windows.Forms.Panel pnlGSDangDay;
        private System.Windows.Forms.Panel pnlLopDangHoc;
        private System.Windows.Forms.Label lblTongGS;
        private System.Windows.Forms.Label lblCountGS;
        private System.Windows.Forms.Label lblTongHV;
        private System.Windows.Forms.Label lblCountHV;
        private System.Windows.Forms.Label lblTongLop;
        private System.Windows.Forms.Label lblCountLop;
        private System.Windows.Forms.Label lblGSRanh;
        private System.Windows.Forms.Label lblCountGSRanh;
        private System.Windows.Forms.Label lblGSDangDay;
        private System.Windows.Forms.Label lblCountGSDangDay;
        private System.Windows.Forms.Label lblLopDangHoc;
        private System.Windows.Forms.Label lblCountLopDangHoc;
        private System.Windows.Forms.Label lblThongTinGS;
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

            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.pnlTongGS = new System.Windows.Forms.Panel();
            this.lblCountGS = new System.Windows.Forms.Label();
            this.lblTongGS = new System.Windows.Forms.Label();
            this.pnlTongHV = new System.Windows.Forms.Panel();
            this.lblCountHV = new System.Windows.Forms.Label();
            this.lblTongHV = new System.Windows.Forms.Label();
            this.pnlTongLop = new System.Windows.Forms.Panel();
            this.lblCountLop = new System.Windows.Forms.Label();
            this.lblTongLop = new System.Windows.Forms.Label();
            this.pnlGSRanh = new System.Windows.Forms.Panel();
            this.lblCountGSRanh = new System.Windows.Forms.Label();
            this.lblGSRanh = new System.Windows.Forms.Label();
            this.pnlGSDangDay = new System.Windows.Forms.Panel();
            this.lblCountGSDangDay = new System.Windows.Forms.Label();
            this.lblGSDangDay = new System.Windows.Forms.Label();
            this.pnlLopDangHoc = new System.Windows.Forms.Panel();
            this.lblCountLopDangHoc = new System.Windows.Forms.Label();
            this.lblLopDangHoc = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gbGiaSu = new System.Windows.Forms.GroupBox();
            this.dgvGiaSu = new System.Windows.Forms.DataGridView();
            this.lblThongTinGS = new System.Windows.Forms.Label();
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
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();

            this.panelTop.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.pnlTongGS.SuspendLayout();
            this.pnlTongHV.SuspendLayout();
            this.pnlTongLop.SuspendLayout();
            this.pnlGSRanh.SuspendLayout();
            this.pnlGSDangDay.SuspendLayout();
            this.pnlLopDangHoc.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.gbGiaSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSu)).BeginInit();
            this.panelRight.SuspendLayout();
            this.gbThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelTop.Controls.Add(this.btnRefresh);
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
            this.lblTitle.Size = new System.Drawing.Size(380, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 THỐNG KÊ THEO GIA SƯ";

            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Location = new System.Drawing.Point(1030, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelStats.Controls.Add(this.pnlTongGS);
            this.panelStats.Controls.Add(this.pnlTongHV);
            this.panelStats.Controls.Add(this.pnlTongLop);
            this.panelStats.Controls.Add(this.pnlGSRanh);
            this.panelStats.Controls.Add(this.pnlGSDangDay);
            this.panelStats.Controls.Add(this.pnlLopDangHoc);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 60);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.panelStats.Size = new System.Drawing.Size(1200, 130);
            this.panelStats.TabIndex = 1;

            // 
            // pnlTongGS
            // 
            this.pnlTongGS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.pnlTongGS.Controls.Add(this.lblCountGS);
            this.pnlTongGS.Controls.Add(this.lblTongGS);
            this.pnlTongGS.Location = new System.Drawing.Point(20, 20);
            this.pnlTongGS.Name = "pnlTongGS";
            this.pnlTongGS.Size = new System.Drawing.Size(180, 90);
            this.pnlTongGS.TabIndex = 0;

            // 
            // lblCountGS
            // 
            this.lblCountGS.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountGS.ForeColor = System.Drawing.Color.White;
            this.lblCountGS.Location = new System.Drawing.Point(10, 35);
            this.lblCountGS.Name = "lblCountGS";
            this.lblCountGS.Size = new System.Drawing.Size(160, 45);
            this.lblCountGS.TabIndex = 1;
            this.lblCountGS.Text = "0";
            this.lblCountGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTongGS
            // 
            this.lblTongGS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongGS.ForeColor = System.Drawing.Color.White;
            this.lblTongGS.Location = new System.Drawing.Point(10, 10);
            this.lblTongGS.Name = "lblTongGS";
            this.lblTongGS.Size = new System.Drawing.Size(160, 20);
            this.lblTongGS.TabIndex = 0;
            this.lblTongGS.Text = "👨‍🏫 TỔNG GIA SƯ";
            this.lblTongGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlTongHV
            // 
            this.pnlTongHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlTongHV.Controls.Add(this.lblCountHV);
            this.pnlTongHV.Controls.Add(this.lblTongHV);
            this.pnlTongHV.Location = new System.Drawing.Point(215, 20);
            this.pnlTongHV.Name = "pnlTongHV";
            this.pnlTongHV.Size = new System.Drawing.Size(180, 90);
            this.pnlTongHV.TabIndex = 1;

            // 
            // lblCountHV
            // 
            this.lblCountHV.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountHV.ForeColor = System.Drawing.Color.White;
            this.lblCountHV.Location = new System.Drawing.Point(10, 35);
            this.lblCountHV.Name = "lblCountHV";
            this.lblCountHV.Size = new System.Drawing.Size(160, 45);
            this.lblCountHV.TabIndex = 1;
            this.lblCountHV.Text = "0";
            this.lblCountHV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTongHV
            // 
            this.lblTongHV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongHV.ForeColor = System.Drawing.Color.White;
            this.lblTongHV.Location = new System.Drawing.Point(10, 10);
            this.lblTongHV.Name = "lblTongHV";
            this.lblTongHV.Size = new System.Drawing.Size(160, 20);
            this.lblTongHV.TabIndex = 0;
            this.lblTongHV.Text = "👨‍🎓 HỌC VIÊN";
            this.lblTongHV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlTongLop
            // 
            this.pnlTongLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlTongLop.Controls.Add(this.lblCountLop);
            this.pnlTongLop.Controls.Add(this.lblTongLop);
            this.pnlTongLop.Location = new System.Drawing.Point(410, 20);
            this.pnlTongLop.Name = "pnlTongLop";
            this.pnlTongLop.Size = new System.Drawing.Size(180, 90);
            this.pnlTongLop.TabIndex = 2;

            // 
            // lblCountLop
            // 
            this.lblCountLop.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountLop.ForeColor = System.Drawing.Color.White;
            this.lblCountLop.Location = new System.Drawing.Point(10, 35);
            this.lblCountLop.Name = "lblCountLop";
            this.lblCountLop.Size = new System.Drawing.Size(160, 45);
            this.lblCountLop.TabIndex = 1;
            this.lblCountLop.Text = "0";
            this.lblCountLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTongLop
            // 
            this.lblTongLop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongLop.ForeColor = System.Drawing.Color.White;
            this.lblTongLop.Location = new System.Drawing.Point(10, 10);
            this.lblTongLop.Name = "lblTongLop";
            this.lblTongLop.Size = new System.Drawing.Size(160, 20);
            this.lblTongLop.TabIndex = 0;
            this.lblTongLop.Text = "🏫 LỚP HỌC";
            this.lblTongLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlGSRanh
            // 
            this.pnlGSRanh.BackColor = System.Drawing.Color.White;
            this.pnlGSRanh.Controls.Add(this.lblCountGSRanh);
            this.pnlGSRanh.Controls.Add(this.lblGSRanh);
            this.pnlGSRanh.Location = new System.Drawing.Point(610, 20);
            this.pnlGSRanh.Name = "pnlGSRanh";
            this.pnlGSRanh.Size = new System.Drawing.Size(180, 90);
            this.pnlGSRanh.TabIndex = 3;

            // 
            // lblCountGSRanh
            // 
            this.lblCountGSRanh.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountGSRanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblCountGSRanh.Location = new System.Drawing.Point(10, 35);
            this.lblCountGSRanh.Name = "lblCountGSRanh";
            this.lblCountGSRanh.Size = new System.Drawing.Size(160, 45);
            this.lblCountGSRanh.TabIndex = 1;
            this.lblCountGSRanh.Text = "0";
            this.lblCountGSRanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblGSRanh
            // 
            this.lblGSRanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGSRanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGSRanh.Location = new System.Drawing.Point(10, 10);
            this.lblGSRanh.Name = "lblGSRanh";
            this.lblGSRanh.Size = new System.Drawing.Size(160, 20);
            this.lblGSRanh.TabIndex = 0;
            this.lblGSRanh.Text = "✓ GS Rảnh";
            this.lblGSRanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlGSDangDay
            // 
            this.pnlGSDangDay.BackColor = System.Drawing.Color.White;
            this.pnlGSDangDay.Controls.Add(this.lblCountGSDangDay);
            this.pnlGSDangDay.Controls.Add(this.lblGSDangDay);
            this.pnlGSDangDay.Location = new System.Drawing.Point(805, 20);
            this.pnlGSDangDay.Name = "pnlGSDangDay";
            this.pnlGSDangDay.Size = new System.Drawing.Size(180, 90);
            this.pnlGSDangDay.TabIndex = 4;

            // 
            // lblCountGSDangDay
            // 
            this.lblCountGSDangDay.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountGSDangDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblCountGSDangDay.Location = new System.Drawing.Point(10, 35);
            this.lblCountGSDangDay.Name = "lblCountGSDangDay";
            this.lblCountGSDangDay.Size = new System.Drawing.Size(160, 45);
            this.lblCountGSDangDay.TabIndex = 1;
            this.lblCountGSDangDay.Text = "0";
            this.lblCountGSDangDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblGSDangDay
            // 
            this.lblGSDangDay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGSDangDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGSDangDay.Location = new System.Drawing.Point(10, 10);
            this.lblGSDangDay.Name = "lblGSDangDay";
            this.lblGSDangDay.Size = new System.Drawing.Size(160, 20);
            this.lblGSDangDay.TabIndex = 0;
            this.lblGSDangDay.Text = "⏰ GS Đang Dạy";
            this.lblGSDangDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlLopDangHoc
            // 
            this.pnlLopDangHoc.BackColor = System.Drawing.Color.White;
            this.pnlLopDangHoc.Controls.Add(this.lblCountLopDangHoc);
            this.pnlLopDangHoc.Controls.Add(this.lblLopDangHoc);
            this.pnlLopDangHoc.Location = new System.Drawing.Point(1000, 20);
            this.pnlLopDangHoc.Name = "pnlLopDangHoc";
            this.pnlLopDangHoc.Size = new System.Drawing.Size(180, 90);
            this.pnlLopDangHoc.TabIndex = 5;

            // 
            // lblCountLopDangHoc
            // 
            this.lblCountLopDangHoc.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountLopDangHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblCountLopDangHoc.Location = new System.Drawing.Point(10, 35);
            this.lblCountLopDangHoc.Name = "lblCountLopDangHoc";
            this.lblCountLopDangHoc.Size = new System.Drawing.Size(160, 45);
            this.lblCountLopDangHoc.TabIndex = 1;
            this.lblCountLopDangHoc.Text = "0";
            this.lblCountLopDangHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblLopDangHoc
            // 
            this.lblLopDangHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLopDangHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblLopDangHoc.Location = new System.Drawing.Point(10, 10);
            this.lblLopDangHoc.Name = "lblLopDangHoc";
            this.lblLopDangHoc.Size = new System.Drawing.Size(160, 20);
            this.lblLopDangHoc.TabIndex = 0;
            this.lblLopDangHoc.Text = "📖 Lớp Đang Học";
            this.lblLopDangHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelLeft.Controls.Add(this.gbGiaSu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 190);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15, 0, 7, 15);
            this.panelLeft.Size = new System.Drawing.Size(450, 460);
            this.panelLeft.TabIndex = 2;

            // 
            // gbGiaSu
            // 
            this.gbGiaSu.BackColor = System.Drawing.Color.White;
            this.gbGiaSu.Controls.Add(this.dgvGiaSu);
            this.gbGiaSu.Controls.Add(this.lblThongTinGS);
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
            this.gbGiaSu.Location = new System.Drawing.Point(15, 0);
            this.gbGiaSu.Name = "gbGiaSu";
            this.gbGiaSu.Padding = new System.Windows.Forms.Padding(15);
            this.gbGiaSu.Size = new System.Drawing.Size(428, 445);
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
            this.dgvGiaSu.RowHeadersVisible = false;
            this.dgvGiaSu.RowTemplate.Height = 30;
            this.dgvGiaSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaSu.Size = new System.Drawing.Size(392, 240);
            this.dgvGiaSu.TabIndex = 0;
            this.dgvGiaSu.SelectionChanged += new System.EventHandler(this.dgvGiaSu_SelectionChanged);

            // 
            // lblThongTinGS
            // 
            this.lblThongTinGS.AutoSize = true;
            this.lblThongTinGS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTinGS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblThongTinGS.Location = new System.Drawing.Point(18, 280);
            this.lblThongTinGS.Name = "lblThongTinGS";
            this.lblThongTinGS.Size = new System.Drawing.Size(150, 19);
            this.lblThongTinGS.TabIndex = 1;
            this.lblThongTinGS.Text = "📋 Thông Tin Chi Tiết";

            // 
            // lblMaGS
            // 
            this.lblMaGS.AutoSize = true;
            this.lblMaGS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaGS.Location = new System.Drawing.Point(18, 310);
            this.lblMaGS.Name = "lblMaGS";
            this.lblMaGS.Size = new System.Drawing.Size(50, 15);
            this.lblMaGS.Text = "Mã GS:";

            // 
            // txtMaGS
            // 
            this.txtMaGS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtMaGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaGS.Location = new System.Drawing.Point(100, 307);
            this.txtMaGS.Name = "txtMaGS";
            this.txtMaGS.ReadOnly = true;
            this.txtMaGS.Size = new System.Drawing.Size(80, 23);
            this.txtMaGS.TabIndex = 2;

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(18, 340);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 15);
            this.lblHoTen.Text = "Họ Tên:";

            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtHoTen.Location = new System.Drawing.Point(100, 337);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(310, 23);
            this.txtHoTen.TabIndex = 3;

            // 
            // lblChuyenMon
            // 
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChuyenMon.Location = new System.Drawing.Point(18, 370);
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.Size = new System.Drawing.Size(82, 15);
            this.lblChuyenMon.Text = "Chuyên Môn:";

            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtChuyenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChuyenMon.Location = new System.Drawing.Point(100, 367);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.ReadOnly = true;
            this.txtChuyenMon.Size = new System.Drawing.Size(310, 23);
            this.txtChuyenMon.TabIndex = 4;

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.Location = new System.Drawing.Point(18, 400);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 15);
            this.lblTrangThai.Text = "Trạng Thái:";

            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTrangThai.ForeColor = System.Drawing.Color.White;
            this.txtTrangThai.Location = new System.Drawing.Point(100, 397);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(130, 23);
            this.txtTrangThai.TabIndex = 5;
            this.txtTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // lblSoLop
            // 
            this.lblSoLop.AutoSize = true;
            this.lblSoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLop.Location = new System.Drawing.Point(250, 400);
            this.lblSoLop.Name = "lblSoLop";
            this.lblSoLop.Size = new System.Drawing.Size(48, 15);
            this.lblSoLop.Text = "Số Lớp:";

            // 
            // txtSoLop
            // 
            this.txtSoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.txtSoLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoLop.ForeColor = System.Drawing.Color.White;
            this.txtSoLop.Location = new System.Drawing.Point(310, 397);
            this.txtSoLop.Name = "txtSoLop";
            this.txtSoLop.ReadOnly = true;
            this.txtSoLop.Size = new System.Drawing.Size(100, 23);
            this.txtSoLop.TabIndex = 6;
            this.txtSoLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.splitter1.Location = new System.Drawing.Point(450, 190);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 460);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;

            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelRight.Controls.Add(this.gbThongKe);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(453, 190);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(7, 0, 15, 15);
            this.panelRight.Size = new System.Drawing.Size(747, 460);
            this.panelRight.TabIndex = 4;

            // 
            // gbThongKe
            // 
            this.gbThongKe.BackColor = System.Drawing.Color.White;
            this.gbThongKe.Controls.Add(this.dgvLopHoc);
            this.gbThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gbThongKe.Location = new System.Drawing.Point(7, 0);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Padding = new System.Windows.Forms.Padding(15);
            this.gbThongKe.Size = new System.Drawing.Size(725, 445);
            this.gbThongKe.TabIndex = 0;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "📚 Danh Sách Lớp Học";

            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.AllowUserToDeleteRows = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopHoc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHoc.EnableHeadersVisualStyles = false;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgvLopHoc.Location = new System.Drawing.Point(15, 29);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowTemplate.Height = 30;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(695, 401);
            this.dgvLopHoc.TabIndex = 0;

            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.pnlTongGS.ResumeLayout(false);
            this.pnlTongHV.ResumeLayout(false);
            this.pnlTongLop.ResumeLayout(false);
            this.pnlGSRanh.ResumeLayout(false);
            this.pnlGSDangDay.ResumeLayout(false);
            this.pnlLopDangHoc.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.gbGiaSu.ResumeLayout(false);
            this.gbGiaSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSu)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.gbThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}