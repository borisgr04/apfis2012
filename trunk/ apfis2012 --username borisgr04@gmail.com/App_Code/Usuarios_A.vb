Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
''' <summary>
''' Clase usuario, compatible con los Usuarios Aplicación ASP.
''' Para el Modulo de Consultas, Depsues utilizar modelo de Asp.Net (MemberShip)
''' </summary>
''' <remarks></remarks>
<System.ComponentModel.DataObject()> _
Public Class UsuariosA
    Inherits BDDatos


    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function Validar_Usuarios(ByVal Usuario As String, ByVal Clave As String) As Boolean
        Me.Conectar()
        Dim Seg As New Seguridad
        querystring = "SELECT Nvl(Count(*),0) As Cant FROM Usuarios WHERE Trim(Username)=Trim(:Username) And Trim(PassWord)=Trim(:PassWord)"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Username", UCase(Usuario))
        Me.AsignarParametroCadena(":PassWord", Seg.Cript(Clave))
        'Throw New Exception(Me._Comando.CommandText)
        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        'Throw New Exception(IIf() > 0, True, False).ToString)
        Dim c As Integer = CInt(dataTb.Rows(0)("Cant"))
        Return c > 0
    End Function

    
End Class




