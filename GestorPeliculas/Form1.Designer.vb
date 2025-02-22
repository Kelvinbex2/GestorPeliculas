<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.Turquoise
        ProgressBar1.ForeColor = Color.Turquoise
        ProgressBar1.Location = New Point(150, 300)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(500, 30)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Arial", 20F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(212, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 32)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido a KelvinBex Club"
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(300, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 333)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KelvinBex club"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label

End Class
