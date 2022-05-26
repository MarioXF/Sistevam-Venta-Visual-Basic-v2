Imports CapaDatos
Imports CapaEntidad
Public Class NCliente
    Dim objentCliente As New LCliente
    Dim objdatCliente As New DCliente
    'creacion de datatable
    Public Function MostrarClientes() As DataTable
        Dim dat As New DCliente
        Return dat.MostrarClientes()
    End Function
End Class
