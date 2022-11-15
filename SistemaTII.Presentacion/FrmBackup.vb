Imports System.IO

Public Class FrmBackup
    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
        Try
            Dim Neg As New Negocio.NBackup
            Dim Ds As New DataSet
            Ds = Neg.GetDB
            If Ds.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                For Each fila In Ds.Tables(0).Rows
                    CboBaseDatos.Items.Add(fila(0).ToString)
                Next

                CboBaseDatos.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRutaGuardar_Click(sender As Object, e As EventArgs) Handles BtnRutaGuardar.Click
        SaveFileDialog1.Filter = "SQL Backup files | *.bak"
        SaveFileDialog1.FileName = CboBaseDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtRutaGuardar.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        Try
            'Verificamos que exista la carpeta, de lo contrario la crea
            If Not Directory.Exists("D:\taller2\Backup") Then
                Directory.CreateDirectory("D:\taller2\Backup")
            End If

            Dim Neg As New Negocio.NBackup
            Neg.Backup(CboBaseDatos.Text, TxtRutaGuardar.Text)

            MsgBox("Se ha realizado el backup correctamente.", vbOKOnly + vbInformation, "Backup Correcto")
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub BtnRutaRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRutaRestaurar.Click
        OpenFileDialog1.Filter = "SQL Backup Files | *.bak"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtRutaRestaurar.Text = OpenFileDialog1.FileName
            Dim NameArray() As String = Split(TxtRutaRestaurar.Text.Substring(TxtRutaRestaurar.Text.LastIndexOf("\") + 1), "-")
            TxtBaseRestaurar.Text = NameArray(0)
        End If
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Try
            Dim Result As Integer
            Result = MsgBox("Está a punto de restaurar la Base de Datos. Perderá toda la información que no haya sido guardada. Desea continuar?", MsgBoxStyle.OkCancel + vbExclamation, "Advertencia")
            If Result = 1 Then
                Dim Neg As New Negocio.NBackup
                Neg.Restore(TxtBaseRestaurar.Text, TxtRutaRestaurar.Text)
                MsgBox("Se ha realizado el restore correctamente.", vbOKOnly + vbInformation, "Restore Backup Correcto")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub FrmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Variables.IdRol = 4) Then
            BtnRutaRestaurar.Enabled = True
            BtnRestaurar.Enabled = True
        Else
            BtnRutaRestaurar.Enabled = False
            BtnRestaurar.Enabled = False
        End If

    End Sub
End Class