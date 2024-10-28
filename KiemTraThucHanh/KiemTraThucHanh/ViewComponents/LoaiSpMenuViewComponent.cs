using KiemTraThucHanh.Repository;
using Microsoft.AspNetCore.Mvc;
namespace KiemTraThucHanh.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSp)
        {
            _loaiSp = loaiSp;
        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAll().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
