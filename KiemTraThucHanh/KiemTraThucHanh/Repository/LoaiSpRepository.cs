using KiemTraThucHanh.Models;

namespace KiemTraThucHanh.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSpRepository(QlbanVaLiContext context)
        {
            _context = context;
        }

        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp Delete(TLoaiSp loaiSp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAll()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string loaiSp)
        {
            return _context.TLoaiSps.Find(loaiSp);
        }

        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
