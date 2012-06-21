Imports Microsoft.VisualBasic

Public Class Seguridad
    Public semillaC As Integer
    Sub New()
        semillaC = 45
    End Sub
    Public Function Cript(ByVal txt As String) As String
        Dim i As Integer, l As String, txt2 As String = "", semilla As Integer
        Cript = ""
        semilla = semillaC
        '	On Error Resume Next
        For i = 1 To Len(txt)
            l = Mid(txt, i, 1)
            l = 155 - Asc(l)
            txt2 = txt2 + Chr(l)
        Next
        txt = txt2
        For i = 1 To Len(txt)
            l = Mid(txt, i, 1)
            l = Asc(l) Xor semilla
            Cript = Cript & l & Chr(164)
        Next
        Return Cript
    End Function
    Public Function DesCript(ByVal txt As String) As String

        Dim i As Integer, l As String, semilla As Integer, pal = "", c = "", txt3 As String = ""
        semilla = semillaC
        DesCript = ""
        '	On Error Resume Next
        For i = 1 To Len(txt)
            l = Mid(txt, i, 1)
            If l = Chr(164) Then
                l = pal Xor semilla
                c = semilla Xor pal
                l = Chr(l)
                DesCript = DesCript & l
                pal = ""
            Else
                pal = pal & l
            End If

        Next
        For i = 1 To Len(DesCript)
            l = Mid(DesCript, i, 1)
            l = 155 - Asc(l)
            txt3 = txt3 + Chr(l)
        Next
        DesCript = txt3
        Return DesCript
    End Function

End Class
