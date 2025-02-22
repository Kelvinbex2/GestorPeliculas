Imports System.Data.SQLite

Public Class Alquilar
    Public dniCliente As String ' Variable para almacenar el DNI del cliente
    Private Sub Alquilar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTitulosEnCombo()
    End Sub


    Private Sub CargarTitulosEnCombo()
        Dim query As String = "SELECT titulo FROM Pelicula"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        ComboBox1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ComboBox1.Items.Add(row("titulo").ToString())
        Next

    End Sub






    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then Exit Sub

        Dim query As String = "SELECT * FROM Pelicula WHERE titulo = @titulo"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@titulo", ComboBox1.SelectedItem.ToString())
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Verificar si hay resultados y llenar los TextBox
        If dt.Rows.Count > 0 Then
            txtDirec.Text = dt.Rows(0)("director").ToString()
            txtGen.Text = dt.Rows(0)("genero").ToString()
            txtAño.Text = dt.Rows(0)("año").ToString()
        End If
    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Obtener el correo del cliente desde el formulario Cliente
            Dim emailCliente As String = dniCliente

            If String.IsNullOrEmpty(emailCliente) Then
                MessageBox.Show("No se encontró un correo asociado al cliente.")
                Exit Sub
            End If

            ' Obtener el título de la película seleccionada
            Dim tituloPelicula As String = ComboBox1.SelectedItem.ToString()

            Using conn As SQLiteConnection = ObtenerConexion()
                conn.Open()

                '  Obtener el DNI del cliente a partir del correo
                Dim dniCliente As String = ""
                Dim queryDni As String = "SELECT dni FROM Cliente WHERE dni = @dni"

                Using cmd As New SQLiteCommand(queryDni, conn)
                    cmd.Parameters.AddWithValue("@dni", emailCliente)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        dniCliente = result.ToString()
                    Else
                        MessageBox.Show("No se encontró un DNI asociado a este correo.")
                        Exit Sub
                    End If
                End Using

                '  Obtener id_peli y stock
                Dim idPeli As Integer = -1
                Dim stock As Integer = 0
                Dim query As String = "SELECT id_peli, stock FROM Pelicula WHERE titulo = @titulo"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@titulo", tituloPelicula)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            idPeli = Convert.ToInt32(reader("id_peli"))
                            stock = Convert.ToInt32(reader("stock"))
                        End If
                    End Using
                End Using

                ' Verificar si hay stock disponible
                If idPeli = -1 OrElse stock = 0 Then
                    MessageBox.Show("No hay stock disponible o la película no existe.")
                    Exit Sub
                End If

                '  Iniciar transacción para asegurar la atomicidad
                Using transaction = conn.BeginTransaction()

                    '  Actualizar el stock en la base de datos
                    Dim updateQuery As String = "UPDATE Pelicula SET stock = stock - 1 WHERE id_peli = @id_peli"
                    Using cmd As New SQLiteCommand(updateQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@id_peli", idPeli)
                        cmd.ExecuteNonQuery()
                    End Using

                    '  Registrar el alquiler en la tabla Alquiler con el DNI obtenido
                    Dim alquilerQuery As String = "INSERT INTO Alquiler (dni, id_pelicula, fecha_alquiler, devuelto) VALUES (@dni, @idPeli, @fecha, 'N')"
                    Using cmd As New SQLiteCommand(alquilerQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@dni", dniCliente)
                        cmd.Parameters.AddWithValue("@idPeli", idPeli)
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                        cmd.ExecuteNonQuery()
                    End Using

                    '  Confirmar la transacción
                    transaction.Commit()
                End Using ' 🔥 Asegura que la transacción se cierre

                MessageBox.Show("Película alquilada con éxito.")
                ' Desmarcar el checkbox
                CheckBox1.Checked = False
            End Using ' 🔥 Se cierra la conexión automáticamente
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cliente.Show()
        Me.Close()
        Cliente.CargarDatosCliente(dniCliente)

    End Sub
End Class