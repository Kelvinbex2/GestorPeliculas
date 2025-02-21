Imports System.Data.SQLite

Public Class Cliente


    ' Método para cargar los datos del cliente
    Public Sub CargarDatosCliente(dni As String)
        GestorClientes.CargarDatosCliente(dni, lblNombre, lblApel, lblCorreo, lblAlquilados)
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
