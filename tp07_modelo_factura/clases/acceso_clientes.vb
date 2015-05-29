Public Class acceso_clientes
    Inherits acceso_a_datos

    Public Event inicializar()
    Public Sub ini()
        Me._tabla = "t_clientes"
    End Sub
End Class
