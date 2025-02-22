Imports System.Data.SQLite

Public Class Listar
    Private Sub Listar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPeliculas()
    End Sub

    Private Sub CargarPeliculas()
        ' Limpiar el ListView antes de cargar datos nuevos
        ListView1.Items.Clear()

        ' Consulta SQL para obtener todas las películas
        Dim query As String = "SELECT titulo, director, año, genero, sipnosis FROM Pelicula"

        ' Crear un DataTable para almacenar los datos
        Dim dt As New DataTable()

        ' Usar SQLiteDataAdapter y DataSet para cargar los datos
        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt) ' Llenar el DataTable con los datos de la consulta
            End Using
        End Using

        ' Agregar los datos al ListView
        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("titulo").ToString())
            item.SubItems.Add(row("director").ToString())
            item.SubItems.Add(row("año").ToString())
            item.SubItems.Add(row("genero").ToString())
            item.SubItems.Add(row("sipnosis").ToString())

            ' Agregar la fila al ListView
            ListView1.Items.Add(item)
        Next

        ' Verificar si no hay resultados
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("No hay películas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
