Imports CapaDatos
Imports CapaEntidad
Public Class NEmpleado
    Dim objentEmpleado As New LEmpleado
    Dim objdatEmpleado As New DEmpleado
    'creacion de datatable
    Public Function MostrarEmpleado() As DataTable
        Dim dat As New DEmpleado
        Return dat.MostrarEmpleado
    End Function
End Class
