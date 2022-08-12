Imports System.Data.SqlClient
Public Class NuevaCategoria
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        NuevaTarea.Show()
        NuevaTarea.cboCategoria.SelectedIndex = -1
        NuevaTarea.CargarDatos()
        NuevaTarea.Enabled = True
        NuevaTarea.BringToFront()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim lector As SqlDataReader
        lector = BD.ReadCommand($"select Categoria 
                                    from Categorias 
                                    where Categoria = '{txtCategoria.Text}'")

        If txtCategoria.Text = "" Then
            MsgBox("Debe llenar el campo de categoria", vbOKOnly, "Error")
        ElseIf lector.Read() Then
            MsgBox("La categoria ya existe", vbOKOnly, "Error")
        Else
            BD.Command($"insert into Categorias 
                                values('{txtCategoria.Text}')")
            MsgBox("Categoria registrada correctamente", vbOKOnly, "Completado")
            txtCategoria.Text = ""
        End If

    End Sub
End Class