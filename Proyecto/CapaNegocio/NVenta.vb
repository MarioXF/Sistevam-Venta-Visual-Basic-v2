Imports CapaDatos
Imports CapaEntidad
Public Class NVenta
    Dim objentCliente As New LVenta
    Dim objdatCliente As New DVenta
    'creacion de datatable
    Public Function MostrarVenta() As DataTable
        Dim dat As New DVenta
        Return dat.MostrarVenta()
    End Function
End Class
