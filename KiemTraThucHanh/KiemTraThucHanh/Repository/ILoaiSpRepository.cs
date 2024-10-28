using KiemTraThucHanh.Models;

namespace KiemTraThucHanh.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(TLoaiSp loaiSp);
        TLoaiSp GetLoaiSp(string loaiSp);
        IEnumerable<TLoaiSp> GetAll();

    }
}
