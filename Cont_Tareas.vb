Imports System.Data.SqlClient
Public Class Cont_Tareas
    Dim IDs As New ArrayList
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        NuevaTarea.Enabled = True
        NuevaTarea.BringToFront()
    End Sub
    Public Sub CargarContactos()
        Dim lector As SqlDataReader
        lector = BD.ReadCommand($"select ID_Contacto, Nombre, Apellido from Contactos")
        IDs.Clear()
        cboContacto.Items.Clear()

        Do While lector.Read()
            If Not NuevaTarea.IDs.Contains(lector("ID_Contacto")) Then
                cboContacto.Items.Add($"{lector("Nombre")} {lector("Apellido")}")
                IDs.Add(lector("ID_Contacto"))
            End If
        Loop
        lector.Close()

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cboContacto.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un contacto")
        Else
            NuevaTarea.lbContactos.Items.Add(cboContacto.SelectedItem)
            NuevaTarea.IDs.Add(IDs(cboContacto.SelectedIndex))
            btnAtras.PerformClick()
        End If
    End Sub
End Class