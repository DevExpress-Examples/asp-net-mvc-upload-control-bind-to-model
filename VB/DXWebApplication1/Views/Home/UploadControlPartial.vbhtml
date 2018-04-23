@Html.DevExpress().UploadControl( _
    Sub(settings)
            settings.Name = "ImagesProperty"
            settings.Width = Unit.Percentage(100)
    End Sub).GetHtml()