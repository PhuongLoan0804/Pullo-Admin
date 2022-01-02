using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pullo_Admin.Models;

namespace Pullo_Admin.Controllers
{
    public class DanhMucController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;

            return View(context.GetDanhMucs());
        }
        public IActionResult CreateDM()
        {

            return View();
        }
        public IActionResult ThemDM(DanhMuc DM)
            {
                int count;

                StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
                count = context.ThemDM(DM);

                if (count > 0)
                    ViewData["thongbao"] = "Insert thành công";
                else
                    ViewData["thongbao"] = "Insert không thành công";
                return View();
            }
        public IActionResult UpdateDM(DanhMuc dm)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            count = context.UpdateDM(dm);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }
        public IActionResult ViewDM(int madm)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            DanhMuc dm = context.ViewDM(madm);
            ViewData.Model = dm;
            return View();
        }
        public IActionResult DeleteDM(int madm)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            int count = context.XoaDM(madm);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
