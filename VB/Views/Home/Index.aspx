<%@ Page Language="vb" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Example.Models.MyModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	How to submit a form using the NavBar extension
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<h2>
		<%=Html.Encode(ViewData("Message"))%></h2>
	<p>
		To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/"
			title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
	</p>
<%
	   Html.BeginForm("PostValues", "Home")
%>
	<table>
		<tr>
			<td>
				<% 
					Html.DevExpress().NavBar(Function(settings) AnonymousMethod1(settings)).Render()
				%>
				<%=Html.Hidden("actionName")%>
			</td>
			<td>
				<% 
					Html.DevExpress().Memo(Function(settings) AnonymousMethod2(settings)).Bind(Model.Text).Render()
				%>
			</td>
		</tr>
	</table>
<%
	   Html.EndForm()
%>
</asp:Content>


private bool AnonymousMethod1(object settings)
{
	settings.Name = "navbar";
	MVCxNavBarGroup group = settings.Groups.Add("group 1");
	group.Items.Add("Action 1", "act1");
	group.Items.Add("Action 2", "act2");
	settings.ClientSideEvents.ItemClick = "function (s, e) { document.getElementById('actionName').value = e.item.name; document.forms[0].submit(); }";
	Return True;
}

private bool AnonymousMethod2(object settings)
{
	settings.Name = "Text";
	settings.Width = Unit.Pixel(200);
	settings.Height = Unit.Pixel(100);
	settings.Properties.NullText = "Enter something...";
	Return True;
}