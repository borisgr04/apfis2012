Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Data
Public Class SubCategorias
    Inherits BDDatos
    Sub New()
        Me.Tabla = "SCAT_PROD"
        Me.Vista = "VSCAT_PROD"
        Me.VistaDB = "VSCAT_PROD"
    End Sub
    Public Function GetbyPK(ByVal Cod_Scat As String) As DataTable
        Me.Conectar()
        Me.querystring = "Select * from VSCAT_PROD where Cod_Scat=:Cod_Scat"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Scat", Cod_Scat)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Original_Cod_SCat As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM SCAT_PROD Where Cod_SCat=:Cod_SCat_o"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_SCat_o", Original_Cod_SCat)
            Me.num_reg = EjecutarComando()
            ConfirmarTransaccion()
            Me.lErrorG = False
            Me.Msg = MsgOk + "[" + Me.num_reg.ToString + "]"
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
    Public Function Insert(ByVal Cod_Cat As String, ByVal Cod_SCat As String, ByVal Des_SCat As String, ByVal Cod_SCat_Ant As String, ByVal Cod_Fnd As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO SCAT_PROD(Cod_SCat, Des_SCat, Cod_Cat, Cod_Scat_Ant, Cod_Fnd)VALUES(:Cod_SCat, :Des_SCat, :Cod_Cat, :Cod_SCat_Ant, :Cod_Fnd) "
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Des_SCat", Des_SCat)
            Me.AsignarParametroCadena(":Cod_SCat", Cod_SCat)
            Me.AsignarParametroCadena(":Cod_SCat_Ant", Cod_SCat_Ant)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Cod_Fnd", Cod_Fnd)
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
    Public Function Update(ByVal Cod_Cat As String, ByVal Cod_SCat As String, ByVal Des_SCat As String, ByVal Cod_SCat_Ant As String, ByVal Cod_Fnd As String, ByVal Original_Cod_SCat As String) As String

        Try
            Conectar()
            querystring = "UPDATE SCAT_PROD SET Des_SCat=:Des_SCat, Cod_SCat=:Cod_SCat, Cod_Cat=:Cod_Cat, Cod_Scat_Ant=:Cod_SCat_Ant, Cod_Fnd=:Cod_Fnd Where Cod_SCat=:Original_Cod_SCat"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Des_SCat", Des_SCat)
            Me.AsignarParametroCadena(":Cod_SCat", Cod_SCat)
            Me.AsignarParametroCadena(":Cod_SCat_Ant", Cod_SCat_Ant)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Cod_Fnd", Cod_Fnd)
            Me.AsignarParametroCadena(":Original_Cod_SCat", Original_Cod_SCat)
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
