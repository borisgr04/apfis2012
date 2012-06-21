Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Data
'Clase para manejar la Tabla Municipios de la Base de datos
'Fecha Creaciòn: 19 dic 2009
'Autor: Ronal Javier
<System.ComponentModel.DataObject()> _
Public Class Municipios
    Inherits BDDatos
    '---------------------------------------------------------------------------------------------------------------
    ' Funciòn Insert: Agrega datos a la tabla Municipios

    'Public Function Insert(ByVal MUN_COD As String, ByVal MUN_NOM As String, ByVal MUN_DPCO As String) As String

    '    Dim na As Integer
    '    Me.AbrirDB()
    '    Try
    '        Dim dbCommand As New OracleCommand
    '        dbCommand.Connection = dbConnection
    '        dbCommand.CommandText = "INSERT INTO Municipios (MUN_COD,MUN_NOM,MUN_DPCO)VALUES(:MUN_COD,:MUN_NOM,:MUN_DPCO)"
    '        dbCommand.Parameters.Add("MUN_COD", OracleDbType.Varchar2, ParameterDirection.Input).Value = MUN_COD
    '        dbCommand.Parameters.Add("MUN_NOM", OracleDbType.Varchar2, ParameterDirection.Input).Value = MUN_NOM
    '        dbCommand.Parameters.Add("MUN_DPCO", OracleDbType.Varchar2, ParameterDirection.Input).Value = MUN_DPCO

    '        'Me.usuario

    '        na = dbCommand.ExecuteNonQuery()
    '        Me.Msg = MsgOk + "<BR> Número de Filas Afectadas " + na.ToString
    '        Me.lErrorG = False
    '    Catch exo As OracleException
    '        Me.lErrorG = True
    '        Me.Msg = "Error de Datos:" + exo.Message
    '    Catch ex As Exception
    '        Me.lErrorG = True
    '        Me.Msg = "Error de App:" + ex.Message
    '    Finally
    '        Me.CerrarBD()
    '    End Try


    '    Return Msg
    'End Function
    '' Funciòn Actualizar: Acatualiza datos a la tabla Municipios
    ''    
    'Public Function Update(ByVal MUN_COD_OR As String, ByVal MUN_COD As String, ByVal MUN_NOM As String, ByVal MUN_DPCO As String) As String
    '    Dim na As String
    '    Me.AbrirDB()
    '    Try
    '        Dim dbCommand As New OracleCommand
    '        dbCommand.Connection = dbConnection
    '        dbCommand.CommandText = "UPDATE Municipios SET MUN_COD='" + MUN_COD + "',MUN_NOM='" + MUN_NOM + "' ,MUN_DPCO='" + MUN_DPCO + "' WHERE MUN_COD='" + MUN_COD_OR + "' "
    '        na = dbCommand.ExecuteNonQuery()
    '        Me.Msg = MsgOk + "<BR> Registros Actualizados [" + na + "]"

    '        Me.lErrorG = False
    '    Catch exo As OracleException
    '        Me.lErrorG = True
    '        Me.Msg = "Error de Datos:" + exo.Message
    '    Catch ex As Exception
    '        Me.lErrorG = True
    '        Me.Msg = "Error de App:" + ex.Message
    '    Finally
    '        Me.CerrarBD()
    '    End Try

    '    Return Msg
    'End Function
    ''Funciòn Delete: elimina datos a la tabla Municipios
    '' Parametros: Tcta_Codi : Còdigo

    'Public Function Delete(ByVal MUN_COD As String) As String
    '    Dim na As String

    '    'If (CInt(COD) = 1) Or (CInt(COD) = 2) Or (CInt(COD) = 3) Then

    '    'Return "Esta Clase de Impuesto, No se puede eliminar"
    '    'End If
    '    Me.AbrirDB()
    '    Try
    '        Dim dbCommand As New OracleCommand
    '        dbCommand.Connection = dbConnection

    '        dbCommand.CommandText = "DELETE Municipios WHERE MUN_COD='" + MUN_COD + "'"
    '        na = dbCommand.ExecuteNonQuery()
    '        Me.Msg = MsgOk + " # Registros Eliminados:" + na.ToString
    '        Me.lErrorG = False
    '    Catch exo As OracleException
    '        Me.lErrorG = True
    '        Me.Msg = "Error de Datos:" + exo.Message
    '    Catch ex As Exception
    '        Me.lErrorG = True
    '        Me.Msg = "Error de App:" + ex.Message
    '    Finally
    '        Me.CerrarBD()
    '    End Try
    '    Return Msg
    'End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overrides Function GetRecords() As DataTable
        Me.Conectar()
        querystring = "SELECT * FROM Municipios ORDER BY COD_MUN"
        Me.CrearComando(querystring)
        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function


End Class
