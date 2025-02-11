Public Class Restablecer
    Private Sub btmAtras_Click(sender As Object, e As EventArgs) Handles btmAtras.Click
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim nuevaContraseña As String = txtContraseña.Text.Trim()
        Dim repetirContraseña As String = txtNueContraseña.Text.Trim()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(nuevaContraseña) OrElse String.IsNullOrEmpty(repetirContraseña) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar que la nueva contraseña y la repetida sean iguales
        If nuevaContraseña <> repetirContraseña Then
            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Intentar restablecer la contraseña
        If RestablecerContraseña(email, nuevaContraseña) Then
            MessageBox.Show("¡Contraseña restablecida exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close() ' Cerrar el formulario después del cambio exitoso
        Else
            MessageBox.Show("No se encontró un usuario con ese correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class