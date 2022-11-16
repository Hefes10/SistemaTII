﻿Imports SistemaTII.Entidades
Imports System.Data.SqlClient
Public Class DVenta
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_buscar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultaFechas(FechaInicio As Date, FechaFin As Date, IdUsuario As Integer) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_consulta_fechas", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio
            Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = IdUsuario
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultaFechasProducto(FechaInicio As Date, FechaFin As Date, IdArticulo As Integer) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_consulta_producto", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio
            Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin
            Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = IdArticulo
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultaSoloFechas(FechaInicio As Date, FechaFin As Date) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_consulta_solo_fechas", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio
            Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultaFechasMas(FechaInicio As Date, FechaFin As Date) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_consulta_top10", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio
            Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UltimoComprobante(name As String) As Object
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_ultimo_comprobante", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = name
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_listar_detalle", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Anular(Id As Integer)
        Try
            Dim Comando As New SqlCommand("venta_anular", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Insertar(Obj As Venta, Det As DataTable)
        Try
            Dim Comando As New SqlCommand("venta_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Obj.IdVenta
            Comando.Parameters("@idventa").Direction = ParameterDirection.Output
            Comando.Parameters.Add("@idusuario", SqlDbType.VarChar).Value = Obj.IdUsuario
            Comando.Parameters.Add("@idcliente", SqlDbType.VarChar).Value = Obj.IdCliente
            Comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = Obj.TipoComprobante
            Comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.SerieComprobante
            Comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.NumComprobante
            Comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = Obj.Impuesto
            Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total
            Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Det


            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function UltimoIdVenta() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("venta_ultimo_id", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
