Imports System.Data.SQLite

Public Class Cliente


    ' Método para cargar los datos del cliente
    Public Sub CargarDatosCliente(dni As String)
        GestorClientes.CargarDatosCliente(dni, lblDni, lblNombre, lblApel, lblCorreo, lblAlquilados)
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        ' Crear una instancia de Alquilar y pasarle el DNI del cliente
        Dim alquilarForm As New Alquilar()
        alquilarForm.dniCliente = lblDni.Text ' 🔥 Pasar el DNI al formulario de Alquilar
        alquilarForm.Show()


    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btndevolvr.Click
        ' Verificar si lblDni tiene un valor antes de abrir Devolver
        If String.IsNullOrEmpty(lblDni.Text) Then
            MessageBox.Show("El DNI del cliente no está disponible. Intente iniciar sesión de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Crear una instancia del formulario Devolver y pasar el DNI
        Dim devolverForm As New Devolver()
        devolverForm.dniCliente = lblDni.Text '  Pasar el DNI
        devolverForm.Show()

    End Sub



    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        ' Verificar si lblDni tiene un valor antes de abrir Historial
        If String.IsNullOrEmpty(lblDni.Text) Then
            MessageBox.Show("El DNI del cliente no está disponible. Intente iniciar sesión de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Crear una instancia del formulario Historial y pasar el DNI
        Dim historialForm As New Historial()
        historialForm.dniCliente = lblDni.Text '  Pasar el DNI
        historialForm.Show()

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar.Show()

    End Sub


End Class
