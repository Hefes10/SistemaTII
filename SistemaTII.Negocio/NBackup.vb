Imports SistemaTII.Datos

Public Class NBackup

    Public Function GetDB() As DataSet
        Try
            Dim Datos As New DBackup
            Dim Ds As New DataSet
            Ds = Datos.GetDB()
            Return Ds
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub Backup(text1 As String, text2 As String)
        Try
            Dim Datos As New DBackup
            Datos.Backup(text1, text2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Restore(text1 As String, text2 As String)
        Try
            Dim Datos As New DBackup
            Datos.Restore(text1, text2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
