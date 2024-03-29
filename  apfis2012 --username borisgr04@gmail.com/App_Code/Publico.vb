﻿Imports Microsoft.VisualBasic
Imports System.Web.UI
''' <summary>
''' Clase para el manejo de Variables Globales
''' </summary>
''' <remarks></remarks>
Public Class Publico

    ''' <summary>
    ''' Decimales segun la region
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Valor_Dec(ByVal v As String) As Decimal
        Return v.Replace(NoPunto_Dec, Punto_Dec)
    End Function

    ''' <summary>
    ''' Decimales segun la region
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function InvValor_Dec(ByVal v As String) As Decimal
        Return v.Replace(Punto_Dec, NoPunto_Dec)
    End Function

    ''' <summary>
    ''' Reemplaza punto por coma
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PuntoPorComa(ByVal v As String) As Decimal
        Return v.Replace(".", ",")
    End Function
    ''' <summary>
    ''' Especifica el caracter q marca el punto decimal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property Punto_Dec As String
        Get
            Return ConfigurationManager.AppSettings("Punto_Dec")
        End Get
    End Property

    ''' <summary>
    ''' Especifica el caracter q marca el punto no decimal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property NoPunto_Dec As String
        Get
            Return ConfigurationManager.AppSettings("NoPunto_Dec")
        End Get
    End Property

    ''' <summary>
    ''' Retorna el nombre base de la cookie de la aplicacion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property Cookie As String
        Get
            Return ConfigurationManager.AppSettings("COOKIE")
        End Get
    End Property

    ''' <summary>
    ''' Especifica el tiempo que se mostrará el Mensaje antes de que lo desaparezca el Timmer de Updatepanel
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property IntevalMSG As Integer
        Get
            Return CInt(ConfigurationManager.AppSettings("IntevalMSG"))
        End Get
    End Property

    ''' <summary>
    ''' Especifica si los mensaje se desapareceran con el Timer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property EnabledTimer As Boolean
        Get
            Return Util.N1_0(ConfigurationManager.AppSettings("EnabledTimer"))
        End Get
    End Property
    ''' <summary>
    ''' Especifica si el servidor SMPT para la aplicación tiene habilitado el SSL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property EnabledSSLMail As Boolean
        Get
            Return Util.SI_NO(ConfigurationManager.AppSettings("EnabledSSLMail"))
        End Get
    End Property
    '
    ''' <summary>
    ''' Retorna el nombre de la Aplicacíón
    ''' Autor: BGR Fecha. 10 de Enero de 2011
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property Nombre_App As String
        Get
            Return ConfigurationManager.AppSettings("NOMAPP").Replace("reg", "&reg")
        End Get
    End Property

    ''' <summary>
    ''' Directorio Virtual en IIS, Tomarlo como base de ruta de acceso Autor:BGR Fecha:10 ene 2011
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared ReadOnly Property DirectorioVirtual As String
        Get
            Return ConfigurationManager.AppSettings("VIRTUAL")
        End Get
    End Property


End Class
