Public Class Login
    Private esAdmin As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUsuario.Text = "Usuario"
        lbAdmin.Text = "Cambiar a Admin"
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtPassword.Text

        If esAdmin Then
            If VerificarCredenciales(usuario, contrasena, True) Then
                MessageBox.Show("¡Bienvenido Administrador!", "Acceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Credenciales de administrador incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If VerificarCredenciales(usuario, contrasena, False) Then
                MessageBox.Show("¡Bienvenido Usuario!", "Acceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub lbAdmin_Click(sender As Object, e As EventArgs) Handles lbAdmin.Click
        esAdmin = Not esAdmin

        If esAdmin Then
            lbUsuario.Text = "Admin"
            lbAdmin.Text = "Cambiar a Usuario"
        Else
            lbUsuario.Text = "Usuario"
            lbAdmin.Text = "Cambiar a Admin"
        End If
    End Sub


    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        MessageBox.Show("Restablecer contraseña funcionalidad no implementada.", "Restablecer", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Registrar.Show()
        Me.Hide()
    End Sub
End Class
