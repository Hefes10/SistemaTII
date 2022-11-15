Imports SistemaTII.Entidades
Imports SistemaTII.Datos

Public Class NVenta
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DVenta
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
            Dim Datos As New DVenta
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ConsultaFechas(FechaInicio As Date, FechaFin As Date, IdUsuario As Integer) As DataTable
        Try
            Dim Datos As New DVenta
            Dim Tabla As New DataTable
            Tabla = Datos.ConsultaFechas(FechaInicio, FechaFin, IdUsuario)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ConsultaFechasProducto(FechaInicio As Date, FechaFin As Date, IdArticulo As Integer) As DataTable
        Try
            Dim Datos As New DVenta
            Dim Tabla As New DataTable
            Tabla = Datos.ConsultaFechasProducto(FechaInicio, FechaFin, IdArticulo)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ConsultaSoloFechas(FechaInicio As Date, FechaFin As Date) As DataTable
        Try
            Dim Datos As New DVenta
            Dim Tabla As New DataTable
            Tabla = Datos.ConsultaSoloFechas(FechaInicio, FechaFin)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Datos As New DVenta
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDetalle(Id)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Anular(Id As Integer) As Boolean
        Try
            Dim Datos As New DVenta
            Datos.Anular(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Insertar(Obj As Venta, Det As DataTable) As Boolean
        Try
            Dim Datos As New DVenta
            Datos.Insertar(Obj, Det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function UltimoIdVenta() As Integer
        Try
            Dim Datos As New DVenta
            Return Datos.UltimoIdVenta.Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarComprobante(name As String) As DataTable
        Try
            Dim Datos As New DVenta
            Return Datos.UltimoComprobante(name)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
