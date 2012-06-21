Imports Microsoft.VisualBasic
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data
Imports System.ComponentModel

<DataObjectAttribute()> _
Public Class ConActas
    Inherits BDDatos

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetRecords(ByVal fecha_ini As Date, ByVal fecha_fin As Date) As DataTable
        Me.Conectar()
        querystring = "Select * From vActasV3 Where FechaIni BetWeen to_date(:f1,'dd/mm/yyyy') And to_date(:f2,'dd/mm/yyyy')"
        CrearComando(querystring)
        AsignarParametroCadena(":f1", fecha_ini.ToShortDateString)
        AsignarParametroCadena(":f2", fecha_fin.ToShortDateString)
        Dim dataTb As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetInventario(ByVal fecha_ini As String, ByVal fecha_fin As String, ByVal prod As String) As DataTable
        Me.Conectar()

        querystring = " Select COD_BOD BODEGA,COD_PROD ""CODIGO"",DESCRIPCION,INICIAL ""CANTIDAD INICIAL"",ENT ""CANTIDAD ENTRADA EN EL PERIODO"", SAL ""CANTIDAD SALIDA EN EL PERIODO"",ANULADA ""CANTIDAD ANULADA EN EL PERIODO"",PER ""CANTIDAD PERIODO"",INFINAL ""CANTIDAD FINAL PERIODO"",CANT_ACT ""CANTIDAD ACTUAL"" "
        querystring += " From (     Select P.Cod_Bod,P.Cod_Prod,Inicial,NVL(ENT,0) ENT,NVL(SAL,0)SAL,NVL(ANULADA,0)ANULADA,NVL((ENT-SAL-ANULADA),0) PER, NVL(Inicial+Nvl((ENT-SAL-ANULADA),0),0) InFinal,P.Can_Prod Cant_Act    "
        querystring += " From     (     Select PB.*, InvInicial(to_date(:f1,'DD/MM/YY'),Cod_Prod) As Inicial From ProdBod PB     ) P     Left Join     (     "
        querystring += " Select     CODIGO,  "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='E' THEN CANTMOV ELSE 0 END),0) AS ENT, "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='S' AND EST_MOV IS NULL  THEN CANTMOV ELSE 0 END),0) AS SAL, "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='A' THEN CANTMOV ELSE 0 END),0) AS ANULADA "
        querystring += " From Movimientos M "
        querystring += " Where     Fecha BetWeen to_date(:f1,'DD/MM/YY') And to_date(:f2,'DD/MM/YY')      GROUP BY Codigo     ) MOV     On Cod_Prod=MOV.CODIGO "
        querystring += " ) I inner join productos P On P.CODIGO=I.cod_Prod  Where CODIGO LIKE :prod Order by DESCRIPCION "

        CrearComando(querystring)
        AsignarParametroCadena(":f1", CDate(fecha_ini).ToShortDateString)
        AsignarParametroCadena(":f1", CDate(fecha_ini).ToShortDateString)
        AsignarParametroCadena(":f2", CDate(fecha_fin).ToShortDateString)
        AsignarParametroCadena(":prod", prod)
        'Throw New Exception(Me._Comando.CommandText)

        Dim dataTb As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetInventarioRpt(ByVal fecha_ini As String, ByVal fecha_fin As String, ByVal prod As String) As DataTable
        Me.Conectar()

        querystring = " Select COD_BOD ,COD_PROD ,DESCRIPCION,INICIAL ,ENT , SAL ,ANULADA ,PER ,INFINAL ,CANT_ACT  "
        querystring += " From (     Select P.Cod_Bod,P.Cod_Prod,Inicial,NVL(ENT,0) ENT,NVL(SAL,0)SAL,NVL(ANULADA,0)ANULADA,NVL((ENT-SAL-ANULADA),0) PER, NVL(Inicial+Nvl((ENT-SAL-ANULADA),0),0) InFinal,P.Can_Prod Cant_Act    "
        querystring += " From     (     Select PB.*, InvInicial(to_date(:f1,'DD/MM/YY'),Cod_Prod) As Inicial From ProdBod PB     ) P     Left Join     (     "
        querystring += " Select     CODIGO,  "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='E' THEN CANTMOV ELSE 0 END),0) AS ENT, "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='S' AND EST_MOV IS NULL  THEN CANTMOV ELSE 0 END),0) AS SAL, "
        querystring += " Nvl(SUM(CASE WHEN TIPO ='A' THEN CANTMOV ELSE 0 END),0) AS ANULADA "
        querystring += " From Movimientos M "
        querystring += " Where     Fecha BetWeen to_date(:f1,'DD/MM/YY') And to_date(:f2,'DD/MM/YY')      GROUP BY Codigo     ) MOV     On Cod_Prod=MOV.CODIGO "
        querystring += " ) I inner join productos P On P.CODIGO=I.cod_Prod  Where CODIGO LIKE :prod  Order by DESCRIPCION "

        CrearComando(querystring)
        AsignarParametroCadena(":f1", CDate(fecha_ini).ToShortDateString)
        AsignarParametroCadena(":f1", CDate(fecha_ini).ToShortDateString)
        AsignarParametroCadena(":f2", CDate(fecha_fin).ToShortDateString)
        AsignarParametroCadena(":prod", prod)
        'Throw New Exception(Me._Comando.CommandText)

        Dim dataTb As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function
        
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetFondoV2(ByVal fecha_ini As Date, ByVal fecha_fin As Date) As DataTable
        Me.Conectar()
        querystring = "Select * From VFONDODEPv02 Where FechaIni BetWeen to_date(:f1,'dd/mm/yyyy') And to_date(:f2,'dd/mm/yyyy') ORDER BY FECHAINI"
        CrearComando(querystring)
        AsignarParametroCadena(":f1", fecha_ini.ToShortDateString)
        AsignarParametroCadena(":f2", fecha_fin.ToShortDateString)
        Dim dataTb As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetFondo(ByVal fecha_ini As Date, ByVal fecha_fin As Date) As DataTable
        Me.Conectar()
        querystring = "Select * From VFONDODEP Where FechaIni BetWeen to_date(:f1,'dd/mm/yyyy') And to_date(:f2,'dd/mm/yyyy') ORDER BY FECHAINI"
        CrearComando(querystring)
        AsignarParametroCadena(":f1", fecha_ini.ToShortDateString)
        AsignarParametroCadena(":f2", fecha_fin.ToShortDateString)
        Dim dataTb As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dataTb
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Overloads Function GetDRecords(ByVal NroActa As String) As DataTable
        Me.Conectar()
        querystring = "SELECT * From vProdActasv4 Where NroActa=:NroActa"
        CrearComando(querystring)
        AsignarParametroCadena(":NroActa", NroActa)
        Dim dataTb As DataTable = New DataTable
        Desconectar()
        Return dataTb
    End Function

End Class
