Public Class Agendar
    Public Shared prev As String
    Public Shared ID As Integer

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        If prev = "vist" Then
            VistaT.CargarDatos()
            VistaT.Enabled = True
            VistaT.BringToFront()
        Else
            VistaPendientes.CargarDatos()
            VistaPendientes.Enabled = True
            VistaPendientes.BringToFront()
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        BD.Command($"update Tareas set 
                                Dia = '{dtpFecha.Value.Day}', 
                                Mes = '{dtpFecha.Value.Month}', 
                                Year = '{dtpFecha.Value.Year}' 
                        where ID_Tarea = {ID}")
        MsgBox("Fecha actualizada")
        btnAtras.PerformClick()
    End Sub
End Class