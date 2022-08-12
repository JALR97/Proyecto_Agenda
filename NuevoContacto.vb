Imports System.Data.SqlClient
Public Class NuevoContacto
    Public Shared prev As String
    Public Sub ModoContacto(opc As Integer)
        If opc = 1 Then
            Me.Text = "Nuevo Contacto"
            btnFinalizar.Text = "Finalizar"
            lblHeader.Text = "Ingrese la informacion del nuevo contacto"
        Else
            Me.Text = "Modificar Contacto"
            btnFinalizar.Text = "Modificar"
            lblHeader.Text = "Puede Modificar la informacion del contacto"
        End If
    End Sub
    Private Function GenerarID()
        Dim lector As SqlDataReader
        Dim ant As Integer = 0
        lector = BD.ReadCommand("select ID_Contacto from Contactos order by ID_Contacto")
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
    Private Sub LimpiarCampos()
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtTelf.Text = ""
        txtEmail.Text = ""
        dtpCumple.Value = Date.Today()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        LimpiarCampos()
        Me.Hide()
        If prev = "det" Then
            Contactos.CargarContacto(ContactoDetalles.ID)
            ContactoDetalles.Show()
        ElseIf prev = "all" Then
            Contactos.CargarDatos()
            Contactos.Show()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If txtNombre.Text = "" Then
            MsgBox($"Debe darle un nombre al contacto antes de finalizar", vbOKOnly, "Error")
            Exit Sub
        End If

        If btnFinalizar.Text = "Finalizar" Then
            BD.Command($"insert into Contactos 
                        values({GenerarID()}, 
                        '{txtNombre.Text}', 
                        '{txtApellido.Text}', 
                        {dtpCumple.Value.Day}, 
                        {dtpCumple.Value.Month}, 
                        '{txtTelf.Text}', 
                        '{txtEmail.Text}')")
            MsgBox("Contacto registrado correctamente", vbOKOnly, "Completado")
            LimpiarCampos()
        Else
            BD.Command($"update Contactos set 
                                Nombre = '{txtNombre.Text}', 
                                Apellido = '{txtApellido.Text}', 
                                Dia = {dtpCumple.Value.Day}, 
                                Mes = {dtpCumple.Value.Month},
                                Telf = '{txtTelf.Text}', 
                                Email = '{txtEmail.Text}'
                        Where ID_Contacto = {ContactoDetalles.ID}")
            MsgBox("Datos actualizados", vbOKOnly, "Completado")
        End If

    End Sub
End Class