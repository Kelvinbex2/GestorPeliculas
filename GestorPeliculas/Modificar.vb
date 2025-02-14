Imports System.Data.SQLite

Public Class Modificar
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ComboTitulo.Items.Clear()
        For Each row As DataRow In dt.Rows
            ComboTitulo.Items.Add(row("titulo").ToString())
        Next
    End Sub



    Private Sub ComboTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTitulo.SelectedIndexChanged
        If ComboTitulo.SelectedIndex = -1 Then Exit Sub

        Dim query As String = "SELECT * FROM Pelicula WHERE titulo = @titulo"
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@titulo", ComboTitulo.SelectedItem.ToString())
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Verificar si hay resultados y llenar los TextBox
        If dt.Rows.Count > 0 Then
            txtId.Text = dt.Rows(0)("id_peli").ToString()
            txtStock.Text = dt.Rows(0)("stock").ToString()
            txtDir.Text = dt.Rows(0)("director").ToString()
            txtFec.Text = dt.Rows(0)("año").ToString()
            txtGen.Text = dt.Rows(0)("genero").ToString()
            txtSip.Text = dt.Rows(0)("sipnosis").ToString()
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ComboTitulo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una película para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE Pelicula 
                           SET director = @director, 
                               año = @año, 
                               genero = @genero, 
                               stock = @stock, 
                               sipnosis = @sipnosis 
                           WHERE titulo = @titulo"

        Dim dt As New DataTable()

        Using conn As SQLiteConnection = ObtenerConexion()
            conn.Open()
            Using da As New SQLiteDataAdapter(query, conn)
                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@titulo", ComboTitulo.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@id_peli", txtId.Text)
                    cmd.Parameters.AddWithValue("@director", txtDir.Text)
                    cmd.Parameters.AddWithValue("@año", txtFec.Text)
                    cmd.Parameters.AddWithValue("@genero", txtGen.Text)
                    cmd.Parameters.AddWithValue("@stock", CInt(txtStock.Text))
                    cmd.Parameters.AddWithValue("@sipnosis", txtSip.Text)

                    da.SelectCommand = cmd
                    da.Fill(dt)
                End Using
            End Using
        End Using

        MessageBox.Show("Película actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub sal_Click(sender As Object, e As EventArgs) Handles sal.Click
        Me.Hide()
    End Sub
End Class
