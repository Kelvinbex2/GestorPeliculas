<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar))
        ComboTitulo = New ComboBox()
        txtFec = New TextBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnAceptar = New Button()
        txtSip = New TextBox()
        txtStock = New TextBox()
        txtDir = New TextBox()
        txtGen = New TextBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboTitulo
        ' 
        ComboTitulo.FormattingEnabled = True
        ComboTitulo.Location = New Point(51, 106)
        ComboTitulo.Name = "ComboTitulo"
        ComboTitulo.Size = New Size(221, 23)
        ComboTitulo.TabIndex = 0
        ' 
        ' txtFec
        ' 
        txtFec.BackColor = Color.WhiteSmoke
        txtFec.Location = New Point(51, 228)
        txtFec.Name = "txtFec"
        txtFec.PlaceholderText = "Fecha"
        txtFec.Size = New Size(221, 23)
        txtFec.TabIndex = 72
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(25, 306)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(20, 23)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 71
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.WhiteSmoke
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(25, 270)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 23)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 70
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.WhiteSmoke
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(25, 228)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 23)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 69
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.WhiteSmoke
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(25, 186)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 68
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.WhiteSmoke
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(25, 142)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 67
        PictureBox3.TabStop = False
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = SystemColors.Window
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(172), CByte(184), CByte(196))
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Location = New Point(120, 342)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 65
        btnAceptar.Text = "Agregar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' txtSip
        ' 
        txtSip.BackColor = Color.WhiteSmoke
        txtSip.Location = New Point(51, 306)
        txtSip.Name = "txtSip"
        txtSip.PlaceholderText = "Sipnosis"
        txtSip.Size = New Size(221, 23)
        txtSip.TabIndex = 64
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.WhiteSmoke
        txtStock.Location = New Point(51, 145)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "stock"
        txtStock.Size = New Size(221, 23)
        txtStock.TabIndex = 62
        ' 
        ' txtDir
        ' 
        txtDir.BackColor = Color.WhiteSmoke
        txtDir.Location = New Point(51, 186)
        txtDir.Name = "txtDir"
        txtDir.PlaceholderText = "Director"
        txtDir.Size = New Size(221, 23)
        txtDir.TabIndex = 63
        ' 
        ' txtGen
        ' 
        txtGen.BackColor = Color.WhiteSmoke
        txtGen.Location = New Point(51, 270)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(221, 23)
        txtGen.TabIndex = 60
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(25, 106)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 66
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtFec)
        Panel1.Controls.Add(ComboTitulo)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(txtGen)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(txtDir)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(txtStock)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(txtSip)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnAceptar)
        Panel1.Location = New Point(143, 169)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(291, 386)
        Panel1.TabIndex = 73
        ' 
        ' Modificar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 567)
        Controls.Add(Panel1)
        Name = "Modificar"
        Text = "Modificar"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboTitulo As ComboBox
    Friend WithEvents txtFec As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtSip As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtGen As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
