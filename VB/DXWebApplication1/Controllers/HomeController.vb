Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DXWebApplication1.Controllers
	Public Class HomeController
		Inherits Controller

		<HttpGet>
		Public Function Index() As ActionResult
			Return View()
		End Function
		<HttpPost>
		Public Function Index(ByVal model As Object) As ActionResult
			Return View()
		End Function
	End Class
End Namespace
