Public Class frm_buscar_pedido

    Private Sub frm_buscar_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.buscar_datos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub _grid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles _grid1.CellDoubleClick
        frm_orden_pedido._sucursal = Me._grid1.CurrentRow.Cells(1).Value
        frm_orden_pedido._nro_pedido = Me._grid1.CurrentRow.Cells(0).Value

        Me.Close()

    End Sub

    Private Sub buscar_datos()
        Dim _acceso1 As New acceso_a_datos(frm_orden_pedido._cadena_conexion, acceso_a_datos.motores.OleDb)

        Dim sql As String
        Dim tablaL As New Data.DataTable

        sql = "SELECT t_pedidos.nro_pedido, t_pedidos.nro_sucursal, t_pedidos.fecha, t_clientes.n_cliente, t_pedidos.total " & _
              " FROM (t_pedidos INNER JOIN " & _
              "t_clientes ON t_pedidos.id_cliente = t_clientes.id_cliente)"

        tablaL = _acceso1._consulta(sql)

        Dim c As Integer

        Me._grid1.Rows.Clear()

        For c = 0 To tablaL.Rows.Count() - 1
            Me._grid1.Rows.Add(tablaL.Rows(c)("nro_pedido"), tablaL.Rows(c)("nro_sucursal"), tablaL.Rows(c)("fecha") _
            , tablaL.Rows(c)("n_cliente"), tablaL.Rows(c)("total"))
        Next

    End Sub

End Class