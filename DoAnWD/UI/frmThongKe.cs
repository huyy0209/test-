using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAnWD.BLL.Services;
using DoAnWD.Common;
using DoAnWD.Models;

namespace DoAnWD
{
    /// <summary>
    /// Form Thống Kê - Refactored 3-Layer
    /// Master-Detail: Gia Sư → Lớp Học
    /// </summary>
    public partial class frmThongKe : Form
    {
        private ThongKeService _service;

        public frmThongKe()
        {
            InitializeComponent();
            _service = new ThongKeService();
            Load += FrmThongKe_Load;
            FormClosed += FrmThongKe_FormClosed;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            LoadStatistics();
            LoadGiaSuList();
        }

        private void LoadStatistics()
        {
            try
            {
                var stats = _service.GetStatistics();

                lblCountGS.Text = stats.TongGiaSu.ToString();
                lblCountHV.Text = stats.TongHocVien.ToString();
                lblCountLop.Text = stats.TongLopHoc.ToString();
                lblCountGSRanh.Text = stats.GiaSuRanh.ToString();
                lblCountGSDangDay.Text = stats.GiaSuDangDay.ToString();
                lblCountLopDangHoc.Text = stats.LopDangHoc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thống kê: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadGiaSuList()
        {
            try
            {
                var giaSuData = _service.GetGiaSuWithLopCount();
                dgvGiaSu.DataSource = giaSuData;

                ConfigureGiaSuColumns();
                ApplyGiaSuRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách gia sư: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureGiaSuColumns()
        {
            if (dgvGiaSu.Columns.Count > 0)
            {
                dgvGiaSu.Columns["MaGS"].HeaderText = "Mã";
                dgvGiaSu.Columns["MaGS"].Width = 50;
                dgvGiaSu.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvGiaSu.Columns["ChuyenMon"].HeaderText = "Chuyên Môn";
                dgvGiaSu.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvGiaSu.Columns["TrangThai"].Width = 100;
                dgvGiaSu.Columns["SoLop"].HeaderText = "Số Lớp";
                dgvGiaSu.Columns["SoLop"].Width = 70;
                dgvGiaSu.Columns["SoLop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGiaSu.Columns["SoLop"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void ApplyGiaSuRowColors()
        {
            foreach (DataGridViewRow row in dgvGiaSu.Rows)
            {
                var trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == Constants.GiaSuStatus.DangDay)
                    row.DefaultCellStyle.BackColor = Constants.Colors.ActiveOrange;
                else if (trangThai == Constants.GiaSuStatus.Ranh || trangThai == Constants.GiaSuStatus.SanSang)
                    row.DefaultCellStyle.BackColor = Constants.Colors.ActiveGreen;
            }
        }

        private void dgvGiaSu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGiaSu.CurrentRow == null) return;

            try
            {
                int maGS = Convert.ToInt32(dgvGiaSu.CurrentRow.Cells["MaGS"].Value);
                LoadGiaSuDetails(maGS);
                LoadLopHocByGiaSu(maGS);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadGiaSuDetails(int maGS)
        {
            try
            {
                // Sử dụng GiaSuService để lấy thông tin
                var giaSuService = new GiaSuService();
                var giaSu = giaSuService.GetById(maGS);

                if (giaSu != null)
                {
                    txtMaGS.Text = giaSu.MaGS.ToString();
                    txtHoTen.Text = giaSu.HoTen ?? "";
                    txtChuyenMon.Text = giaSu.ChuyenMon ?? "";
                    txtTrangThai.Text = giaSu.TrangThai ?? Constants.GiaSuStatus.Ranh;

                    if (giaSu.TrangThai == Constants.GiaSuStatus.DangDay)
                    {
                        txtTrangThai.BackColor = Constants.Colors.Red;
                        txtTrangThai.ForeColor = Color.White;
                    }
                    else
                    {
                        txtTrangThai.BackColor = Constants.Colors.Green;
                        txtTrangThai.ForeColor = Color.White;
                    }
                }

                giaSuService.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadLopHocByGiaSu(int maGS)
        {
            try
            {
                var lopHocData = _service.GetLopHocByGiaSu(maGS);
                dgvLopHoc.DataSource = lopHocData;

                var activeLopCount = _service.CountActiveLopHocByGiaSu(maGS);
                txtSoLop.Text = activeLopCount.ToString();

                ConfigureLopHocColumns();
                ApplyLopHocRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lớp học: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureLopHocColumns()
        {
            if (dgvLopHoc.Columns.Count > 0)
            {
                dgvLopHoc.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgvLopHoc.Columns["MaLop"].Width = 80;
                dgvLopHoc.Columns["HocVien"].HeaderText = "Học Viên";
                dgvLopHoc.Columns["MonHoc"].HeaderText = "Môn Học";
                dgvLopHoc.Columns["HocPhi"].HeaderText = "Học Phí";
                dgvLopHoc.Columns["HocPhi"].DefaultCellStyle.Format = "N0";
                dgvLopHoc.Columns["HocPhi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLopHoc.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvLopHoc.Columns["TrangThai"].Width = 120;
            }
        }

        private void ApplyLopHocRowColors()
        {
            foreach (DataGridViewRow row in dgvLopHoc.Rows)
            {
                var trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == Constants.LopHocStatus.DangHoc)
                    row.DefaultCellStyle.BackColor = Constants.Colors.ActiveGreen;
                else if (trangThai == Constants.LopHocStatus.HoanThanh)
                    row.DefaultCellStyle.BackColor = Constants.Colors.LightGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _service?.Dispose();
            _service = new ThongKeService();
            RefreshAll();
            MessageBox.Show(Constants.Messages.LamMoiThanhCong,
                Constants.Messages.InfoTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FrmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            _service?.Dispose();
        }
    }
}