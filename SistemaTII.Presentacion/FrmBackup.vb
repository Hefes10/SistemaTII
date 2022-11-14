﻿Imports System.IO

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
End Class