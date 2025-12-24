using System;
using System.Linq;
using System.Windows.Forms;
using DoAnWD.BLL.Services;
using DoAnWD.Common;
using DoAnWD.Models;

namespace DoAnWD
{
    /// <summary>
    /// Dialog Ghép Lớp - Refactored 3-Layer
    /// </summary>
    public partial class frmChucNangGhepLop : Form
    {
        private HocVienService _hocVienService;
        private GiaSuService _giaSuService;
        private LopHocService _lopHocService;

        public frmChucNangGhepLop()
        {
            InitializeComponent();
            _hocVienService = new HocVienService();
            _giaSuService = new GiaSuService();
            _lopHocService = new LopHocService();
            Load += FrmChucNangGhepLop_Load;
            FormClosed += FrmChucNangGhepLop_FormClosed;
        }

        private void FrmChucNangGhepLop_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Học Viên
                var hocViens = _hocVienService.GetAll().ToList();
                cboHocVien.DataSource = hocViens;
                cboHocVien.DisplayMember = "HoTen";
                cboHocVien.ValueMember = "MaHV";

                // Load Gia Sư rảnh
                var giaSus = _giaSuService.GetAvailable().ToList();
                cboGiaSu.DataSource = giaSus;
                cboGiaSu.DisplayMember = "HoTen";
                cboGiaSu.ValueMember = "MaGS";

                // Set mặc định
                cboTrangThai.SelectedIndex = 0;

                if (cboHocVien.Items.Count > 0)
                    cboHocVien.SelectedIndex = 0;
                if (cboGiaSu.Items.Count > 0)
                    cboGiaSu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo: {ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cboHocVien.SelectedItem as HocVien;
            if (selected != null)
            {
                txtSDT_HV.Text = selected.SDT ?? "";
                txtDiaChi_HV.Text = selected.DiaChi ?? "";
            }
        }

        private void cboGiaSu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cboGiaSu.SelectedItem as GiaSu;
            if (selected != null)
            {
                txtSDT_GS.Text = selected.SDT ?? "";
                txtChuyenMon_GS.Text = selected.ChuyenMon ?? "";

                // Highlight chuyên môn (tự động điền môn học)
                txtChuyenMon_GS.BackColor = Constants.Colors.ActiveOrange;
                txtChuyenMon_GS.ForeColor = Constants.Colors.Orange;
            }
        }

        private void btnGhepLop_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selections
                if (cboHocVien.SelectedValue == null)
                {
                    MessageBox.Show(Constants.Messages.VuiLongChonHocVien,
                        Constants.Messages.WarningTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (cboGiaSu.SelectedValue == null)
                {
                    MessageBox.Show(Constants.Messages.VuiLongChonGiaSu,
                        Constants.Messages.WarningTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var selectedGiaSu = cboGiaSu.SelectedItem as GiaSu;
                if (selectedGiaSu == null || string.IsNullOrWhiteSpace(selectedGiaSu.ChuyenMon))
                {
                    MessageBox.Show("Gia sư chưa có chuyên môn. Vui lòng cập nhật chuyên môn cho gia sư trước.",
                        Constants.Messages.WarningTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validate học phí
                decimal hocPhi = 0;
                if (!decimal.TryParse(txtHocPhi.Text, out hocPhi))
                {
                    MessageBox.Show("Học phí phải là số.",
                        Constants.Messages.WarningTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtHocPhi.Focus();
                    return;
                }

                if (hocPhi <= 0)
                {
                    MessageBox.Show(Constants.Messages.HocPhiKhongHopLe,
                        Constants.Messages.WarningTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtHocPhi.Focus();
                    return;
                }

                // Ghép lớp thông qua Service
                int maHV = (int)cboHocVien.SelectedValue;
                int maGS = (int)cboGiaSu.SelectedValue;
                string monHoc = selectedGiaSu.ChuyenMon.Trim();
                string trangThai = cboTrangThai.SelectedItem.ToString();

                _lopHocService.GhepLop(maHV, maGS, monHoc, hocPhi, trangThai);

                MessageBox.Show(
                    $"Ghép lớp thành công!\n\nMôn học: {monHoc}\nHọc viên: {cboHocVien.Text}\nGia sư: {cboGiaSu.Text}",
                    Constants.Messages.SuccessTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    Constants.Messages.WarningTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    Constants.Messages.WarningTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Constants.Messages.LoiKhiGhepLop}{ex.Message}",
                    Constants.Messages.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChucNangGhepLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hocVienService?.Dispose();
            _giaSuService?.Dispose();
            _lopHocService?.Dispose();
        }
    }
}