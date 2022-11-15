Public Class FrmReporteFechas
    Private Sub FrmReporteFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_consulta_solo_fechas' table. You can move, or remove it, as needed.
        Me.venta_consulta_solo_fechasTableAdapter.Fill(Me.DsSistema.venta_consulta_solo_fechas, Variables.RepFechaInicio, Variables.RepFechaFin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class