@ModelType T983248_VB.SavedModel
@Code
    ViewData("Title") = "Complete"
End Code

<h2>Complete</h2>

<div>
    <h4>Result</h4>
    @Html.DisplayNameFor(Function(model) model.UserName)

    @Html.DisplayFor(Function(model) model.UserName)
    <img src="@Url.Content(Model.FileUrl)" style="width:300px;height:300px;" />
</div>
<p>
    @Html.ActionLink("Back to List", "Index")
</p>
