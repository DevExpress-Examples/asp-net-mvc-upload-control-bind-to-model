<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T185980)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Upload Control for ASP.NET MVC -  Registration form with model binding support

This example demonstrates how to bind [UploadControl](https://docs.devexpress.com/AspNetMvc/8977/components/file-management/file-upload) (its posted files) with a `Model` property. 

```csharp
public ActionResult Index(UserModel modelDTO) {
    string fileName = string.Empty;
    if (ModelState.IsValid) {
        if (modelDTO.Attachment.Length > 0 && modelDTO.Attachment[0].ContentLength > 0) {
            fileName = string.Format("~/Content/Files/{0}", modelDTO.Attachment[0].FileName);
            modelDTO.Attachment[0].SaveAs(Server.MapPath(fileName));
        }
    }
    SavedModel model = new SavedModel();
    model.UserName = modelDTO.UserName;
    model.FileUrl = fileName;
    return View("Complete", model);
}
```
## Files to Review

* [HomeController.cs](./CS/T983248_MVC/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T983248_VB/Controllers/HomeController.vb))
* [Complete.cshtml](./CS/T983248_MVC/Views/Home/Complete.cshtml) (VB: [Complete.vbhtml](./VB/T983248_VB/Views/Home/Complete.vbhtml))
* [Index.cshtml](./CS/T983248_MVC/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/T983248_VB/Views/Home/Index.vbhtml))
