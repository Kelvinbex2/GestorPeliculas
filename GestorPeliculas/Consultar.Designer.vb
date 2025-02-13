<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar
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
        ListViewPeliculas = New ListView()
        Id = New ColumnHeader()
        Titulo = New ColumnHeader()
        Director = New ColumnHeader()
        Año = New ColumnHeader()
        Genero = New ColumnHeader()
        Stock = New ColumnHeader()
        Sinopsis = New ColumnHeader()
        ListViewAlquiler = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ListViewPeliculas
        ' 
        ListViewPeliculas.Columns.AddRange(New ColumnHeader() {Id, Titulo, Director, Año, Genero, Stock, Sinopsis})
        ListViewPeliculas.Location = New Point(12, 66)
        ListViewPeliculas.Name = "ListViewPeliculas"
        ListViewPeliculas.Size = New Size(776, 389)
        ListViewPeliculas.TabIndex = 0
        ListViewPeliculas.UseCompatibleStateImageBehavior = False
        ListViewPeliculas.View = View.Details
        ' 
        ' Id
        ' 
        Id.Text = "Id"
        Id.Width = 30
        ' 
        ' Titulo
        ' 
        Titulo.Text = "Titulo"
        Titulo.Width = 100
        ' 
        ' Director
        ' 
        Director.Text = "Director"
        Director.Width = 150
        ' 
        ' Año
        ' 
        Año.Text = "Año"
        Año.Width = 100
        ' 
        ' Genero
        ' 
        Genero.Text = "Genero"
        Genero.Width = 120
        ' 
        ' Stock
        ' 
        Stock.Text = "Stock"
        Stock.Width = 50
        ' 
        ' Sinopsis
        ' 
        Sinopsis.Text = "Sinopsis"
        Sinopsis.Width = 1000
        ' 
        ' ListViewAlquiler
        ' 
        ListViewAlquiler.BackColor = SystemColors.InactiveBorder
        ListViewAlquiler.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        ListViewAlquiler.Location = New Point(12, 515)
        ListViewAlquiler.Name = "ListViewAlquiler"
        ListViewAlquiler.Size = New Size(783, 280)
        ListViewAlquiler.TabIndex = 1
        ListViewAlquiler.UseCompatibleStateImageBehavior = False
        ListViewAlquiler.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Id_Aquiler"
        ColumnHeader1.Width = 80
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "dni"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "id_Pelicula"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Fecha_Alquiler"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Fecha_devo"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Devuelto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.0F)
        Label1.Location = New Point(316, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 46)
        Label1.TabIndex = 2
        Label1.Text = "Peliculas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 25.0F)
        Label2.Location = New Point(316, 466)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 46)
        Label2.TabIndex = 3
        Label2.Text = "Alquilado"
        ' 
        ' Consultar
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 807)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListViewAlquiler)
        Controls.Add(ListViewPeliculas)
        Name = "Consultar"
        Text = "Consultar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListViewPeliculas As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents Director As ColumnHeader
    Friend WithEvents Año As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
    Friend WithEvents Stock As ColumnHeader
    Friend WithEvents Sinopsis As ColumnHeader
    Friend WithEvents ListViewAlquiler As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
