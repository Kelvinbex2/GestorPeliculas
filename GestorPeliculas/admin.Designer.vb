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
        txtEmail = New TextBox()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        Panel3 = New Panel()
        TextBox3 = New TextBox()
        Panel4 = New Panel()
        TextBox4 = New TextBox()
        Panel5 = New Panel()
        TextBox5 = New TextBox()
        Panel6 = New Panel()
        TextBox6 = New TextBox()
        Panel7 = New Panel()
        MenuStrip1.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
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
        PictureBox8.Location = New Point(12, 27)
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
        TextBox1.Font = New Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(132, 27)
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
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Control
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Location = New Point(12, 175)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(195, 23)
        txtEmail.TabIndex = 23
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(12, 199)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(195, 1)
        Panel2.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(12, 236)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Email"
        TextBox2.Size = New Size(195, 23)
        TextBox2.TabIndex = 25
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(12, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 1)
        Panel3.TabIndex = 24
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Control
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(12, 308)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Email"
        TextBox3.Size = New Size(195, 23)
        TextBox3.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(12, 332)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(195, 1)
        Panel4.TabIndex = 26
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(12, 383)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Email"
        TextBox4.Size = New Size(195, 23)
        TextBox4.TabIndex = 29
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(12, 407)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(195, 1)
        Panel5.TabIndex = 28
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.Control
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(12, 457)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Email"
        TextBox5.Size = New Size(195, 23)
        TextBox5.TabIndex = 31
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(12, 481)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(195, 1)
        Panel6.TabIndex = 30
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
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 544)
        Controls.Add(TextBox5)
        Controls.Add(Panel6)
        Controls.Add(TextBox4)
        Controls.Add(Panel5)
        Controls.Add(TextBox3)
        Controls.Add(Panel4)
        Controls.Add(TextBox2)
        Controls.Add(Panel3)
        Controls.Add(txtEmail)
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel6 As Panel
End Class
