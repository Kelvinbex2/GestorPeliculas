<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolver
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
        Panel1 = New Panel()
        CheckBoxDev = New CheckBox()
        txtDni = New TextBox()
        Titulo = New ComboBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(CheckBoxDev)
        Panel1.Controls.Add(txtDni)
        Panel1.Controls.Add(Titulo)
        Panel1.Location = New Point(33, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(240, 194)
        Panel1.TabIndex = 0
        ' 
        ' CheckBoxDev
        ' 
        CheckBoxDev.AutoSize = True
        CheckBoxDev.Location = New Point(154, 62)
        CheckBoxDev.Name = "CheckBoxDev"
        CheckBoxDev.Size = New Size(72, 19)
        CheckBoxDev.TabIndex = 2
        CheckBoxDev.Text = "Devolver"
        CheckBoxDev.UseVisualStyleBackColor = True
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(26, 87)
        txtDni.Name = "txtDni"
        txtDni.ReadOnly = True
        txtDni.Size = New Size(121, 23)
        txtDni.TabIndex = 1
        ' 
        ' Titulo
        ' 
        Titulo.FormattingEnabled = True
        Titulo.Location = New Point(26, 32)
        Titulo.Name = "Titulo"
        Titulo.Size = New Size(121, 23)
        Titulo.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(158, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Devolver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(336, 239)
        Controls.Add(Panel1)
        Name = "Devolver"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Devolver"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxDev As CheckBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Titulo As ComboBox
    Friend WithEvents Button1 As Button
End Class
