Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports System.Collections.Specialized
Imports System.ComponentModel



'CLASE              : BDDATOS
'DESCRIPCIÓN        : Clase Base de Acceso a la Base de Datos
'AUTOR              : BORIS GONZALEZ.
'FECHA CREACIÓN     : 18 de Julio del 2009
'FECHA MODIFICACION : 23 DE SEPTIEMBRE DE 2010
'AGREGADO A SIRCC2011, 26 de septiembre
<DataObjectAttribute()> _
Public Class BDDatos
    Inherits BD

    'HEREDADO DE BD CLASE 
    Protected MsgOk As String = "Se Realizó la Operación Exitosamente - "
    Protected Tabla As String
    Protected VistaDB As String
    Protected Vista As String
    Protected usuario As String
    Protected Ruta_Doc As String
    Protected AppName As String
    Protected inLine As Boolean
    Protected num_reg As Integer
    Protected querystring As String
    'Publicos
    Public Doc As String
    Public lErrorG As Boolean
    Public Msg As String = ""

    ''' <summary>
    ''' Retorna los todos los registros de la tabla de la Base de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overridable Function GetRecords() As DataTable
        Dim queryString As String = "SELECT * FROM  " + Vista
        Me.Conectar()
        Me.CrearComando(queryString)
        Dim dataSet As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataSet

    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overridable Function GetRecordsDB() As DataTable
        Dim queryString As String = "SELECT * FROM  " + VistaDB
        Me.Conectar()
        Me.CrearComando(queryString)
        Dim dataSet As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataSet

    End Function
    ''' <summary>
    '''  Retorna los todos los registros de la tabla de la Base de datos, segun el filtro especificado
    ''' </summary>
    ''' <param name="Filtro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetRecords(ByVal Filtro As String) As DataTable
        Dim queryString As String = "SELECT * FROM " + Vista + " Where " + Filtro
        Me.Conectar()
        Me.CrearComando(queryString)
        Dim dataSet As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataSet

    End Function
    ''' <summary>
    ''' Abre la Conexión con la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Shadows Sub Conectar()
        MyBase.Conectar()
        Inicializar_Usuario()
    End Sub

    Public Sub New()
        MyBase.New()
        'Me.Ruta_Doc = ConfigurationManager.AppSettings("RUTA_DOC").ToString
        Try
            Me.usuario = Membership.GetUser().UserName
            Me.AppName = Membership.ApplicationName.ToString()
            Me.inLine = True

        Catch ex As Exception
            Me.inLine = False
        End Try
    End Sub

    ''' <summary>
    ''' Inicializa el Usuario, MemberShip en la base de datos (v.usap)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Inicializar_Usuario()
        'Me.CrearComando("Begin Inicializar_Usuario('" + Me.usuario + "'); End;")
        'Me.EjecutarComando()
    End Sub

End Class
