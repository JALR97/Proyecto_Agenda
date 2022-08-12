Imports System.Data.SqlClient
Public Class VistaT
    Public Shared IDs As New ArrayList

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Form1.Show()

    End Sub
    Public Sub CargarDatos()
        Dim hoy, semana As Date
        Dim lector As SqlDataReader
        IDs.Clear()

        lbTareas.Items.Clear()

        If radFecha.Checked Then
            hoy = dtpFecha.Value
        Else
            hoy = Date.Today()
        End If
        semana = hoy.AddDays(6)

        Dim query As String
        If radSemana.Checked Then
            query = $"WITH Agendados (ID_Tarea, Titulo, Dia, Mes, Year, Hecho) as
                        (SELECT ID_Tarea, Titulo, Dia, Mes, Year, Hecho
                        FROM Tareas
	                    WHERE Dia != 0)
                    SELECT ID_Tarea, Titulo, Dia, Mes, Hecho
                    FROM Agendados
                    WHERE (DATEFROMPARTS(Year, Mes, Dia) 
                        between DATEFROMPARTS({hoy.Year}, {hoy.Month}, {hoy.Day}) AND DATEFROMPARTS({semana.Year}, {semana.Month}, {semana.Day}))"
        Else
            query = $"SELECT ID_Tarea, Titulo, Dia, Mes FROM TAREAS 
                    WHERE dia = {hoy.Day} AND mes = {hoy.Month} 
                        AND year = {hoy.Year}"
        End If

        If chkListas.Checked = False Then
            query = query & " AND Hecho = 'False'"
        End If
        query = query & " 
                        Order by DATEFROMPARTS(Year, Mes, Dia)"

        lector = BD.ReadCommand(query)
        Do While lector.Read()
            lbTareas.Items.Add($"{lector("Dia")}/{lector("Mes")} - {lector("Titulo")}")
            IDs.Add(lector("ID_Tarea"))
        Loop
        lector.Close()
        gbTarea.Enabled = False
        lblTitulo.Text = "-"
        lblPrioridad.Text = "-"
        lblInfo.Text = "-"
    End Sub
    Public Sub CargarTarea(id As Integer)
        Dim lector As SqlDataReader
        TareaDetalles.IDsContactos.Clear()
        lector = BD.ReadCommand($"select * from Tareas where ID_Tarea = {id}")

        lector.Read()
        TareaDetalles.lblTitulo.Text = lector("Titulo")
        TareaDetalles.lblInfo.Text = lector("Info")
        TareaDetalles.lblDireccion.Text = lector("Lugar")
        TareaDetalles.lblCategoria.Text = lector("Categoria")
        TareaDetalles.ID = lector("ID_Tarea")
        TareaDetalles.chkListo.Checked = lector("Hecho")
        If lector("Dia") <> 0 Then
            TareaDetalles.lblFecha.Text = $"{lector("Dia")}/{lector("Mes")}/{lector("Year")}"
        Else
            TareaDetalles.lblFecha.Text = "Sin fecha"
        End If

        If lector("Prioridad") = 1 Then
            TareaDetalles.lblPrioridad.Text = "Prioridad Baja"
        ElseIf lector("Prioridad") = 2 Then
            TareaDetalles.lblPrioridad.Text = "Prioridad Media"
        Else
            TareaDetalles.lblPrioridad.Text = "Prioridad Alta"
        End If
        lector.Close()

        TareaDetalles.lbContactos.Items.Clear()
        lector.Close()
        lector = BD.ReadCommand($"select ID_Contacto, Nombre, Apellido from Contactos 
                                    where ID_Contacto in 
                                        (select ID_Contacto from Tareas_Contactos 
                                        where ID_Tarea = {TareaDetalles.ID})")
        Do While lector.Read()
            TareaDetalles.lbContactos.Items.Add($"{lector("Nombre")} {lector("Apellido")}")
            TareaDetalles.IDsContactos.Add(lector("ID_Contacto"))
        Loop
        TareaDetalles.btnVerContacto.Enabled = False
        lector.Close()

    End Sub
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        CargarTarea(IDs(lbTareas.SelectedIndex))
        Me.Hide()
        TareaDetalles.Show()
        TareaDetalles.prev = "vist"
    End Sub
    Private Sub chkListas_CheckedChanged(sender As Object, e As EventArgs) Handles chkListas.CheckedChanged
        CargarDatos()
    End Sub

    Private Sub lbTareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTareas.SelectedIndexChanged
        Dim lector As SqlDataReader
        If lbTareas.SelectedIndex = -1 Then
            Exit Sub
        End If

        lector = BD.ReadCommand($"select Titulo, Info, Prioridad 
                                    from Tareas 
                                    where ID_Tarea = {IDs(lbTareas.SelectedIndex)}")
        lector.Read()
        lblTitulo.Text = lector("Titulo")
        If lector("Prioridad") = 1 Then
            lblPrioridad.Text = "Prioridad baja"
        ElseIf lector("Prioridad") = 2 Then
            lblPrioridad.Text = "Prioridad media"
        Else
            lblPrioridad.Text = "Prioridad alta"
        End If
        lblInfo.Text = lector("Info")
        gbTarea.Enabled = True
        lector.Close()
    End Sub

    Private Sub btnTareaN_Click(sender As Object, e As EventArgs) Handles btnTareaN.Click
        Me.Hide()
        NuevaTarea.ModoTarea(1)
        NuevaTarea.Show()
        NuevaTarea.prev = "vist"
        NuevaTarea.CargarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        TareaDetalles.ID = IDs(lbTareas.SelectedIndex)
        If TareaDetalles.Eliminar() Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnReagendar_Click(sender As Object, e As EventArgs) Handles btnReagendar.Click
        Me.Enabled = False
        Agendar.ID = IDs(lbTareas.SelectedIndex)
        Agendar.Show()
        Agendar.prev = "vist"
    End Sub
    Private Sub radHoy_CheckedChanged(sender As Object, e As EventArgs) Handles radHoy.CheckedChanged
        If radHoy.Checked Then
            CargarDatos()
        End If
    End Sub
    Private Sub radFecha_CheckedChanged(sender As Object, e As EventArgs) Handles radFecha.CheckedChanged
        If radFecha.Checked Then
            dtpFecha.Enabled = True
            CargarDatos()
        Else
            dtpFecha.Enabled = False
        End If
    End Sub
    Private Sub radSemana_CheckedChanged(sender As Object, e As EventArgs) Handles radSemana.CheckedChanged
        If radSemana.Checked Then
            CargarDatos()
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If radFecha.Checked Then
            dtpFecha.Enabled = True
            CargarDatos()
        End If
    End Sub
End Class