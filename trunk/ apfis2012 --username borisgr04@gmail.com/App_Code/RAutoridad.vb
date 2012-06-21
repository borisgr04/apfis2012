Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class RAutoridad
    Inherits BDDatos
    Sub New()
        Me.Tabla = "RAutoridad"
        Me.Vista = "RAutoridad"
        Me.VistaDB = "RAutoridad"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyPK(ByVal Cedula As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from RAutoridad where Ced_Aut=:Cedula"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cedula", Cedula)
        'Throw New Exception(vComando.CommandText)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Ced_Aut As String, ByVal Ape1_Aut As String, ByVal Ape2_Aut As String, ByVal Nom_Aut As String, ByVal Exp_Ced_Aut As String, ByVal Dir_Aut As String, ByVal Tel_Aut As String, ByVal Cor_Aut As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO RAutoridad(Ced_Aut, Ape1_Aut, Ape2_Aut, Nom_Aut, Exp_Ced_Aut, Dir_Aut, Tel_Aut, Cor_Aut)VALUES(:Ced_Aut, :Ape1_Aut, :Ape2_Aut, :Nom_Aut, :Exp_Ced_Aut, :Dir_Aut, :Tel_Aut, :Cor_Aut)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Ced_Aut", Ced_Aut)
            Me.AsignarParametroCadena(":Ape1_Aut", Ape1_Aut)
            Me.AsignarParametroCadena(":Ape2_Aut", Ape2_Aut)
            Me.AsignarParametroCadena(":Nom_Aut", Nom_Aut)
            Me.AsignarParametroCadena(":Exp_Ced_Aut", Exp_Ced_Aut)
            Me.AsignarParametroCadena(":Dir_Aut", Dir_Aut)
            Me.AsignarParametroCadena(":Tel_Aut", Tel_Aut)
            Me.AsignarParametroCadena(":Cor_Aut", Cor_Aut)
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
    Public Function Update(ByVal Ced_Aut As String, ByVal Ape1_Aut As String, ByVal Ape2_Aut As String, ByVal Nom_Aut As String, ByVal Exp_Ced_Aut As String, ByVal Dir_Aut As String, ByVal Tel_Aut As String, ByVal Cor_Aut As String, ByVal CedPK As String) As String
        Try
            Conectar()
            querystring = "UPDATE RAutoridad SET Ced_Aut=:Ced_Aut, Ape1_Aut=:Ape1_Aut, Ape2_Aut=:Ape2_Aut, Nom_Aut=:Nom_Aut, Exp_Ced_Aut=:Exp_Ced_Aut, Dir_Aut=:Dir_Aut, Tel_Aut=:Tel_Aut, Cor_Aut=:Cor_Aut WHERE Ced_Aut=:CedulaPK"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Ced_Aut", Ced_Aut)
            Me.AsignarParametroCadena(":Ape1_Aut", Ape1_Aut)
            Me.AsignarParametroCadena(":Ape2_Aut", Ape2_Aut)
            Me.AsignarParametroCadena(":Nom_Aut", Nom_Aut)
            Me.AsignarParametroCadena(":Exp_Ced_Aut", Exp_Ced_Aut)
            Me.AsignarParametroCadena(":Dir_Aut", Dir_Aut)
            Me.AsignarParametroCadena(":Tel_Aut", Tel_Aut)
            Me.AsignarParametroCadena(":Cor_Aut", Cor_Aut)
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
            querystring = "DELETE FROM RAutoridad Where Ced_Aut=:Cedula"
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
