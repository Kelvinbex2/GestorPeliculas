Public Class Login
    Private esAdmin As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUsuario.Text = "Usuario"
        lbAdmin.Text = "Cambiar a Admin"

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtPassword.Text

        ' Verificar credenciales, pasando la variable esAdmin para saber si es cliente o admin
        Dim nombreUsuario As String = VerificarCredenciales(usuario, contrasena, esAdmin)

        If esAdmin Then
            If nombreUsuario <> "" Then
                Dim adminForm As New admin()
                adminForm.NombreUsuario = nombreUsuario
                adminForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Credenciales de administrador incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If nombreUsuario <> "" Then
                ' Obtener el DNI del cliente (usamos la función para obtener el DNI)
                Dim dni As String = GestorClientes.ObtenerDniPorEmail(usuario)

                ' Crear una instancia del formulario Cliente
                Dim clienteForm As New Cliente()

                ' Pasar el DNI al formulario Cliente para cargar sus datos
                clienteForm.CargarDatosCliente(dni)

                ' Mostrar el formulario Cliente
                clienteForm.Show()
                Me.Hide()
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
        Restablecer.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Registrar.Show()
        Me.Hide()
    End Sub
End Class
