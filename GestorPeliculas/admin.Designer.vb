<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        AgregarAdminToolStripMenuItem = New ToolStripMenuItem()
        AgregarPeliculaToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        TextBox6 = New TextBox()
        Panel7 = New Panel()
        Panel9 = New Panel()
        btnAcep = New Button()
        TextContra = New TextBox()
        Panel8 = New Panel()
        TextEmail = New TextBox()
        Panel6 = New Panel()
        TextTlf = New TextBox()
        Panel5 = New Panel()
        TextApel = New TextBox()
        Panel4 = New Panel()
        TextBoxNombre = New TextBox()
        Panel3 = New Panel()
        PictureBox8 = New PictureBox()
        Panel10 = New Panel()
        btnagregar = New Button()
        txtSip = New TextBox()
        txtCal = New TextBox()
        txtDir = New TextBox()
        txtTit = New TextBox()
        txtFec = New TextBox()
        txtGen = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, AgregarAdminToolStripMenuItem, AgregarPeliculaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' AgregarAdminToolStripMenuItem
        ' 
        AgregarAdminToolStripMenuItem.Name = "AgregarAdminToolStripMenuItem"
        AgregarAdminToolStripMenuItem.Size = New Size(98, 20)
        AgregarAdminToolStripMenuItem.Text = "Agregar admin"
        ' 
        ' AgregarPeliculaToolStripMenuItem
        ' 
        AgregarPeliculaToolStripMenuItem.Name = "AgregarPeliculaToolStripMenuItem"
        AgregarPeliculaToolStripMenuItem.Size = New Size(105, 20)
        AgregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Enabled = False
        TextBox1.Font = New Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(279, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 51)
        TextBox1.TabIndex = 20
        TextBox1.Text = "Bienvenido"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Panel7)
        Panel1.Location = New Point(376, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 489)
        Panel1.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = SystemColors.Control
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(-97, 248)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Email"
        TextBox6.Size = New Size(195, 23)
        TextBox6.TabIndex = 4
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(-97, 272)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(195, 1)
        Panel7.TabIndex = 3
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(btnAcep)
        Panel9.Controls.Add(TextContra)
        Panel9.Controls.Add(Panel8)
        Panel9.Controls.Add(TextEmail)
        Panel9.Controls.Add(Panel6)
        Panel9.Controls.Add(TextTlf)
        Panel9.Controls.Add(Panel5)
        Panel9.Controls.Add(TextApel)
        Panel9.Controls.Add(Panel4)
        Panel9.Controls.Add(TextBoxNombre)
        Panel9.Controls.Add(Panel3)
        Panel9.Controls.Add(PictureBox8)
        Panel9.Location = New Point(12, 100)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(358, 483)
        Panel9.TabIndex = 44
        ' 
        ' btnAcep
        ' 
        btnAcep.Location = New Point(126, 430)
        btnAcep.Name = "btnAcep"
        btnAcep.Size = New Size(75, 23)
        btnAcep.TabIndex = 48
        btnAcep.Text = "Aceptar"
        btnAcep.UseVisualStyleBackColor = True
        ' 
        ' TextContra
        ' 
        TextContra.BackColor = SystemColors.Control
        TextContra.BorderStyle = BorderStyle.None
        TextContra.Location = New Point(72, 384)
        TextContra.Multiline = True
        TextContra.Name = "TextContra"
        TextContra.PlaceholderText = "Contraseña"
        TextContra.Size = New Size(195, 23)
        TextContra.TabIndex = 47
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(72, 408)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(195, 1)
        Panel8.TabIndex = 46
        ' 
        ' TextEmail
        ' 
        TextEmail.BackColor = SystemColors.Control
        TextEmail.BorderStyle = BorderStyle.None
        TextEmail.Location = New Point(72, 342)
        TextEmail.Multiline = True
        TextEmail.Name = "TextEmail"
        TextEmail.PlaceholderText = "Email"
        TextEmail.Size = New Size(195, 23)
        TextEmail.TabIndex = 45
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(72, 366)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(195, 1)
        Panel6.TabIndex = 44
        ' 
        ' TextTlf
        ' 
        TextTlf.BackColor = SystemColors.Control
        TextTlf.BorderStyle = BorderStyle.None
        TextTlf.Location = New Point(72, 301)
        TextTlf.Multiline = True
        TextTlf.Name = "TextTlf"
        TextTlf.PlaceholderText = "Telefono"
        TextTlf.Size = New Size(195, 23)
        TextTlf.TabIndex = 43
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(72, 325)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(195, 1)
        Panel5.TabIndex = 42
        ' 
        ' TextApel
        ' 
        TextApel.BackColor = SystemColors.Control
        TextApel.BorderStyle = BorderStyle.None
        TextApel.Location = New Point(72, 257)
        TextApel.Multiline = True
        TextApel.Name = "TextApel"
        TextApel.PlaceholderText = "Apellido"
        TextApel.Size = New Size(195, 23)
        TextApel.TabIndex = 41
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(72, 281)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(195, 1)
        Panel4.TabIndex = 40
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.BackColor = SystemColors.Control
        TextBoxNombre.BorderStyle = BorderStyle.None
        TextBoxNombre.Location = New Point(72, 213)
        TextBoxNombre.Multiline = True
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.PlaceholderText = "Nombre"
        TextBoxNombre.Size = New Size(195, 23)
        TextBoxNombre.TabIndex = 39
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(72, 237)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 1)
        Panel3.TabIndex = 38
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(117, 33)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(107, 110)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 35
        PictureBox8.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(btnagregar)
        Panel10.Controls.Add(txtSip)
        Panel10.Controls.Add(txtCal)
        Panel10.Controls.Add(txtDir)
        Panel10.Controls.Add(txtTit)
        Panel10.Controls.Add(txtFec)
        Panel10.Controls.Add(txtGen)
        Panel10.Controls.Add(PictureBox1)
        Panel10.Location = New Point(383, 100)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(417, 483)
        Panel10.TabIndex = 45
        ' 
        ' btnagregar
        ' 
        btnagregar.Location = New Point(144, 441)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(75, 23)
        btnagregar.TabIndex = 52
        btnagregar.Text = "Agregar"
        btnagregar.UseVisualStyleBackColor = True
        ' 
        ' txtSip
        ' 
        txtSip.Location = New Point(68, 407)
        txtSip.Name = "txtSip"
        txtSip.PlaceholderText = "Sipnosis"
        txtSip.Size = New Size(221, 23)
        txtSip.TabIndex = 51
        ' 
        ' txtCal
        ' 
        txtCal.Location = New Point(68, 246)
        txtCal.Name = "txtCal"
        txtCal.PlaceholderText = "stock"
        txtCal.Size = New Size(221, 23)
        txtCal.TabIndex = 49
        ' 
        ' txtDir
        ' 
        txtDir.Location = New Point(68, 287)
        txtDir.Name = "txtDir"
        txtDir.PlaceholderText = "Director"
        txtDir.Size = New Size(221, 23)
        txtDir.TabIndex = 50
        ' 
        ' txtTit
        ' 
        txtTit.Location = New Point(68, 202)
        txtTit.Name = "txtTit"
        txtTit.PlaceholderText = "Titulo"
        txtTit.Size = New Size(221, 23)
        txtTit.TabIndex = 47
        ' 
        ' txtFec
        ' 
        txtFec.Location = New Point(68, 329)
        txtFec.Name = "txtFec"
        txtFec.PlaceholderText = "Año"
        txtFec.Size = New Size(221, 23)
        txtFec.TabIndex = 48
        ' 
        ' txtGen
        ' 
        txtGen.Location = New Point(68, 371)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(221, 23)
        txtGen.TabIndex = 46
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(122, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 583)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "admin"
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents AgregarAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnAcep As Button
    Friend WithEvents TextContra As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextTlf As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextApel As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtSip As TextBox
    Friend WithEvents txtCal As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtTit As TextBox
    Friend WithEvents txtFec As TextBox
    Friend WithEvents txtGen As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
