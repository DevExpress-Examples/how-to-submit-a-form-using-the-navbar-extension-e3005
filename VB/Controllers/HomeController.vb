Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports Example.Models
Imports DevExpress.Web.Mvc

Namespace Example.Controllers
	<HandleError> _
	Public Class HomeController
		Inherits Controller
		<HttpGet> _
		Public Function Index() As ActionResult
			ViewData("Message") = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Dim model As New MyModel()

			Return View(model)
		End Function

		<HttpPost> _
		Public Function PostValues(ByVal form As FormCollection) As ActionResult
			Dim actionName As String = form("actionName")

			Dim model As New MyModel()

			If TryUpdateModel(Of MyModel)(model) Then
				If actionName = "act1" Then
					Return RedirectToAction("PostValues1", model)
				ElseIf actionName = "act2" Then
					Return RedirectToAction("PostValues2", model)
				End If
			End If

			Return Content("Form was not submitted by the NavBar, or the Model was invalid :(")
		End Function

		Public Function PostValues1(ByVal model As MyModel) As ActionResult
			Return Content(String.Format("Action 1 (memo: '{0}')", model.Text))
		End Function

		Public Function PostValues2(ByVal model As MyModel) As ActionResult
			Return Content(String.Format("Action 2 (memo: '{0}')", model.Text))
		End Function
	End Class
End Namespace
