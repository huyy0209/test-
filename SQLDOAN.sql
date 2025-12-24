CREATE DATABASE QuanLyGiaSu;
GO
USE QuanLyGiaSu;

CREATE TABLE GiaSu (
    MaGS INT PRIMARY KEY IDENTITY,
    HoTen NVARCHAR(100),
    SDT VARCHAR(20),
    ChuyenMon NVARCHAR(100),
    TrangThai NVARCHAR(50) DEFAULT N'Sẵn sàng'
);

CREATE TABLE HocVien (
    MaHV INT PRIMARY KEY IDENTITY,
    HoTen NVARCHAR(100),
    SDT VARCHAR(20),
    DiaChi NVARCHAR(200)
);

CREATE TABLE LopHoc (
    MaLop INT PRIMARY KEY IDENTITY,
    MaGS INT FOREIGN KEY REFERENCES GiaSu(MaGS),
    MaHV INT FOREIGN KEY REFERENCES HocVien(MaHV),
    MonHoc NVARCHAR(50),
    HocPhi DECIMAL(18,2),
    TrangThai NVARCHAR(50) 
);

-- INSERT dữ liệu cho bảng GiaSu
INSERT INTO GiaSu (HoTen, SDT, ChuyenMon, TrangThai) VALUES
(N'Nguyễn Văn An', '0901234567', N'Toán học', N'Sẵn sàng'),
(N'Trần Thị Bình', '0912345678', N'Tiếng Anh', N'Đang dạy'),
(N'Lê Hoàng Cường', '0923456789', N'Vật lý', N'Sẵn sàng'),
(N'Phạm Thu Duyên', '0934567890', N'Hóa học', N'Đang dạy'),
(N'Võ Minh Đức', '0945678901', N'Sinh học', N'Sẵn sàng'),
(N'Đặng Thị Hà', '0956789012', N'Văn học', N'Đang dạy'),
(N'Hoàng Văn Khánh', '0967890123', N'Toán học', N'Sẵn sàng'),
(N'Bùi Thị Lan', '0978901234', N'Tiếng Anh', N'Đang dạy'),
(N'Ngô Văn Minh', '0989012345', N'Tin học', N'Sẵn sàng'),
(N'Phan Thị Nga', '0990123456', N'Địa lý', N'Sẵn sàng');

-- INSERT dữ liệu cho bảng HocVien
INSERT INTO HocVien (HoTen, SDT, DiaChi) VALUES
(N'Trần Minh Anh', '0911111111', N'123 Nguyễn Huệ, Q1, TP. HCM'),
(N'Lê Thị Bảo', '0922222222', N'456 Lê Lợi, Q3, TP.HCM'),
(N'Nguyễn Văn Cường', '0933333333', N'789 Trần Hưng Đạo, Q5, TP.HCM'),
(N'Phạm Thị Diệu', '0944444444', N'321 Hai Bà Trưng, Quận 1, TP.HCM'),
(N'Võ Văn Em', '0955555555', N'654 Võ Văn Tần, Q3, TP.HCM'),
(N'Đỗ Thị Phượng', '0966666666', N'987 Điện Biên Phủ, Q10, TP.HCM'),
(N'Huỳnh Văn Giang', '0977777777', N'147 Cách Mạng Tháng 8, Q10, TP.HCM'),
(N'Trịnh Thị Hương', '0988888888', N'258 Lý Thường Kiệt, Q11, TP.HCM'),
(N'Mai Văn Inh', '0999999999', N'369 Nguyễn Thị Minh Khai, Q1, TP.HCM'),
(N'Lý Thị Kiều', '0910101010', N'741 Lê Văn Sỹ, Q3, TP.HCM'),
(N'Đinh Văn Long', '0920202020', N'852 Phan Xích Long, Phú Nhuận, TP.HCM'),
(N'Cao Thị Mai', '0930303030', N'963 Hoàng Văn Thụ, Tân Bình, TP.HCM');

-- INSERT dữ liệu cho bảng LopHoc
INSERT INTO LopHoc (MaGS, MaHV, MonHoc, HocPhi, TrangThai) VALUES
(1, 1, N'Toán lớp 10', 2000000, N'Đang dạy'),
(1, 3, N'Toán lớp 11', 2200000, N'Đang dạy'),
(2, 2, N'Tiếng Anh giao tiếp', 1800000, N'Đang dạy'),
(2, 4, N'Tiếng Anh IELTS', 3000000, N'Đang dạy'),
(3, 5, N'Vật lý lớp 12', 2500000, N'Đã hoàn thành'),
(4, 6, N'Hóa học lớp 10', 2000000, N'Đang dạy'),
(4, 7, N'Hóa học lớp 11', 2200000, N'Đang dạy'),
(6, 8, N'Văn học lớp 12', 1800000, N'Đang dạy'),
(6, 9, N'Văn học lớp 11', 1800000, N'Đã hoàn thành'),
(8, 10, N'Tiếng Anh lớp 9', 1600000, N'Đang dạy'),
(8, 11, N'Tiếng Anh thiếu nhi', 1500000, N'Đang dạy'),
(7, 12, N'Toán lớp 9', 1800000, N'Đã hoàn thành'),
(5, 1, N'Sinh học lớp 10', 1900000, N'Đã hoàn thành'),
(9, 3, N'Tin học văn phòng', 1700000, N'Sẵn sàng'),
(10, 5, N'Địa lý lớp 12', 1800000, N'Sẵn sàng');

-- Kiểm tra dữ liệu đã insert