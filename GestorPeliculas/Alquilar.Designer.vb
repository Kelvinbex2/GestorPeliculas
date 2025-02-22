<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquilar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alquilar))
        Panel1 = New Panel()
        Button1 = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtAño = New TextBox()
        CheckBox1 = New CheckBox()
        txtGen = New TextBox()
        txtDirec = New TextBox()
        ComboBox1 = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtAño)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(txtGen)
        Panel1.Controls.Add(txtDirec)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(134, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(297, 338)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(3, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 23)
        Button1.TabIndex = 13
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.GhostWhite
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(30, 249)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 23)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.GhostWhite
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(30, 220)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.GhostWhite
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(30, 191)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.GhostWhite
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(30, 162)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 131)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtAño
        ' 
        txtAño.Font = New Font("Segoe UI", 9F)
        txtAño.Location = New Point(56, 249)
        txtAño.Name = "txtAño"
        txtAño.PlaceholderText = "Año"
        txtAño.Size = New Size(179, 23)
        txtAño.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.White
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        CheckBox1.Location = New Point(155, 278)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(81, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "¿Alquilar ?"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' txtGen
        ' 
        txtGen.Location = New Point(56, 220)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(179, 23)
        txtGen.TabIndex = 2
        ' 
        ' txtDirec
        ' 
        txtDirec.Location = New Point(56, 191)
        txtDirec.Name = "txtDirec"
        txtDirec.PlaceholderText = "Director"
        txtDirec.Size = New Size(179, 23)
        txtDirec.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(56, 162)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(179, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Alquilar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(551, 450)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Alquilar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alquilar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtGen As TextBox
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button


End Class
