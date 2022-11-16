Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class FrmUsuario
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 120
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 120
        DgvListado.Columns(8).Width = 100
        DgvListado.Columns(9).Width = 120
        DgvListado.Columns(10).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NUsuario
            DgvListado.DataSource = Neg.Listar()
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
            Dim Neg As New Negocio.NUsuario
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
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
        TxtClave.Text = ""
    End Sub

    Private Sub CargarRol()
        Try
            Dim Neg As New Negocio.NRol
            CboRol.DataSource = Neg.Listar()
            CboRol.ValueMember = "idrol"
            CboRol.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.SelectedCells.Item(1).Value
            CboRol.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(4).Value
            CboTipoDocumento.Text = DgvListado.SelectedCells.Item(5).Value
            TxtNumDocumento.Text = DgvListado.SelectedCells.Item(6).Value
            TxtDireccion.Text = DgvListado.SelectedCells.Item(7).Value
            TxtTelefono.Text = DgvListado.SelectedCells.Item(8).Value
            TxtEmail.Text = DgvListado.SelectedCells.Item(9).Value

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

    Private Sub TxtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress, TxtNombre.TextChanged
        If IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Está seguro de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar Registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
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
    End Sub
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
        ChkSeleccionar.Visible = False
        Me.Limpiar()
        Me.CargarRol()
    End Sub

    Private Sub BtnListarTodos_Click(sender As Object, e As EventArgs) Handles BtnListarTodos.Click
        Me.Listar()
        ChkSeleccionar.Visible = True
    End Sub


    Private Sub TxtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim bln As Boolean = IsValidEmail(TxtEmail.Text)
        If bln = True Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del artículo, este campo es obligatorio")
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Dim bln As Boolean = IsValidEmail(TxtEmail.Text)
        Try
            If Me.ValidateChildren = True And CboRol.Text <> "" And TxtNombre.Text <> "" And bln = True And TxtClave.Text <> "" Then
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.NUsuario

                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If Obj.IdRol = 4 And Variables.IdRol <> 4 Then
                    MsgBox("Ud. No tiene privilegios para dar de alta un usuario con el rol de Superadmin", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sistema")
                    Me.Listar()
                Else
                    If (Neg.Insertar(Obj)) Then
                        MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                        Me.Listar()
                    Else
                        MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro Incorrecto")
                        Me.Listar()
                    End If
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And CboRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" And TxtId.Text <> "" Then
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.NUsuario

                Obj.IdUsuario = TxtId.Text
                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text
                Obj.NumDocumento = TxtNumDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If Obj.IdRol = 4 And Variables.IdRol <> 4 Then
                    MsgBox("Ud. No tiene privilegios para actualizar un usuario con el rol de Superadmin", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sistema")
                    Me.Listar()
                Else
                    If (Neg.Actualizar(Obj)) Then
                        MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualización Correcta")
                        Me.Listar()
                    Else
                        MsgBox("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización Incorrecta")
                        Me.Listar()
                    End If
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
        If (MsgBox("Está seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar Registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Selected)
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

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Está seguro de activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar Registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
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
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtValor.Text <> "" Then
            Me.Buscar()
            ChkSeleccionar.Visible = True
        End If
    End Sub

    Private Sub CboRol_Validating(sender As Object, e As CancelEventArgs) Handles CboRol.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el precio de venta del artículo, este dato es obligatorio")
        End If
    End Sub
    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del usuario, este campo es obligatorio")
        End If
    End Sub

    Private Sub TxtNumDocumento_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtNumDocumento.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class