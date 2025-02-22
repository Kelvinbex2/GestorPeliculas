Imports System.Data.SQLite

Public Class Devolver
    Public dniCliente As String ' Variable pública para recibir el DNI del cliente

    Private Sub Devolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDni.Text = dniCliente
        CargarPeliculasAlquiladas()
    End Sub

    Private Sub CargarPeliculasAlquiladas()
        If String.IsNullOrEmpty(dniCliente) Then
            MessageBox.Show("No se recibió un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Limpiar el ComboBox antes de cargar nuevas películas
        Titulo.Items.Clear()

        ' Llamar al módulo para obtener las películas alquiladas
        Dim peliculas As List(Of String) = ObtenerPeliculasAlquiladas(dniCliente)

        ' Agregar las películas al ComboBox
        For Each pelicula As String In peliculas
            Titulo.Items.Add(pelicula)
        Next

        ' Verificar si el cliente tiene películas alquiladas
        If Titulo.Items.Count = 0 Then
            MessageBox.Show("Este cliente no tiene películas pendientes de devolución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckBoxDev_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDev.CheckedChanged
        If CheckBoxDev.Checked Then
            If Titulo.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una película para devolver.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CheckBoxDev.Checked = False ' Desmarcar el checkbox
                Exit Sub
            End If

            ' Obtener el título de la película seleccionada
            Dim tituloPelicula As String = Titulo.SelectedItem.ToString()

            ' Llamar a la función del módulo para devolver la película
            If DevolverPelicula(dniCliente, tituloPelicula) Then
                CargarPeliculasAlquiladas() '  Actualizar la lista de películas
            End If

            ' Desmarcar el checkbox
            CheckBoxDev.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cliente.Show()
        Cliente.CargarDatosCliente(dniCliente)
        Me.Close()
    End Sub
End Class
