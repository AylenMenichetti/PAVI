Public Class frm_inicio_sistema

    Private Sub ABMPersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMPersonasToolStripMenuItem.Click
        frm_tp4_acceso_datos.Show()
    End Sub

    Private Sub ABMTipoDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMTipoDocumentoToolStripMenuItem.Click
        Dim frm_ABM_gener As New frm_ABM_gener("tipo_documento", "id_tipo_documento", "n_tipo_documento")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMTToolStripMenuItem.Click
        Dim frm_ABM_gener As New frm_ABM_gener("estado_civil", "id_estado_civil", "n_estado_civil")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub AMBOrdenDePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AMBOrdenDePedidosToolStripMenuItem.Click
        frm_orden_pedido.ShowDialog()
    End Sub
End Class
