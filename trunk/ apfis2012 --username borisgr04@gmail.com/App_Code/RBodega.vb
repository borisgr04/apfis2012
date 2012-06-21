Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class RBodega
    Inherits BDDatos
    Sub New()
        Me.Tabla = "RBodega"
        Me.Vista = "RBodega"
        Me.VistaDB = "RBodega"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyPK(ByVal Cedula As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from RBodega where Ced_Bod=:Cedula"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Cedula", Cedula)
        'Throw New Exception(vComando.CommandText)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Ced_Bod As String, ByVal Ape1_Bod As String, ByVal Ape2_Bod As String, ByVal Nom_Bod As String, ByVal Exp_Ced_Bod As String, ByVal Dir_Bod As String, ByVal Tel_Bod As String, ByVal Cor_Bod As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO RBodega(Ced_Bod, Ape1_Bod, Ape2_Bod, Nom_Bod, Exp_Ced_Bod, Dir_Bod, Tel_Bod, Cor_Bod)VALUES(:Ced_Bod, :Ape1_Bod, :Ape2_Bod, :Nom_Bod, :Exp_Ced_Bod, :Dir_Bod, :Tel_Bod, :Cor_Bod)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Ced_Bod", Ced_Bod)
            Me.AsignarParametroCadena(":Ape1_Bod", Ape1_Bod)
            Me.AsignarParametroCadena(":Ape2_Bod", Ape2_Bod)
            Me.AsignarParametroCadena(":Nom_Bod", Nom_Bod)
            Me.AsignarParametroCadena(":Exp_Ced_Bod", Exp_Ced_Bod)
            Me.AsignarParametroCadena(":Dir_Bod", Dir_Bod)
            Me.AsignarParametroCadena(":Tel_Bod", Tel_Bod)
            Me.AsignarParametroCadena(":Cor_Bod", Cor_Bod)
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
    Public Function Update(ByVal Ced_Bod As String, ByVal Ape1_Bod As String, ByVal Ape2_Bod As String, ByVal Nom_Bod As String, ByVal Exp_Ced_Bod As String, ByVal Dir_Bod As String, ByVal Tel_Bod As String, ByVal Cor_Bod As String, ByVal CedPK As String) As String
        Try
            Conectar()
            querystring = "UPDATE RBodega SET Ced_Bod=:Ced_Bod, Ape1_Bod=:Ape1_Bod, Ape2_Bod=:Ape2_Bod, Nom_Bod=:Nom_Bod, Exp_Ced_Bod=:Exp_Ced_Bod, Dir_Bod=:Dir_Bod, Tel_Bod=:Tel_Bod, Cor_Bod=:Cor_Bod WHERE Ced_Bod=:CedulaPK"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Ced_Bod", Ced_Bod)
            Me.AsignarParametroCadena(":Ape1_Bod", Ape1_Bod)
            Me.AsignarParametroCadena(":Ape2_Bod", Ape2_Bod)
            Me.AsignarParametroCadena(":Nom_Bod", Nom_Bod)
            Me.AsignarParametroCadena(":Exp_Ced_Bod", Exp_Ced_Bod)
            Me.AsignarParametroCadena(":Dir_Bod", Dir_Bod)
            Me.AsignarParametroCadena(":Tel_Bod", Tel_Bod)
            Me.AsignarParametroCadena(":Cor_Bod", Cor_Bod)
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
            querystring = "DELETE FROM RBodega Where Ced_Bod=:Cedula"
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
