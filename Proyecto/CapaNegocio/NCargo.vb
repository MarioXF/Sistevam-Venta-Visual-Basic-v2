Imports CapaDatos
Imports CapaEntidad
Public Class NCargo
    Dim objentCliente As New LCargo
    Dim objdatCliente As New DCargo
    'creacion de datatable
    Public Function MostrarCargo() As DataTable
        Dim dat As New DCargo
        Return dat.MostrarCargo()
    End Function
End Class
