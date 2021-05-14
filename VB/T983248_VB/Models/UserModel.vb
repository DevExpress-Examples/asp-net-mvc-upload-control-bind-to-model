Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Web

Public Class UserModel
    <Required>
    Public Property UserName As String
    Public Property Attachment As UploadedFile()
End Class

Public Class SavedModel
    Public Property UserName As String
    Public Property FileUrl As String
End Class

