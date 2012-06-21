Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Infractores
    Inherits BDDatos
    Sub New()
        Me.Tabla = "Infractor"
        Me.Vista = "Infractor"
        Me.VistaDB = "Infractor"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyPK(ByVal Cedula As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from Infractor where Ced_Inf=:Cedula"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cedula", Cedula)
        'Throw New Exception(vComando.CommandText)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Ced_Inf As String, ByVal Ape1_inf As String, ByVal Ape2_Inf As String, ByVal Nom_Inf As String, ByVal Exp_Ced_Inf As String, ByVal Dir_Inf As String, ByVal Tel_Inf As String, ByVal Cor_Inf As String) As String
        Try
            Conectar()
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
    Public Function Update(ByVal Ced_Inf As String, ByVal Ape1_inf As String, ByVal Ape2_Inf As String, ByVal Nom_Inf As String, ByVal Exp_Ced_Inf As String, ByVal Dir_Inf As String, ByVal Tel_Inf As String, ByVal Cor_Inf As String, ByVal CedPK As String) As String
        Try
            Conectar()
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
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Cedula As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM Infractor Where Ced_Inf=:Cedula"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Cedula", Cedula)
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
End Class
