Imports System.Data.SqlClient
Public Class Conexion
    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=localhost;Initial Catalog=dbsistema;Integrated Security=True")
    End Sub
End Class
