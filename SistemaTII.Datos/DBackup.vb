Imports System.Data.SqlClient

Public Class DBackup
    Inherits Conexion

    Public Function GetDB() As DataSet
        Try
            MyBase.conn.Open()

            Dim Comando As New SqlCommand("SELECT name from sys.databases", MyBase.conn)
            Dim Da As New SqlDataAdapter(Comando)
            Dim Ds As New DataSet
            Da.Fill(Ds)
            Return Ds
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Backup(nameDB As String, ruta As String)
        Try
            MyBase.conn.Open()

            Dim Script As String
            Script = "BACKUP DATABASE [" & nameDB & "] TO  DISK = N'" & ruta & "' WITH NOFORMAT, NOINIT, SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
            Dim Comando As New SqlCommand(Script, MyBase.conn)
            Comando.ExecuteNonQuery()

            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Restore(nameDB As String, ruta As String)
        Try
            MyBase.conn.Open()

            Dim Script As String
            Script = "USE [master] RESTORE DATABASE [" & nameDB & "] FROM  DISK = N'" & ruta & "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5"
            Dim Comando As New SqlCommand(Script, MyBase.conn)
            Comando.ExecuteNonQuery()

            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
