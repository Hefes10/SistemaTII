<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRutaGuardar = New System.Windows.Forms.TextBox()
        Me.TxtBaseRestaurar = New System.Windows.Forms.TextBox()
        Me.TxtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.CboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.BtnRutaGuardar = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnRutaRestaurar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 102)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Base de datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruta a guardar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ruta del backup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Base de datos a restaurar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Backup y restauración de Base de Datos SQL Server"
        '
        'TxtRutaGuardar
        '
        Me.TxtRutaGuardar.Location = New System.Drawing.Point(115, 170)
        Me.TxtRutaGuardar.Name = "TxtRutaGuardar"
        Me.TxtRutaGuardar.Size = New System.Drawing.Size(354, 20)
        Me.TxtRutaGuardar.TabIndex = 5
        '
        'TxtBaseRestaurar
        '
        Me.TxtBaseRestaurar.Location = New System.Drawing.Point(147, 346)
        Me.TxtBaseRestaurar.Name = "TxtBaseRestaurar"
        Me.TxtBaseRestaurar.Size = New System.Drawing.Size(322, 20)
        Me.TxtBaseRestaurar.TabIndex = 6
        '
        'TxtRutaRestaurar
        '
        Me.TxtRutaRestaurar.Location = New System.Drawing.Point(147, 311)
        Me.TxtRutaRestaurar.Name = "TxtRutaRestaurar"
        Me.TxtRutaRestaurar.Size = New System.Drawing.Size(322, 20)
        Me.TxtRutaRestaurar.TabIndex = 7
        '
        'CboBaseDatos
        '
        Me.CboBaseDatos.FormattingEnabled = True
        Me.CboBaseDatos.Location = New System.Drawing.Point(115, 131)
        Me.CboBaseDatos.Name = "CboBaseDatos"
        Me.CboBaseDatos.Size = New System.Drawing.Size(159, 21)
        Me.CboBaseDatos.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(294, 131)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConectar.TabIndex = 9
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'BtnRutaGuardar
        '
        Me.BtnRutaGuardar.Location = New System.Drawing.Point(492, 170)
        Me.BtnRutaGuardar.Name = "BtnRutaGuardar"
        Me.BtnRutaGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRutaGuardar.TabIndex = 10
        Me.BtnRutaGuardar.Text = "Ruta"
        Me.BtnRutaGuardar.UseVisualStyleBackColor = True
        '
        'BtnBackup
        '
        Me.BtnBackup.Location = New System.Drawing.Point(492, 217)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackup.TabIndex = 11
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'BtnRutaRestaurar
        '
        Me.BtnRutaRestaurar.Location = New System.Drawing.Point(492, 311)
        Me.BtnRutaRestaurar.Name = "BtnRutaRestaurar"
        Me.BtnRutaRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRutaRestaurar.TabIndex = 12
        Me.BtnRutaRestaurar.Text = "Ruta"
        Me.BtnRutaRestaurar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(492, 346)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRestaurar.TabIndex = 13
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 450)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnRutaRestaurar)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnRutaGuardar)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.CboBaseDatos)
        Me.Controls.Add(Me.TxtRutaRestaurar)
        Me.Controls.Add(Me.TxtBaseRestaurar)
        Me.Controls.Add(Me.TxtRutaGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmBackup"
        Me.Text = "FrmBackup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRutaGuardar As TextBox
    Friend WithEvents TxtBaseRestaurar As TextBox
    Friend WithEvents TxtRutaRestaurar As TextBox
    Friend WithEvents CboBaseDatos As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnConectar As Button
    Friend WithEvents BtnRutaGuardar As Button
    Friend WithEvents BtnBackup As Button
    Friend WithEvents BtnRutaRestaurar As Button
    Friend WithEvents BtnRestaurar As Button
End Class
