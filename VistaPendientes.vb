Imports System.Data.SqlClient
Public Class VistaPendientes
    Public Shared IDs As New ArrayList
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Form1.Show()

    End Sub
    Public Sub CargarDatos()
        Dim lector As SqlDataReader
        IDs.Clear()
        lbPendientes.Items.Clear()

        lector = BD.ReadCommand($"select ID_Tarea, Titulo 
                                from Tareas
                                where dia = 0 
                                Order by Titulo")
        Do While lector.Read()
            lbPendientes.Items.Add(lector("Titulo"))
            IDs.Add(lector("ID_Tarea"))
        Loop
        lector.Close()
        lblTitulo.Text = "-"
        lblInfo.Text = "-"
        gbTarea.Enabled = False
    End Sub
    Private Sub btnTareaN_Click(sender As Object, e As EventArgs) Handles btnTareaN.Click
        Me.Hide()
        NuevaTarea.ModoTarea(1)
        NuevaTarea.Show()
        NuevaTarea.prev = "pen"
        NuevaTarea.CargarDatos()
    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        Me.Enabled = False
        Agendar.ID = IDs(lbPendientes.SelectedIndex)
        Agendar.Show()
        Agendar.prev = "pen"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        TareaDetalles.ID = IDs(lbPendientes.SelectedIndex)
        If TareaDetalles.Eliminar() Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        VistaT.CargarTarea(IDs(lbPendientes.SelectedIndex))
        Me.Hide()
        TareaDetalles.Show()
        TareaDetalles.prev = "pen"

    End Sub

    Private Sub lbPendientes_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lbPendientes.SelectedIndexChanged

        If lbPendientes.SelectedIndex <> -1 Then
            Dim lector As SqlDataReader
            lector = BD.ReadCommand($"select Titulo, Info 
                                    from Tareas 
                                    where ID_Tarea = {IDs(lbPendientes.SelectedIndex)}")
            lector.Read()
            lblTitulo.Text = lector("Titulo")
            lblInfo.Text = lector("Info")
            gbTarea.Enabled = True
            lector.Close()
        End If
    End Sub
End Class