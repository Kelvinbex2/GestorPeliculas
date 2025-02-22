Imports System.Data.SQLite
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module GestorClientes

    ' Función para obtener los datos del cliente a partir del DNI
    Public Sub CargarDatosCliente(dni As String, lblNombre As Label, lblApel As Label, lblCorreo As Label, lblAlquilados As Label)
        Dim queryCliente As String = "SELECT nombre, apellidos, email FROM Cliente WHERE dni = @dni"
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





End Module
