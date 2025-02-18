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
        Id_Aquiler = New ColumnHeader()
        dni = New ColumnHeader()
        id_Pelicula = New ColumnHeader()
        Fecha_Alquiler = New ColumnHeader()
        Fecha_devo = New ColumnHeader()
        Devuelto = New ColumnHeader()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListViewPeliculas
        ' 
        ListViewPeliculas.Columns.AddRange(New ColumnHeader() {Id, Titulo, Director, Año, Genero, Stock, Sinopsis})
        ListViewPeliculas.GridLines = True
        ListViewPeliculas.HeaderStyle = ColumnHeaderStyle.Nonclickable
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
        ListViewAlquiler.Columns.AddRange(New ColumnHeader() {Id_Aquiler, dni, id_Pelicula, Fecha_Alquiler, Fecha_devo, Devuelto})
        ListViewAlquiler.GridLines = True
        ListViewAlquiler.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListViewAlquiler.Location = New Point(12, 515)
        ListViewAlquiler.Name = "ListViewAlquiler"
        ListViewAlquiler.Size = New Size(783, 280)
        ListViewAlquiler.TabIndex = 1
        ListViewAlquiler.UseCompatibleStateImageBehavior = False
        ListViewAlquiler.View = View.Details
        ' 
        ' Id_Aquiler
        ' 
        Id_Aquiler.Text = "Id_Aquiler"
        Id_Aquiler.Width = 80
        ' 
        ' dni
        ' 
        dni.Text = "dni"
        dni.Width = 100
        ' 
        ' id_Pelicula
        ' 
        id_Pelicula.Text = "id_Pelicula(Titulo)"
        id_Pelicula.Width = 200
        ' 
        ' Fecha_Alquiler
        ' 
        Fecha_Alquiler.Text = "Fecha_Alquiler"
        Fecha_Alquiler.Width = 100
        ' 
        ' Fecha_devo
        ' 
        Fecha_devo.Text = "Fecha_devo"
        Fecha_devo.Width = 100
        ' 
        ' Devuelto
        ' 
        Devuelto.Text = "Devuelto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F)
        Label1.Location = New Point(316, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 46)
        Label1.TabIndex = 2
        Label1.Text = "Peliculas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 25F)
        Label2.Location = New Point(316, 466)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 46)
        Label2.TabIndex = 3
        Label2.Text = "Alquilado"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Consultar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 807)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListViewAlquiler)
        Controls.Add(ListViewPeliculas)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Consultar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consultar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
    Friend WithEvents Id_Aquiler As ColumnHeader
    Friend WithEvents dni As ColumnHeader
    Friend WithEvents id_Pelicula As ColumnHeader
    Friend WithEvents Fecha_Alquiler As ColumnHeader
    Friend WithEvents Fecha_devo As ColumnHeader
    Friend WithEvents Devuelto As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
