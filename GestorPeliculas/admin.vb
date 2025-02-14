Public Class admin
    Public Property NombreUsuario As String

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel10.Visible = False
        Panel9.Visible = True


        If Not String.IsNullOrEmpty(NombreUsuario) Then
            lblMsg.Text = "Bienvenido "
            lbluser.Text = NombreUsuario
        Else
            lblMsg.Text = "Bienvenido"
        End If
    End Sub


    Private Sub AgregarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPeliculaToolStripMenuItem.Click
        Panel9.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub AgregarAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAdminToolStripMenuItem.Click
        Panel9.Visible = True
        Panel10.Visible = False
    End Sub


    Private Sub btnAcep_Click(sender As Object, e As EventArgs) Handles btnAcep.Click
        Dim nombre As String = TextBoxNombre.Text
        Dim apellidos As String = TextApel.Text
        Dim telefono As String = TextTlf.Text
        Dim email As String = TextEmail.Text
        Dim contraseña As String = TextContra.Text

        If nombre = "" Or apellidos = "" Or telefono = "" Or email = "" Or contraseña = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AgregarAdministrador(nombre, apellidos, telefono, email, contraseña) Then
            MessageBox.Show("Administrador agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            admin()
        End If
    End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim titulo As String = txtTit.Text
        Dim stock As Integer
        Dim director As String = txtDir.Text
        Dim año As String = txtFec.Text
        Dim genero As String = txtGen.Text
        Dim sipnosis As String = txtSip.Text


        If titulo = "" Or txtCal.Text = "" Or director = "" Or txtFec.Text = "" Or genero = "" Or sipnosis = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtCal.Text, stock) Then
            MessageBox.Show("Stock debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        If AgregarPelicula(titulo, stock, director, año, genero, sipnosis) Then
            MessageBox.Show("Película agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            limpiarPeli()
        End If
    End Sub


    Public Sub limpiarPeli()
        txtTit.Clear()
        txtCal.Clear()
        txtDir.Clear()
        txtFec.Clear()
        txtGen.Clear()
        txtSip.Clear()
    End Sub
    Public Sub admin()
        TextBoxNombre.Clear()
        TextApel.Clear()
        TextTlf.Clear()
        TextEmail.Clear()
        TextContra.Clear()
    End Sub

    Private Sub CerrarSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSessionToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click
        Eliminar.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Consultar.Show()
        Me.Hide()
    End Sub

    Private Sub ModificarPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPToolStripMenuItem.Click
        Modificar.Show()
    End Sub
End Class