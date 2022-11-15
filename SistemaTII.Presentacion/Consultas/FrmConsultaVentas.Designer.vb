<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaVentas
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
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboVendedor = New System.Windows.Forms.ComboBox()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarM = New System.Windows.Forms.Button()
        Me.LblTotalM = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoM = New System.Windows.Forms.Label()
        Me.LblSubTotalM = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVerComprobante = New System.Windows.Forms.Button()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelMostrarD = New System.Windows.Forms.Panel()
        Me.BtnCerrarPanel = New System.Windows.Forms.Button()
        Me.LblTot = New System.Windows.Forms.Label()
        Me.LblImpuesto = New System.Windows.Forms.Label()
        Me.LblSub = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DgvMostrarD = New System.Windows.Forms.DataGridView()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblTotalReg = New System.Windows.Forms.Label()
        Me.BtnFiltrar2 = New System.Windows.Forms.Button()
        Me.DtFechaFi = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.DgvListadoFecha = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LblTotalProducto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboProducto = New System.Windows.Forms.ComboBox()
        Me.PanelMostrarProducto = New System.Windows.Forms.Panel()
        Me.BtnCerrarP = New System.Windows.Forms.Button()
        Me.LblTotalP = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoP = New System.Windows.Forms.Label()
        Me.LblSubTotalP = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DgvDetalleProducto = New System.Windows.Forms.DataGridView()
        Me.BtnFiltrarProducto = New System.Windows.Forms.Button()
        Me.DtFechaF = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnReporteProducto = New System.Windows.Forms.Button()
        Me.DgvListadoProducto = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarD.SuspendLayout()
        CType(Me.DgvMostrarD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvListadoFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.PanelMostrarProducto.SuspendLayout()
        CType(Me.DgvDetalleProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.CboVendedor)
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnFiltrar)
        Me.TabPage1.Controls.Add(Me.DtFechaFin)
        Me.TabPage1.Controls.Add(Me.DtFechaInicio)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BtnVerComprobante)
        Me.TabPage1.Controls.Add(Me.Lbltotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1073, 566)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado por vendedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(452, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Vendedor: "
        '
        'CboVendedor
        '
        Me.CboVendedor.FormattingEnabled = True
        Me.CboVendedor.Location = New System.Drawing.Point(545, 24)
        Me.CboVendedor.Name = "CboVendedor"
        Me.CboVendedor.Size = New System.Drawing.Size(124, 24)
        Me.CboVendedor.TabIndex = 27
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalImpuestoM)
        Me.PanelMostrar.Controls.Add(Me.LblSubTotalM)
        Me.PanelMostrar.Controls.Add(Me.Label10)
        Me.PanelMostrar.Controls.Add(Me.Label9)
        Me.PanelMostrar.Controls.Add(Me.Label8)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrarDetalle)
        Me.PanelMostrar.Location = New System.Drawing.Point(150, 107)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(936, 463)
        Me.PanelMostrar.TabIndex = 18
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarM
        '
        Me.BtnCerrarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarM.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarM.Location = New System.Drawing.Point(838, 12)
        Me.BtnCerrarM.Name = "BtnCerrarM"
        Me.BtnCerrarM.Size = New System.Drawing.Size(37, 31)
        Me.BtnCerrarM.TabIndex = 7
        Me.BtnCerrarM.Text = "X"
        Me.BtnCerrarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarM.UseVisualStyleBackColor = True
        '
        'LblTotalM
        '
        Me.LblTotalM.AutoSize = True
        Me.LblTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalM.Location = New System.Drawing.Point(771, 429)
        Me.LblTotalM.Name = "LblTotalM"
        Me.LblTotalM.Size = New System.Drawing.Size(19, 20)
        Me.LblTotalM.TabIndex = 6
        Me.LblTotalM.Text = "0"
        '
        'LblTotalImpuestoM
        '
        Me.LblTotalImpuestoM.AutoSize = True
        Me.LblTotalImpuestoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoM.Location = New System.Drawing.Point(771, 398)
        Me.LblTotalImpuestoM.Name = "LblTotalImpuestoM"
        Me.LblTotalImpuestoM.Size = New System.Drawing.Size(19, 20)
        Me.LblTotalImpuestoM.TabIndex = 5
        Me.LblTotalImpuestoM.Text = "0"
        '
        'LblSubTotalM
        '
        Me.LblSubTotalM.AutoSize = True
        Me.LblSubTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalM.Location = New System.Drawing.Point(771, 365)
        Me.LblSubTotalM.Name = "LblSubTotalM"
        Me.LblSubTotalM.Size = New System.Drawing.Size(19, 20)
        Me.LblSubTotalM.TabIndex = 4
        Me.LblSubTotalM.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(588, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(588, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(588, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sub Total"
        '
        'DgvMostrarDetalle
        '
        Me.DgvMostrarDetalle.AllowUserToAddRows = False
        Me.DgvMostrarDetalle.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalle.Location = New System.Drawing.Point(40, 49)
        Me.DgvMostrarDetalle.Name = "DgvMostrarDetalle"
        Me.DgvMostrarDetalle.ReadOnly = True
        Me.DgvMostrarDetalle.RowHeadersWidth = 51
        Me.DgvMostrarDetalle.RowTemplate.Height = 24
        Me.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(835, 309)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(703, 18)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(151, 37)
        Me.BtnFiltrar.TabIndex = 15
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(292, 26)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaFin.TabIndex = 14
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicio.Location = New System.Drawing.Point(81, 26)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaInicio.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde"
        '
        'BtnVerComprobante
        '
        Me.BtnVerComprobante.Location = New System.Drawing.Point(880, 17)
        Me.BtnVerComprobante.Name = "BtnVerComprobante"
        Me.BtnVerComprobante.Size = New System.Drawing.Size(152, 38)
        Me.BtnVerComprobante.TabIndex = 10
        Me.BtnVerComprobante.Text = "Reporte"
        Me.BtnVerComprobante.UseVisualStyleBackColor = True
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(688, 514)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(40, 17)
        Me.Lbltotal.TabIndex = 1
        Me.Lbltotal.Text = "Total"
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(6, 83)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.RowHeadersWidth = 51
        Me.DgvListado.RowTemplate.Height = 24
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1020, 410)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 6
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        Me.Seleccionar.Width = 125
        '
        'PanelMostrarD
        '
        Me.PanelMostrarD.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelMostrarD.Controls.Add(Me.BtnCerrarPanel)
        Me.PanelMostrarD.Controls.Add(Me.LblTot)
        Me.PanelMostrarD.Controls.Add(Me.LblImpuesto)
        Me.PanelMostrarD.Controls.Add(Me.LblSub)
        Me.PanelMostrarD.Controls.Add(Me.Label12)
        Me.PanelMostrarD.Controls.Add(Me.Label13)
        Me.PanelMostrarD.Controls.Add(Me.Label14)
        Me.PanelMostrarD.Controls.Add(Me.DgvMostrarD)
        Me.PanelMostrarD.Location = New System.Drawing.Point(148, 61)
        Me.PanelMostrarD.Name = "PanelMostrarD"
        Me.PanelMostrarD.Size = New System.Drawing.Size(919, 477)
        Me.PanelMostrarD.TabIndex = 27
        Me.PanelMostrarD.Visible = False
        '
        'BtnCerrarPanel
        '
        Me.BtnCerrarPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarPanel.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarPanel.Location = New System.Drawing.Point(838, 12)
        Me.BtnCerrarPanel.Name = "BtnCerrarPanel"
        Me.BtnCerrarPanel.Size = New System.Drawing.Size(37, 31)
        Me.BtnCerrarPanel.TabIndex = 7
        Me.BtnCerrarPanel.Text = "X"
        Me.BtnCerrarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarPanel.UseVisualStyleBackColor = True
        '
        'LblTot
        '
        Me.LblTot.AutoSize = True
        Me.LblTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTot.Location = New System.Drawing.Point(771, 429)
        Me.LblTot.Name = "LblTot"
        Me.LblTot.Size = New System.Drawing.Size(19, 20)
        Me.LblTot.TabIndex = 6
        Me.LblTot.Text = "0"
        '
        'LblImpuesto
        '
        Me.LblImpuesto.AutoSize = True
        Me.LblImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpuesto.Location = New System.Drawing.Point(771, 398)
        Me.LblImpuesto.Name = "LblImpuesto"
        Me.LblImpuesto.Size = New System.Drawing.Size(19, 20)
        Me.LblImpuesto.TabIndex = 5
        Me.LblImpuesto.Text = "0"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSub.Location = New System.Drawing.Point(771, 365)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(19, 20)
        Me.LblSub.TabIndex = 4
        Me.LblSub.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(588, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(588, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total Impuesto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(588, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Sub Total"
        '
        'DgvMostrarD
        '
        Me.DgvMostrarD.AllowUserToAddRows = False
        Me.DgvMostrarD.AllowUserToDeleteRows = False
        Me.DgvMostrarD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarD.Location = New System.Drawing.Point(40, 49)
        Me.DgvMostrarD.Name = "DgvMostrarD"
        Me.DgvMostrarD.ReadOnly = True
        Me.DgvMostrarD.RowHeadersWidth = 51
        Me.DgvMostrarD.RowTemplate.Height = 24
        Me.DgvMostrarD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarD.Size = New System.Drawing.Size(835, 309)
        Me.DgvMostrarD.TabIndex = 0
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Controls.Add(Me.TabPage3)
        Me.TabGeneral.Controls.Add(Me.TabPage4)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 23)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1081, 595)
        Me.TabGeneral.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelMostrarD)
        Me.TabPage2.Controls.Add(Me.LblTotalReg)
        Me.TabPage2.Controls.Add(Me.BtnFiltrar2)
        Me.TabPage2.Controls.Add(Me.DtFechaFi)
        Me.TabPage2.Controls.Add(Me.DtFechaIni)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BtnReporte)
        Me.TabPage2.Controls.Add(Me.DgvListadoFecha)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1073, 566)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado entre fechas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LblTotalReg
        '
        Me.LblTotalReg.AutoSize = True
        Me.LblTotalReg.Location = New System.Drawing.Point(840, 521)
        Me.LblTotalReg.Name = "LblTotalReg"
        Me.LblTotalReg.Size = New System.Drawing.Size(40, 17)
        Me.LblTotalReg.TabIndex = 25
        Me.LblTotalReg.Text = "Total"
        '
        'BtnFiltrar2
        '
        Me.BtnFiltrar2.Location = New System.Drawing.Point(632, 18)
        Me.BtnFiltrar2.Name = "BtnFiltrar2"
        Me.BtnFiltrar2.Size = New System.Drawing.Size(151, 37)
        Me.BtnFiltrar2.TabIndex = 24
        Me.BtnFiltrar2.Text = "Filtrar"
        Me.BtnFiltrar2.UseVisualStyleBackColor = True
        '
        'DtFechaFi
        '
        Me.DtFechaFi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFi.Location = New System.Drawing.Point(381, 25)
        Me.DtFechaFi.Name = "DtFechaFi"
        Me.DtFechaFi.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaFi.TabIndex = 23
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(170, 25)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaIni.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Desde"
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(809, 17)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(152, 38)
        Me.BtnReporte.TabIndex = 19
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'DgvListadoFecha
        '
        Me.DgvListadoFecha.AllowUserToAddRows = False
        Me.DgvListadoFecha.AllowUserToDeleteRows = False
        Me.DgvListadoFecha.AllowUserToOrderColumns = True
        Me.DgvListadoFecha.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvListadoFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListadoFecha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.DgvListadoFecha.Location = New System.Drawing.Point(19, 79)
        Me.DgvListadoFecha.Name = "DgvListadoFecha"
        Me.DgvListadoFecha.ReadOnly = True
        Me.DgvListadoFecha.RowHeadersWidth = 51
        Me.DgvListadoFecha.RowTemplate.Height = 24
        Me.DgvListadoFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListadoFecha.Size = New System.Drawing.Size(1020, 410)
        Me.DgvListadoFecha.TabIndex = 18
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Seleccionar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LblTotalProducto)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.CboProducto)
        Me.TabPage3.Controls.Add(Me.PanelMostrarProducto)
        Me.TabPage3.Controls.Add(Me.BtnFiltrarProducto)
        Me.TabPage3.Controls.Add(Me.DtFechaF)
        Me.TabPage3.Controls.Add(Me.DtFechaI)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.BtnReporteProducto)
        Me.TabPage3.Controls.Add(Me.DgvListadoProducto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1073, 566)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Listado por producto"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LblTotalProducto
        '
        Me.LblTotalProducto.AutoSize = True
        Me.LblTotalProducto.Location = New System.Drawing.Point(844, 526)
        Me.LblTotalProducto.Name = "LblTotalProducto"
        Me.LblTotalProducto.Size = New System.Drawing.Size(44, 17)
        Me.LblTotalProducto.TabIndex = 39
        Me.LblTotalProducto.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Producto:"
        '
        'CboProducto
        '
        Me.CboProducto.FormattingEnabled = True
        Me.CboProducto.Location = New System.Drawing.Point(517, 14)
        Me.CboProducto.Name = "CboProducto"
        Me.CboProducto.Size = New System.Drawing.Size(170, 24)
        Me.CboProducto.TabIndex = 37
        '
        'PanelMostrarProducto
        '
        Me.PanelMostrarProducto.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelMostrarProducto.Controls.Add(Me.BtnCerrarP)
        Me.PanelMostrarProducto.Controls.Add(Me.LblTotalP)
        Me.PanelMostrarProducto.Controls.Add(Me.LblTotalImpuestoP)
        Me.PanelMostrarProducto.Controls.Add(Me.LblSubTotalP)
        Me.PanelMostrarProducto.Controls.Add(Me.Label16)
        Me.PanelMostrarProducto.Controls.Add(Me.Label17)
        Me.PanelMostrarProducto.Controls.Add(Me.Label18)
        Me.PanelMostrarProducto.Controls.Add(Me.DgvDetalleProducto)
        Me.PanelMostrarProducto.Location = New System.Drawing.Point(121, 90)
        Me.PanelMostrarProducto.Name = "PanelMostrarProducto"
        Me.PanelMostrarProducto.Size = New System.Drawing.Size(936, 473)
        Me.PanelMostrarProducto.TabIndex = 36
        Me.PanelMostrarProducto.Visible = False
        '
        'BtnCerrarP
        '
        Me.BtnCerrarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarP.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarP.Location = New System.Drawing.Point(838, 12)
        Me.BtnCerrarP.Name = "BtnCerrarP"
        Me.BtnCerrarP.Size = New System.Drawing.Size(37, 31)
        Me.BtnCerrarP.TabIndex = 7
        Me.BtnCerrarP.Text = "X"
        Me.BtnCerrarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarP.UseVisualStyleBackColor = True
        '
        'LblTotalP
        '
        Me.LblTotalP.AutoSize = True
        Me.LblTotalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalP.Location = New System.Drawing.Point(771, 429)
        Me.LblTotalP.Name = "LblTotalP"
        Me.LblTotalP.Size = New System.Drawing.Size(19, 20)
        Me.LblTotalP.TabIndex = 6
        Me.LblTotalP.Text = "0"
        '
        'LblTotalImpuestoP
        '
        Me.LblTotalImpuestoP.AutoSize = True
        Me.LblTotalImpuestoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoP.Location = New System.Drawing.Point(771, 398)
        Me.LblTotalImpuestoP.Name = "LblTotalImpuestoP"
        Me.LblTotalImpuestoP.Size = New System.Drawing.Size(19, 20)
        Me.LblTotalImpuestoP.TabIndex = 5
        Me.LblTotalImpuestoP.Text = "0"
        '
        'LblSubTotalP
        '
        Me.LblSubTotalP.AutoSize = True
        Me.LblSubTotalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalP.Location = New System.Drawing.Point(771, 365)
        Me.LblSubTotalP.Name = "LblSubTotalP"
        Me.LblSubTotalP.Size = New System.Drawing.Size(19, 20)
        Me.LblSubTotalP.TabIndex = 4
        Me.LblSubTotalP.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(588, 429)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(588, 398)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Total Impuesto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(588, 365)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Sub Total"
        '
        'DgvDetalleProducto
        '
        Me.DgvDetalleProducto.AllowUserToAddRows = False
        Me.DgvDetalleProducto.AllowUserToDeleteRows = False
        Me.DgvDetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleProducto.Location = New System.Drawing.Point(47, 53)
        Me.DgvDetalleProducto.Name = "DgvDetalleProducto"
        Me.DgvDetalleProducto.ReadOnly = True
        Me.DgvDetalleProducto.RowHeadersWidth = 51
        Me.DgvDetalleProducto.RowTemplate.Height = 24
        Me.DgvDetalleProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleProducto.Size = New System.Drawing.Size(835, 309)
        Me.DgvDetalleProducto.TabIndex = 0
        '
        'BtnFiltrarProducto
        '
        Me.BtnFiltrarProducto.Location = New System.Drawing.Point(693, 8)
        Me.BtnFiltrarProducto.Name = "BtnFiltrarProducto"
        Me.BtnFiltrarProducto.Size = New System.Drawing.Size(151, 37)
        Me.BtnFiltrarProducto.TabIndex = 35
        Me.BtnFiltrarProducto.Text = "Filtrar"
        Me.BtnFiltrarProducto.UseVisualStyleBackColor = True
        '
        'DtFechaF
        '
        Me.DtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaF.Location = New System.Drawing.Point(282, 16)
        Me.DtFechaF.Name = "DtFechaF"
        Me.DtFechaF.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaF.TabIndex = 34
        '
        'DtFechaI
        '
        Me.DtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaI.Location = New System.Drawing.Point(71, 16)
        Me.DtFechaI.Name = "DtFechaI"
        Me.DtFechaI.Size = New System.Drawing.Size(125, 22)
        Me.DtFechaI.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(214, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Hasta"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Desde"
        '
        'BtnReporteProducto
        '
        Me.BtnReporteProducto.Location = New System.Drawing.Point(870, 7)
        Me.BtnReporteProducto.Name = "BtnReporteProducto"
        Me.BtnReporteProducto.Size = New System.Drawing.Size(152, 38)
        Me.BtnReporteProducto.TabIndex = 30
        Me.BtnReporteProducto.Text = "Reporte"
        Me.BtnReporteProducto.UseVisualStyleBackColor = True
        '
        'DgvListadoProducto
        '
        Me.DgvListadoProducto.AllowUserToAddRows = False
        Me.DgvListadoProducto.AllowUserToDeleteRows = False
        Me.DgvListadoProducto.AllowUserToOrderColumns = True
        Me.DgvListadoProducto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListadoProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        Me.DgvListadoProducto.Location = New System.Drawing.Point(6, 73)
        Me.DgvListadoProducto.Name = "DgvListadoProducto"
        Me.DgvListadoProducto.ReadOnly = True
        Me.DgvListadoProducto.RowHeadersWidth = 51
        Me.DgvListadoProducto.RowTemplate.Height = 24
        Me.DgvListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListadoProducto.Size = New System.Drawing.Size(1010, 410)
        Me.DgvListadoProducto.TabIndex = 29
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Seleccionar"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1073, 566)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Listado más vendidos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FrmConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 670)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmConsultaVentas"
        Me.Text = "Consulta de Ventas entre fechas"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarD.ResumeLayout(False)
        Me.PanelMostrarD.PerformLayout()
        CType(Me.DgvMostrarD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvListadoFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.PanelMostrarProducto.ResumeLayout(False)
        Me.PanelMostrarProducto.PerformLayout()
        CType(Me.DgvDetalleProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnVerComprobante As Button
    Friend WithEvents Lbltotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents BtnCerrarM As Button
    Friend WithEvents LblTotalM As Label
    Friend WithEvents LblTotalImpuestoM As Label
    Friend WithEvents LblSubTotalM As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnFiltrar2 As Button
    Friend WithEvents DtFechaFi As DateTimePicker
    Friend WithEvents DtFechaIni As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnReporte As Button
    Friend WithEvents DgvListadoFecha As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents PanelMostrarD As Panel
    Friend WithEvents BtnCerrarPanel As Button
    Friend WithEvents LblTot As Label
    Friend WithEvents LblImpuesto As Label
    Friend WithEvents LblSub As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DgvMostrarD As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents CboVendedor As ComboBox
    Friend WithEvents LblTotalReg As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents CboProducto As ComboBox
    Friend WithEvents PanelMostrarProducto As Panel
    Friend WithEvents BtnCerrarP As Button
    Friend WithEvents LblTotalP As Label
    Friend WithEvents LblTotalImpuestoP As Label
    Friend WithEvents LblSubTotalP As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DgvDetalleProducto As DataGridView
    Friend WithEvents BtnFiltrarProducto As Button
    Friend WithEvents DtFechaF As DateTimePicker
    Friend WithEvents DtFechaI As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnReporteProducto As Button
    Friend WithEvents DgvListadoProducto As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LblTotalProducto As Label
End Class
