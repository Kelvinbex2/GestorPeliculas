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
        CerrarSessionToolStripMenuItem = New ToolStripMenuItem()
        ConsultarToolStripMenuItem = New ToolStripMenuItem()
        OperacionesToolStripMenuItem = New ToolStripMenuItem()
        AgregarAdminToolStripMenuItem = New ToolStripMenuItem()
        AgregarPeliculaToolStripMenuItem = New ToolStripMenuItem()
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
        txtFec = New TextBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnagregar = New Button()
        txtSip = New TextBox()
        txtCal = New TextBox()
        txtDir = New TextBox()
        txtTit = New TextBox()
        txtGen = New TextBox()
        PictureBox1 = New PictureBox()
        Panel7 = New Panel()
        TextBox6 = New TextBox()
        Panel1 = New Panel()
        lblMsg = New Label()
        lbluser = New Label()
        MenuStrip1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, AgregarAdminToolStripMenuItem, AgregarPeliculaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(742, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarSessionToolStripMenuItem, ConsultarToolStripMenuItem, OperacionesToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' CerrarSessionToolStripMenuItem
        ' 
        CerrarSessionToolStripMenuItem.Name = "CerrarSessionToolStripMenuItem"
        CerrarSessionToolStripMenuItem.Size = New Size(180, 22)
        CerrarSessionToolStripMenuItem.Text = "Cerrar session"
        ' 
        ' ConsultarToolStripMenuItem
        ' 
        ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        ConsultarToolStripMenuItem.Size = New Size(180, 22)
        ConsultarToolStripMenuItem.Text = "Consultar Peliculas"
        ' 
        ' OperacionesToolStripMenuItem
        ' 
        OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        OperacionesToolStripMenuItem.Size = New Size(180, 22)
        OperacionesToolStripMenuItem.Text = "Eliminar "
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
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.Fixed3D
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
        Panel9.Size = New Size(345, 436)
        Panel9.TabIndex = 44
        ' 
        ' btnAcep
        ' 
        btnAcep.BackColor = SystemColors.Window
        btnAcep.FlatAppearance.BorderSize = 0
        btnAcep.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnAcep.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnAcep.FlatStyle = FlatStyle.Flat
        btnAcep.Location = New Point(133, 375)
        btnAcep.Name = "btnAcep"
        btnAcep.Size = New Size(75, 23)
        btnAcep.TabIndex = 48
        btnAcep.Text = "Aceptar"
        btnAcep.UseVisualStyleBackColor = False
        ' 
        ' TextContra
        ' 
        TextContra.BackColor = Color.WhiteSmoke
        TextContra.BorderStyle = BorderStyle.None
        TextContra.Location = New Point(79, 329)
        TextContra.Multiline = True
        TextContra.Name = "TextContra"
        TextContra.PlaceholderText = "Contraseña"
        TextContra.Size = New Size(195, 23)
        TextContra.TabIndex = 47
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(79, 353)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(195, 1)
        Panel8.TabIndex = 46
        ' 
        ' TextEmail
        ' 
        TextEmail.BackColor = Color.WhiteSmoke
        TextEmail.BorderStyle = BorderStyle.None
        TextEmail.Location = New Point(79, 287)
        TextEmail.Multiline = True
        TextEmail.Name = "TextEmail"
        TextEmail.PlaceholderText = "Email"
        TextEmail.Size = New Size(195, 23)
        TextEmail.TabIndex = 45
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(79, 311)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(195, 1)
        Panel6.TabIndex = 44
        ' 
        ' TextTlf
        ' 
        TextTlf.BackColor = Color.WhiteSmoke
        TextTlf.BorderStyle = BorderStyle.None
        TextTlf.Location = New Point(79, 246)
        TextTlf.Multiline = True
        TextTlf.Name = "TextTlf"
        TextTlf.PlaceholderText = "Telefono"
        TextTlf.Size = New Size(195, 23)
        TextTlf.TabIndex = 43
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(79, 270)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(195, 1)
        Panel5.TabIndex = 42
        ' 
        ' TextApel
        ' 
        TextApel.BackColor = Color.WhiteSmoke
        TextApel.BorderStyle = BorderStyle.None
        TextApel.Location = New Point(79, 202)
        TextApel.Multiline = True
        TextApel.Name = "TextApel"
        TextApel.PlaceholderText = "Apellido"
        TextApel.Size = New Size(195, 23)
        TextApel.TabIndex = 41
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(79, 226)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(195, 1)
        Panel4.TabIndex = 40
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.BackColor = Color.WhiteSmoke
        TextBoxNombre.BorderStyle = BorderStyle.None
        TextBoxNombre.Location = New Point(79, 158)
        TextBoxNombre.Multiline = True
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.PlaceholderText = "Nombre"
        TextBoxNombre.Size = New Size(195, 23)
        TextBoxNombre.TabIndex = 39
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(79, 182)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 1)
        Panel3.TabIndex = 38
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(127, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(107, 110)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 35
        PictureBox8.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(txtFec)
        Panel10.Controls.Add(PictureBox7)
        Panel10.Controls.Add(PictureBox6)
        Panel10.Controls.Add(PictureBox5)
        Panel10.Controls.Add(PictureBox4)
        Panel10.Controls.Add(PictureBox3)
        Panel10.Controls.Add(PictureBox2)
        Panel10.Controls.Add(btnagregar)
        Panel10.Controls.Add(txtSip)
        Panel10.Controls.Add(txtCal)
        Panel10.Controls.Add(txtDir)
        Panel10.Controls.Add(txtTit)
        Panel10.Controls.Add(txtGen)
        Panel10.Controls.Add(PictureBox1)
        Panel10.Location = New Point(385, 100)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(345, 436)
        Panel10.TabIndex = 45
        ' 
        ' txtFec
        ' 
        txtFec.BackColor = Color.WhiteSmoke
        txtFec.Location = New Point(74, 266)
        txtFec.Name = "txtFec"
        txtFec.PlaceholderText = "Fecha"
        txtFec.Size = New Size(221, 23)
        txtFec.TabIndex = 59
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(48, 344)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(20, 23)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 58
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.WhiteSmoke
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(48, 308)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 23)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 57
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.WhiteSmoke
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(48, 266)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 23)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 56
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.WhiteSmoke
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(48, 224)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 55
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.WhiteSmoke
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(48, 180)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 54
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(48, 139)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 53
        PictureBox2.TabStop = False
        ' 
        ' btnagregar
        ' 
        btnagregar.BackColor = SystemColors.Window
        btnagregar.FlatAppearance.BorderSize = 0
        btnagregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnagregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnagregar.FlatStyle = FlatStyle.Flat
        btnagregar.Location = New Point(143, 380)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(75, 23)
        btnagregar.TabIndex = 52
        btnagregar.Text = "Agregar"
        btnagregar.UseVisualStyleBackColor = False
        ' 
        ' txtSip
        ' 
        txtSip.BackColor = Color.WhiteSmoke
        txtSip.Location = New Point(74, 344)
        txtSip.Name = "txtSip"
        txtSip.PlaceholderText = "Sipnosis"
        txtSip.Size = New Size(221, 23)
        txtSip.TabIndex = 51
        ' 
        ' txtCal
        ' 
        txtCal.BackColor = Color.WhiteSmoke
        txtCal.Location = New Point(74, 183)
        txtCal.Name = "txtCal"
        txtCal.PlaceholderText = "stock"
        txtCal.Size = New Size(221, 23)
        txtCal.TabIndex = 49
        ' 
        ' txtDir
        ' 
        txtDir.BackColor = Color.WhiteSmoke
        txtDir.Location = New Point(74, 224)
        txtDir.Name = "txtDir"
        txtDir.PlaceholderText = "Director"
        txtDir.Size = New Size(221, 23)
        txtDir.TabIndex = 50
        ' 
        ' txtTit
        ' 
        txtTit.BackColor = Color.WhiteSmoke
        txtTit.Location = New Point(74, 139)
        txtTit.Name = "txtTit"
        txtTit.PlaceholderText = "Titulo"
        txtTit.Size = New Size(221, 23)
        txtTit.TabIndex = 47
        ' 
        ' txtGen
        ' 
        txtGen.BackColor = Color.WhiteSmoke
        txtGen.Location = New Point(74, 308)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(221, 23)
        txtGen.TabIndex = 46
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(131, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(-97, 272)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(195, 1)
        Panel7.TabIndex = 3
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
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Panel7)
        Panel1.ForeColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(370, 103)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 436)
        Panel1.TabIndex = 21
        ' 
        ' lblMsg
        ' 
        lblMsg.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        lblMsg.Location = New Point(316, 51)
        lblMsg.Name = "lblMsg"
        lblMsg.Size = New Size(112, 23)
        lblMsg.TabIndex = 46
        lblMsg.Text = "Bienvenido"
        lblMsg.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbluser
        ' 
        lbluser.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic)
        lbluser.Location = New Point(0, 74)
        lbluser.Name = "lbluser"
        lbluser.Size = New Size(742, 23)
        lbluser.TabIndex = 47
        lbluser.Text = "user"
        lbluser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(742, 600)
        Controls.Add(lbluser)
        Controls.Add(lblMsg)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "admin"
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents txtGen As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents CerrarSessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
End Class
