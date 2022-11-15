Imports System.Text.RegularExpressions
Public Class FrmLogin

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function


    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        Try
            Dim bln As Boolean = IsValidEmail(TxtEmail.Text)
            Dim Email As String, Clave As String
            Dim Obj As New Entidades.Usuario
            Dim Neg As New Negocio.NUsuario
            Email = TxtEmail.Text.Trim()
            Clave = TxtClave.Text.Trim()
            Obj = Neg.Login(Email, Clave)
            If (bln = True And TxtClave.Text <> "") Then
                If (Obj Is Nothing) Then
                    MsgBox("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
                ElseIf (Obj.Estado = False) Then
                    MsgBox("El usuario no está activo", vbOKOnly + vbCritical, "Usuario no tiene acceso")
                Else
                    Me.Hide()
                    FrmPrincipal.IdUsuario = Obj.IdUsuario
                    Variables.IdUsuario = Obj.IdUsuario
                    Variables.IdRol = Obj.IdRol
                    Variables.Nombre = Obj.Nombre
                    FrmPrincipal.IdRol = Obj.IdRol
                    FrmPrincipal.Rol = Obj.Rol
                    FrmPrincipal.Nombre = Obj.Nombre
                    FrmPrincipal.Show()
                End If
            Else
                MsgBox("Correo o clave inválida", vbOKOnly + vbCritical, "Error de login")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class