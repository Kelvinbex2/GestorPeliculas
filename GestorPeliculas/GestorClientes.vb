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



    Public Sub MostrarInformacionCliente(dniCliente As String, nombreCliente As String)
        ' Validar que el DNI no esté vacío
        If String.IsNullOrEmpty(dniCliente) Then
            MessageBox.Show("No hay información disponible del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim peliculasAlquiladas As Integer = 0
        Dim clienteTipo As String = "Novice"
        Dim esPuntual As String = "Desconocido"

        ' 🔹 Obtener la cantidad de películas alquiladas en total
        Dim queryCantidad As String = "SELECT COUNT(*) FROM Alquiler WHERE dni = @dni"

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(queryCantidad, conn)
                cmd.Parameters.AddWithValue("@dni", dniCliente)
                peliculasAlquiladas = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        ' 🔹 Determinar el tipo de cliente
        If peliculasAlquiladas > 7 Then
            clienteTipo = "Cliente de Casa  🏠"
        End If

        ' 🔹 Verificar si devuelve en tiempo (máximo 4 días)
        Dim queryTiempoDevolucion As String = "SELECT fecha_alquiler, fecha_devo FROM Alquiler WHERE dni = @dni AND fecha_devo IS NOT NULL"

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(queryTiempoDevolucion, conn)
                cmd.Parameters.AddWithValue("@dni", dniCliente)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim totalAlquileres As Integer = 0
                    Dim devolucionesPuntuales As Integer = 0

                    While reader.Read()
                        Dim fechaAlquiler As Date = Convert.ToDateTime(reader("fecha_alquiler"))
                        Dim fechaDevolucion As Date = Convert.ToDateTime(reader("fecha_devo"))
                        Dim diasDiferencia As Integer = (fechaDevolucion - fechaAlquiler).Days

                        If diasDiferencia <= 4 Then
                            devolucionesPuntuales += 1
                        End If
                        totalAlquileres += 1
                    End While

                    ' Si la mayoría de las devoluciones fueron puntuales, se considera puntual
                    If totalAlquileres > 0 Then
                        Dim porcentajePuntualidad As Double = (devolucionesPuntuales / totalAlquileres) * 100
                        If porcentajePuntualidad >= 50 Then
                            esPuntual = "Puntual ⏳"
                        Else
                            esPuntual = "Impuntual ⌛"
                        End If
                    End If
                End Using
            End Using
        End Using

        ' 🔹 Construir el mensaje con la información del cliente
        Dim mensaje As String = $"📌 **Información del Cliente**" & vbCrLf & vbCrLf &
                                $"👤 Nombre: {nombreCliente}" & vbCrLf &
                                $"📄 DNI: {dniCliente}" & vbCrLf &
                                $"🎬 Total de Películas Alquiladas: {peliculasAlquiladas}" & vbCrLf &
                                $"🏷 Tipo de Cliente: {clienteTipo}" & vbCrLf &
                                $"⏳ Puntualidad: {esPuntual}"

        ' 🔹 Mostrar la información en un MessageBox
        MessageBox.Show(mensaje, "Resumen de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub






End Module
