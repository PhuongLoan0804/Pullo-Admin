using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pullo_Admin.Models;

namespace Pullo_Admin.Controllers
{
    public class SachController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;

            return View(context.GetSachs());
        }
        public IActionResult CreateSach()
        {

            return View();
        }
        public IActionResult ThemSach(Sach sach)
        {
            int count;

            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            count = context.ThemSach(sach);

            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
        }
        public IActionResult UpdateSach(Sach sach)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            count = context.UpdateSach(sach);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }
        public IActionResult ViewSach(int isbn)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            Sach sach = context.ViewSach(isbn);
            ViewData.Model = sach;
            return View();
        }
        public IActionResult DeleteSach(int isbn)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Pullo_Admin.Models.StoreContext)) as StoreContext;
            int count = context.XoaSach(isbn);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
