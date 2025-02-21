Imports System.Data.SQLite

Public Class Alquilar
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
            txt.Text = dt.Rows(0)("año").ToString()
        End If
    End Sub





    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Obtener el correo del cliente
            Dim emailCliente As String

            If String.IsNullOrEmpty(emailCliente) Then
                MessageBox.Show("No se encontró un DNI para este correo.")
                Exit Sub
            End If

            ' Obtener el título de la película seleccionada
            Dim tituloPelicula As String = ComboBox1.SelectedItem.ToString()

            ' Consultar la película seleccionada para obtener su id y stock
            Dim query As String = "SELECT id_peli, stock FROM Pelicula WHERE titulo = @titulo"
            Dim dt As New DataTable()

            Using conn As SQLiteConnection = ObtenerConexion()
                conn.Open()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@titulo", tituloPelicula)
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

            ' Verificar si la película existe
            If dt.Rows.Count > 0 Then
                Dim idPeli As Integer = Convert.ToInt32(dt.Rows(0)("id_peli"))
                Dim stock As Integer = Convert.ToInt32(dt.Rows(0)("stock"))

                ' Verificar si hay stock disponible
                If stock > 0 Then
                    ' Actualizar el stock en la base de datos
                    Dim updateQuery As String = "UPDATE Pelicula SET stock = stock - 1 WHERE id_peli = @id_peli"
                    Using conn As SQLiteConnection = ObtenerConexion()
                        conn.Open()
                        Using cmd As New SQLiteCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("@id_peli", idPeli)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Registrar el alquiler en la tabla Alquiler
                    Dim alquilerQuery As String = "INSERT INTO Alquiler (dni, id_pelicula, fecha_alquiler, devuelto) VALUES ((SELECT dni FROM Cliente WHERE email = @clienteEmail), @idPeli, @fecha, 'N')"
                    Using conn As SQLiteConnection = ObtenerConexion()
                        conn.Open()
                        Using cmd As New SQLiteCommand(alquilerQuery, conn)
                            cmd.Parameters.AddWithValue("@clienteEmail", emailCliente)
                            cmd.Parameters.AddWithValue("@idPeli", idPeli)
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Película alquilada con éxito.")
                Else
                    MessageBox.Show("No hay stock disponible.")
                End If
            End If
        End If
    End Sub







End Class