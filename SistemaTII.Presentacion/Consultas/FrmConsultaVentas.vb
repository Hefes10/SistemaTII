Public Class FrmConsultaVentas
    Private DtDetalle As New DataTable
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(3).Width = 150
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 70
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100
    End Sub

    Private Sub CargarVendedor()
        Try
            Dim Neg As New Negocio.NUsuario
            CboVendedor.DataSource = Neg.ListarVendedores()
            CboVendedor.ValueMember = "idusuario"
            CboVendedor.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Filtrar()
        Try
            Dim Obj As New Entidades.Usuario
            Dim Neg As New Negocio.NVenta
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtFechaInicio.Value
            Obj.IdUsuario = CboVendedor.SelectedValue
            FechaFin = DtFechaFin.Value
            DgvListado.DataSource = Neg.ConsultaFechas(FechaInicio, FechaFin, Obj.IdUsuario)
            DgvListado.Visible = True
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FiltrarFecha()
        Try
            Dim Neg As New Negocio.NVenta
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtFechaInicio.Value
            FechaFin = DtFechaFin.Value
            DgvListadoFecha.DataSource = Neg.ConsultaSoloFechas(FechaInicio, FechaFin)
            DgvListadoFecha.Visible = True
            LblTotalReg.Text = "Total Registros: " & DgvListadoFecha.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (FrmPrincipal.IdRol = 1) Then
            CboVendedor.Enabled = True
            Me.CargarVendedor()
        ElseIf (FrmPrincipal.IdRol = 2) Then
            'aca se va a seleccionar el id del vendedor
            CboVendedor.Enabled = False
            Try
                Dim Neg As New Negocio.NUsuario
                CboVendedor.DataSource = Neg.Buscar(Variables.Nombre)
                CboVendedor.ValueMember = "ID"
                CboVendedor.DisplayMember = "Nombre"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        PanelMostrar.Visible = False
        PanelMostrarD.Visible = False
        DgvListado.Visible = False
        DgvListadoFecha.Visible = False
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Me.Filtrar()
    End Sub

    Private Sub BtnVerComprobante_Click(sender As Object, e As EventArgs) Handles BtnVerComprobante.Click
        Try
            Variables.IdVenta = DgvListado.SelectedCells.Item(1).Value
            FrmReporteComprobanteVenta.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.NVenta
            DgvMostrarDetalle.DataSource = Neg.ListarDetalle(DgvListado.SelectedCells.Item(1).Value)

            Dim Total As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0

            Total = DgvListado.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + DgvListado.SelectedCells.Item(9).Value), 2)
            TotalImpuesto = Total - SubTotal

            LblTotalM.Text = Total
            LblTotalImpuestoM.Text = TotalImpuesto
            LblSubTotalM.Text = SubTotal

            PanelMostrar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarM_Click(sender As Object, e As EventArgs) Handles BtnCerrarM.Click
        PanelMostrar.Visible = False
    End Sub

    Private Sub BtnFiltrar2_Click(sender As Object, e As EventArgs) Handles BtnFiltrar2.Click
        Me.FiltrarFecha()
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            Variables.IdVenta = DgvListadoFecha.SelectedCells.Item(1).Value
            FrmReporteComprobanteVenta.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListadoFecha_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListadoFecha.CellDoubleClick
        Try
            Dim Neg As New Negocio.NVenta
            DgvMostrarD.DataSource = Neg.ListarDetalle(DgvListadoFecha.SelectedCells.Item(1).Value)

            Dim Total As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0

            Total = DgvListadoFecha.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + DgvListadoFecha.SelectedCells.Item(9).Value), 2)
            TotalImpuesto = Total - SubTotal

            LblTot.Text = Total
            LblImpuesto.Text = TotalImpuesto
            LblSub.Text = SubTotal

            PanelMostrarD.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarPanel_Click(sender As Object, e As EventArgs) Handles BtnCerrarPanel.Click
        PanelMostrarD.Visible = False
    End Sub

End Class