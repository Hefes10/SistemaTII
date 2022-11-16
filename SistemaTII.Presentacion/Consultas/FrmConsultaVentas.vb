Public Class FrmConsultaVentas
    Private DtDetalle As New DataTable
    Private Sub FrmConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (FrmPrincipal.IdRol = 1 Or FrmPrincipal.IdRol = 4) Then
            CboVendedor.Enabled = True
            Me.CargarVendedor()
            Me.CargarProducto()
        ElseIf (FrmPrincipal.IdRol = 2) Then
            'aca se va a seleccionar el id del vendedor
            CboVendedor.Enabled = False
            Me.TabPage2.Enabled = False
            Me.TabPage3.Enabled = False
            Me.TabPage4.Enabled = False
            Try
                Dim Neg As New Negocio.NUsuario
                CboVendedor.DataSource = Neg.Buscar(Variables.Nombre)
                CboVendedor.ValueMember = "ID"
                CboVendedor.DisplayMember = "Nombre"
                CboVendedor.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        PanelMostrar.Visible = False
        PanelMostrarD.Visible = False
        PanelMostrarProducto.Visible = False
        DgvListado.Visible = False
        DgvListadoFecha.Visible = False
        DgvListadoProducto.Visible = False
        DgvListadoM.Visible = False
    End Sub

    '----LISTADO POR VENDEDOR----
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


    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Me.Filtrar()
    End Sub

    Private Sub BtnVerComprobante_Click(sender As Object, e As EventArgs) Handles BtnVerComprobante.Click
        Try
            Variables.RepFechaInicio = DtFechaInicio.Value
            Variables.RepFechaFin = DtFechaFin.Value
            Variables.IdUsuario = CboVendedor.SelectedValue
            FrmReporteVendedor.ShowDialog()
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
            TotalImpuesto = Math.Round((Total / (1 + DgvListado.SelectedCells.Item(9).Value)), 2)
            SubTotal = Total - TotalImpuesto
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

    '----- LISTADO ENTRE FECHAS----
    Private Sub FormatoFecha()
        DgvListadoFecha.Columns(0).Visible = False
        DgvListadoFecha.Columns(2).Visible = False
        DgvListadoFecha.Columns(0).Width = 100
        DgvListadoFecha.Columns(1).Width = 60
        DgvListadoFecha.Columns(3).Width = 150
        DgvListadoFecha.Columns(4).Width = 150
        DgvListadoFecha.Columns(5).Width = 100
        DgvListadoFecha.Columns(6).Width = 70
        DgvListadoFecha.Columns(7).Width = 70
        DgvListadoFecha.Columns(8).Width = 60
        DgvListadoFecha.Columns(9).Width = 100
        DgvListadoFecha.Columns(10).Width = 100
        DgvListadoFecha.Columns(11).Width = 100
    End Sub
    Private Sub FiltrarFecha()
        Try
            Dim Neg As New Negocio.NVenta
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtFechaIni.Value
            FechaFin = DtFechaFi.Value
            DgvListadoFecha.DataSource = Neg.ConsultaSoloFechas(FechaInicio, FechaFin)
            DgvListadoFecha.Visible = True
            LblTotalReg.Text = "Total Registros: " & DgvListadoFecha.DataSource.Rows.Count
            Me.FormatoFecha()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnFiltrar2_Click(sender As Object, e As EventArgs) Handles BtnFiltrar2.Click
        Me.FiltrarFecha()
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            Variables.RepFechaInicio = DtFechaIni.Value
            Variables.RepFechaFin = DtFechaFi.Value
            FrmReporteFechas.ShowDialog()
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

    '----- LISTADO POR PRODUCTO -----

    Private Sub FormatoProducto()
        DgvListadoProducto.Columns(0).Visible = False
        DgvListadoProducto.Columns(2).Visible = False
        DgvListadoProducto.Columns(0).Width = 100
        DgvListadoProducto.Columns(1).Width = 60
        DgvListadoProducto.Columns(3).Width = 150
        DgvListadoProducto.Columns(4).Width = 150
        DgvListadoProducto.Columns(5).Width = 100
        DgvListadoProducto.Columns(6).Width = 70
        DgvListadoProducto.Columns(7).Width = 70
        DgvListadoProducto.Columns(8).Width = 60
        DgvListadoProducto.Columns(9).Width = 100
        DgvListadoProducto.Columns(10).Width = 100
        DgvListadoProducto.Columns(11).Width = 100
    End Sub
    Private Sub CargarProducto()
        Try
            Dim Neg As New Negocio.NArticulo
            CboProducto.DataSource = Neg.ListarArticulos()
            CboProducto.ValueMember = "idarticulo"
            CboProducto.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FiltrarProducto()
        Try
            Dim Obj As New Entidades.Articulo
            Dim Neg As New Negocio.NVenta
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtFechaI.Value
            Obj.IdArticulo = CboProducto.SelectedValue
            FechaFin = DtFechaF.Value
            DgvListadoProducto.DataSource = Neg.ConsultaFechasProducto(FechaInicio, FechaFin, Obj.IdArticulo)
            DgvListadoProducto.Visible = True
            LblTotalProducto.Text = "Total Registros: " & DgvListadoProducto.DataSource.Rows.Count
            Me.FormatoProducto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnFiltrarProducto_Click(sender As Object, e As EventArgs) Handles BtnFiltrarProducto.Click
        Me.FiltrarProducto()
    End Sub
    Private Sub BtnReporteProducto_Click(sender As Object, e As EventArgs) Handles BtnReporteProducto.Click
        Try
            Variables.RepFechaInicio = DtFechaI.Value
            Variables.RepFechaFin = DtFechaF.Value
            Variables.IdArticulo = CboProducto.SelectedValue
            FrmReporteFechaArticulos.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListadoProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListadoProducto.CellDoubleClick
        Try
            Dim Neg As New Negocio.NVenta
            DgvDetalleProducto.DataSource = Neg.ListarDetalle(DgvListadoProducto.SelectedCells.Item(1).Value)

            Dim Total As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0

            Total = DgvListadoProducto.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + DgvListadoProducto.SelectedCells.Item(9).Value), 2)
            TotalImpuesto = Total - SubTotal

            LblTotalProducto.Text = Total
            LblTotalImpuestoP.Text = TotalImpuesto
            LblSubTotalP.Text = SubTotal

            PanelMostrarProducto.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarP_Click(sender As Object, e As EventArgs) Handles BtnCerrarP.Click
        PanelMostrarProducto.Visible = False
    End Sub

    '----- LISTADO DE MÁS VENDIDOS -----

    Private Sub FormatoM()
        DgvListadoM.Columns(0).Visible = False
        DgvListadoM.Columns(0).Width = 100
        DgvListadoM.Columns(1).Width = 60
        DgvListadoM.Columns(2).Width = 150
        DgvListadoM.Columns(3).Width = 150
        DgvListadoM.Columns(4).Width = 150
    End Sub
    Private Sub FiltrarM()
        Try
            Dim Neg As New Negocio.NVenta
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtFechaInicioM.Value
            FechaFin = DtFechaFinM.Value
            DgvListadoM.DataSource = Neg.ConsultaFechasMas(FechaInicio, FechaFin)
            DgvListadoM.Visible = True
            LblTotalReg.Text = "Total Registros: " & DgvListadoM.DataSource.Rows.Count
            Me.FormatoM()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnFiltrarM_Click(sender As Object, e As EventArgs) Handles BtnFiltrarM.Click
        Me.FiltrarM()
    End Sub

    Private Sub BtnReporteM_Click(sender As Object, e As EventArgs) Handles BtnReporteM.Click
        Try
            Variables.RepFechaInicio = DtFechaInicioM.Value
            Variables.RepFechaFin = DtFechaFinM.Value
            FrmReporteTop.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class