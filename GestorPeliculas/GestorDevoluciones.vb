Imports System.Data.SQLite

Module GestorDevoluciones

    ' Función para obtener las películas alquiladas por el cliente
    Public Function ObtenerPeliculasAlquiladas(dniCliente As String) As List(Of String)
        Dim peliculas As New List(Of String)

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Dim query As String = "SELECT Pelicula.titulo FROM Alquiler " &
                                  "INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                                  "WHERE Alquiler.dni = @dni AND Alquiler.devuelto = 'N'"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@dni", dniCliente)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        peliculas.Add(reader("titulo").ToString())
                    End While
                End Using
            End Using
        End Using

        Return peliculas
    End Function

    ' Función para devolver una película
    Public Function DevolverPelicula(dniCliente As String, tituloPelicula As String) As Boolean
        If String.IsNullOrEmpty(dniCliente) OrElse String.IsNullOrEmpty(tituloPelicula) Then
            MessageBox.Show("DNI o título de película no válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using transaction = conn.BeginTransaction()
                Try
                    ' Obtener ID de la película y alquiler
                    Dim idPeli As Integer = -1
                    Dim idAlqui As Integer = -1
                    Dim queryId As String = "SELECT id_pelicula, id_alqui FROM Alquiler " &
                                            "INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                                            "WHERE Alquiler.dni = @dni AND Pelicula.titulo = @titulo AND Alquiler.devuelto = 'N' LIMIT 1"

                    Using cmd As New SQLiteCommand(queryId, conn, transaction)
                        cmd.Parameters.AddWithValue("@dni", dniCliente)
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
                        Return False
                    End If

                    ' Marcar la película como devuelta
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
                    Return True

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al devolver la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Module
