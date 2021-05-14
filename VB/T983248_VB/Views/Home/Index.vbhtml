@ModelType T983248_VB.UserModel
@Code
    ViewData("Title") = "Home Page"
End Code

@Using (Html.BeginForm())
    @Html.DevExpress().FormLayout(Sub(settings)
                                       settings.Name = "FormLayout"
                                       settings.Items.Add(Function(m) m.UserName)
                                       settings.Items.Add(Function(m) m.Attachment, Sub(i)
                                                                                        i.NestedExtension().UploadControl(Sub(s) s.ValidationSettings.ShowErrors = True)
                                                                                    End Sub)
                                       settings.Items.Add(Sub(i)
                                                              i.Name = "btnSubmit"
                                                              i.ShowCaption = DefaultBoolean.[False]
                                                              i.NestedExtension().Button(Sub(s)
                                                                                             s.Text = "Submit Invoice"
                                                                                             s.UseSubmitBehavior = True
                                                                                         End Sub)
                                                          End Sub)
                                   End Sub).GetHtml()
End Using