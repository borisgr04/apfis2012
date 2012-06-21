Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports System.Collections.Specialized
Imports System.ComponentModel
'CLASE              : Entidad
'DESCRIPCIÓN        : Nueva Version SIRCC2011, Clase Base de Acceso a la Base de Datos
'AUTOR              : BORIS GONZALEZ.
'FECHA CREACIÓN     : 27 de Enero del 2011
'FECHA MODIFICACION :
<System.ComponentModel.DataObject()> _
Public Class Entidad
    Inherits BDDatos

    Public Sub New()
        MyBase.New()
        Me.Vista = "CTRL_ENTIDAD"
        Me.Tabla = "CTRL_ENTIDAD"
        Me.Ruta_Doc = ConfigurationManager.AppSettings("RUTA_DOC").ToString
        Try
            Me.usuario = Membership.GetUser().UserName
            Me.AppName = Membership.ApplicationName.ToString()
            Me.inLine = True
        Catch ex As Exception
            Me.inLine = False
        End Try
    End Sub

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyPk(ByVal Cod_SecPrincipal As String) As DataTable
        querystring = "SELECT * FROM  " + Tabla + " Where Cod_SecPrincipal=:Cod_SecPrincipal"
        Me.Conectar()
        Me.CrearComando(querystring)
        AsignarParametroCadena(":Cod_SecPrincipal", Cod_SecPrincipal)
        Dim dataSet As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataSet
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Update, True)> _
    Public Function Update(ByVal Cod_SecPrincipal_O As String, ByVal Cod_SecPrincipal As String, ByVal Nom_SecPrincipal As String, ByVal Nit As String, ByVal Representante_Legal As String, ByVal Telefono As String, ByVal Fax As String, ByVal Email As String, ByVal Direccion As String, ByVal Pais As String, ByVal Departamento As String, ByVal Ciudad As String, ByVal Municipio As String) As String
        Me.Conectar()
        Try
            Me.ComenzarTransaccion()
            querystring = "UPDATE CTRL_ENTIDAD SET Cod_SecPrincipal=:Cod_SecPrincipal, Nom_SecPrincipal=:Nom_SecPrincipal, Nit=:Nit, Representante_Legal=:Representante_Legal, Telefono=:Telefono, Fax=:Fax, Email=:Email, Direccion=:Direccion, Pais=:Pais, Departamento=:Departamento, Ciudad=:Ciudad, Municipio=:Municipio WHERE Cod_SecPrincipal=:Cod_SecPrincipal_O"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_SecPrincipal", Cod_SecPrincipal)
            Me.AsignarParametroCadena(":Nom_SecPrincipal", Nom_SecPrincipal)
            Me.AsignarParametroCadena(":Nit", Nit)
            Me.AsignarParametroCadena(":Representante_Legal", Representante_Legal)
            Me.AsignarParametroCadena(":Telefono", Telefono)
            Me.AsignarParametroCadena(":Fax", Fax)
            Me.AsignarParametroCadena(":Email", Email)
            Me.AsignarParametroCadena(":Direccion", Direccion)
            Me.AsignarParametroCadena(":Pais", Pais)
            Me.AsignarParametroCadena(":Departamento", Departamento)
            Me.AsignarParametroCadena(":Ciudad", Ciudad)
            Me.AsignarParametroCadena(":Municipio", Municipio)
            Me.AsignarParametroCadena(":Cod_SecPrincipal_O", Cod_SecPrincipal_O)
            'Throw New Exception(Me._Comando.CommandText)
            Me.num_reg = Me.EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = Me.MsgOk + " Filas Afectadas [" + Me.num_reg.ToString + "]"
            Me.lErrorG = False
        Catch ex As Exception
            Me.Msg = "Error:" + ex.Message
            Me.CancelarTransaccion()
            Me.lErrorG = True
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
End Class


