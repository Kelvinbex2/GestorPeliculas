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


    Public Function AgregarPelicula(titulo As String, stock As Integer, director As String, año As String, genero As String, sipnosis As String) As Boolean
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



    ' Método para obtener los datos del administrador por email utilizando DataSet
    Public Function ObtenerDatosPorEmail(email As String, query As String) As DataSet
        Dim ds As New DataSet()


        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                ' Definir el parámetro para evitar SQL injection
                da.SelectCommand.Parameters.AddWithValue("@Email", email)

                da.Fill(ds, "Datos")
            End Using
        End Using

        Return ds
    End Function

    Public Function ObtenerTodosLosEmails(query As String) As DataTable

        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function



    Public Sub EliminarPorEmail(email As String, query As String)
        Using conn As SQLiteConnection = ObtenerConexion()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub clear(Nombre As TextBox, Apellido As TextBox, Tlf As TextBox, Email As TextBox)
        Nombre.Clear()
        Apellido.Clear()
        Tlf.Clear()
        Email.Clear()
    End Sub

    Public Sub CargarEmailsEnComboBox(ComboBoxGmailAmin As ComboBox, Query As String)
        Dim dt As DataTable = ObtenerTodosLosEmails(Query)

        ComboBoxGmailAmin.Items.Clear()

        For Each row As DataRow In dt.Rows
            ComboBoxGmailAmin.Items.Add(row("email").ToString())
        Next
    End Sub

    Public Sub ObtenerRows(Nom As TextBox, Apel As TextBox, Tlf As TextBox, Email As TextBox, ds As DataSet)
        Nom.Text = ds.Tables("Datos").Rows(0)("nombre").ToString()
        Apel.Text = ds.Tables("Datos").Rows(0)("apellidos").ToString()
        Tlf.Text = ds.Tables("Datos").Rows(0)("telefono").ToString()
        Email.Text = ds.Tables("Datos").Rows(0)("email").ToString()
    End Sub

End Module
