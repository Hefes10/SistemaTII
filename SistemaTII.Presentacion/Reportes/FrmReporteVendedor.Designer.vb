<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVendedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsSistema = New SistemaTII.Presentacion.DsSistema()
        Me.venta_consulta_fechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_consulta_fechasTableAdapter = New SistemaTII.Presentacion.DsSistemaTableAdapters.venta_consulta_fechasTableAdapter()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_consulta_fechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsReporteVendedor"
        ReportDataSource1.Value = Me.venta_consulta_fechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaTII.Presentacion.RptReporteVendedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1162, 503)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsSistema
        '
        Me.DsSistema.DataSetName = "DsSistema"
        Me.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_consulta_fechasBindingSource
        '
        Me.venta_consulta_fechasBindingSource.DataMember = "venta_consulta_fechas"
        Me.venta_consulta_fechasBindingSource.DataSource = Me.DsSistema
        '
        'venta_consulta_fechasTableAdapter
        '
        Me.venta_consulta_fechasTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 503)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteVendedor"
        Me.Text = "Reporte de ventas por vendedor"
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_consulta_fechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_consulta_fechasBindingSource As BindingSource
    Friend WithEvents DsSistema As DsSistema
    Friend WithEvents venta_consulta_fechasTableAdapter As DsSistemaTableAdapters.venta_consulta_fechasTableAdapter
End Class
