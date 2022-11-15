Public Class FrmReporteFechaArticulos
    Private Sub FrmReporteFechaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_consulta_producto' table. You can move, or remove it, as needed.
        Me.venta_consulta_productoTableAdapter.Fill(Me.DsSistema.venta_consulta_producto, Variables.RepFechaInicio, Variables.RepFechaFin, Variables.IdArticulo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class