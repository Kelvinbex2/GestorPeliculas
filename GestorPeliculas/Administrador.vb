Imports System.Data.SQLite

Module Administrador

    Public Function AgregarAdministrador(nombre As String, apellidos As String, telefono As String, email As String, contraseña As String) As Boolean
        Try
            Using con As SQLiteConnection = ConexionBD.ObtenerConexion()
                con.Open()
                Dim sql As String = "INSERT INTO Admin (nombre, apellidos, telefono, email, contraseña) VALUES (@nombre, @apellidos, @telefono, @email, @contraseña)"
                Using cmd As New SQLiteCommand(sql, con)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellidos", apellidos)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al agregar el administrador: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Function AgregarPelicula(titulo As String, stock As Integer, director As String, año As Integer, genero As String, sipnosis As String) As Boolean
        Try
            Using con As SQLiteConnection = ConexionBD.ObtenerConexion()
                con.Open()
                Dim sql As String = "INSERT INTO Pelicula (titulo, stock, director, año, genero, sipnosis) VALUES (@titulo, @stock, @director, @año, @genero, @sipnosis)"
                Using cmd As New SQLiteCommand(sql, con)
                    cmd.Parameters.AddWithValue("@titulo", titulo)
                    cmd.Parameters.AddWithValue("@stock", stock)
                    cmd.Parameters.AddWithValue("@director", director)
                    cmd.Parameters.AddWithValue("@año", año)
                    cmd.Parameters.AddWithValue("@genero", genero)
                    cmd.Parameters.AddWithValue("@sipnosis", sipnosis)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al agregar la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
