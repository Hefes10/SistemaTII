Imports System.Data.SqlClient
Public Class Conexion
    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=localhost;Initial Catalog=dbsistema;User ID=sa;Password=asd123")
    End Sub
End Class
