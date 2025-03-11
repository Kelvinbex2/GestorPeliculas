Imports System.Data.SQLite

Public Class Consultar
    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Administrador.CargarPeliculasEnListView(ListViewPeliculas)
        Administrador.CargarAlquileresEnListView(ListViewAlquiler)
    End Sub


    Private Sub ListViewPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewPeliculas.SelectedIndexChanged
        If ListViewPeliculas.SelectedItems.Count = 0 Then Exit Sub

        Dim idPeli As Integer = CInt(ListViewPeliculas.SelectedItems(0).SubItems(0).Text) ' Obtener el id_peli de la película seleccionada

        CargarAlquileresDePelicula(idPeli)
    End Sub

    Public Sub CargarAlquileresDePelicula(idPeli As Integer)
        Dim query As String = "SELECT A.id_alqui, A.dni, P.id_peli, P.titulo, A.fecha_alquiler, A.fecha_devo, A.devuelto 
                           FROM Alquiler A 
                           JOIN Pelicula P ON A.id_pelicula = P.id_peli 
                           WHERE P.id_peli = @idPeli"

        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@idPeli", idPeli)
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ListViewAlquiler.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("id_alqui").ToString()) ' ID del alquiler
            item.SubItems.Add(row("dni").ToString())
            ' item.SubItems.Add(row("id_peli").ToString()) ' Si quieres mostrar el título también cambiar el select en cargar alquileres listview 
            item.SubItems.Add(row("titulo").ToString()) ' Si quieres mostrar el título también
            item.SubItems.Add(row("fecha_alquiler").ToString())
            item.SubItems.Add(row("fecha_devo").ToString())
            item.SubItems.Add(row("devuelto").ToString())

            ListViewAlquiler.Items.Add(item)
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        admin.Show()
        Me.Close()
    End Sub
End Class