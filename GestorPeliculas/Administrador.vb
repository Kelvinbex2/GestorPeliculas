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

    Public Sub obternerRow(direc As TextBox, genero As TextBox, fecha As TextBox, sip As TextBox, ds As DataSet)
        direc.Text = ds.Tables("Pelicula").Rows(0)("director").ToString()
        genero.Text = ds.Tables("Pelicula").Rows(0)("genero").ToString()
        fecha.Text = ds.Tables("Pelicula").Rows(0)("año").ToString()
        sip.Text = ds.Tables("Pelicula").Rows(0)("sipnosis").ToString()
    End Sub


    Public Sub CargarTitulosPeliculasEnComboBox(combo As ComboBox)
        Dim query As String = "SELECT titulo FROM Pelicula"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        ' Limpiar y agregar los títulos al ComboBox
        combo.Items.Clear()
        For Each row As DataRow In dt.Rows
            combo.Items.Add(row("titulo").ToString())
        Next
    End Sub



    Public Function ObtenerPeliculaPorTitulo(titulo As String) As DataSet
        Dim query As String = "SELECT director, genero, año, sipnosis, stock FROM Pelicula WHERE titulo = @Titulo"
        Dim ds As New DataSet()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@Titulo", titulo)
                da.Fill(ds, "Pelicula")
            End Using
        End Using

        Return ds
    End Function


    Public Sub DisminuirStockPorTitulo(titulo As String, cantidadReducir As Integer)
        Dim query As String = "UPDATE Pelicula SET stock = stock - @Cantidad WHERE titulo = @Titulo AND stock >= @Cantidad"

        Using conn As SQLiteConnection = ObtenerConexion()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Titulo", titulo)
                cmd.Parameters.AddWithValue("@Cantidad", cantidadReducir)
                conn.Open()

                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                If filasAfectadas = 0 Then
                    MessageBox.Show("No se puede disminuir más el stock. La película no tiene suficientes copias disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using
    End Sub


    Public Sub CargarPeliculasEnListView(listView As ListView)
        Dim query As String = "SELECT id_peli, titulo, director, año, genero, stock, sipnosis FROM Pelicula"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        listView.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("id_peli").ToString()) ' Columna Id
            item.SubItems.Add(row("titulo").ToString())
            item.SubItems.Add(row("director").ToString())
            item.SubItems.Add(row("año").ToString())
            item.SubItems.Add(row("genero").ToString())
            item.SubItems.Add(row("stock").ToString())
            item.SubItems.Add(row("sipnosis").ToString())

            listView.Items.Add(item)
        Next
    End Sub





    Public Sub CargarAlquileresEnListView(listView As ListView)
        Dim query As String = "SELECT A.id_alqui, A.dni, P.titulo, A.fecha_alquiler, A.fecha_devo, A.devuelto 
                           FROM Alquiler A 
                           JOIN Pelicula P ON A.id_pelicula = P.id_peli"

        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        listView.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("id_alqui").ToString()) ' Columna Id_Alquiler
            item.SubItems.Add(row("dni").ToString())
            item.SubItems.Add(row("titulo").ToString()) ' Mostrar el título en lugar del id_pelicula
            item.SubItems.Add(row("fecha_alquiler").ToString())
            item.SubItems.Add(row("fecha_devo").ToString())
            item.SubItems.Add(row("devuelto").ToString())

            listView.Items.Add(item)
        Next
    End Sub



End Module
