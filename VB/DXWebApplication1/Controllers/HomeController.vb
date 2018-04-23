Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc
Imports DevExpress.Web

Namespace DXWebApplication1.Controllers
	Public Class UserModelDTO
		<Required>
		Public Property NameProperty() As String
		Public Property ImagesProperty() As UploadedFile()
	End Class

    Public Class UserModel
        Public Property Name() As String
        Public Property Avatar() As String
    End Class

	Public Class HomeController
		Inherits Controller

		<HttpGet>
		Public Function Index() As ActionResult
			Return View()
		End Function

		<HttpPost>
		Public Function Index(ByVal modelDTO As UserModelDTO) As ActionResult
			Dim avatarFileName As String = String.Empty
			If ModelState.IsValid Then
				If modelDTO.ImagesProperty.Length > 0 AndAlso modelDTO.ImagesProperty(0).ContentLength > 0 Then
					avatarFileName = String.Format("~/Content/Images/{0}", modelDTO.ImagesProperty(0).FileName)
					modelDTO.ImagesProperty(0).SaveAs(Server.MapPath(avatarFileName))
				End If
			End If

			Dim model As New UserModel()
			model.Name = modelDTO.NameProperty
			model.Avatar = avatarFileName

			Return View("Complete", model)
		End Function
	End Class
End Namespace