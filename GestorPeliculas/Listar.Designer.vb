<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        MenuStrip1 = New MenuStrip()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(12, 27)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(727, 411)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Titulo"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Director"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Año"
        ColumnHeader3.Width = 80
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Genero"
        ColumnHeader4.Width = 120
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Sipnosis"
        ColumnHeader5.Width = 500
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(766, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Listar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(766, 450)
        Controls.Add(ListView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Listar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Listar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
