Public Class FrmReporteVendedor
    Private Sub FrmReporteVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_consulta_fechas' table. You can move, or remove it, as needed.
        Me.venta_consulta_fechasTableAdapter.Fill(Me.DsSistema.venta_consulta_fechas, Variables.RepFechaInicio, Variables.RepFechaFin, Variables.IdUsuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class