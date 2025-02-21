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
        lblAnño = New Label()
        Titulo = New Label()
        checkAquila = New CheckBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lblAnño)
        Panel1.Controls.Add(Titulo)
        Panel1.Controls.Add(checkAquila)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(179, 124)
        Panel1.TabIndex = 0
        ' 
        ' lblAnño
        ' 
        lblAnño.Location = New Point(3, 93)
        lblAnño.Name = "lblAnño"
        lblAnño.Size = New Size(173, 23)
        lblAnño.TabIndex = 3
        lblAnño.Text = "Año"
        lblAnño.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Titulo
        ' 
        Titulo.Location = New Point(3, 70)
        Titulo.Name = "Titulo"
        Titulo.Size = New Size(173, 23)
        Titulo.TabIndex = 2
        Titulo.Text = "Titulo"
        Titulo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' checkAquila
        ' 
        checkAquila.AutoSize = True
        checkAquila.Location = New Point(79, 18)
        checkAquila.Name = "checkAquila"
        checkAquila.Size = New Size(63, 19)
        checkAquila.TabIndex = 1
        checkAquila.Text = "Alquila"
        checkAquila.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 47)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Titulo As Label
    Friend WithEvents checkAquila As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAnño As Label

    
End Class
