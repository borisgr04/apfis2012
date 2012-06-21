Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel


<System.ComponentModel.DataObject()> _
Public Class Terceros
    Inherits BDDatos

    Public Sub New()
        Me.Tabla = "Terceros"
        Me.VistaDB = "Terceros"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetRecords(ByVal busc As String, ByVal tipo As String) As DataTable

        Me.Conectar()
        '++++++++++ TIPO: 
        '** AR -> AGENTE RECAUDADOR
        '** RT -> RENTAS
        '** OT -> OTRO - PD o P
        '**
        Dim tp As String = "OT"
        If (tipo = "AR") Or (tipo = "RT") Then
            tp = tipo
        End If
        Dim queryString As String
        If busc <> "" Then
            busc = "%" + UCase(busc) + "%"
            queryString = "SELECT * FROM TERCEROS WHERE ((Cedula like :busc) OR (upper(NOMBRES) like :busc)) And Tipo=:Tipo"
            Me.CrearComando(queryString)
            Me.AsignarParametroCadena(":busc", busc)
            Me.AsignarParametroCadena(":busc", busc)
            Me.AsignarParametroCadena(":Tipo", UCase(tipo))
            'Throw New Exception(vComando.CommandText)
        Else
            queryString = "SELECT * FROM TERCEROS WHERE 1<>1"
            Me.CrearComando(queryString)
        End If

        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function
    

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetByUser(Optional ByVal User As String = "") As DataTable

        'Si no recibe ningún Usuario, buscará los Datos del Usuario Conectado

        If User = "" Then

            User = Me.usuario
        End If
        'Me.Desconectar()
        Me.Conectar()
        querystring = "SELECT * FROM Terceros WHERE Cedula=:Cedula"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cedula", User)
        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetByIde(ByVal Ide_ter As String) As DataTable

        Me.Conectar()
        Dim queryString As String = "SELECT * FROM Terceros WHERE Cedula=:Cedula"

        Me.CrearComando(queryString)
        Me.AsignarParametroCadena(":Cedula", Ide_ter)
        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetByTipo(ByVal Tipo As String) As DataTable

        Me.Conectar()
        Dim queryString As String = "SELECT * FROM Terceros WHERE Tipo=:Tipo"
        Me.CrearComando(queryString)
        Me.AsignarParametroCadena(":Tipo", Tipo)
        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Ced_Inf As String, ByVal Ape1_inf As String, ByVal Ape2_Inf As String, ByVal Nom_Inf As String, ByVal Exp_Ced_Inf As String, ByVal Dir_Inf As String, ByVal Tel_Inf As String, ByVal Cor_Inf As String, ByVal Tipo As String) As String
        Try
            Conectar()
            If Tipo = "Infractor" Then
                querystring = "INSERT INTO Infractor(Ced_Inf, Ape1_Inf, Ape2_Inf, Nom_Inf, Exp_Ced_Inf, Dir_Inf, Tel_Inf, Cor_Inf)VALUES(:Ced_Inf, :Ape1_Inf, :Ape2_Inf, :Nom_Inf, :Exp_Ced_Inf, :Dir_Inf, :Tel_Inf, :Cor_Inf)"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Inf", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Inf", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Inf", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Inf", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Inf", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Inf", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Inf", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Inf", Cor_Inf)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            ElseIf Tipo = "RBodega" Then
                querystring = "INSERT INTO RBodega(Ced_Bod, Ape1_Bod, Ape2_Bod, Nom_Bod, Exp_Ced_Bod, Dir_Bod, Tel_Bod, Cor_Bod)VALUES(:Ced_Bod, :Ape1_Bod, :Ape2_Bod, :Nom_Bod, :Exp_Ced_Bod, :Dir_Bod, :Tel_Bod, :Cor_Bod)"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Bod", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Bod", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Bod", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Bod", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Bod", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Bod", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Bod", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Bod", Cor_Inf)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            ElseIf Tipo = "RAutoridad" Then
                querystring = "INSERT INTO RAutoridad(Ced_Aut, Ape1_Aut, Ape2_Aut, Nom_Aut, Exp_Ced_Aut, Dir_Aut, Tel_Aut, Cor_Aut)VALUES(:Ced_Aut, :Ape1_Aut, :Ape2_Aut, :Nom_Aut, :Exp_Ced_Aut, :Dir_Aut, :Tel_Aut, :Cor_Aut)"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Aut", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Aut", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Aut", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Aut", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Aut", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Aut", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Aut", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Aut", Cor_Inf)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            Else
                querystring = "INSERT INTO CGOPERATIVO(Ced_Cgo, Ape1_Cgo, Ape2_Cgo, Nom_Cgo, Exp_Ced_Cgo, Dir_Cgo, Tel_Cgo, Cor_Cgo)VALUES(:Ced_Aut, :Ape1_Aut, :Ape2_Aut, :Nom_Aut, :Exp_Ced_Aut, :Dir_Aut, :Tel_Aut, :Cor_Aut)"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Aut", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Aut", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Aut", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Aut", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Aut", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Aut", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Aut", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Aut", Cor_Inf)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            End If
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
    Public Function Update(ByVal Ced_Inf As String, ByVal Ape1_inf As String, ByVal Ape2_Inf As String, ByVal Nom_Inf As String, ByVal Exp_Ced_Inf As String, ByVal Dir_Inf As String, ByVal Tel_Inf As String, ByVal Cor_Inf As String, ByVal CedPK As String, ByVal Tipo As String) As String
        Try
            Conectar()
            If Tipo = "Infractor" Then
                querystring = "UPDATE Infractor SET Ced_Inf=:Ced_Inf, Ape1_Inf=:Ape1_Inf, Ape2_Inf=:Ape2_Inf, Nom_Inf=:Nom_Inf, Exp_Ced_Inf=:Exp_Ced_Inf, Dir_Inf=:Dir_Inf, Tel_Inf=:Tel_Inf, Cor_Inf=:Cor_Inf WHERE Ced_iNF=:CedulaPK"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Inf", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Inf", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Inf", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Inf", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Inf", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Inf", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Inf", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Inf", Cor_Inf)
                Me.AsignarParametroCadena(":CedulaPK", CedPK)
                'Throw New Exception(vComando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            ElseIf Tipo = "RBodega" Then
                querystring = "UPDATE RBodega SET Ced_Bod=:Ced_Bod, Ape1_Bod=:Ape1_Bod, Ape2_Bod=:Ape2_Bod, Nom_Bod=:Nom_Bod, Exp_Ced_Bod=:Exp_Ced_Bod, Dir_Bod=:Dir_Bod, Tel_Bod=:Tel_Bod, Cor_Bod=:Cor_Bod WHERE Ced_Bod=:CedulaPK"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Bod", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Bod", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Bod", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Bod", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Bod", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Bod", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Bod", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Bod", Cor_Inf)
                Me.AsignarParametroCadena(":CedulaPK", CedPK)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            ElseIf Tipo = "RAutoridad" Then
                querystring = "UPDATE RAutoridad SET Ced_Aut=:Ced_Aut, Ape1_Aut=:Ape1_Aut, Ape2_Aut=:Ape2_Aut, Nom_Aut=:Nom_Aut, Exp_Ced_Aut=:Exp_Ced_Aut, Dir_Aut=:Dir_Aut, Tel_Aut=:Tel_Aut, Cor_Aut=:Cor_Aut WHERE Ced_Aut=:CedulaPK"
                Me.CrearComando(querystring)
                Me.AsignarParametroCadena(":Ced_Aut", Ced_Inf)
                Me.AsignarParametroCadena(":Ape1_Aut", Ape1_inf)
                Me.AsignarParametroCadena(":Ape2_Aut", Ape2_Inf)
                Me.AsignarParametroCadena(":Nom_Aut", Nom_Inf)
                Me.AsignarParametroCadena(":Exp_Ced_Aut", Exp_Ced_Inf)
                Me.AsignarParametroCadena(":Dir_Aut", Dir_Inf)
                Me.AsignarParametroCadena(":Tel_Aut", Tel_Inf)
                Me.AsignarParametroCadena(":Cor_Aut", Cor_Inf)
                Me.AsignarParametroCadena(":CedulaPK", CedPK)
                'Throw New Exception(_Comando.CommandText)
                Me.num_reg = Me.EjecutarComando()
                Me.ConfirmarTransaccion()
                Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
                Me.lErrorG = False
            End If
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
