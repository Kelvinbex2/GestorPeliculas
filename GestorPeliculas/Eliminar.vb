Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Eliminar
    Dim query As String = "DELETE FROM Admin WHERE email = @Email"
    Dim queryAdmin As String = "SELECT email FROM Admin"
    Dim querySelectAdmin As String = "SELECT nombre, apellidos, telefono, email FROM Admin WHERE email = @Email"
    Dim queryCliente As String = "SELECT email FROM Cliente"
    Dim queryUs As String = "DELETE FROM Cliente WHERE email = @Email"
    Dim querySelectUs As String = "SELECT nombre, apellidos, telefono, email FROM Cliente WHERE email = @Email"

    Private Sub Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar Panel1 por defecto y ocultar los otros
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Administrador.CargarEmailsEnComboBox(ComboBoxGmailAmin, queryAdmin)
        Administrador.CargarEmailsEnComboBox(ComboboxGmailDni, queryCliente)
        Administrador.CargarTitulosPeliculasEnComboBox(ComboTitulo)
    End Sub



    Private Sub ComboBoxGmailAmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGmailAmin.SelectedIndexChanged
        If ComboBoxGmailAmin.SelectedItem Is Nothing Then Exit Sub

        Dim selectedEmail As String = ComboBoxGmailAmin.SelectedItem.ToString()
        Dim ds As DataSet = Administrador.ObtenerDatosPorEmail(selectedEmail, querySelectAdmin)

        If ds.Tables("Datos").Rows.Count > 0 Then
            Administrador.ObtenerRows(TextBoxNombre, TextApel, TextTlf, TextEmail, ds)

        Else
            MessageBox.Show("No se encontraron datos para este email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub






    Private Sub btnAcpAdmin_Click(sender As Object, e As EventArgs) Handles btnAcpAdmin.Click
        If ComboBoxGmailAmin.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un administrador para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedEmail As String = ComboBoxGmailAmin.SelectedItem.ToString()

        If MessageBox.Show("¿Está seguro de que desea eliminar este administrador?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Administrador.EliminarPorEmail(selectedEmail, query)

            Administrador.clear(TextBoxNombre, TextApel, TextTlf, TextEmail)


            Administrador.CargarEmailsEnComboBox(ComboBoxGmailAmin, queryAdmin)
        End If
    End Sub






    Private Sub ComboboxGmailDni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboboxGmailDni.SelectedIndexChanged
        If ComboboxGmailDni.SelectedItem Is Nothing Then Exit Sub

        Dim selectedEmail As String = ComboboxGmailDni.SelectedItem.ToString()
        Dim ds As DataSet = Administrador.ObtenerDatosPorEmail(selectedEmail, querySelectUs)

        If ds.Tables("Datos").Rows.Count > 0 Then
            Administrador.ObtenerRows(txtNomUser, txtApelUser, txtTlfUser, txtEmailUser, ds)
        Else
            MessageBox.Show("No se encontraron datos para este usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnAcpUser_Click(sender As Object, e As EventArgs) Handles btnAcpUser.Click
        If ComboboxGmailDni.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedEmail As String = ComboboxGmailDni.SelectedItem.ToString()

        If MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Administrador.EliminarPorEmail(selectedEmail, queryUs)

            ' Limpiar los TextBox
            Administrador.clear(txtNomUser, txtApelUser, txtTlfUser, txtEmailUser)

            ' Recargar el ComboBox con los emails actualizados
            Administrador.CargarEmailsEnComboBox(ComboboxGmailDni, queryCliente)
        End If
    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem1.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub AdministradorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem1.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub PeliculaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeliculaToolStripMenuItem1.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub btmAtras_Click(sender As Object, e As EventArgs) Handles btmAtras.Click
        admin.Show()
        Me.Hide()
    End Sub



    Private Sub ComboTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTitulo.SelectedIndexChanged
        If ComboTitulo.SelectedItem Is Nothing Then Exit Sub

        Dim selectedTitulo As String = ComboTitulo.SelectedItem.ToString()
        Dim ds As DataSet = Administrador.ObtenerPeliculaPorTitulo(selectedTitulo)

        ' Recargar información de la película después de modificar el stock
        If ds.Tables("Pelicula").Rows.Count > 0 Then
            Administrador.obternerRow(txtDirec, txtGenero, txtFecha, txtSip, ds)
        Else
            MessageBox.Show("No se encontraron datos para esta película.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnAcpPeli_Click(sender As Object, e As EventArgs) Handles btnAcpPeli.Click
        If ComboTitulo.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una película para eliminar copias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtStock.Text) OrElse Not IsNumeric(txtStock.Text) Then
            MessageBox.Show("Ingrese un número válido para reducir el stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedTitulo As String = ComboTitulo.SelectedItem.ToString()
        Dim cantidadReducir As Integer = CInt(txtStock.Text) ' convierte el texto de un TextBox a un número entero

        If cantidadReducir <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor que 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("¿Está seguro de que deseas eliminar " & cantidadReducir.ToString() & " copias de esta película?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Administrador.DisminuirStockPorTitulo(selectedTitulo, cantidadReducir)


            Dim ds As DataSet = Administrador.ObtenerPeliculaPorTitulo(selectedTitulo)
            If ds.Tables("Pelicula").Rows.Count > 0 Then
                Administrador.obternerRow(txtDirec, txtGenero, txtFecha, txtSip, ds)
            End If
        End If
    End Sub




End Class