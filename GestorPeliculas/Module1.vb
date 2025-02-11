Imports System.Data.SQLite

Module ConexionBD
    Private ReadOnly ConnectionString As String = "Data Source=C:\Users\diurno\source\repos\GestorPeliculas\videoClub.db; Version=3;"

    Public Function ObtenerConexion() As SQLiteConnection
        Dim con As New SQLiteConnection(ConnectionString)
        Return con
    End Function

    Public Function VerificarCredenciales(emailOrId As String, contraseña As String, esAdmin As Boolean) As Boolean
        Using conn As SQLiteConnection = ObtenerConexion()
            Try
                conn.Open()
                Dim query As String

                If esAdmin Then
                    query = "SELECT COUNT(*) FROM Admin WHERE id_admin = @id_admin AND contraseña = @contraseña"
                Else
                    query = "SELECT COUNT(*) FROM Cliente WHERE email = @email AND contraseña = @contraseña"
                End If

                Using cmd As New SQLiteCommand(query, conn)
                    If esAdmin Then
                        cmd.Parameters.AddWithValue("@id_admin", emailOrId)
                    Else
                        cmd.Parameters.AddWithValue("@email", emailOrId)
                    End If
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    Return count > 0
                End Using
            Catch ex As Exception
                Console.WriteLine("Error al verificar las credenciales: " & ex.Message)
                Return False
            End Try
        End Using
    End Function



    Public Function InsertarCliente(dni As String, nombre As String, apellidos As String, telefono As String, email As String, direccion As String, contraseña As String) As Boolean
        Dim conn As SQLiteConnection = ObtenerConexion()
        Dim cmd As SQLiteCommand = Nothing

        Try
            conn.Open()
            Dim query As String = "INSERT INTO Cliente (dni, nombre, apellidos, telefono, email, direccion, contraseña) VALUES (@dni, @nombre, @apellidos, @telefono, @email, @direccion, @contraseña)"

            cmd = New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@dni", dni)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellidos", apellidos)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contraseña", contraseña)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As SQLiteException When ex.ErrorCode = SQLiteErrorCode.Constraint
            MessageBox.Show("El DNI o el Email ya están registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            Console.WriteLine("Error al insertar el cliente: " & ex.Message)
            Return False
        Finally
            If cmd IsNot Nothing Then cmd.Dispose()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function




End Module
