Imports System.Data.SQLite

Public Class Devolver
    Public dniCliente As String '  Variable pública para recibir el DNI del cliente

    Private Sub Devolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el DNI en el TextBox (para referencia, pero deshabilitado)
        txtDni.Text = dniCliente

        ' Cargar películas alquiladas cuando se abre el formulario
        CargarPeliculasAlquiladas()
    End Sub

    Private Sub CargarPeliculasAlquiladas()
        If String.IsNullOrEmpty(dniCliente) Then
            MessageBox.Show("No se recibió un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Titulo.Items.Clear()

        ' Consulta para obtener las películas alquiladas que aún no han sido devueltas
        Dim query As String = "SELECT Pelicula.titulo FROM Alquiler " &
                              "INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                              "WHERE Alquiler.dni = @dni AND Alquiler.devuelto = 'N'"

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@dni", dniCliente) ' 🔥 Usamos la variable dniCliente
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Titulo.Items.Add(reader("titulo").ToString())
                    End While
                End Using
            End Using
        End Using

        ' Verificar si el cliente tiene películas alquiladas
        If Titulo.Items.Count = 0 Then
            MessageBox.Show("Este cliente no tiene películas pendientes de devolución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckBoxDev_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDev.CheckedChanged
        ' Verificar que se haya seleccionado una película
        If Titulo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una película para devolver.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CheckBoxDev.Checked = False ' Desmarcar el checkbox
            Exit Sub
        End If

        ' Confirmar si el usuario quiere devolver la película
        If MessageBox.Show("¿Está seguro de que desea devolver esta película?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            CheckBoxDev.Checked = False ' Desmarcar el checkbox
            Exit Sub
        End If

        ' Obtener el título de la película seleccionada
        Dim tituloPelicula As String = Titulo.SelectedItem.ToString()

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using transaction = conn.BeginTransaction()
                Try
                    ' Obtener el ID de la película alquilada
                    Dim idPeli As Integer = -1
                    Dim idAlqui As Integer = -1
                    Dim queryId As String = "SELECT id_pelicula, id_alqui FROM Alquiler " &
                                            "INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                                            "WHERE Alquiler.dni = @dni AND Pelicula.titulo = @titulo AND Alquiler.devuelto = 'N' LIMIT 1"

                    Using cmd As New SQLiteCommand(queryId, conn, transaction)
                        cmd.Parameters.AddWithValue("@dni", dniCliente) '  Usamos dniCliente en lugar de txtDni.Text
                        cmd.Parameters.AddWithValue("@titulo", tituloPelicula)
                        Using reader As SQLiteDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                idPeli = Convert.ToInt32(reader("id_pelicula"))
                                idAlqui = Convert.ToInt32(reader("id_alqui"))
                            End If
                        End Using
                    End Using

                    ' Verificar que se encontró un alquiler válido
                    If idPeli = -1 OrElse idAlqui = -1 Then
                        MessageBox.Show("Error al encontrar la película en el registro de alquileres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    ' Marcar la película como devuelta en la tabla Alquiler
                    Dim updateAlquiler As String = "UPDATE Alquiler SET devuelto = 'S', fecha_devo = @fecha WHERE id_alqui = @idAlqui"
                    Using cmd As New SQLiteCommand(updateAlquiler, conn, transaction)
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@idAlqui", idAlqui)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Aumentar el stock de la película
                    Dim updateStock As String = "UPDATE Pelicula SET stock = stock + 1 WHERE id_peli = @idPeli"
                    Using cmd As New SQLiteCommand(updateStock, conn, transaction)
                        cmd.Parameters.AddWithValue("@idPeli", idPeli)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Confirmar la transacción
                    transaction.Commit()
                    MessageBox.Show("Película devuelta con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Actualizar la lista de películas alquiladas
                    CargarPeliculasAlquiladas()

                    ' Desmarcar el checkbox
                    CheckBoxDev.Checked = False
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al devolver la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cliente.Show()
        Cliente.CargarDatosCliente(dniCliente)
        Me.Close()
    End Sub
End Class
