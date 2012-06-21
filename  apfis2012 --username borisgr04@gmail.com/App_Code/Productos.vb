Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Productos
    Inherits BDDatos
    Sub New()
        Me.Tabla = "Productos"
        Me.Vista = "VProductos"
        Me.VistaDB = "Vproductos"
    End Sub
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyPK(ByVal Codigo As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from vProductos where codigo=:Codigo"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":Codigo", Codigo)
        'Throw New Exception(vComando.CommandText)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)> _
    Public Function Insert(ByVal Codigo As String, ByVal Descripcion As String, ByVal SubCategoria As String, ByVal Capacidad As String, ByVal PrecioLegal As Decimal, ByVal precioIlegal As Decimal, ByVal GradosA As Decimal, ByVal Fab As String) As String
        Try
            Conectar()
            querystring = "INSERT INTO PRODUCTOS(Codigo, Descripcion, Cod_SCat, Cap_Prod, Tip_Fab, GradoA, Valor, Val_Ilegal)VALUES(:Codigo, :Descripcion, :Cod_SCat, :Cap_Prod, :Tip_Fab, :GradoA, :Valor, :Val_Ilegal)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Codigo", Codigo)
            Me.AsignarParametroCadena(":Descripcion", Descripcion)
            Me.AsignarParametroCadena(":Cod_SCat", SubCategoria)
            Me.AsignarParametroCadena(":Cap_Prod", Capacidad)
            Me.AsignarParametroCadena(":Tip_Fab", Fab)
            Me.AsignarParametroDecimal(":GradoA", GradosA)
            Me.AsignarParametroDecimal(":Valor", precioIlegal)
            Me.AsignarParametroDecimal(":Val_Ilegal", PrecioLegal)
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
    Public Function Update(ByVal Codigo As String, ByVal Descripcion As String, ByVal SubCategoria As String, ByVal Capacidad As String, ByVal PrecioLegal As Decimal, ByVal precioIlegal As Decimal, ByVal GradosA As Decimal, ByVal Fab As String, ByVal CodPK As String) As String
        Try
            Conectar()
            querystring = "UPDATE PRODUCTOS SET Codigo=:Codigo, Descripcion=:Descripcion, Cod_SCat=:Cod_SCat, Cap_Prod=:Cap_Prod, Tip_Fab=:Tip_Fab, GradoA=:GradoA, Valor=:Valor, Val_Ilegal=:Val_Ilegal WHERE Codigo=:CodigoPK"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Codigo", Codigo)
            Me.AsignarParametroCadena(":Descripcion", Descripcion)
            Me.AsignarParametroCadena(":Cod_SCat", SubCategoria)
            Me.AsignarParametroCadena(":Cap_Prod", Capacidad)
            Me.AsignarParametroCadena(":Tip_Fab", Fab)
            Me.AsignarParametroDecimal(":GradoA", GradosA)
            Me.AsignarParametroDecimal(":Valor", precioIlegal)
            Me.AsignarParametroDecimal(":Val_Ilegal", PrecioLegal)
            Me.AsignarParametroCadena(":CodigoPK", CodPK)
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
    Public Overloads Function Delete(ByVal Codigo As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM PRODUCTOS Where Codigo=:Codigo"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Codigo", Codigo)
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
            queryString = "SELECT * FROM vProductos WHERE ((Codigo like :busc) OR (upper(Descripcion) like :busc))"
            Me.CrearComando(queryString)
            Me.AsignarParametroCadena(":busc", busc)
            Me.AsignarParametroCadena(":busc", busc)
            'Throw New Exception(vComando.CommandText)
        Else
            queryString = "SELECT * FROM vProductos WHERE 1<>1"
            Me.CrearComando(queryString)
        End If

        Dim dataTb As DataTable = Me.EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb

    End Function
End Class
