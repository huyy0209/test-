namespace DoAnWD.Common
{
    /// <summary>
    /// Hằng số toàn project - Thay thế magic strings
    /// OOP: Encapsulation - Đóng gói constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Trạng thái Gia Sư
        /// </summary>
        public static class GiaSuStatus
        {
            public const string Ranh = "Rảnh";
            public const string SanSang = "Sẵn sàng";
            public const string DangDay = "Đang dạy";
            public const string TamNghi = "Tạm nghỉ";
        }

        /// <summary>
        /// Trạng thái Lớp Học
        /// </summary>
        public static class LopHocStatus
        {
            public const string DangHoc = "Đang học";
            public const string HoanThanh = "Hoàn thành";
            public const string TamDung = "Tạm dừng";
        }

        /// <summary>
        /// Validation Regex Patterns
        /// </summary>
        public static class Validation
        {
            public const string PhoneRegex = @"^\d{10,11}$";
            public const string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        }

        /// <summary>
        /// Thông báo chuẩn
        /// </summary>
        public static class Messages
        {
            // Success messages
            public const string ThemThanhCong = "Thêm thành công!";
            public const string SuaThanhCong = "Cập nhật thành công!";
            public const string XoaThanhCong = "Xóa thành công!";
            public const string GhepLopThanhCong = "Ghép lớp thành công!";
            public const string LamMoiThanhCong = "Đã làm mới dữ liệu!";
            public const string HuyThaoTac = "Đã hủy thao tác!";

            // Error messages
            public const string LoiKhiThem = "Lỗi khi thêm: ";
            public const string LoiKhiSua = "Lỗi khi sửa: ";
            public const string LoiKhiXoa = "Lỗi khi xóa: ";
            public const string LoiKhiGhepLop = "Lỗi khi ghép lớp: ";

            // Validation messages
            public const string VuiLongNhapHoTen = "Vui lòng nhập họ tên.";
            public const string VuiLongNhapSDT = "Vui lòng nhập số điện thoại.";
            public const string SDTKhongHopLe = "Số điện thoại phải là 10-11 chữ số.";
            public const string VuiLongNhapEmail = "Vui lòng nhập email.";
            public const string EmailKhongHopLe = "Email không đúng định dạng.";
            public const string VuiLongNhapChuyenMon = "Vui lòng nhập chuyên môn.";
            public const string VuiLongNhapDiaChi = "Vui lòng nhập địa chỉ.";
            public const string VuiLongChonGiaSu = "Vui lòng chọn gia sư.";
            public const string VuiLongChonHocVien = "Vui lòng chọn học viên.";
            public const string HocPhiKhongHopLe = "Học phí phải lớn hơn 0.";

            // Title messages
            public const string ErrorTitle = "Lỗi";
            public const string SuccessTitle = "Thành công";
            public const string WarningTitle = "Cảnh báo";
            public const string InfoTitle = "Thông báo";
            public const string ConfirmTitle = "Xác nhận";
        }

        /// <summary>
        /// UI Colors (HEX to RGB)
        /// </summary>
        public static class Colors
        {
            // Primary colors
            public static readonly System.Drawing.Color Purple = System.Drawing.Color.FromArgb(142, 68, 173);
            public static readonly System.Drawing.Color Blue = System.Drawing.Color.FromArgb(52, 152, 219);
            public static readonly System.Drawing.Color Orange = System.Drawing.Color.FromArgb(230, 126, 34);
            public static readonly System.Drawing.Color Green = System.Drawing.Color.FromArgb(46, 204, 113);
            public static readonly System.Drawing.Color Red = System.Drawing.Color.FromArgb(231, 76, 60);

            // Background colors
            public static readonly System.Drawing.Color LightGray = System.Drawing.Color.FromArgb(236, 240, 241);
            public static readonly System.Drawing.Color DarkGray = System.Drawing.Color.FromArgb(52, 73, 94);
            
            // Status colors
            public static readonly System.Drawing.Color ActiveGreen = System.Drawing.Color.FromArgb(212, 239, 223);
            public static readonly System.Drawing.Color ActiveOrange = System.Drawing.Color.FromArgb(255, 243, 224);
        }
    }
}