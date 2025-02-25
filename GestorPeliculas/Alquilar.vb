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
            ' Obtener el título de la película seleccionada
            Dim tituloPelicula As String = ComboBox1.SelectedItem?.ToString()

            ' Llamar a la función del módulo para alquilar
            If AlquilarPelicula(dniCliente, tituloPelicula) Then
                ' 🔥 Si el alquiler fue exitoso, actualizar Cliente
                Cliente.CargarDatosCliente(dniCliente)
            End If

            ' Desmarcar el checkbox
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cliente.Show()
        Cliente.CargarDatosCliente(dniCliente)
        Me.Hide()
    End Sub
End Class
