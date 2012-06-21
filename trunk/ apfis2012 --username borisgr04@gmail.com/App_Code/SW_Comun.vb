Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
'<WebService(Namespace:="http://tempuri.org/")> _
<WebService(Namespace:="http://www.byasystems.com.co/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class SW_Comun
    Inherits System.Web.Services.WebService


    ''' <summary>
    ''' Valida Usuario en Base de Datos SIRCC 2011
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod()> _
    Public Function ValidarUsuario2(ByVal Username As String, ByVal password As String, ByRef oNombre As String) As Boolean
        If Usuarios.Validar_Usuarios(Username, password) Then
            Dim t As New Terceros
            oNombre = t.GetByUser(Username).Rows(0)("Nom_Ter").ToString
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Valida Usuario en Base de Datos SIRCC 2011, utilizada para SIRCC Doc
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod()> _
    Public Function ValidarUsuario(ByVal Username As String, ByVal password As String) As Boolean
        Return Usuarios.Validar_Usuarios(Username, password)
    End Function

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World! This is SIRCC2011"
    End Function

End Class