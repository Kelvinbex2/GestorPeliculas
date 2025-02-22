Imports System.Data.SQLite

Module GestorAlquileres

    ' Función para alquilar una película
    Public Function AlquilarPelicula(dniCliente As String, tituloPelicula As String) As Boolean
        ' Validar entradas
        If String.IsNullOrEmpty(dniCliente) OrElse String.IsNullOrEmpty(tituloPelicula) Then
            MessageBox.Show("DNI o título de película no válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using transaction = conn.BeginTransaction()
                Try
                    ' 🔹 Obtener ID de la película y stock disponible
                    Dim idPeli As Integer = -1
                    Dim stock As Integer = 0
                    Dim query As String = "SELECT id_peli, stock FROM Pelicula WHERE titulo = @titulo"

                    Using cmd As New SQLiteCommand(query, conn, transaction)
                        cmd.Parameters.AddWithValue("@titulo", tituloPelicula)
                        Using reader As SQLiteDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                idPeli = Convert.ToInt32(reader("id_peli"))
                                stock = Convert.ToInt32(reader("stock"))
                            End If
                        End Using
                    End Using

                    ' 🔹 Verificar si hay stock disponible
                    If idPeli = -1 OrElse stock = 0 Then
                        MessageBox.Show("No hay stock disponible o la película no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If

                    ' 🔹 Registrar el alquiler en la tabla Alquiler
                    Dim alquilerQuery As String = "INSERT INTO Alquiler (dni, id_pelicula, fecha_alquiler, devuelto) VALUES (@dni, @idPeli, @fecha, 'N')"
                    Using cmd As New SQLiteCommand(alquilerQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@dni", dniCliente)
                        cmd.Parameters.AddWithValue("@idPeli", idPeli)
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 🔹 Actualizar el stock en la base de datos
                    Dim updateStockQuery As String = "UPDATE Pelicula SET stock = stock - 1 WHERE id_peli = @idPeli"
                    Using cmd As New SQLiteCommand(updateStockQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@idPeli", idPeli)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 🔹 Confirmar la transacción
                    transaction.Commit()
                    MessageBox.Show("Película alquilada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al alquilar la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Module
