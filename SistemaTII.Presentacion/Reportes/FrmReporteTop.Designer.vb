<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteTop
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsSistema = New SistemaTII.Presentacion.DsSistema()
        Me.venta_consulta_top10BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_consulta_top10TableAdapter = New SistemaTII.Presentacion.DsSistemaTableAdapters.venta_consulta_top10TableAdapter()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_consulta_top10BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DsReporteTop"
        ReportDataSource2.Value = Me.venta_consulta_top10BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaTII.Presentacion.RptReporteTop.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1120, 709)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsSistema
        '
        Me.DsSistema.DataSetName = "DsSistema"
        Me.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_consulta_top10BindingSource
        '
        Me.venta_consulta_top10BindingSource.DataMember = "venta_consulta_top10"
        Me.venta_consulta_top10BindingSource.DataSource = Me.DsSistema
        '
        'venta_consulta_top10TableAdapter
        '
        Me.venta_consulta_top10TableAdapter.ClearBeforeFill = True
        '
        'FrmReporteTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 709)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteTop"
        Me.Text = "Reporte de productos más vendidos "
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_consulta_top10BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_consulta_top10BindingSource As BindingSource
    Friend WithEvents DsSistema As DsSistema
    Friend WithEvents venta_consulta_top10TableAdapter As DsSistemaTableAdapters.venta_consulta_top10TableAdapter
End Class
