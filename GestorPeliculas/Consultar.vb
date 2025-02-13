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
        Dim query As String = "SELECT A.id_alqui, A.dni, A.id_pelicula, A.fecha_alquiler, A.fecha_devo, A.devuelto 
                       FROM Alquiler A 
                       JOIN Pelicula P ON A.id_pelicula = P.id_peli"


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
            Dim item As New ListViewItem(row("id_alqui").ToString()) ' Columna Id_Alquiler
            item.SubItems.Add(row("dni").ToString())
            item.SubItems.Add(row("id_pelicula").ToString()) ' Ahora se muestra el ID de la película correctamente
            item.SubItems.Add(row("fecha_alquiler").ToString())
            item.SubItems.Add(row("fecha_devo").ToString())
            item.SubItems.Add(row("devuelto").ToString())


            ListViewAlquiler.Items.Add(item)
        Next
    End Sub

End Class