using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T983248_MVC.Models
{
    public class UserModel
    {
        [Required]
        public string UserName { get; set; }
        public UploadedFile[] Attachment { get; set; }

    }

    public class SavedModel
    {
        public string UserName { get; set; }
        public string FileUrl { get; set; }
    }
}