@Code
    ViewBag.Title = "How to submit a form using the NavBar extension"
End Code
<script type="text/javascript">
    function OnItemClick(s, e) {
        document.getElementById('actionName').value = e.item.name;
        document.forms[0].submit();
    }
</script>
<h2>
    @Html.Encode(ViewData("Message"))</h2>
<p>
    To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/"
        title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>
@Using (Html.BeginForm("PostValues", "Home"))
    @<table>
        <tr>
            <td>
                @Html.DevExpress().NavBar(Sub(settings)           
               settings.Name = "navbar"
               Dim group as MVCxNavBarGroup  = settings.Groups.Add("group 1")
               group.Items.Add("Action 1", "act1")
               group.Items.Add("Action 2", "act2")
               settings.ClientSideEvents.ItemClick = "OnItemClick"
           End Sub).GetHtml()

                @Html.Hidden("actionName")
            </td>
            <td>
                @Html.DevExpress().Memo(Sub(settings)           
               settings.Name = "Text"
               settings.Width = Unit.Pixel(200)
               settings.Height = Unit.Pixel(100)
               settings.Properties.NullText = "Enter something..."
           End Sub).Bind(Model.Text).GetHtml()
            </td>
        </tr>
    </table>
End Using