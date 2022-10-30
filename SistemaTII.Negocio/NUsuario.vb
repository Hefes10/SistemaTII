Imports SistemaTII.Datos
Imports SistemaTII.Entidades

Public Class NUsuario

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DUsuario
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DUsuario
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As Usuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(Obj As Usuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
