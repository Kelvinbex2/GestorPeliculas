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
        Panel1 = New Panel()
        txtCorreo = New TextBox()
        txtDniCliente = New TextBox()
        txtAño = New TextBox()
        txtGen = New TextBox()
        txtDirec = New TextBox()
        ComboBox1 = New ComboBox()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtCorreo)
        Panel1.Controls.Add(txtDniCliente)
        Panel1.Controls.Add(txtAño)
        Panel1.Controls.Add(txtGen)
        Panel1.Controls.Add(txtDirec)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 382)
        Panel1.TabIndex = 0
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(18, 219)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(197, 23)
        txtCorreo.TabIndex = 6
        ' 
        ' txtDniCliente
        ' 
        txtDniCliente.Location = New Point(18, 190)
        txtDniCliente.Name = "txtDniCliente"
        txtDniCliente.PlaceholderText = "Dni"
        txtDniCliente.Size = New Size(197, 23)
        txtDniCliente.TabIndex = 5
        ' 
        ' txtAño
        ' 
        txtAño.Location = New Point(18, 161)
        txtAño.Name = "txtAño"
        txtAño.PlaceholderText = "Año"
        txtAño.Size = New Size(197, 23)
        txtAño.TabIndex = 3
        ' 
        ' txtGen
        ' 
        txtGen.Location = New Point(18, 132)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(197, 23)
        txtGen.TabIndex = 2
        ' 
        ' txtDirec
        ' 
        txtDirec.Location = New Point(18, 103)
        txtDirec.Name = "txtDirec"
        txtDirec.PlaceholderText = "Director"
        txtDirec.Size = New Size(197, 23)
        txtDirec.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(18, 60)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(458, 224)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(80, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "¿Alquilar ?"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Alquilar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(CheckBox1)
        Name = "Alquilar"
        Text = "Alquilar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtGen As TextBox
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDniCliente As TextBox


End Class
