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
        ' Cerrar la conexión si está abierta antes de abrir Alquilar
        If ConexionBD.ObtenerConexion().State = ConnectionState.Open Then
            ConexionBD.ObtenerConexion().Close()
        End If

        ' Crear una instancia de Alquilar y pasarle el DNI del cliente
        Dim alquilarForm As New Alquilar()
        alquilarForm.dniCliente = lblDni.Text ' 🔥 Pasar el DNI al formulario de Alquilar
        alquilarForm.Show()

    End Sub



End Class
