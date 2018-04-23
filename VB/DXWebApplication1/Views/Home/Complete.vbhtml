@ModelType DXWebApplication1.Controllers.UserModel

@Html.DevExpress().FormLayout( _
    Sub(fl)
            fl.Name = "frmLayout"
            fl.Items.Add(Function(m) m.Name)
            If (Not String.IsNullOrEmpty(Model.Avatar)) Then
                fl.Items.Add( _
                    Sub(itemSettigns)
                            itemSettigns.Caption = "Avatar"
                            itemSettigns.NestedExtensionType = FormLayoutNestedExtensionItemType.Image
                            Dim imgSettigns As ImageEditSettings = CType(itemSettigns.NestedExtensionSettings, ImageEditSettings)
                            imgSettigns.Name = "imgAvatar"
                            imgSettigns.ImageUrl = Model.Avatar
                            imgSettigns.Width = Unit.Pixel(200)
                            imgSettigns.Height = Unit.Pixel(200)
                    End Sub)
            End If
    End Sub).GetHtml()

@Html.ActionLink("<< Home", "Index")