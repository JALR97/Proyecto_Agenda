Imports System.Data.SqlClient
Public Class TareaDetalles
    Public Shared ID As Integer
    Public Shared IDsContactos As New ArrayList
    Public Shared prev As String
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        If prev = "pen" Then
            VistaPendientes.CargarDatos()
            VistaPendientes.Show()
        Else
            VistaT.CargarDatos()
            VistaT.Show()
        End If

    End Sub

    Private Sub lblModificar_Click(sender As Object, e As EventArgs) Handles lblModificar.Click

        NuevaTarea.ModoTarea(2)
        NuevaTarea.txtTitulo.Text = lblTitulo.Text
        NuevaTarea.txtInfo.Text = lblInfo.Text
        NuevaTarea.txtLugar.Text = lblDireccion.Text
        NuevaTarea.cboCategoria.Text = lblCategoria.Text
        If lblPrioridad.Text.Equals("Prioridad Baja") Then
            NuevaTarea.cboPrioridad.SelectedIndex = 0
        ElseIf lblPrioridad.Text.Equals("Prioridad Media") Then
            NuevaTarea.cboPrioridad.SelectedIndex = 1
        Else
            NuevaTarea.cboPrioridad.SelectedIndex = 2
        End If

        If lblFecha.Text <> "Sin fecha" Then
            NuevaTarea.radSi.Checked = True
            Dim strs() As String = lblFecha.Text.Split("/")
            NuevaTarea.dtpFecha.Value = Convert.ToDateTime($"{strs(1)}/{strs(0)}/{strs(2)}")
        End If

        Me.Hide()
        NuevaTarea.Show()
        NuevaTarea.CargarDatos()
    End Sub
    Public Function Eliminar()
        If MsgBox("Seguro que desea eliminar esta tarea?", vbQuestion + vbYesNo, "Eliminar") = vbYes Then
            BD.Command($"DELETE FROM Tareas_Contactos WHERE ID_Tarea = {ID}")
            BD.Command($"DELETE FROM Tareas WHERE ID_Tarea = {ID}")
            Return True
        End If
        Return False
    End Function
    Private Sub btnEliminarTarea_Click(sender As Object, e As EventArgs) Handles btnEliminarTarea.Click
        If Eliminar() Then
            btnAtras.PerformClick()
        End If
    End Sub

    Private Sub chkListo_CheckedChanged(sender As Object, e As EventArgs) Handles chkListo.CheckedChanged
        BD.Command($"update Tareas set Hecho = '{chkListo.Checked}' where ID_Tarea = {ID}")
    End Sub

    Private Sub lbContactos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContactos.SelectedIndexChanged
        If lbContactos.SelectedIndex <> -1 Then
            btnVerContacto.Enabled = True
        End If
    End Sub

    Private Sub btnVerContacto_Click(sender As Object, e As EventArgs) Handles btnVerContacto.Click
        Contactos.CargarContacto(IDsContactos(lbContactos.SelectedIndex))
        Me.Hide()
        ContactoDetalles.Show()
        ContactoDetalles.prev = "tar"
    End Sub
End Class