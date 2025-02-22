<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Titulo = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        btnCerrar = New Button()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Titulo, ColumnHeader1, ColumnHeader2, ColumnHeader3})
        ListView1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 12)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(545, 296)
        ListView1.Sorting = SortOrder.Ascending
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Titulo
        ' 
        Titulo.Text = "Titulo"
        Titulo.Width = 200
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Fecha Alquilado"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Fecha devolucion"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Devuelto"
        ColumnHeader3.Width = 100
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(514, 323)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(75, 23)
        btnCerrar.TabIndex = 1
        btnCerrar.Text = "Salir"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Historial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 348)
        Controls.Add(btnCerrar)
        Controls.Add(ListView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Historial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Historial"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnCerrar As Button
End Class
