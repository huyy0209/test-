namespace DoAnWD
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHost;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Button btnGiaSu;
        private System.Windows.Forms.Button btnHocVien;
        private System.Windows.Forms.Button btnGhepLop;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panelBottomButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelActiveIndicator;

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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.btnGiaSu = new System.Windows.Forms.Button();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.btnGhepLop = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panelBottomButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelHost = new System.Windows.Forms.Panel();
            this.panelActiveIndicator = new System.Windows.Forms.Panel();

            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBottomButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.panelBottomButtons);
            this.panelSidebar.Controls.Add(this.btnThongKe);
            this.panelSidebar.Controls.Add(this.btnGhepLop);
            this.panelSidebar.Controls.Add(this.btnHocVien);
            this.panelSidebar.Controls.Add(this.btnGiaSu);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 700);
            this.panelSidebar.TabIndex = 0;

            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelLogo.Controls.Add(this.lblAppSubtitle);
            this.panelLogo.Controls.Add(this.lblAppName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 120);
            this.panelLogo.TabIndex = 0;

            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(10, 30);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(230, 35);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "🎓 GIA SƯ ONLINE";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(10, 65);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(230, 20);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Quản lý Gia Sư - Học Viên";
            this.lblAppSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnGiaSu
            // 
            this.btnGiaSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGiaSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaSu.FlatAppearance.BorderSize = 0;
            this.btnGiaSu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnGiaSu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGiaSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaSu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGiaSu.ForeColor = System.Drawing.Color.White;
            this.btnGiaSu.Image = null;
            this.btnGiaSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaSu.Location = new System.Drawing.Point(0, 140);
            this.btnGiaSu.Name = "btnGiaSu";
            this.btnGiaSu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGiaSu.Size = new System.Drawing.Size(250, 60);
            this.btnGiaSu.TabIndex = 1;
            this.btnGiaSu.Text = "   👨‍🏫  Quản Lý Gia Sư";
            this.btnGiaSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaSu.UseVisualStyleBackColor = false;
            this.btnGiaSu.Click += new System.EventHandler(this.btnGiaSu_Click);

            // 
            // btnHocVien
            // 
            this.btnHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHocVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHocVien.FlatAppearance.BorderSize = 0;
            this.btnHocVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHocVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHocVien.ForeColor = System.Drawing.Color.White;
            this.btnHocVien.Image = null;
            this.btnHocVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocVien.Location = new System.Drawing.Point(0, 210);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHocVien.Size = new System.Drawing.Size(250, 60);
            this.btnHocVien.TabIndex = 2;
            this.btnHocVien.Text = "   📚  Quản Lý Học Viên";
            this.btnHocVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocVien.UseVisualStyleBackColor = false;
            this.btnHocVien.Click += new System.EventHandler(this.btnHocVien_Click);

            // 
            // btnGhepLop
            // 
            this.btnGhepLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGhepLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhepLop.FlatAppearance.BorderSize = 0;
            this.btnGhepLop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnGhepLop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGhepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhepLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGhepLop.ForeColor = System.Drawing.Color.White;
            this.btnGhepLop.Image = null;
            this.btnGhepLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhepLop.Location = new System.Drawing.Point(0, 280);
            this.btnGhepLop.Name = "btnGhepLop";
            this.btnGhepLop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGhepLop.Size = new System.Drawing.Size(250, 60);
            this.btnGhepLop.TabIndex = 3;
            this.btnGhepLop.Text = "   🏫  Quản Lý Lớp Học";
            this.btnGhepLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhepLop.UseVisualStyleBackColor = false;
            this.btnGhepLop.Click += new System.EventHandler(this.btnGhepLop_Click);

            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = null;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 350);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 60);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "   📊  Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // 
            // panelBottomButtons
            // 
            this.panelBottomButtons.Controls.Add(this.btnRefresh);
            this.panelBottomButtons.Controls.Add(this.btnExit);
            this.panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtons.Location = new System.Drawing.Point(0, 570);
            this.panelBottomButtons.Name = "panelBottomButtons";
            this.panelBottomButtons.Size = new System.Drawing.Size(250, 130);
            this.panelBottomButtons.TabIndex = 5;

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(250, 50);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "   🔄  Làm Mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "   🚪  Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // panelHost
            // 
            this.panelHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHost.Location = new System.Drawing.Point(250, 0);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(950, 700);
            this.panelHost.TabIndex = 1;

            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelHost);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Gia Sư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}