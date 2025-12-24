using System;
using System.Collections.Generic;
using DoAnWD.BLL.Validators;
using DoAnWD.Common;
using DoAnWD.DAL.Repositories;
using DoAnWD.Models;

namespace DoAnWD.BLL.Services
{
    /// <summary>
    /// Business Logic cho Lớp Học
    /// </summary>
    public class LopHocService : IDisposable
    {
        private readonly GiaSuContextDB _context;
        private readonly LopHocRepository _lopHocRepo;
        private readonly GiaSuRepository _giaSuRepo;
        private readonly HocVienRepository _hocVienRepo;

        public LopHocService()
        {
            _context = new GiaSuContextDB();
            _lopHocRepo = new LopHocRepository(_context);
            _giaSuRepo = new GiaSuRepository(_context);
            _hocVienRepo = new HocVienRepository(_context);
        }

        /// <summary>
        /// Lấy tất cả lớp học
        /// </summary>
        public IEnumerable<LopHoc> GetAll()
        {
            return _lopHocRepo.GetAll();
        }

        /// <summary>
        /// Lấy lớp học theo gia sư
        /// </summary>
        public IEnumerable<object> GetByGiaSu(int maGS)
        {
            return _lopHocRepo.GetLopHocByGiaSu(maGS);
        }

        /// <summary>
        /// Lấy tất cả lớp với thông tin chi tiết
        /// </summary>
        public IEnumerable<object> GetAllWithDetails()
        {
            return _lopHocRepo.GetAllLopHocWithDetails();
        }

        /// <summary>
        /// Ghép lớp mới
        /// </summary>
        public void GhepLop(int maHV, int maGS, string monHoc, decimal hocPhi, string trangThai)
        {
            // Validate
            string errorMessage;
            if (!LopHocValidator.Validate(maHV, maGS, monHoc, hocPhi, out errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

            // Kiểm tra trùng lặp
            if (_lopHocRepo.IsDuplicateLopHoc(maHV, maGS, monHoc))
            {
                var giaSu = _giaSuRepo.GetById(maGS);
                var hocVien = _hocVienRepo.GetById(maHV);
                throw new InvalidOperationException(
                    $"Lớp học đã tồn tại!\n\nHọc viên '{hocVien?.HoTen}' đã có lớp '{monHoc}' với gia sư '{giaSu?.HoTen}' (đang học).");
            }

            // Create lớp học
            var lopHoc = new LopHoc
            {
                MaHV = maHV,
                MaGS = maGS,
                MonHoc = monHoc.Trim(),
                HocPhi = hocPhi,
                TrangThai = string.IsNullOrWhiteSpace(trangThai) ? Constants.LopHocStatus.DangHoc : trangThai
            };

            _lopHocRepo.Add(lopHoc);

            // Cập nhật trạng thái gia sư
            var giaSuEntity = _giaSuRepo.GetById(maGS);
            if (giaSuEntity != null)
            {
                giaSuEntity.TrangThai = Constants.GiaSuStatus.DangDay;
                _giaSuRepo.Update(giaSuEntity);
            }

            _lopHocRepo.SaveChanges();
        }

        /// <summary>
        /// Xóa lớp học
        /// </summary>
        public void Delete(int maLop)
        {
            var lopHoc = _lopHocRepo.GetById(maLop);
            if (lopHoc == null)
            {
                throw new Exception("Không tìm thấy lớp học.");
            }

            int? maGS = lopHoc.MaGS;

            // Xóa lớp
            _lopHocRepo.Remove(lopHoc);
            _lopHocRepo.SaveChanges();

            // Cập nhật trạng thái gia sư
            if (maGS.HasValue)
            {
                _giaSuRepo.UpdateStatusBasedOnLopHoc(maGS.Value);
                _giaSuRepo.SaveChanges();
            }
        }

        /// <summary>
        /// Đếm tổng lớp học
        /// </summary>
        public int CountAll()
        {
            return _lopHocRepo.Count();
        }

        /// <summary>
        /// Đếm lớp đang học
        /// </summary>
        public int CountActive()
        {
            return _lopHocRepo.Count(l => l.TrangThai == Constants.LopHocStatus.DangHoc);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}