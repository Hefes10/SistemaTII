Public Class FrmReporteTop
    Private Sub FrmReporteTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_consulta_top10' table. You can move, or remove it, as needed.
        Me.venta_consulta_top10TableAdapter.Fill(Me.DsSistema.venta_consulta_top10, Variables.RepFechaInicio, Variables.RepFechaFin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class