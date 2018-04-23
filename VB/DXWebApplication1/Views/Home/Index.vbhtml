@ModelType DXWebApplication1.Controllers.UserModelDTO
@Using (Html.BeginForm())
    @Html.DevExpress().FormLayout( _
    Sub(fl)
        fl.Name = "frmLayout"
        fl.Items.Add(Function(m) m.NameProperty, _
                     Sub(itemSettings)
                         itemSettings.NestedExtensionSettings.Width = Unit.Percentage(100)
                     End Sub)
        fl.Items.Add( _
           Sub(item)
               item.Caption = "ImagesProperty"
               item.SetNestedContent( _
                   Sub()
                       Html.RenderPartial("UploadControlPartial")
                   End Sub)
           End Sub)
        fl.Items.Add( _
            Sub(itemSettigns)
                itemSettigns.Caption = ""
                itemSettigns.HorizontalAlign = FormLayoutHorizontalAlign.Right
                itemSettigns.NestedExtensionType = FormLayoutNestedExtensionItemType.Button
                Dim btnSettigns As ButtonSettings = CType(itemSettigns.NestedExtensionSettings, ButtonSettings)
                btnSettigns.Name = "btnSumit"
                btnSettigns.Text = "Submit"
                btnSettigns.UseSubmitBehavior = True
            End Sub)
    End Sub).GetHtml()
End Using