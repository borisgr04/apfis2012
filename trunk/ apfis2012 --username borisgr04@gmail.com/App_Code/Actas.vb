Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class Actas
    Inherits BDDatos
    Sub New()
        Me.Tabla = "Actas"
        Me.Vista = "Actas"
    End Sub
    Public Function Insert(ByVal na As String, ByVal fi As String, ByVal ff As String, ByVal nit_est As String, ByVal fact As String, ByVal otrod As String, ByVal ced_inf As String, ByVal factcom As String, ByVal relotro As String, ByVal mancar As String, ByVal factcompfolio As String, ByVal mancargafolio As String, ByVal otrosfolio As String, ByVal ide_coor As String, ByVal ide_aut As String, ByVal ide_bod As String, ByVal chkcoor As String, ByVal chkinf As String, ByVal chkaut As String, ByVal chkbod As String, ByVal estado As String, ByVal codmun As String, ByVal codbod As String, ByVal firma As String) As String
        Try
            Dim firma1 As String
            If firma = 1 Then
                firma1 = "PERSONAL"
            Else
                firma1 = "TESTIGOS"
            End If
            Me.Conectar()
            Me.querystring = "INSERT INTO ACTAS(NROACTA, FECHAINI, FECHAFIN, NIT_EST, FACTURA, OTRODOC, CED_INF, REL_FACTCOM, REL_MANCARGA, REL_OTROS, REL_FACTCOM_FOLIO, REL_MANCARGA_FOLIO, REL_OTROS_FOLIO, IDE_COOR, IDE_AUTORIDAD, IDE_BODEGA, ESTADO, FAUT, FINF, FBOD, COD_BOD, COD_MUN, FIRMA, FCOOR, USUARIO) VALUES(:NROACTA, :FECHAINI, :FECHAFIN, :NIT_EST, :FACTURA, :OTRODOC, :CED_INF, :REL_FACTCOM, :REL_MANCARGA, :REL_OTROS, :REL_FACTCOM_FOLIO, :REL_MANCARGA_FOLIO, :REL_OTROS_FOLIO, :IDE_COOR, :IDE_AUTORIDAD, :IDE_BODEGA, :ESTADO, :FAUT, :FINF, :FBOD, :COD_BOD, :COD_MUN, :FIRMA, :FCOOR, :USUARIO)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":NROACTA", na)
            Me.AsignarParametroCadena(":FECHAINI", fi)
            Me.AsignarParametroCadena(":FECHAFIN", ff)
            Me.AsignarParametroCadena(":NIT_EST", nit_est)
            Me.AsignarParametroCadena(":FACTURA", fact)
            Me.AsignarParametroCadena(":OTRODOC", otrod)
            Me.AsignarParametroCadena(":CED_INF", ced_inf)
            Me.AsignarParametroCadena(":REL_FACTCOM", factcom)
            Me.AsignarParametroCadena(":REL_MANCARGA", mancar)
            Me.AsignarParametroCadena(":REL_OTROS", relotro)
            Me.AsignarParametroCadena(":REL_FACTCOM_FOLIO", factcompfolio)
            Me.AsignarParametroCadena(":REL_MANCARGA_FOLIO", mancargafolio)
            Me.AsignarParametroCadena(":REL_OTROS_FOLIO", otrosfolio)
            Me.AsignarParametroCadena(":IDE_COOR", ide_coor)
            Me.AsignarParametroCadena(":IDE_AUTORIDAD", ide_aut)
            Me.AsignarParametroCadena(":IDE_BODEGA", ide_bod)
            Me.AsignarParametroCadena(":ESTADO", estado)
            Me.AsignarParametroCadena(":FAUT", chkaut)
            Me.AsignarParametroCadena(":FINF", chkinf)
            Me.AsignarParametroCadena(":FBOD", chkbod)
            Me.AsignarParametroCadena(":COD_BOD", codbod)
            Me.AsignarParametroCadena(":COD_MUN", codmun)
            Me.AsignarParametroCadena(":FIRMA", firma1)
            Me.AsignarParametroCadena(":FCOOR", chkcoor)
            Me.AsignarParametroCadena(":USUARIO", "ADMIN")
            Me.num_reg = EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = MsgOk + "[" + num_reg.ToString + "] Filas afectadas" + "---" + Me.usuario
            Me.lErrorG = False
        Catch ex As Exception
            Me.lErrorG = True
            Me.CancelarTransaccion()
            Me.Msg = "Error: " & ex.Message & "---" & Me.usuario
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
    Public Function Update(ByVal na As String, ByVal fi As String, ByVal ff As String, ByVal nit_est As String, ByVal fact As String, ByVal otrod As String, ByVal ced_inf As String, ByVal factcom As String, ByVal relotro As String, ByVal mancar As String, ByVal factcompfolio As String, ByVal mancargafolio As String, ByVal otrosfolio As String, ByVal ide_coor As String, ByVal ide_aut As String, ByVal ide_bod As String, ByVal chkcoor As String, ByVal chkinf As String, ByVal chkaut As String, ByVal chkbod As String, ByVal estado As String, ByVal codmun As String, ByVal codbod As String, ByVal firma As String, ByVal NumActaPK As String) As String
        Try
            Dim firma1 As String
            If firma = 1 Then
                firma1 = "PERSONAL"
            Else
                firma1 = "TESTIGOS"
            End If
            Me.Conectar()
            Me.querystring = "UPDATE ACTAS SET NROACTA=:NROACTA, FECHAINI=:FECHAINI, FECHAFIN=:FECHAFIN, NIT_EST=:NIT_EST, FACTURA=:FACTURA, OTRODOC=:OTRODOC, CED_INF=:CED_INF, REL_FACTCOM=:REL_FACTCOM, REL_MANCARGA=:REL_MANCARGA, REL_OTROS=:REL_OTROS, REL_FACTCOM_FOLIO=:REL_FACTCOM_FOLIO, REL_MANCARGA_FOLIO=:REL_MANCARGA_FOLIO, REL_OTROS_FOLIO=:REL_OTROS_FOLIO, IDE_COOR=:IDE_COOR, IDE_AUTORIDAD=:IDE_AUTORIDAD, IDE_BODEGA=:IDE_BODEGA, FAUT=:FAUT, FINF=:FINF, FBOD=:FBOD, COD_BOD=:COD_BOD, COD_MUN=:COD_MUN, FIRMA=:FIRMA, FCOOR=:FCOOR, USUARIO=:USUARIO WHERE NROACTA=:NROACTAPK"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":NROACTA", na)
            Me.AsignarParametroCadena(":FECHAINI", fi)
            Me.AsignarParametroCadena(":FECHAFIN", ff)
            Me.AsignarParametroCadena(":NIT_EST", nit_est)
            Me.AsignarParametroCadena(":FACTURA", fact)
            Me.AsignarParametroCadena(":OTRODOC", otrod)
            Me.AsignarParametroCadena(":CED_INF", ced_inf)
            Me.AsignarParametroCadena(":REL_FACTCOM", factcom)
            Me.AsignarParametroCadena(":REL_MANCARGA", mancar)
            Me.AsignarParametroCadena(":REL_OTROS", relotro)
            Me.AsignarParametroCadena(":REL_FACTCOM_FOLIO", factcompfolio)
            Me.AsignarParametroCadena(":REL_MANCARGA_FOLIO", mancargafolio)
            Me.AsignarParametroCadena(":REL_OTROS_FOLIO", otrosfolio)
            Me.AsignarParametroCadena(":IDE_COOR", ide_coor)
            Me.AsignarParametroCadena(":IDE_AUTORIDAD", ide_aut)
            Me.AsignarParametroCadena(":IDE_BODEGA", ide_bod)
            Me.AsignarParametroCadena(":FAUT", chkaut)
            Me.AsignarParametroCadena(":FINF", chkinf)
            Me.AsignarParametroCadena(":FBOD", chkbod)
            Me.AsignarParametroCadena(":COD_BOD", codbod)
            Me.AsignarParametroCadena(":COD_MUN", codmun)
            Me.AsignarParametroCadena(":FIRMA", firma1)
            Me.AsignarParametroCadena(":FCOOR", chkcoor)
            Me.AsignarParametroCadena(":USUARIO", "ADMIN")
            Me.AsignarParametroCadena(":NROACTAPK", NumActaPK)
            'Throw New Exception(vComando.CommandText)
            Me.num_reg = EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = MsgOk + "[" + num_reg.ToString + "] Filas afectadas" + "---" + Me.usuario
            Me.lErrorG = False
        Catch ex As Exception
            Me.lErrorG = True
            Me.CancelarTransaccion()
            Me.Msg = "Error: " & ex.Message & "---" & Me.usuario
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
    Public Function GetbyPK(ByVal NumActa As String) As DataTable
        Me.Conectar()
        Me.querystring = "Select * from Actas where NroActa=:NumActa"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":NumActa", NumActa)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Function GetbyEst(ByVal FI As Date, ByVal FF As Date, ByVal Estado As String) As DataTable
        Me.Conectar()
        Me.querystring = "Select * from VPROD_DESTRUCCION where FechaIni between :FI and :FF and Estado=:Estado"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":FI", FI.ToShortDateString)
        Me.AsignarParametroCadena(":FF", FF.ToShortDateString)
        Me.AsignarParametroCadena(":Estado", Estado)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
End Class
