Imports System.Data.SqlClient
Public Class HBD
    Public Shared IDs As New ArrayList
    Public Sub CargarDatos()
        Dim lector As SqlDataReader
        IDs.Clear()
        lbHBD.Items.Clear()
        Dim query As String


        query = $"select ID_Contacto, Nombre, Apellido, Mes, Dia, pos = 1
                    from Contactos
                    where DATEFROMPARTS(2000, {Date.Today.Month}, {Date.Today.Day}) > DATEFROMPARTS(2000, Mes, Dia)
			            union all
		            select ID_Contacto, Nombre, Apellido, Mes, Dia, pos = 2
		            from Contactos
		            where DATEFROMPARTS(2000, {Date.Today.Month}, {Date.Today.Day}) <= DATEFROMPARTS(2000, Mes, Dia)
		        order by pos desc, mes, dia"

        lector = BD.ReadCommand(query)
        Do While lector.Read()
            lbHBD.Items.Add($"{lector("Dia")}/{lector("Mes")} - {lector("Nombre")} {lector("Apellido")}")
            IDs.Add(lector("ID_Contacto"))
        Loop
        lector.Close()
        btnVer.Enabled = False

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub lbHBD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbHBD.SelectedIndexChanged
        If lbHBD.SelectedIndex <> -1 Then
            btnVer.Enabled = True
        End If
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim lector As SqlDataReader

        lector = BD.ReadCommand($"select * from Contactos where ID_Contacto = {IDs(lbHBD.SelectedIndex)}")
        lector.Read()

        ContactoDetalles.lblNombre.Text = lector("Nombre")
        ContactoDetalles.lblApellido.Text = lector("Apellido")
        ContactoDetalles.lblTelefono.Text = lector("Telf")
        ContactoDetalles.lblEmail.Text = lector("Email")
        ContactoDetalles.lblFechaN.Text = $"{lector("Dia")}/{lector("Mes")}"
        ContactoDetalles.ID = lector("ID_Contacto")

        lector.Close()

        Me.Hide()
        ContactoDetalles.prev = "hbd"
        ContactoDetalles.Show()
    End Sub
End Class