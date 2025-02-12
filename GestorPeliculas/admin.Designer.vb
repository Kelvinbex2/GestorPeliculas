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
        PictureBox8 = New PictureBox()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        TextBox6 = New TextBox()
        Panel7 = New Panel()
        txtId = New TextBox()
        Panel2 = New Panel()
        TextBoxNombre = New TextBox()
        Panel3 = New Panel()
        TextApel = New TextBox()
        Panel4 = New Panel()
        TextTlf = New TextBox()
        Panel5 = New Panel()
        TextEmail = New TextBox()
        Panel6 = New Panel()
        TextContra = New TextBox()
        Panel8 = New Panel()
        btnAcep = New Button()
        AgregarAdminToolStripMenuItem = New ToolStripMenuItem()
        BajaUnClienteToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, AgregarAdminToolStripMenuItem, BajaUnClienteToolStripMenuItem})
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
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(12, 68)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(114, 109)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 19
        PictureBox8.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Enabled = False
        TextBox1.Font = New Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0)
        TextBox1.Location = New Point(168, 178)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 51)
        TextBox1.TabIndex = 20
        TextBox1.Text = "Bienvenido"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Panel7)
        Panel1.Location = New Point(413, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 520)
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
        ' txtId
        ' 
        txtId.BackColor = SystemColors.Control
        txtId.BorderStyle = BorderStyle.None
        txtId.Location = New Point(10, 255)
        txtId.Multiline = True
        txtId.Name = "txtId"
        txtId.PlaceholderText = "Id"
        txtId.Size = New Size(195, 23)
        txtId.TabIndex = 23
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(10, 279)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(195, 1)
        Panel2.TabIndex = 22
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.BackColor = SystemColors.Control
        TextBoxNombre.BorderStyle = BorderStyle.None
        TextBoxNombre.Location = New Point(10, 302)
        TextBoxNombre.Multiline = True
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.PlaceholderText = "Nombre"
        TextBoxNombre.Size = New Size(195, 23)
        TextBoxNombre.TabIndex = 25
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(10, 326)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 1)
        Panel3.TabIndex = 24
        ' 
        ' TextApel
        ' 
        TextApel.BackColor = SystemColors.Control
        TextApel.BorderStyle = BorderStyle.None
        TextApel.Location = New Point(10, 346)
        TextApel.Multiline = True
        TextApel.Name = "TextApel"
        TextApel.PlaceholderText = "Apellido"
        TextApel.Size = New Size(195, 23)
        TextApel.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(10, 370)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(195, 1)
        Panel4.TabIndex = 26
        ' 
        ' TextTlf
        ' 
        TextTlf.BackColor = SystemColors.Control
        TextTlf.BorderStyle = BorderStyle.None
        TextTlf.Location = New Point(10, 390)
        TextTlf.Multiline = True
        TextTlf.Name = "TextTlf"
        TextTlf.PlaceholderText = "Telefono"
        TextTlf.Size = New Size(195, 23)
        TextTlf.TabIndex = 29
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(10, 414)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(195, 1)
        Panel5.TabIndex = 28
        ' 
        ' TextEmail
        ' 
        TextEmail.BackColor = SystemColors.Control
        TextEmail.BorderStyle = BorderStyle.None
        TextEmail.Location = New Point(10, 431)
        TextEmail.Multiline = True
        TextEmail.Name = "TextEmail"
        TextEmail.PlaceholderText = "Email"
        TextEmail.Size = New Size(195, 23)
        TextEmail.TabIndex = 31
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(10, 455)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(195, 1)
        Panel6.TabIndex = 30
        ' 
        ' TextContra
        ' 
        TextContra.BackColor = SystemColors.Control
        TextContra.BorderStyle = BorderStyle.None
        TextContra.Location = New Point(10, 473)
        TextContra.Multiline = True
        TextContra.Name = "TextContra"
        TextContra.PlaceholderText = "Contraseña"
        TextContra.Size = New Size(195, 23)
        TextContra.TabIndex = 33
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(10, 497)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(195, 1)
        Panel8.TabIndex = 32
        ' 
        ' btnAcep
        ' 
        btnAcep.Location = New Point(101, 524)
        btnAcep.Name = "btnAcep"
        btnAcep.Size = New Size(75, 23)
        btnAcep.TabIndex = 34
        btnAcep.Text = "Aceptar"
        btnAcep.UseVisualStyleBackColor = True
        ' 
        ' AgregarAdminToolStripMenuItem
        ' 
        AgregarAdminToolStripMenuItem.Name = "AgregarAdminToolStripMenuItem"
        AgregarAdminToolStripMenuItem.Size = New Size(98, 20)
        AgregarAdminToolStripMenuItem.Text = "Agregar admin"
        ' 
        ' BajaUnClienteToolStripMenuItem
        ' 
        BajaUnClienteToolStripMenuItem.Name = "BajaUnClienteToolStripMenuItem"
        BajaUnClienteToolStripMenuItem.Size = New Size(96, 20)
        BajaUnClienteToolStripMenuItem.Text = "Baja un cliente"
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 583)
        Controls.Add(btnAcep)
        Controls.Add(TextContra)
        Controls.Add(Panel8)
        Controls.Add(TextEmail)
        Controls.Add(Panel6)
        Controls.Add(TextTlf)
        Controls.Add(Panel5)
        Controls.Add(TextApel)
        Controls.Add(Panel4)
        Controls.Add(TextBoxNombre)
        Controls.Add(Panel3)
        Controls.Add(txtId)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "admin"
        Text = "admin"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtId As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextApel As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextTlf As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextContra As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents AgregarAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaUnClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAcep As Button
End Class
