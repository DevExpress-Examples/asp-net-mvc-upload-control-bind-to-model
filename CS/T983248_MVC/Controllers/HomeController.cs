using DevExpress.Web;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T983248_MVC.Models;

namespace T983248_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Index(UserModel modelDTO)
        {
            string fileName = string.Empty;
            if (ModelState.IsValid)
            {
                if (modelDTO.Attachment.Length > 0 && modelDTO.Attachment[0].ContentLength > 0)
                {
                    fileName = string.Format("~/Content/Files/{0}", modelDTO.Attachment[0].FileName);
                    modelDTO.Attachment[0].SaveAs(Server.MapPath(fileName));
                }
            }
            SavedModel model = new SavedModel();
            model.UserName = modelDTO.UserName;
            model.FileUrl = fileName;
            return View("Complete", model);
        }
    }
}