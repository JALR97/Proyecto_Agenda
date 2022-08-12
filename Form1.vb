Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        BD.Cerrar()
        Application.Exit()
        End
    End Sub

    Private Sub btnVistaT_Click(sender As Object, e As EventArgs) Handles btnVistaT.Click
        Me.Hide()
        VistaT.Show()
        VistaT.CargarDatos()

    End Sub

    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        Me.Hide()
        VistaPendientes.Show()
        VistaPendientes.CargarDatos()
    End Sub

    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        Me.Hide()
        Contactos.Show()
        Contactos.CargarDatos()
    End Sub

    Private Sub btnHPB_Click(sender As Object, e As EventArgs) Handles btnHPB.Click
        Me.Hide()
        HBD.CargarDatos()
        HBD.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BD.Conectar()

    End Sub
End Class
