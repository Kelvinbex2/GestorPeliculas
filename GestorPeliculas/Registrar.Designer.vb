<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        txtDni = New TextBox()
        txtNombre = New TextBox()
        txtApel = New TextBox()
        txtTlf = New TextBox()
        txtEmail = New TextBox()
        txtDir = New TextBox()
        TextBox1 = New TextBox()
        btnRegistar = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        btmAtras = New Button()
        Label1 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(257, 231)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "Dni"
        txtDni.Size = New Size(155, 23)
        txtDni.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(257, 280)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(155, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApel
        ' 
        txtApel.Location = New Point(257, 325)
        txtApel.Name = "txtApel"
        txtApel.PlaceholderText = "Apellidos"
        txtApel.Size = New Size(155, 23)
        txtApel.TabIndex = 2
        ' 
        ' txtTlf
        ' 
        txtTlf.Location = New Point(257, 417)
        txtTlf.Name = "txtTlf"
        txtTlf.PlaceholderText = "Telefono"
        txtTlf.Size = New Size(155, 23)
        txtTlf.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(257, 502)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(155, 23)
        txtEmail.TabIndex = 4
        ' 
        ' txtDir
        ' 
        txtDir.Location = New Point(257, 370)
        txtDir.Name = "txtDir"
        txtDir.PlaceholderText = "Dirección"
        txtDir.Size = New Size(155, 23)
        txtDir.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(257, 459)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Contraseña"
        TextBox1.Size = New Size(155, 23)
        TextBox1.TabIndex = 6
        ' 
        ' btnRegistar
        ' 
        btnRegistar.BackColor = Color.GhostWhite
        btnRegistar.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRegistar.FlatAppearance.BorderSize = 0
        btnRegistar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRegistar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnRegistar.FlatStyle = FlatStyle.Popup
        btnRegistar.Location = New Point(283, 548)
        btnRegistar.Name = "btnRegistar"
        btnRegistar.Size = New Size(100, 23)
        btnRegistar.TabIndex = 7
        btnRegistar.Text = "Registrar"
        btnRegistar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.GhostWhite
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(231, 231)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.GhostWhite
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(231, 280)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.GhostWhite
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(231, 325)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.GhostWhite
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(231, 459)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.GhostWhite
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(231, 370)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 23)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.GhostWhite
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(231, 417)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 23)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.GhostWhite
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(231, 502)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(20, 23)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(269, 90)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(114, 109)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 15
        PictureBox8.TabStop = False
        ' 
        ' btmAtras
        ' 
        btmAtras.BackColor = Color.Thistle
        btmAtras.BackgroundImage = CType(resources.GetObject("btmAtras.BackgroundImage"), Image)
        btmAtras.BackgroundImageLayout = ImageLayout.Stretch
        btmAtras.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btmAtras.FlatAppearance.BorderSize = 0
        btmAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btmAtras.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btmAtras.FlatStyle = FlatStyle.Popup
        btmAtras.Location = New Point(12, 560)
        btmAtras.Name = "btmAtras"
        btmAtras.Size = New Size(40, 40)
        btmAtras.TabIndex = 16
        btmAtras.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(119, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 54)
        Label1.TabIndex = 17
        Label1.Text = "CREAR UNA CUENTA"
        ' 
        ' Registrar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(633, 612)
        Controls.Add(Label1)
        Controls.Add(btmAtras)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(btnRegistar)
        Controls.Add(TextBox1)
        Controls.Add(txtDir)
        Controls.Add(txtEmail)
        Controls.Add(txtTlf)
        Controls.Add(txtApel)
        Controls.Add(txtNombre)
        Controls.Add(txtDni)
        Name = "Registrar"
        Text = "Registrar"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApel As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRegistar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btmAtras As Button
    Friend WithEvents Label1 As Label
End Class
