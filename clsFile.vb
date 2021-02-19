Imports System.IO

Public Class clsFile
    Private sr As IO.StreamReader
    Private sw As IO.StreamWriter
    Private st As IO.FileStream

    Public Function Open(s As String) As Boolean
        Try
            sr = New StreamReader（s， System.Text.Encoding.Default）
            Open = True
            Exit Function
        Catch
            Open = False
        End Try
    End Function

    Public Function Close() As Boolean
        On Error Resume Next
        sr.Close()
    End Function

    Public Function isEnd() As Boolean
        isEnd = sr.EndOfStream
    End Function

    Public Function ReadLine() As String
        ReadLine = sr.ReadLine()
    End Function

    Public Function Save(filename As String, textobj As TextBox, codeset As String) As Boolean
        Try
            st = New IO.FileStream(filename, IO.FileMode.Create)
            sw = New IO.StreamWriter(st, System.Text.Encoding.GetEncoding(codeset))
            sw.Write(textobj.Text)
            sw.Close()
            Save = True
            Exit Function
        Catch
            MessageBox.Show("error on saving...", "error", MessageBoxButtons.OK)
            Save = False
        End Try
    End Function

    Public Function Load(filename As String, textobj As TextBox, codeset As String) As Boolean
        Try
            sr = New StreamReader（filename， System.Text.Encoding.GetEncoding(codeset))
            textobj.Text = sr.ReadToEnd
            sr.Close()
            Load = True
            Exit Function
        Catch
            MessageBox.Show("error on loading...", "error", MessageBoxButtons.OK)
            Load = False
        End Try
    End Function
End Class
