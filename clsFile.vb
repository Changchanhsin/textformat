Imports System.IO

Public Class clsFile
    Private sr As StreamReader

    Public Function FileOpen(s As String) As Boolean
        Try
            sr = New StreamReader（s， System.Text.Encoding.Default）
            FileOpen = True
            Exit Function
        Catch
            FileOpen = False
        End Try
    End Function

    Public Function FileClose() As Boolean
        On Error Resume Next
        sr.Close()
    End Function

    Public Function FileEnd() As Boolean
        FileEnd = sr.EndOfStream
    End Function

    Public Function ReadLine() As String
        ReadLine = sr.ReadLine()
    End Function
End Class
