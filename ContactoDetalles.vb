Public Class ContactoDetalles
    Public Shared ID As Integer
    Public Shared prev As String
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        If prev = "hbd" Then
            HBD.Show()
            HBD.CargarDatos()
        ElseIf prev = "tar" Then
            TareaDetalles.Show()
            VistaT.CargarTarea(TareaDetalles.ID)
        Else
            Contactos.Show()
            Contactos.CargarDatos()
        End If
    End Sub
    Public Function Eliminar()
        If MsgBox("Seguro que desea eliminar este contacto?", vbQuestion + vbYesNo, "Eliminar") = vbYes Then
            BD.Command($"delete from Tareas_Contactos where ID_Contacto = {ID}")
            BD.Command($"delete from Contactos where ID_Contacto = {ID}")
            Return True
        End If
        Return False
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Eliminar() Then
            btnAtras.PerformClick()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim hbd As Date
        Dim fecha() As String = lblFechaN.Text.Split("/")
        hbd = New Date(2000, Val(fecha(1)), Val(fecha(0)))

        NuevoContacto.ModoContacto(2)
        NuevoContacto.txtNombre.Text = lblNombre.Text
        NuevoContacto.txtApellido.Text = lblApellido.Text
        NuevoContacto.txtEmail.Text = lblEmail.Text
        NuevoContacto.txtTelf.Text = lblTelefono.Text
        NuevoContacto.dtpCumple.Value = hbd
        Me.Hide()
        NuevoContacto.Show()
        NuevoContacto.prev = "det"
    End Sub
End Class