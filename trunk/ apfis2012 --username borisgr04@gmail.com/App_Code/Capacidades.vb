Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Capacidades
    Inherits BDDatos
    Sub New()
        Me.Tabla = "CAP_PROD"
        Me.Vista = "VCAP_PROD"
        Me.VistaDB = "VCAP_PROD"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyCat(ByVal Cod_Scat As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from vcap_prod where cod_cat=(select cod_cat from scat_prod where cod_scat=:Cod_Scat)"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Scat", Cod_Scat)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    Public Function GetbyPK(ByVal Cod_Cap As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from vcap_prod where cod_cap=:Cod_Cap"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Cap", Cod_Cap)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Original_Cod_Cap As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM CAP_PROD Where Cod_Cap=:Cod_Cap_o"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Cap_o", Original_Cod_Cap)
            Me.num_reg = EjecutarComando()
            ConfirmarTransaccion()
            Me.lErrorG = False
            Me.Msg = MsgOk & "[" & num_reg & "] " & "Filas Afectadas"
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
    Public Function Insert(ByVal Cod_Cap As String, ByVal Des_Cap As String, ByVal Cod_Cat As String, ByVal Cod_Cap_Ant As String, ByVal Pre_Fnd As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO CAP_PROD(Cod_Cap, Des_Cap, Cod_Cat, Cod_Cap_Ant, Pre_Fnd)VALUES(:Cod_Cap, :Des_Cap, :Cod_Cat, :Cod_Cap_Ant, :Pre_Fnd) "
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Cap", Cod_Cap)
            Me.AsignarParametroCadena(":Des_Cap", Des_Cap)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Cod_Cap_Ant", Cod_Cap_Ant)
            Me.AsignarParametroCadena(":Pre_Fnd", Pre_Fnd)
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
    Public Function Update(ByVal Cod_Cap As String, ByVal Des_Cap As String, ByVal Cod_Cat As String, ByVal Cod_Cap_Ant As String, ByVal Pre_Fnd As String, ByVal Original_Cod_Cap As String) As String
        Try
            Conectar()
            querystring = "UPDATE CAP_PROD SET Des_Cap=:Des_Cap, Cod_Cap=:Cod_Cap, Cod_Cat=:Cod_Cat, Cod_Cap_Ant=:Cod_Cap_Ant, Pre_Fnd=:Pre_Fnd Where Cod_Cap=:Original_Cod_Cap"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Cap", Cod_Cap)
            Me.AsignarParametroCadena(":Des_Cap", Des_Cap)
            Me.AsignarParametroCadena(":Cod_Cat", Cod_Cat)
            Me.AsignarParametroCadena(":Cod_Cap_Ant", Cod_Cap_Ant)
            Me.AsignarParametroCadena(":Pre_Fnd", Pre_Fnd)
            Me.AsignarParametroCadena(":Original_Cod_Cap", Original_Cod_Cap)
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
End Class
