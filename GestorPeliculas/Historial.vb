Imports System.Data.SQLite

Public Class Historial
    Public dniCliente As String ' 🔥 Recibe el DNI del cliente

    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHistorial()
    End Sub

    Private Sub CargarHistorial()
        ' Verificar si el DNI está vacío
        If String.IsNullOrEmpty(dniCliente) Then
            MessageBox.Show("No se recibió un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Limpiar el ListView antes de cargar nuevos datos
        ListView1.Items.Clear()

        ' Consulta para obtener el historial de alquileres del cliente
        Dim query As String = "SELECT Pelicula.titulo, Alquiler.fecha_alquiler, " &
                              "COALESCE(Alquiler.fecha_devo, 'No devuelto') AS fecha_devolucion, " &
                              "CASE WHEN Alquiler.devuelto = 'S' THEN 'Sí' ELSE 'No' END AS devuelto " &
                              "FROM Alquiler " &
                              "INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                              "WHERE Alquiler.dni = @dni " &
                              "ORDER BY Alquiler.fecha_alquiler DESC"

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@dni", dniCliente)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Crear una fila con los datos obtenidos
                        Dim item As New ListViewItem(reader("titulo").ToString()) ' Primera columna (Título)
                        item.SubItems.Add(reader("fecha_alquiler").ToString()) ' Segunda columna (Fecha alquiler)
                        item.SubItems.Add(reader("fecha_devolucion").ToString()) ' Tercera columna (Fecha devolución)
                        item.SubItems.Add(reader("devuelto").ToString()) ' Cuarta columna (Devuelto o No)

                        ' Agregar la fila al ListView
                        ListView1.Items.Add(item)
                    End While
                End Using
            End Using
        End Using

        ' Verificar si no hay resultados
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("Este cliente no tiene historial de alquileres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class