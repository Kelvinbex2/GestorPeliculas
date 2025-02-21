Imports System.Data.SQLite
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module GestorClientes

    ' Función para obtener los datos del cliente a partir del DNI
    Public Sub CargarDatosCliente(dni As String, lblNombre As Label, lblApel As Label, lblCorreo As Label, lblAlquilados As Label)
        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()

            ' Obtener los datos del cliente (nombre, apellidos, email)
            Dim cmd As New SQLiteCommand("SELECT nombre, apellidos, email FROM Cliente WHERE dni = @dni", conn)
            cmd.Parameters.AddWithValue("@dni", dni)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Mostrar los datos en los controles (labels)
                lblNombre.Text = reader("nombre").ToString()
                lblApel.Text = reader("apellidos").ToString()
                lblCorreo.Text = reader("email").ToString()
            End If

            ' Obtener el número de películas alquiladas (que no han sido devueltas)
            Dim cmdPeliculas As New SQLiteCommand("SELECT COUNT(*) FROM Alquiler WHERE dni = @dni AND devuelto = 'N'", conn)
            cmdPeliculas.Parameters.AddWithValue("@dni", dni)
            Dim peliculasAlquiladas As Integer = Convert.ToInt32(cmdPeliculas.ExecuteScalar())

            lblAlquilados.Text = "Películas alquiladas: " & peliculasAlquiladas.ToString()

            conn.Close()
        End Using
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





End Module
