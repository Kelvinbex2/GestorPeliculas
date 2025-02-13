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
    End Sub


    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub PeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeliculaToolStripMenuItem.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
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


End Class