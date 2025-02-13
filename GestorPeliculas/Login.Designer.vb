<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        btnRestablecer = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnIniciar = New Button()
        btnRegistrar = New Button()
        lbUsuario = New Label()
        Panel1 = New Panel()
        lbAdmin = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(228, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(197, 233)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Usuario"
        txtUsuario.Size = New Size(178, 23)
        txtUsuario.TabIndex = 1
        txtUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(197, 276)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Contraseña"
        txtPassword.Size = New Size(178, 23)
        txtPassword.TabIndex = 2
        txtPassword.TextAlign = HorizontalAlignment.Center
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnRestablecer
        ' 
        btnRestablecer.FlatAppearance.BorderSize = 0
        btnRestablecer.FlatAppearance.MouseDownBackColor = Color.Thistle
        btnRestablecer.FlatAppearance.MouseOverBackColor = Color.Thistle
        btnRestablecer.FlatStyle = FlatStyle.Flat
        btnRestablecer.Font = New Font("Segoe UI", 8.0F)
        btnRestablecer.ForeColor = Color.DarkMagenta
        btnRestablecer.Location = New Point(211, 320)
        btnRestablecer.Name = "btnRestablecer"
        btnRestablecer.Size = New Size(147, 23)
        btnRestablecer.TabIndex = 3
        btnRestablecer.Text = "Restablecer contraseña "
        btnRestablecer.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Lavender
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(171, 233)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Lavender
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(171, 276)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = Color.FromArgb(CByte(230), CByte(233), CByte(242))
        btnIniciar.FlatAppearance.BorderSize = 0
        btnIniciar.FlatAppearance.MouseDownBackColor = Color.Thistle
        btnIniciar.FlatAppearance.MouseOverBackColor = Color.Thistle
        btnIniciar.FlatStyle = FlatStyle.Flat
        btnIniciar.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnIniciar.ForeColor = Color.DarkMagenta
        btnIniciar.Location = New Point(197, 376)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(178, 32)
        btnIniciar.TabIndex = 6
        btnIniciar.Text = "Iniciar sesion"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Thistle
        btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Thistle
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.Font = New Font("Segoe UI", 10.0F)
        btnRegistrar.ForeColor = Color.DarkMagenta
        btnRegistrar.Location = New Point(249, 414)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(77, 26)
        btnRegistrar.TabIndex = 7
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' lbUsuario
        ' 
        lbUsuario.AutoSize = True
        lbUsuario.FlatStyle = FlatStyle.Flat
        lbUsuario.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lbUsuario.Location = New Point(235, 204)
        lbUsuario.Name = "lbUsuario"
        lbUsuario.Size = New Size(49, 15)
        lbUsuario.TabIndex = 8
        lbUsuario.Text = "Usuario"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(288, 202)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 20)
        Panel1.TabIndex = 9
        ' 
        ' lbAdmin
        ' 
        lbAdmin.AutoSize = True
        lbAdmin.FlatStyle = FlatStyle.Flat
        lbAdmin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lbAdmin.Location = New Point(295, 204)
        lbAdmin.Name = "lbAdmin"
        lbAdmin.Size = New Size(43, 15)
        lbAdmin.TabIndex = 10
        lbAdmin.Text = "Admin"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(557, 497)
        Controls.Add(lbAdmin)
        Controls.Add(Panel1)
        Controls.Add(lbUsuario)
        Controls.Add(btnRegistrar)
        Controls.Add(btnIniciar)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(btnRestablecer)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Controls.Add(PictureBox1)
        Name = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lbUsuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbAdmin As Label
End Class
