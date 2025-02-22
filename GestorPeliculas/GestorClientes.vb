Imports System.Data.SQLite
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module GestorClientes

    ' Función para obtener los datos del cliente a partir del DNI
    Public Sub CargarDatosCliente(dni As String, lblDni As Label, lblNombre As Label, lblApel As Label, lblCorreo As Label, lblAlquilados As Label)
        Dim queryCliente As String = "SELECT dni, nombre, apellidos, email FROM Cliente WHERE dni = @dni"
        Dim queryPeliculas As String = "SELECT COUNT(*) FROM Alquiler WHERE dni = @dni AND devuelto = 'N'"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ConexionBD.ObtenerConexion()
            conn.Open()

            ' Obtener los datos del cliente
            Using cmd As New SQLiteCommand(queryCliente, conn)
                cmd.Parameters.AddWithValue("@dni", dni)
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            ' Verificar si se encontraron datos del cliente
            If dt.Rows.Count > 0 Then
                lblDni.Text = dt.Rows(0)("dni").ToString() ' 🔥 Asegurar que se actualiza correctamente
                lblNombre.Text = dt.Rows(0)("nombre").ToString()
                lblApel.Text = dt.Rows(0)("apellidos").ToString()
                lblCorreo.Text = dt.Rows(0)("email").ToString()
            End If

            ' Obtener la cantidad de películas alquiladas que no han sido devueltas
            Using cmdPeliculas As New SQLiteCommand(queryPeliculas, conn)
                cmdPeliculas.Parameters.AddWithValue("@dni", dni)
                Dim peliculasAlquiladas As Integer = Convert.ToInt32(cmdPeliculas.ExecuteScalar())
                lblAlquilados.Text = "Películas alquiladas: " & peliculasAlquiladas.ToString()
            End Using
        End Using '  Se cierra la conexión automáticamente al salir del bloque Using
    End Sub



    ' Función para obtener el DNI del cliente a partir del correo electrónico
    Public Function ObtenerDniPorEmail(email As String) As String
        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT dni FROM Cliente WHERE email = @email", conn)
            cmd.Parameters.AddWithValue("@email", email)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return result.ToString()
            Else
                Return String.Empty
            End If
        End Using
    End Function



    ' Función para obtener y mostrar la información del cliente
    Public Sub MostrarInformacionCliente(dniCliente As String, nombreCliente As String)
            ' Validar que el DNI no esté vacío
            If String.IsNullOrEmpty(dniCliente) Then
                MessageBox.Show("No hay información disponible del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 🔹 Obtener la cantidad de películas alquiladas sin devolver
            Dim peliculasPendientes As Integer = 0
            Dim queryPendientes As String = "SELECT COUNT(*) FROM Alquiler WHERE dni = @dni AND devuelto = 'N'"

            Using conn As SQLiteConnection = ObtenerConexion()
                conn.Open()
                Using cmd As New SQLiteCommand(queryPendientes, conn)
                    cmd.Parameters.AddWithValue("@dni", dniCliente)
                    peliculasPendientes = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            ' 🔹 Obtener el historial de alquileres
            Dim historial As New List(Of String)
            Dim queryHistorial As String = "SELECT Pelicula.titulo, Alquiler.fecha_alquiler, " &
                                       "COALESCE(Alquiler.fecha_devo, 'No devuelto') AS fecha_devolucion " &
                                       "FROM Alquiler INNER JOIN Pelicula ON Alquiler.id_pelicula = Pelicula.id_peli " &
                                       "WHERE Alquiler.dni = @dni ORDER BY Alquiler.fecha_alquiler DESC"

            Using conn As SQLiteConnection = ObtenerConexion()
                conn.Open()
                Using cmd As New SQLiteCommand(queryHistorial, conn)
                    cmd.Parameters.AddWithValue("@dni", dniCliente)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim titulo As String = reader("titulo").ToString()
                            Dim fechaAlquiler As String = reader("fecha_alquiler").ToString()
                            Dim fechaDevolucion As String = reader("fecha_devolucion").ToString()
                            historial.Add($"{titulo} (Alquilada: {fechaAlquiler} - Devuelta: {fechaDevolucion})")
                        End While
                    End Using
                End Using
            End Using

            ' 🔹 Construir el mensaje con la información del cliente
            Dim mensaje As String = $"📌 **Información del Cliente**" & vbCrLf & vbCrLf &
                                $"👤 Nombre: {nombreCliente}" & vbCrLf &
                                $"📄 DNI: {dniCliente}" & vbCrLf &
                                $"🎬 Películas alquiladas sin devolver: {peliculasPendientes}" & vbCrLf & vbCrLf

            ' 🔹 Agregar historial al mensaje
            If historial.Count > 0 Then
                mensaje &= "📜 **Historial de Alquileres:**" & vbCrLf & String.Join(vbCrLf, historial)
            Else
                mensaje &= "📜 No hay historial de alquileres."
            End If

            ' 🔹 Mostrar la información en un MessageBox
            MessageBox.Show(mensaje, "Resumen de Actividades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub





    End Module
