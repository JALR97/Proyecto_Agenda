Imports System.Data.SqlClient
Public Class NuevaTarea
    Public Shared IDs As New ArrayList
    Public Shared prev As String
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        LimpiarCampos()
        If Me.Text = "Nueva Tarea" Then
            If prev = "vist" Then
                VistaT.Show()
                VistaT.CargarDatos()
            Else
                VistaPendientes.Show()
                VistaPendientes.CargarDatos()
            End If
        Else
            TareaDetalles.Show()
            VistaT.CargarTarea(TareaDetalles.ID)
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtTitulo.Text = ""
        txtInfo.Text = ""
        txtLugar.Text = ""
        cboCategoria.SelectedIndex = -1
        cboPrioridad.SelectedIndex = -1
        radNo.Checked = True
        IDs.Clear()
        lbContactos.Items.Clear()

    End Sub
    Private Function GenerarID()
        Dim lector As SqlDataReader
        Dim ant As Integer = 0
        lector = BD.ReadCommand("select ID_Tarea from Tareas order by ID_Tarea")
        Do While lector.Read()
            If lector(0) - ant > 1 Then
                Exit Do
            Else
                ant = lector(0)
            End If
        Loop
        lector.Close()
        Return ant + 1
    End Function

    Public Sub ModoTarea(opc As Integer)
        If opc = 1 Then
            Me.Text = "Nueva Tarea"
            btnFinalizar.Text = "Finalizar"
            lblHeader.Text = "Ingrese la informacion de la nueva tarea"
        Else
            Me.Text = "Modificar Tarea"
            btnFinalizar.Text = "Modificar"
            lblHeader.Text = "Puede modificar la tarea"
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim dia, mes, year, id As Integer

        If txtTitulo.Text = "" Or cboPrioridad.Text = "" Then
            MsgBox($"Debe darle un titulo y nivel de prioridad a la tarea", vbOKOnly, "Error")
            Exit Sub
        End If

        If radSi.Checked Then
            dia = dtpFecha.Value.Day
            mes = dtpFecha.Value.Month
            year = dtpFecha.Value.Year
        Else
            dia = 0
            mes = 0
            year = 0
        End If

        If btnFinalizar.Text = "Finalizar" Then
            id = GenerarID()
            BD.Command($"insert into Tareas 
                                values({id}, 
                                '{txtTitulo.Text}', 
                                '{txtInfo.Text}', 
                                {dia}, 
                                {mes}, 
                                {year}, 
                                '{txtLugar.Text}', 
                                {cboPrioridad.SelectedIndex + 1}, 
                                '{cboCategoria.Text}', 
                                0)")
            MsgBox("Tarea registrada correctamente", vbOKOnly, "Completado")
        Else
            id = TareaDetalles.ID
            BD.Command($"update Tareas set 
                                Titulo = '{txtTitulo.Text}', 
                                Info = '{txtInfo.Text}',
                                Dia = {dia},
                                Mes = {mes},
                                Year = {year},
                                Lugar = '{txtLugar.Text}', 
                                Categoria = '{cboCategoria.Text}' 
                        where ID_Tarea = {TareaDetalles.ID}")
            MsgBox("Datos actualizados", vbOKOnly, "Completado")
        End If
        BD.Command($"DELETE FROM Tareas_Contactos WHERE ID_Tarea = {id}")
        If IDs.Count() > 0 Then
            For Each idC In IDs
                BD.Command($"insert into Tareas_Contactos values({id}, {idC})")
            Next
        End If

        If btnFinalizar.Text = "Finalizar" Then
            LimpiarCampos()
        End If
    End Sub

    Private Sub radSi_CheckedChanged(sender As Object, e As EventArgs) Handles radSi.CheckedChanged
        If (radSi.Checked = True) Then
            dtpFecha.Enabled = True
        Else
            dtpFecha.Enabled = False
        End If
    End Sub

    Private Sub btnNuevaCat_Click(sender As Object, e As EventArgs) Handles btnNuevaCat.Click
        Me.Enabled = False
        NuevaCategoria.Show()
    End Sub
    Public Sub CargarDatos()
        Dim lector As SqlDataReader
        lector = BD.ReadCommand($"select * from Categorias")
        cboCategoria.Items.Clear()
        IDs.Clear()

        Do While lector.Read()
            cboCategoria.Items.Add(lector(0))
        Loop

        If btnFinalizar.Text = "Modificar" Then
            lbContactos.Items.Clear()
            lector.Close()
            lector = BD.ReadCommand($"select ID_Contacto, Nombre, Apellido from Contactos 
                                    where ID_Contacto in 
                                        (select ID_Contacto from Tareas_Contactos 
                                        where ID_Tarea = {TareaDetalles.ID})")
            Do While lector.Read()
                lbContactos.Items.Add($"{lector("Nombre")} {lector("Apellido")}")
                IDs.Add(lector("ID_Contacto"))
            Loop
            lector.Close()
        End If
    End Sub
    Private Sub btnNuevoContacto_Click(sender As Object, e As EventArgs) Handles btnNuevoContacto.Click
        Cont_Tareas.CargarContactos()
        If Cont_Tareas.cboContacto.Items.Count = 0 Then
            MsgBox("No hay contactos disponibles para agregar")
        Else
            Me.Enabled = False
            Cont_Tareas.Show()
        End If
    End Sub

    Private Sub lbContactos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContactos.SelectedIndexChanged
        btnEliminar.Enabled = True

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lbContactos.SelectedIndex <> -1 Then
            IDs.RemoveAt(lbContactos.SelectedIndex)
            lbContactos.Items.RemoveAt(lbContactos.SelectedIndex)
            btnEliminar.Enabled = False
        End If
    End Sub
End Class