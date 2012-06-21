Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Establecimientos
    Inherits BDDatos
    Sub New()
        Me.Tabla = "ESTABLEC"
        Me.Vista = "ESTABLEC"
        Me.VistaDB = "ESTABLEC"
    End Sub
    Public Function GetbyPK(ByVal Nit As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from ESTABLEC where Nit_Est=:Nit"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Nit", UCase(Nit))
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Original_Nit As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM ESTABLEC Where Nit_Est=:Nit"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Nit", UCase(Original_Nit))
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
    Public Function Insert(ByVal Nom_Est As String, ByVal Dir_Est As String, ByVal Nit_Est As String, ByVal Tel_Est As String, ByVal Cor_Est As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO ESTABLEC(Nit_Est, Nom_Est, Dir_Est, Tel_Est, Cor_Est)VALUES(:Nit_Est, :Nom_Est, :Dir_Est, :Tel_Est, :Cor_Est)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Nit_Est", UCase(Nit_Est))
            Me.AsignarParametroCadena(":Nom_Est", UCase(Nom_Est))
            Me.AsignarParametroCadena(":Dir_Est", UCase(Dir_Est))
            Me.AsignarParametroCadena(":Tel_Est", UCase(Tel_Est))
            Me.AsignarParametroCadena(":Cor_Est", UCase(Cor_Est))
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
    Public Function Update(ByVal Nom_Est As String, ByVal Dir_Est As String, ByVal Nit_Est As String, ByVal Tel_Est As String, ByVal Cor_Est As String, ByVal Original_Nit As String) As String
        Try
            Conectar()
            querystring = "UPDATE ESTABLEC SET Nit_Est=:Nit_Est, Nom_Est=:Nom_Est, Dir_Est=:Dir_Est, Tel_Est=:Tel_Est, Cor_Est=:Cor_Est Where Nit_Est=:Original_Nit"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Nit_Est", UCase(Nit_Est))
            Me.AsignarParametroCadena(":Nom_Est", UCase(Nom_Est))
            Me.AsignarParametroCadena(":Dir_Est", UCase(Dir_Est))
            Me.AsignarParametroCadena(":Tel_Est", UCase(Tel_Est))
            Me.AsignarParametroCadena(":Cor_Est", UCase(Cor_Est))
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
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetRecords(ByVal busc As String, ByVal tipo As String) As DataTable

        Me.Conectar()
        '++++++++++ TIPO: 
        '** AR -> AGENTE RECAUDADOR
        '** RT -> RENTAS
        '** OT -> OTRO - PD o P
        '**
        Dim queryString As String
        If busc <> "" Then
            busc = "%" + UCase(busc) + "%"
            queryString = "SELECT * FROM ESTABLEC WHERE ((Nit_Est like :busc) OR (upper(Nom_Est) like :busc))"
            Me.CrearComando(queryString)
            Me.AsignarParametroCadena(":busc", busc)
            Me.AsignarParametroCadena(":busc", busc)
            'Throw New Exception(vComando.CommandText)
        Else
            queryString = "SELECT * FROM ESTABLEC WHERE 1<>1"
            Me.CrearComando(queryString)
        End If

        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function
End Class
