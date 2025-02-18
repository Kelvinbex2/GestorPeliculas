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
        PictureBox8 = New PictureBox()
        txtId = New TextBox()
        sal = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboTitulo
        ' 
        ComboTitulo.FormattingEnabled = True
        ComboTitulo.Location = New Point(43, 150)
        ComboTitulo.Name = "ComboTitulo"
        ComboTitulo.Size = New Size(221, 23)
        ComboTitulo.TabIndex = 0
        ' 
        ' txtFec
        ' 
        txtFec.BackColor = Color.WhiteSmoke
        txtFec.Location = New Point(43, 276)
        txtFec.Name = "txtFec"
        txtFec.PlaceholderText = "Fecha"
        txtFec.Size = New Size(221, 23)
        txtFec.TabIndex = 72
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.WhiteSmoke
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(17, 354)
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
        PictureBox6.Location = New Point(17, 318)
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
        PictureBox5.Location = New Point(17, 276)
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
        PictureBox4.Location = New Point(17, 234)
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
        PictureBox3.Location = New Point(17, 190)
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
        btnAceptar.Location = New Point(112, 390)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 65
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' txtSip
        ' 
        txtSip.BackColor = Color.WhiteSmoke
        txtSip.Location = New Point(43, 354)
        txtSip.Name = "txtSip"
        txtSip.PlaceholderText = "Sipnosis"
        txtSip.Size = New Size(221, 23)
        txtSip.TabIndex = 64
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.WhiteSmoke
        txtStock.Location = New Point(43, 193)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "stock"
        txtStock.Size = New Size(221, 23)
        txtStock.TabIndex = 62
        ' 
        ' txtDir
        ' 
        txtDir.BackColor = Color.WhiteSmoke
        txtDir.Location = New Point(43, 234)
        txtDir.Name = "txtDir"
        txtDir.PlaceholderText = "Director"
        txtDir.Size = New Size(221, 23)
        txtDir.TabIndex = 63
        ' 
        ' txtGen
        ' 
        txtGen.BackColor = Color.WhiteSmoke
        txtGen.Location = New Point(43, 318)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(221, 23)
        txtGen.TabIndex = 60
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 150)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 66
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(ComboTitulo)
        Panel1.Controls.Add(txtFec)
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
        Panel1.Location = New Point(41, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(291, 430)
        Panel1.TabIndex = 73
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.GhostWhite
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(17, 114)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(20, 23)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 75
        PictureBox8.TabStop = False
        ' 
        ' txtId
        ' 
        txtId.BackColor = Color.WhiteSmoke
        txtId.Enabled = False
        txtId.Location = New Point(43, 114)
        txtId.Name = "txtId"
        txtId.PlaceholderText = "Id"
        txtId.Size = New Size(221, 23)
        txtId.TabIndex = 73
        ' 
        ' sal
        ' 
        sal.Location = New Point(338, 450)
        sal.Name = "sal"
        sal.Size = New Size(61, 23)
        sal.TabIndex = 74
        sal.Text = "Salir"
        sal.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(91, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 75
        PictureBox1.TabStop = False
        ' 
        ' Modificar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(411, 505)
        Controls.Add(sal)
        Controls.Add(Panel1)
        Name = "Modificar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Modificar"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sal As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
