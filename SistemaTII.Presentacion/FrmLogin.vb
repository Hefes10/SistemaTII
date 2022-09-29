Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        Try
            Dim Email As String, Clave As String
            Dim Obj As New Entidades.Usuario
            'Dim Neg As New Negocio.NUsuario
            Email = TxtEmail.Text.Trim()
            Clave = TxtClave.Text.Trim()
            'Obj = Neg.Login(Email, Clave)
            Obj.Estado = True
            If (Obj Is Nothing) Then
                MsgBox("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
            Else
                If (Obj.Estado = False) Then
                    MsgBox("El usuario no esta activo", vbOKOnly + vbCritical, "Usuario no tiene acceso")
                Else
                    Me.Hide()
                    FrmPrincipal.IdUsuario = 1 'Obj.IdUsuario
                    FrmPrincipal.IdRol = 1 'Obj.IdRol
                    FrmPrincipal.Rol = "Administrador"
                    FrmPrincipal.Nombre = "Martin"
                    FrmPrincipal.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class