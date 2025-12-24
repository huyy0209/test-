using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DoAnWD.Common;
using DoAnWD.Models;

namespace DoAnWD.DAL.Repositories
{
    /// <summary>
    /// Repository cho Gia Sư - Thêm methods đặc thù
    /// OOP: Inheritance - Kế thừa Repository generic
    /// </summary>
    public class GiaSuRepository : Repository<GiaSu>
    {
        public GiaSuRepository(GiaSuContextDB context) : base(context)
        {
        }

        /// <summary>
        /// Lấy gia sư rảnh hoặc sẵn sàng (để ghép lớp)
        /// </summary>
        public IEnumerable<GiaSu> GetAvailableGiaSu()
        {
            return _dbSet.Where(g =>
                g.TrangThai == Constants.GiaSuStatus.Ranh ||
                g.TrangThai == Constants.GiaSuStatus.SanSang ||
                g.TrangThai == null
            ).ToList();
        }

        /// <summary>
        /// Lấy gia sư đang dạy
        /// </summary>
        public IEnumerable<GiaSu> GetTeachingGiaSu()
        {
            return _dbSet.Where(g => g.TrangThai == Constants.GiaSuStatus.DangDay).ToList();
        }

        /// <summary>
        /// Lấy gia sư với số lớp đang dạy
        /// </summary>
        public IEnumerable<object> GetGiaSuWithLopCount()
        {
            return _dbSet.Select(g => new
            {
                g.MaGS,
                g.HoTen,
                g.ChuyenMon,
                g.TrangThai,
                SoLop = g.LopHocs.Count(l => l.TrangThai == Constants.LopHocStatus.DangHoc)
            }).OrderByDescending(g => g.SoLop).ToList();
        }

        /// <summary>
        /// Kiểm tra gia sư có lớp đang học không
        /// </summary>
        public bool HasActiveLopHoc(int maGS)
        {
            var giaSu = _dbSet.Find(maGS);
            if (giaSu == null) return false;

            _context.Entry(giaSu).Collection(g => g.LopHocs).Load();
            return giaSu.LopHocs.Any(l => l.TrangThai == Constants.LopHocStatus.DangHoc);
        }

        /// <summary>
        /// Đếm số lớp đang dạy của gia sư
        /// </summary>
        public int CountActiveLopHoc(int maGS)
        {
            var giaSu = _dbSet.Find(maGS);
            if (giaSu == null) return 0;

            _context.Entry(giaSu).Collection(g => g.LopHocs).Load();
            return giaSu.LopHocs.Count(l => l.TrangThai == Constants.LopHocStatus.DangHoc);
        }

        /// <summary>
        /// Cập nhật trạng thái gia sư dựa trên số lớp
        /// </summary>
        public void UpdateStatusBasedOnLopHoc(int maGS)
        {
            var giaSu = _dbSet.Find(maGS);
            if (giaSu == null) return;

            _context.Entry(giaSu).Collection(g => g.LopHocs).Load();
            var activeLopCount = giaSu.LopHocs.Count(l => l.TrangThai == Constants.LopHocStatus.DangHoc);

            giaSu.TrangThai = activeLopCount > 0
                ? Constants.GiaSuStatus.DangDay
                : Constants.GiaSuStatus.Ranh;
        }

        /// <summary>
        /// Tìm kiếm gia sư theo keyword
        /// </summary>
        public IEnumerable<GiaSu> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            keyword = keyword.ToLower();
            return _dbSet.Where(g =>
                (g.HoTen != null && g.HoTen.ToLower().Contains(keyword)) ||
                (g.SDT != null && g.SDT.Contains(keyword)) ||
                (g.ChuyenMon != null && g.ChuyenMon.ToLower().Contains(keyword)) ||
                (g.TrangThai != null && g.TrangThai.ToLower().Contains(keyword))
            ).ToList();
        }
    }
}