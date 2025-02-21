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
        ComboBox1 = New ComboBox()
        txtDirec = New TextBox()
        txtGen = New TextBox()
        txt = New TextBox()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(txt)
        Panel1.Controls.Add(txtGen)
        Panel1.Controls.Add(txtDirec)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 382)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(18, 60)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' txtDirec
        ' 
        txtDirec.Location = New Point(18, 103)
        txtDirec.Name = "txtDirec"
        txtDirec.PlaceholderText = "Director"
        txtDirec.Size = New Size(197, 23)
        txtDirec.TabIndex = 1
        ' 
        ' txtGen
        ' 
        txtGen.Location = New Point(18, 132)
        txtGen.Name = "txtGen"
        txtGen.PlaceholderText = "Genero"
        txtGen.Size = New Size(197, 23)
        txtGen.TabIndex = 2
        ' 
        ' txt
        ' 
        txt.Location = New Point(18, 161)
        txt.Name = "txt"
        txt.PlaceholderText = "Año"
        txt.Size = New Size(197, 23)
        txt.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(18, 190)
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
        Name = "Alquilar"
        Text = "Alquilar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt As TextBox
    Friend WithEvents txtGen As TextBox
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents ComboBox1 As ComboBox


End Class
