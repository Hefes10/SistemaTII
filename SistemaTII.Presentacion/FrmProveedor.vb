Imports System.ComponentModel

Public Class FrmProveedor

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(2).Width = 120
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 120
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 120

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NPersona
            DgvListado.DataSource = Neg.ListarProveedores()
            DgvListado.Visible = True
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NPersona
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.BuscarProveedores(Valor)
            DgvListado.Visible = True
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtId.Text = ""
        TxtNombre.Text = ""
        TxtNumDocumento.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtEmail.Text = ""
    End Sub


    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.SelectedCells.Item(1).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(3).Value
            CboTipoDocumento.Text = DgvListado.SelectedCells.Item(4).Value
            TxtNumDocumento.Text = DgvListado.SelectedCells.Item(5).Value
            TxtDireccion.Text = DgvListado.SelectedCells.Item(6).Value
            TxtTelefono.Text = DgvListado.SelectedCells.Item(7).Value
            TxtEmail.Text = DgvListado.SelectedCells.Item(8).Value

            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1
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

    Private Sub TxtNombre_TextChanged(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvListado.Columns.Item("Seleccionar").Visible = False
        DgvListado.Visible = False
        ChkSeleccionar.Visible = False
        BtnEliminar.Visible = False
        ChkSeleccionar.CheckState = False
        If (FrmPrincipal.IdRol <> 1) Then
            ChkSeleccionar.Visible = False
        End If
        Me.Limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtValor.Text <> "" Then
            Me.Buscar()
        End If
    End Sub

    Private Sub BtnListarProveedores_Click(sender As Object, e As EventArgs) Handles BtnListarProveedores.Click
        Me.Listar()
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
                Dim Obj As New Entidades.Persona
                Dim Neg As New Negocio.NPersona

                Obj.TipoPersona = "Proveedor"
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                    Me.Listar()
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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Está seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar Registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NPersona
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtId.Text <> "" Then
                Dim Obj As New Entidades.Persona
                Dim Neg As New Negocio.NPersona

                Obj.IdPersona = TxtId.Text
                Obj.TipoPersona = "Proveedor"
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización Correcta")
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

    Private Sub TxtNombre_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del Proveedor, este campo es obligatorio")
        End If
    End Sub

    Private Sub TxtNumDocumento_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtNumDocumento.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNumDocumento_Validating(sender As Object, e As CancelEventArgs) Handles TxtNumDocumento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el número de documento del proveedor, este dato es obligatorio")
        End If
    End Sub

End Class