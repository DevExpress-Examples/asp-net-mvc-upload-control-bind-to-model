Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        Return View(New UserModel())
    End Function

    <HttpPost>
    Public Function Index(ByVal modelDTO As UserModel) As ActionResult
        Dim fileName As String = String.Empty

        If ModelState.IsValid Then

            If modelDTO.Attachment.Length > 0 AndAlso modelDTO.Attachment(0).ContentLength > 0 Then
                fileName = String.Format("~/Content/Files/{0}", modelDTO.Attachment(0).FileName)
                modelDTO.Attachment(0).SaveAs(Server.MapPath(fileName))
            End If
        End If

        Dim model As SavedModel = New SavedModel()
        model.UserName = modelDTO.UserName
        model.FileUrl = fileName
        Return View("Complete", model)
    End Function
End Class