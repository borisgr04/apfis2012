Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel

Public Class Categorias
    Inherits BDDatos
    Sub New()
        Me.Tabla = "CAT_PROD"
        Me.Vista = "CAT_PROD"
        Me.VistaDB = "CAT_PROD"
    End Sub
    Public Function GetbyPK(ByVal Cod_Cat As String) As DataTable
        Me.Conectar()
        Me.querystring = "Select * from Cat_Prod where Cod_Cat=:Cod_Cat"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Original_Cod_Cat As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM CAT_PROD Where Cod_Cat=:Cod_Cat_o"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Cat_o", Original_Cod_Cat)
            Me.num_reg = EjecutarComando()
            ConfirmarTransaccion()
            Me.lErrorG = False
            Me.Msg = MsgOk & "[" & num_reg & "] " & "FIlas Afectadas"
        Catch ex As Exception
            CancelarTransaccion()
            Me.lErrorG = True
            Me.Msg = "Error: " & ex.Message
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Cod_Cat As String, ByVal Des_Cat As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO CAT_PROD(Cod_Cat, Des_Cat)VALUES(:Cod_Cat, :Des_Cat) "
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Des_Cat", Des_Cat)
            'Throw New Exception(_Comando.CommandText)
            Me.num_reg = Me.EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
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

    <DataObjectMethodAttribute(DataObjectMethodType.Update, True)> _
    Public Function Update(ByVal Des_Cat As String, ByVal Cod_Cat As String, ByVal Original_Cod_Cat As String) As String

        Try
            Conectar()
            querystring = "UPDATE CAT_PROD SET Des_Cat=:Des_Cat, Cod_Cat=:Cod_Cat Where Cod_Cat=:Original_Cod_Cat"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Des_Cat", Des_Cat)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Original_Cod_Cat", Original_Cod_Cat)
            'Throw New Exception(vComando.CommandText)
            Me.num_reg = Me.EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
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
