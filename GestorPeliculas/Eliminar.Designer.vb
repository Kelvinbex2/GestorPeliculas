<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar))
        Panel1 = New Panel()
        btnAcpAdmin = New Button()
        TextEmail = New TextBox()
        Panel6 = New Panel()
        TextTlf = New TextBox()
        Panel5 = New Panel()
        TextApel = New TextBox()
        Panel4 = New Panel()
        TextBoxNombre = New TextBox()
        Panel7 = New Panel()
        lbAdmin = New Label()
        ComboBoxGmailAmin = New ComboBox()
        PictureBox8 = New PictureBox()
        Panel2 = New Panel()
        btnAcpUser = New Button()
        txtEmailUser = New TextBox()
        Label3 = New Label()
        Panel8 = New Panel()
        ComboboxGmailDni = New ComboBox()
        txtTlfUser = New TextBox()
        PictureBox1 = New PictureBox()
        Panel9 = New Panel()
        txtNomUser = New TextBox()
        txtApelUser = New TextBox()
        Panel11 = New Panel()
        Panel10 = New Panel()
        Panel3 = New Panel()
        btnAcpPeli = New Button()
        txtSip = New TextBox()
        Label5 = New Label()
        Panel12 = New Panel()
        ComboTitulo = New ComboBox()
        txtFecha = New TextBox()
        PictureBox2 = New PictureBox()
        Panel13 = New Panel()
        txtDirec = New TextBox()
        Panel15 = New Panel()
        txtGenero = New TextBox()
        Panel14 = New Panel()
        Panel16 = New Panel()
        Panel17 = New Panel()
        MenuStrip1 = New MenuStrip()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        AdministradorToolStripMenuItem = New ToolStripMenuItem()
        UsuarioToolStripMenuItem = New ToolStripMenuItem()
        PeliculaToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnAcpAdmin)
        Panel1.Controls.Add(TextEmail)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(TextTlf)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(TextApel)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(TextBoxNombre)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(lbAdmin)
        Panel1.Controls.Add(ComboBoxGmailAmin)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Location = New Point(12, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 426)
        Panel1.TabIndex = 0
        ' 
        ' btnAcpAdmin
        ' 
        btnAcpAdmin.Location = New Point(70, 343)
        btnAcpAdmin.Name = "btnAcpAdmin"
        btnAcpAdmin.Size = New Size(75, 23)
        btnAcpAdmin.TabIndex = 56
        btnAcpAdmin.Text = "Aceptar"
        btnAcpAdmin.UseVisualStyleBackColor = True
        ' 
        ' TextEmail
        ' 
        TextEmail.BackColor = SystemColors.Window
        TextEmail.BorderStyle = BorderStyle.None
        TextEmail.Enabled = False
        TextEmail.Location = New Point(15, 303)
        TextEmail.Multiline = True
        TextEmail.Name = "TextEmail"
        TextEmail.PlaceholderText = "Email"
        TextEmail.Size = New Size(195, 23)
        TextEmail.TabIndex = 55
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(15, 327)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(195, 1)
        Panel6.TabIndex = 54
        ' 
        ' TextTlf
        ' 
        TextTlf.BackColor = SystemColors.Window
        TextTlf.BorderStyle = BorderStyle.None
        TextTlf.Enabled = False
        TextTlf.Location = New Point(15, 262)
        TextTlf.Multiline = True
        TextTlf.Name = "TextTlf"
        TextTlf.PlaceholderText = "Telefono"
        TextTlf.Size = New Size(195, 23)
        TextTlf.TabIndex = 53
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(15, 286)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(195, 1)
        Panel5.TabIndex = 52
        ' 
        ' TextApel
        ' 
        TextApel.BackColor = SystemColors.Window
        TextApel.BorderStyle = BorderStyle.None
        TextApel.Enabled = False
        TextApel.Location = New Point(15, 218)
        TextApel.Multiline = True
        TextApel.Name = "TextApel"
        TextApel.PlaceholderText = "Apellidos"
        TextApel.Size = New Size(195, 23)
        TextApel.TabIndex = 51
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(15, 242)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(195, 1)
        Panel4.TabIndex = 50
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.BackColor = SystemColors.Window
        TextBoxNombre.BorderStyle = BorderStyle.None
        TextBoxNombre.Enabled = False
        TextBoxNombre.Location = New Point(15, 174)
        TextBoxNombre.Multiline = True
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.PlaceholderText = "Nombre"
        TextBoxNombre.Size = New Size(195, 23)
        TextBoxNombre.TabIndex = 49
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(15, 198)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(195, 1)
        Panel7.TabIndex = 48
        ' 
        ' lbAdmin
        ' 
        lbAdmin.AutoSize = True
        lbAdmin.Location = New Point(92, 72)
        lbAdmin.Name = "lbAdmin"
        lbAdmin.Size = New Size(43, 15)
        lbAdmin.TabIndex = 39
        lbAdmin.Text = "Admin"
        ' 
        ' ComboBoxGmailAmin
        ' 
        ComboBoxGmailAmin.FormattingEnabled = True
        ComboBoxGmailAmin.Location = New Point(15, 126)
        ComboBoxGmailAmin.Name = "ComboBoxGmailAmin"
        ComboBoxGmailAmin.Size = New Size(195, 23)
        ComboBoxGmailAmin.TabIndex = 1
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(3, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(83, 84)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 36
        PictureBox8.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnAcpUser)
        Panel2.Controls.Add(txtEmailUser)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(ComboboxGmailDni)
        Panel2.Controls.Add(txtTlfUser)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(txtNomUser)
        Panel2.Controls.Add(txtApelUser)
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(Panel10)
        Panel2.Location = New Point(278, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(227, 426)
        Panel2.TabIndex = 1
        ' 
        ' btnAcpUser
        ' 
        btnAcpUser.Location = New Point(73, 343)
        btnAcpUser.Name = "btnAcpUser"
        btnAcpUser.Size = New Size(75, 23)
        btnAcpUser.TabIndex = 64
        btnAcpUser.Text = "Aceptar"
        btnAcpUser.UseVisualStyleBackColor = True
        ' 
        ' txtEmailUser
        ' 
        txtEmailUser.BackColor = SystemColors.Window
        txtEmailUser.BorderStyle = BorderStyle.None
        txtEmailUser.Enabled = False
        txtEmailUser.Location = New Point(19, 305)
        txtEmailUser.Multiline = True
        txtEmailUser.Name = "txtEmailUser"
        txtEmailUser.PlaceholderText = "Email"
        txtEmailUser.Size = New Size(195, 23)
        txtEmailUser.TabIndex = 63
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 39
        Label3.Text = "Usuario"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(19, 329)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(195, 1)
        Panel8.TabIndex = 62
        ' 
        ' ComboboxGmailDni
        ' 
        ComboboxGmailDni.FormattingEnabled = True
        ComboboxGmailDni.Location = New Point(19, 126)
        ComboboxGmailDni.Name = "ComboboxGmailDni"
        ComboboxGmailDni.Size = New Size(195, 23)
        ComboboxGmailDni.TabIndex = 1
        ' 
        ' txtTlfUser
        ' 
        txtTlfUser.BackColor = SystemColors.Window
        txtTlfUser.BorderStyle = BorderStyle.None
        txtTlfUser.Enabled = False
        txtTlfUser.Location = New Point(19, 264)
        txtTlfUser.Multiline = True
        txtTlfUser.Name = "txtTlfUser"
        txtTlfUser.PlaceholderText = "Telefono"
        txtTlfUser.Size = New Size(195, 23)
        txtTlfUser.TabIndex = 61
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.ActiveCaptionText
        Panel9.Location = New Point(19, 288)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(195, 1)
        Panel9.TabIndex = 60
        ' 
        ' txtNomUser
        ' 
        txtNomUser.BackColor = SystemColors.Window
        txtNomUser.BorderStyle = BorderStyle.None
        txtNomUser.Enabled = False
        txtNomUser.Location = New Point(19, 176)
        txtNomUser.Multiline = True
        txtNomUser.Name = "txtNomUser"
        txtNomUser.PlaceholderText = "Nombre"
        txtNomUser.Size = New Size(195, 23)
        txtNomUser.TabIndex = 57
        ' 
        ' txtApelUser
        ' 
        txtApelUser.BackColor = SystemColors.Window
        txtApelUser.BorderStyle = BorderStyle.None
        txtApelUser.Enabled = False
        txtApelUser.Location = New Point(19, 220)
        txtApelUser.Multiline = True
        txtApelUser.Name = "txtApelUser"
        txtApelUser.PlaceholderText = "Apellidos"
        txtApelUser.Size = New Size(195, 23)
        txtApelUser.TabIndex = 59
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = SystemColors.ActiveCaptionText
        Panel11.Location = New Point(19, 200)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(195, 1)
        Panel11.TabIndex = 56
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.ActiveCaptionText
        Panel10.Location = New Point(19, 244)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(195, 1)
        Panel10.TabIndex = 58
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnAcpPeli)
        Panel3.Controls.Add(txtSip)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Panel12)
        Panel3.Controls.Add(ComboTitulo)
        Panel3.Controls.Add(txtFecha)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Panel13)
        Panel3.Controls.Add(txtDirec)
        Panel3.Controls.Add(Panel15)
        Panel3.Controls.Add(txtGenero)
        Panel3.Controls.Add(Panel14)
        Panel3.Location = New Point(543, 76)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(227, 426)
        Panel3.TabIndex = 41
        ' 
        ' btnAcpPeli
        ' 
        btnAcpPeli.Location = New Point(81, 343)
        btnAcpPeli.Name = "btnAcpPeli"
        btnAcpPeli.Size = New Size(75, 23)
        btnAcpPeli.TabIndex = 65
        btnAcpPeli.Text = "Aceptar"
        btnAcpPeli.UseVisualStyleBackColor = True
        ' 
        ' txtSip
        ' 
        txtSip.BackColor = SystemColors.Window
        txtSip.BorderStyle = BorderStyle.None
        txtSip.Enabled = False
        txtSip.Location = New Point(12, 303)
        txtSip.Multiline = True
        txtSip.Name = "txtSip"
        txtSip.PlaceholderText = "Sipnosis"
        txtSip.Size = New Size(195, 23)
        txtSip.TabIndex = 71
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(92, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 39
        Label5.Text = "Peliculas"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = SystemColors.ActiveCaptionText
        Panel12.Location = New Point(12, 327)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(195, 1)
        Panel12.TabIndex = 70
        ' 
        ' ComboTitulo
        ' 
        ComboTitulo.FormattingEnabled = True
        ComboTitulo.Location = New Point(12, 126)
        ComboTitulo.Name = "ComboTitulo"
        ComboTitulo.Size = New Size(195, 23)
        ComboTitulo.TabIndex = 1
        ' 
        ' txtFecha
        ' 
        txtFecha.BackColor = SystemColors.Window
        txtFecha.BorderStyle = BorderStyle.None
        txtFecha.Enabled = False
        txtFecha.Location = New Point(12, 262)
        txtFecha.Multiline = True
        txtFecha.Name = "txtFecha"
        txtFecha.PlaceholderText = "Fecha"
        txtFecha.Size = New Size(195, 23)
        txtFecha.TabIndex = 69
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(83, 84)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = SystemColors.ActiveCaptionText
        Panel13.Location = New Point(12, 286)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(195, 1)
        Panel13.TabIndex = 68
        ' 
        ' txtDirec
        ' 
        txtDirec.BackColor = SystemColors.Window
        txtDirec.BorderStyle = BorderStyle.None
        txtDirec.Enabled = False
        txtDirec.Location = New Point(12, 174)
        txtDirec.Multiline = True
        txtDirec.Name = "txtDirec"
        txtDirec.PlaceholderText = "Director"
        txtDirec.Size = New Size(195, 23)
        txtDirec.TabIndex = 65
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = SystemColors.ActiveCaptionText
        Panel15.Location = New Point(12, 242)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(195, 1)
        Panel15.TabIndex = 66
        ' 
        ' txtGenero
        ' 
        txtGenero.BackColor = SystemColors.Window
        txtGenero.BorderStyle = BorderStyle.None
        txtGenero.Enabled = False
        txtGenero.Location = New Point(12, 218)
        txtGenero.Multiline = True
        txtGenero.Name = "txtGenero"
        txtGenero.PlaceholderText = "Genero"
        txtGenero.Size = New Size(195, 23)
        txtGenero.TabIndex = 67
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = SystemColors.ActiveCaptionText
        Panel14.Location = New Point(12, 198)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(195, 1)
        Panel14.TabIndex = 64
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = SystemColors.ActiveCaptionText
        Panel16.Location = New Point(256, 76)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(1, 426)
        Panel16.TabIndex = 42
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = SystemColors.ActiveCaptionText
        Panel17.Location = New Point(523, 76)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(1, 426)
        Panel17.TabIndex = 43
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {EliminarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(792, 24)
        MenuStrip1.TabIndex = 44
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdministradorToolStripMenuItem, UsuarioToolStripMenuItem, PeliculaToolStripMenuItem})
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(62, 20)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' AdministradorToolStripMenuItem
        ' 
        AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        AdministradorToolStripMenuItem.Size = New Size(150, 22)
        AdministradorToolStripMenuItem.Text = "Administrador"
        ' 
        ' UsuarioToolStripMenuItem
        ' 
        UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        UsuarioToolStripMenuItem.Size = New Size(150, 22)
        UsuarioToolStripMenuItem.Text = "Usuario"
        ' 
        ' PeliculaToolStripMenuItem
        ' 
        PeliculaToolStripMenuItem.Name = "PeliculaToolStripMenuItem"
        PeliculaToolStripMenuItem.Size = New Size(150, 22)
        PeliculaToolStripMenuItem.Text = "Pelicula"
        ' 
        ' Eliminar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 560)
        Controls.Add(Panel17)
        Controls.Add(Panel16)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Eliminar"
        Text = "Eliminar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxGmailAmin As ComboBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lbAdmin As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboboxGmailDni As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboTitulo As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextTlf As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextApel As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtEmailUser As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtTlfUser As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtNomUser As TextBox
    Friend WithEvents txtApelUser As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtSip As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents btnAcpAdmin As Button
    Friend WithEvents btnAcpUser As Button
    Friend WithEvents btnAcpPeli As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeliculaToolStripMenuItem As ToolStripMenuItem
End Class
