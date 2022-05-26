Imports CapaDatos
Imports CapaEntidad
Public Class NProducto
    Dim objentProducto As New LProducto
    Dim objdatProducto As New DProducto
    'creacion de datatable
    Public Function MostrarProductos() As DataTable
        Dim dat As New DProducto
        Return dat.MostrarProductos()
    End Function
End Class
