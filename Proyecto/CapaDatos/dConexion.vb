Imports System.Data.SqlClient
Imports System.Configuration

Public Class dConexion

    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("dbventas").ConnectionString)
    Public Sub conectar()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
