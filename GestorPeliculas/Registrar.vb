Imports System.Data.SQLite

Public Class Registrar
    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Dim dni As String = txtDni.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim apellidos As String = txtApel.Text.Trim()
        Dim telefono As String = txtTlf.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim direccion As String = txtDir.Text.Trim()
        Dim contraseña As String = TextBox1.Text.Trim()


        If String.IsNullOrEmpty(dni) OrElse String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellidos) OrElse
           String.IsNullOrEmpty(telefono) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(direccion) OrElse
           String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If InsertarCliente(dni, nombre, apellidos, telefono, email, direccion, contraseña) Then
            MessageBox.Show("¡Cliente registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Else
            MessageBox.Show("Error al registrar el cliente. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub LimpiarCampos()
        txtDni.Clear()
        txtNombre.Clear()
        txtApel.Clear()
        txtTlf.Clear()
        txtEmail.Clear()
        txtDir.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub btmAtras_Click(sender As Object, e As EventArgs) Handles btmAtras.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
