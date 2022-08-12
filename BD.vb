Imports System.Data.SqlClient
Public Class BD
    Public Shared conexion As SqlConnection

    'Pasos Basicos necesarios para conectarse con la base de datos, a traves de la variable cn.
    Public Shared Sub Conectar()
        conexion = New SqlConnection("Data Source=JL-LAPTOP\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True;MultipleActiveResultSets=True")
        conexion.Open()

    End Sub
    Public Shared Sub Cerrar()
        conexion.Close()
    End Sub
    Public Shared Function Command(q As String)
        Dim comando As New SqlCommand(q, conexion)
        Dim resp As Integer
        Try
            resp = comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Form1.BtnSalir.PerformClick()
        End Try

        Return resp
    End Function
    Public Shared Function ReadCommand(q As String)
        Dim comando As New SqlCommand(q, conexion)
        Dim lector As SqlDataReader

        Try
            lector = comando.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()
            Application.Exit()
        End Try
        Return lector
    End Function
End Class
