Imports System.Data.SqlClient
Public Class Contactos
    Public Shared IDs As New ArrayList
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Form1.Show()

    End Sub
    Public Sub CargarDatos()
        Dim lector As SqlDataReader
        IDs.Clear()
        lbContactos.Items.Clear()
        Dim query As String

        query = $"select ID_Contacto, Nombre, Apellido 
                    from Contactos 
                    order by Nombre"

        lector = BD.ReadCommand(query)
        Do While lector.Read()
            lbContactos.Items.Add($"{lector("Nombre")} {lector("Apellido")}")
            IDs.Add(lector("ID_Contacto"))
        Loop
        lector.Close()
        btnVer.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub lbContactos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContactos.SelectedIndexChanged
        If lbContactos.SelectedIndex <> -1 Then
            btnVer.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoContacto.ModoContacto(1)
        NuevoContacto.Show()
        NuevoContacto.prev = "all"
    End Sub
    Public Sub CargarContacto(id As Integer)
        Dim lector As SqlDataReader

        lector = BD.ReadCommand($"select * from Contactos where ID_Contacto = {id}")
        lector.Read()

        ContactoDetalles.lblNombre.Text = lector("Nombre")
        ContactoDetalles.lblApellido.Text = lector("Apellido")
        ContactoDetalles.lblTelefono.Text = lector("Telf")
        ContactoDetalles.lblEmail.Text = lector("Email")
        ContactoDetalles.lblFechaN.Text = $"{lector("Dia")}/{lector("Mes")}"
        ContactoDetalles.ID = lector("ID_Contacto")

        lector.Close()
    End Sub
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        CargarContacto(IDs(lbContactos.SelectedIndex))
        Me.Hide()
        ContactoDetalles.Show()
        ContactoDetalles.prev = "all"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ContactoDetalles.ID = IDs(lbContactos.SelectedIndex)
        If ContactoDetalles.Eliminar() Then
            CargarDatos()
        End If
    End Sub
End Class