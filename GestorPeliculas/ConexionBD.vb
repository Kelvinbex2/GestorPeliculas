Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms ' Necesario para MessageBox

Module ConexionBD
    Private nombrebd As String = "videoClub.db"
    Private ruta As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\..\videoClub.db"))
    Private ReadOnly ConnectionString As String = "Data Source=" & ruta & "; Version=3;"

    Public Function ObtenerConexion() As SQLiteConnection
        Dim con As New SQLiteConnection(ConnectionString)
        Return con
    End Function

    Public Function VerificarCredenciales(email As String, contraseña As String, esAdmin As Boolean) As String
        Using conn As SQLiteConnection = ObtenerConexion()
            Try
                conn.Open()
                Dim query As String

                If esAdmin Then
                    query = "SELECT nombre FROM Admin WHERE email = @email AND contraseña = @contraseña"
                Else
                    query = "SELECT nombre FROM Cliente WHERE email = @email AND contraseña = @contraseña"
                End If

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)

                    Dim result As Object = cmd.ExecuteScalar()

                    ' Si el usuario existe, devuelve su nombre
                    If result IsNot Nothing Then
                        Return result.ToString()
                    Else
                        Return String.Empty ' Retorna vacío si no se encuentra el usuario
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al verificar las credenciales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return String.Empty
            End Try
        End Using
    End Function

    Public Function InsertarCliente(dni As String, nombre As String, apellidos As String, telefono As String, email As String, direccion As String, contraseña As String) As Boolean
        Using conn As SQLiteConnection = ObtenerConexion()
            Try
                conn.Open()

                Dim adaptador As New SQLiteDataAdapter("SELECT * FROM Cliente", conn)
                Dim dataSet As New DataSet()

                adaptador.Fill(dataSet, "Cliente")

                Dim nuevaFila As DataRow = dataSet.Tables("Cliente").NewRow()
                nuevaFila("dni") = dni
                nuevaFila("nombre") = nombre
                nuevaFila("apellidos") = apellidos
                nuevaFila("telefono") = telefono
                nuevaFila("email") = email
                nuevaFila("direccion") = direccion
                nuevaFila("contraseña") = contraseña

                dataSet.Tables("Cliente").Rows.Add(nuevaFila)

                Dim commandBuilder As New SQLiteCommandBuilder(adaptador)
                adaptador.Update(dataSet, "Cliente")

                Return True
            Catch ex As SQLiteException When ex.ErrorCode = SQLiteErrorCode.Constraint
                MessageBox.Show("El DNI o el Email ya están registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Catch ex As Exception
                Console.WriteLine("Error al insertar el cliente: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Function RestablecerContraseña(email As String, nuevaContraseña As String) As Boolean
        Using conn As SQLiteConnection = ObtenerConexion()
            Try
                conn.Open()

                Dim adaptador As New SQLiteDataAdapter("SELECT * FROM Cliente WHERE email = @email", conn)
                adaptador.SelectCommand.Parameters.AddWithValue("@email", email)

                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Cliente")

                If dataSet.Tables("Cliente").Rows.Count = 0 Then
                    Return False
                End If

                Dim fila As DataRow = dataSet.Tables("Cliente").Rows(0)
                fila("contraseña") = nuevaContraseña

                Dim commandBuilder As New SQLiteCommandBuilder(adaptador)
                adaptador.Update(dataSet, "Cliente")

                Return True
            Catch ex As Exception
                Console.WriteLine("Error al restablecer la contraseña: " & ex.Message)
                Return False
            End Try
        End Using
    End Function
End Module
