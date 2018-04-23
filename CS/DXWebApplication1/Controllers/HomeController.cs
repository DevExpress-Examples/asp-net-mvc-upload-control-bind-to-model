using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DevExpress.Web;

namespace DXWebApplication1.Controllers {
    public class UserModelDTO {
        [Required]
        public string NameProperty { get; set; }
        public UploadedFile[] ImagesProperty { get; set; }
    }

    public class UserModel {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }

    public class HomeController: Controller {
        [HttpGet]
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModelDTO modelDTO) {
            string avatarFileName = string.Empty;
            if (ModelState.IsValid) {
                if (modelDTO.ImagesProperty.Length > 0 && modelDTO.ImagesProperty[0].ContentLength > 0) {
                    avatarFileName = string.Format("~/Content/Images/{0}", modelDTO.ImagesProperty[0].FileName);
                    modelDTO.ImagesProperty[0].SaveAs(Server.MapPath(avatarFileName));
                }
            }

            UserModel model = new UserModel();
            model.Name = modelDTO.NameProperty;
            model.Avatar = avatarFileName;

            return View("Complete", model);
        }
    }
}