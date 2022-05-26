Imports CapaDatos
Imports CapaEntidad
Public Class NCategoria
    Dim objentCliente As New LCategoria
    Dim objdatCliente As New DCategoria
    'creacion de datatable
    Public Function MostrarCategoria() As DataTable
        Dim dat As New DCategoria
        Return dat.MostrarCategoria()
    End Function
End Class
