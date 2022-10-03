Imports System.IO

Public Class FrmArticulo
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\taller2\"
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub

    Private Sub Listar()

        Try
            Dim Neg As New Negocio.NArticulo
            DgvListado.DataSource = Neg.Listar()
            DgvListado.Visible = True
            If (FrmPrincipal.IdRol = 1) Then
                ChkSeleccionar.Visible = True
            End If
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            DgvListado.Visible = True
            If (FrmPrincipal.IdRol = 1) Then
                ChkSeleccionar.Visible = True
            End If
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        ErrorIcono.SetError(TxtNombre, "")
        ErrorIcono.SetError(TxtStock, "")
        ErrorIcono.SetError(TxtPrecioVenta, "")
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtId.Text = ""
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecioVenta.Text = ""
        TxtStock.Text = ""
        TxtImagen.Text = ""
        PicImagen.Image = Nothing
        Txtdescripcion.Text = ""
        RutaOrigen = ""
    End Sub
    Private Sub CargarCategoria()
        Try
            Dim Neg As New Negocio.NCategoria
            CboCategoria.DataSource = Neg.Seleccionar
            CboCategoria.ValueMember = "idcategoria"
            CboCategoria.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
        ChkSeleccionar.Visible = False
        Me.Limpiar()
        Me.CargarCategoria()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click, TxtValor.Enter
        If TxtValor.Text <> "" Then
            Me.Buscar()
        End If
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim File As New OpenFileDialog()
        File.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If File.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            TxtImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\") + 1)
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = Txtdescripcion.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                    If (TxtImagen.Text <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        CopyImg(RutaOrigen, RutaDestino)
                    End If
                    Me.Limpiar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro Incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CopyImg(RutaOrigen As String, RutaDestino As String)
        Dim Path As String
        Path = Dir(Directorio)

        If RutaDestino = vbNullString Then Exit Sub

        If Path = "" Then
            Call MkDir(Directorio)
        End If

        Try
            File.Copy(RutaOrigen, RutaDestino)
        Catch ex As Exception
            MsgBox("La imagen ya existe.", vbOKOnly, "Atención")
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" And TxtId.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdArticulo = TxtId.Text
                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = Txtdescripcion.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización Correcta")
                    If (TxtImagen.Text <> "" And RutaOrigen <> "") Then
                        RutaDestino = Directorio & TxtImagen.Text
                        CopyImg(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización Incorrecta")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        For Each roww As DataGridViewRow In DgvListado.Rows
            Dim mar As Boolean = Convert.ToBoolean(roww.Cells("Seleccionar").Value)
            If mar Then
                If (MsgBox("Está seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar Registros") = vbYes) Then
                    Try
                        Dim Neg As New Negocio.NArticulo
                        For Each row As DataGridViewRow In DgvListado.Rows
                            Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                            If marcado Then
                                Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                                Dim Imagen As String = Convert.ToString(row.Cells("Imagen").Value)
                                Neg.Eliminar(OneKey)
                                File.Delete(Directorio & Imagen)
                            End If
                        Next
                        Me.Listar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        For Each roww As DataGridViewRow In DgvListado.Rows
            Dim mar As Boolean = Convert.ToBoolean(roww.Cells("Seleccionar").Value)
            If mar Then
                If (MsgBox("Está seguro de activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar Registros") = vbYes) Then
                    Try
                        Dim Neg As New Negocio.NArticulo
                        For Each row As DataGridViewRow In DgvListado.Rows
                            Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                            If marcado Then
                                Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                                Neg.Activar(OneKey)
                            End If
                        Next
                        Me.Listar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        For Each roww As DataGridViewRow In DgvListado.Rows
            Dim mar As Boolean = Convert.ToBoolean(roww.Cells("Seleccionar").Value)
            If mar Then
                If (MsgBox("Está seguro de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Activar Registros") = vbYes) Then
                    Try
                        Dim Neg As New Negocio.NArticulo
                        For Each row As DataGridViewRow In DgvListado.Rows
                            Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                            If marcado Then
                                Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                                Neg.Desactivar(OneKey)
                            End If
                        Next
                        Me.Listar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub BtnListarTodos_Click(sender As Object, e As EventArgs) Handles BtnListarTodos.Click
        Me.Listar()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStock_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrecioVenta_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtPrecioVenta.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        FrmReporteArticulos.ShowDialog()
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.SelectedCells.Item(1).Value
            CboCategoria.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtCodigo.Text = DgvListado.SelectedCells.Item(4).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(5).Value
            TxtPrecioVenta.Text = DgvListado.SelectedCells.Item(6).Value
            TxtStock.Text = DgvListado.SelectedCells.Item(7).Value
            Txtdescripcion.Text = DgvListado.SelectedCells.Item(8).Value
            Dim Imagen As String
            Imagen = DgvListado.SelectedCells.Item(9).Value
            If (Imagen <> "") Then
                PicImagen.Image = Image.FromFile(Directorio & Imagen)
                TxtImagen.Text = Imagen
            Else
                PicImagen.Image = Nothing
                TxtImagen.Text = ""
            End If
            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CboCategoria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CboCategoria.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la categoría, este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del artículo, este campo es obligatorio")
        End If
    End Sub

    Private Sub TxtStock_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtStock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el stock del artículo, este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtPrecioVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtPrecioVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el precio de venta del artículo, este dato es obligatorio")
        End If
    End Sub
End Class