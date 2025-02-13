<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restablecer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restablecer))
        Panel1 = New Panel()
        txtEmail = New TextBox()
        txtContraseña = New TextBox()
        Panel2 = New Panel()
        txtNueContraseña = New TextBox()
        Panel3 = New Panel()
        btnRes = New Button()
        PictureBox8 = New PictureBox()
        btmAtras = New Button()
        Label1 = New Label()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(285, 245)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(195, 1)
        Panel1.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Control
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Location = New Point(285, 221)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(195, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtContraseña
        ' 
        txtContraseña.BackColor = SystemColors.Control
        txtContraseña.BorderStyle = BorderStyle.None
        txtContraseña.Location = New Point(285, 262)
        txtContraseña.Multiline = True
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PlaceholderText = "Nueva Contraseña"
        txtContraseña.Size = New Size(195, 23)
        txtContraseña.TabIndex = 4
        txtContraseña.UseSystemPasswordChar = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(285, 287)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(195, 1)
        Panel2.TabIndex = 3
        ' 
        ' txtNueContraseña
        ' 
        txtNueContraseña.BackColor = SystemColors.Control
        txtNueContraseña.BorderStyle = BorderStyle.None
        txtNueContraseña.Location = New Point(285, 302)
        txtNueContraseña.Multiline = True
        txtNueContraseña.Name = "txtNueContraseña"
        txtNueContraseña.PlaceholderText = "Repitir Contraseña"
        txtNueContraseña.Size = New Size(195, 23)
        txtNueContraseña.TabIndex = 6
        txtNueContraseña.UseSystemPasswordChar = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(285, 327)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 1)
        Panel3.TabIndex = 5
        ' 
        ' btnRes
        ' 
        btnRes.BackColor = SystemColors.Control
        btnRes.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRes.FlatStyle = FlatStyle.Popup
        btnRes.Location = New Point(328, 353)
        btnRes.Name = "btnRes"
        btnRes.Size = New Size(99, 29)
        btnRes.TabIndex = 7
        btnRes.Text = "Restablecer"
        btnRes.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(328, 92)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(114, 109)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' btmAtras
        ' 
        btmAtras.BackColor = SystemColors.Control
        btmAtras.BackgroundImage = CType(resources.GetObject("btmAtras.BackgroundImage"), Image)
        btmAtras.BackgroundImageLayout = ImageLayout.Stretch
        btmAtras.FlatAppearance.BorderSize = 0
        btmAtras.FlatAppearance.MouseDownBackColor = Color.Thistle
        btmAtras.FlatAppearance.MouseOverBackColor = Color.Thistle
        btmAtras.FlatStyle = FlatStyle.Flat
        btmAtras.Location = New Point(12, 398)
        btmAtras.Name = "btmAtras"
        btmAtras.Size = New Size(40, 40)
        btmAtras.TabIndex = 17
        btmAtras.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(121, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(558, 54)
        Label1.TabIndex = 20
        Label1.Text = "RESTABLECER CONTRASEÑA"
        ' 
        ' Restablecer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(741, 450)
        Controls.Add(Label1)
        Controls.Add(btmAtras)
        Controls.Add(PictureBox8)
        Controls.Add(btnRes)
        Controls.Add(txtNueContraseña)
        Controls.Add(Panel3)
        Controls.Add(txtContraseña)
        Controls.Add(Panel2)
        Controls.Add(txtEmail)
        Controls.Add(Panel1)
        Name = "Restablecer"
        Text = "Restablecer"
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNueContraseña As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRes As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btmAtras As Button
    Friend WithEvents Label1 As Label
End Class
