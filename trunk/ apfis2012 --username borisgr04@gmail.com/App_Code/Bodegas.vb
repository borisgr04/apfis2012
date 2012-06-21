Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Bodegas
    Inherits BDDatos
    Sub New()
        Me.Tabla = "Bodegas"
        Me.Vista = "VBodegas"
        Me.VistaDB = "VBodegasDB"
    End Sub
    Public Function GetMunbyBOD(ByVal Cod_Bod As String) As String
        Me.Conectar()
        Me.querystring = "select * from BODEGAS where Cod_Bod=:Cod_Bod"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Bod", UCase(Cod_Bod))
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Dim codmun As String = dt.Rows(0)("Cod_Mun").ToString
        Return codmun
    End Function
    Public Function GetbyPK(ByVal Cod_Bod As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from BODEGAS where Cod_Bod=:Cod_Bod"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Bod", UCase(Cod_Bod))
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyMun(ByVal Cod_Mun As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from BODEGAS where Cod_Mun=:Cod_Mun"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cod_Mun", UCase(Cod_Mun))
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Cod_Bod As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM Bodegas Where Cod_Bod=:Cod_Bod"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Bod", UCase(Cod_Bod))
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
    Public Function Insert(ByVal Nom_Est As String, ByVal Dir_Est As String, ByVal Nit_Est As String, ByVal Tel_Est As String, ByVal Cor_Est As String, ByVal Cod_mun As String, ByVal Est_Bod As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO BODEGAS(Cod_Bod, Nom_Bod, Dir_Bod, Tel_Bod, Ema_Bod, Cod_Mun, Est_Bod)VALUES(:Cod_Bod, :Nom_Bod, :Dir_Bod, :Tel_Bod, :Cor_Bod, :Cod_Mun, :Est_Bod)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Bod", UCase(Nit_Est))
            Me.AsignarParametroCadena(":Nom_Bod", UCase(Nom_Est))
            Me.AsignarParametroCadena(":Dir_Bod", UCase(Dir_Est))
            Me.AsignarParametroCadena(":Tel_Bod", UCase(Tel_Est))
            Me.AsignarParametroCadena(":Cor_Bod", UCase(Cor_Est))
            Me.AsignarParametroCadena(":Cod_Mun", UCase(Cod_mun))
            Me.AsignarParametroCadena(":Est_Bod", UCase(Est_Bod))
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

    <DataObjectMethodAttribute(DataObjectMethodType.Update, True)> _
    Public Function Update(ByVal Nom_Est As String, ByVal Dir_Est As String, ByVal Nit_Est As String, ByVal Tel_Est As String, ByVal Cor_Est As String, ByVal cod_mun As String, ByVal Est_Bod As String, ByVal Original_Nit As String) As String
        Try
            Conectar()
            querystring = "UPDATE BODEGAS SET Cod_Bod=:Cod_Bod, Nom_Bod=:Nom_Bod, Dir_Bod=:Dir_Bod, Tel_Bod=:Tel_Bod, Ema_Bod=:Ema_Bod, Est_Bod=:Est_Bod, Cod_mun=:Cod_Mun Where Cod_Bod=:Original_Nit"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cod_Bod", UCase(Nit_Est))
            Me.AsignarParametroCadena(":Nom_Bod", UCase(Nom_Est))
            Me.AsignarParametroCadena(":Dir_Bod", UCase(Dir_Est))
            Me.AsignarParametroCadena(":Tel_Bod", UCase(Tel_Est))
            Me.AsignarParametroCadena(":Ema_Bod", UCase(Cor_Est))
            Me.AsignarParametroCadena(":Cod_Mun", UCase(cod_mun))
            Me.AsignarParametroCadena(":Est_Bod", UCase(Est_Bod))
            Me.AsignarParametroCadena(":Original_Nit", UCase(Original_Nit))
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
