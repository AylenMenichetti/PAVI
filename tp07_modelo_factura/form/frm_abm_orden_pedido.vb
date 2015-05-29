Public Class frm_orden_pedido
    Enum _resultado
        exitoso
        erroneo
    End Enum
    Enum accion
        insertar
        modificar
    End Enum
    Enum busqueda
        si_encontro
        no_encontro
    End Enum
    Public Property _sucursal() As Integer
        Get
            Return Me._txt_sucursal.Text
        End Get
        Set(ByVal value As Integer)
            Me._txt_sucursal.Text = value
        End Set
    End Property
    Public Property _nro_pedido() As Integer
        Get
            Return Me._txt_pedido.Text
        End Get
        Set(ByVal value As Integer)
            Me._txt_pedido.Text = value
            Me.estado = accion.modificar
        End Set
    End Property
    Public Property _cadena_conexion() As String
        Get
            Return Me.cadena_conexion
        End Get
        Set(ByVal value As String)
            Me.cadena_conexion = value
        End Set
    End Property
    Dim _cc0 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    Dim _dir As String = CurDir()
    Dim cadena_conexion As String = ""

    Dim estado As accion = accion.insertar
    Dim _acceso As acceso_a_datos

    Private Sub frm_orden_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._txt_fecha.Text = Today.Date()

        Me._donde_conectar_BD()
        Me._acceso = New acceso_a_datos(Me.cadena_conexion, acceso_a_datos.motores.OleDb)


    End Sub
    Private Sub _donde_conectar_BD()
        'Diseñada para trabajar con el critero de que la DB access esté siempre
        'en  el directorio en el que se encuentra el proyecto.
        '1) para tiempo de diseño en la raiz del proyecto
        '2) para sistema terminado en la raiz del ejecutable

        If Me._dir.IndexOf("bin") > 0 Then
            Me._dir = Me._dir.Substring(0, Me._dir.IndexOf("bin"))
        End If

        Me.cadena_conexion = Me._cc0 + Me._dir + "DBF.mdb"
        Me._objEsp_cliente._cadena_conexion = Me.cadena_conexion


    End Sub
    Private Sub _cmd_buscar_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmd_buscar_articulo.Click


        If Me._txt_id_articulo.Text = "" Then
            MsgBox("El Código del articulo esta vacio", MsgBoxStyle.Critical, "Importante")
            Exit Sub
        End If

        Dim tabla As New Data.DataTable
        Me._acceso._tabla = "t_articulos"
        tabla = Me._acceso.leo_tabla("id_articulo = " & Me._txt_id_articulo.Text.Trim())

        If tabla.Rows.Count > 0 Then
            Me._txt_articulo.Text = tabla.Rows(0)("n_articulo")
            Me._txt_precio.Text = tabla.Rows(0)("precio")
        Else
            MsgBox("No existe ese código de articulos", MsgBoxStyle.Critical, "Importante")
        End If

    End Sub
    Private Sub _cmd_agregar_grilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmd_agregar_grilla.Click

        Dim fila As Integer = Me._busca_duplicado()
 
        If fila > -1 Then
            Me.grilla1.Rows(fila).Cells(0).Value = Convert.ToDouble(Me.grilla1.Rows(fila).Cells(0).Value) + Convert.ToDouble(Me._txt_cantidad.Text)
            Me.grilla1.Rows(fila).Cells(4).Value = Convert.ToDouble(Me.grilla1.Rows(fila).Cells(0).Value) * Convert.ToDouble(Me._txt_precio.Text)
        Else
            Me.grilla1.Rows.Add(Convert.ToDouble(Me._txt_cantidad.Text), Convert.ToDouble(Me._txt_id_articulo.Text) _
                                , Me._txt_articulo.Text, Convert.ToDouble(Me._txt_precio.Text), Convert.ToDouble(Me._txt_Subtotal.Text))
        End If

        Me._txt_sub_total.Text = Me._calcular_total()
        Me._txt_total.Text = Me._txt_sub_total.Text
    End Sub
    Private Function _busca_duplicado() As Integer
        Dim c As Integer
        Dim encontro As Integer = -1

        For c = 0 To Me.grilla1.RowCount - 1
            If Me.grilla1.Rows(c).Cells(1).Value.ToString.Trim = Me._txt_id_articulo.Text.Trim Then
                encontro = c
                Exit For
            End If
        Next
        Return encontro
    End Function
    Private Function _calcular_total() As Double
        Dim c As Integer
        Dim calculo As Double
        calculo = 0
        For c = 0 To Me.grilla1.RowCount - 1
            calculo = calculo + Convert.ToDouble(Me.grilla1.Rows(c).Cells(4).Value)
        Next
        Return calculo
    End Function
    Private Sub _graba_pedido()
        Dim txt As String
        If estado = accion.insertar Then
            txt = "nro_pedido=" & Me._txt_pedido.Text
            txt &= ", nro_sucursal=" & Me._txt_sucursal.Text
            txt &= ", fecha=" & Me._txt_fecha.Text
            txt &= ", id_cliente=" & Me._objEsp_cliente._valor
            txt &= ", sub_total=" & Me._txt_sub_total.Text.Replace(",", ".")
            txt &= ", descuento=" & Me._txt_decuento.Text.Replace(",", ".")
            txt &= ", total=" & Me._txt_total.Text.Replace(",", ".")

            Me._acceso._tabla = "t_pedidos"
            Me._acceso._insertar(txt)
        Else
            txt = "UPDATE t_pedidos "
            txt &= "SET fecha=#" & Me._txt_fecha.Text & "#"
            txt &= ", id_cliente=" & Me._objEsp_cliente._valor
            txt &= ", sub_total=" & Me._txt_sub_total.Text.Replace(",", ".")
            txt &= ", descuentos=" & Me._txt_decuento.Text.Replace(",", ".")
            txt &= ", total=" & Me._txt_total.Text.Replace(",", ".")
            txt &= " WHERE (nro_sucursal=" & Me._txt_sucursal.Text.Trim
            txt &= ") AND (nro_pedido=" & Me._txt_pedido.Text.Trim & ")"

            Me._acceso._modificar(txt)

        End If
    End Sub
    Private Sub _grabar_detalle()
        Dim c As Integer
        Dim txt_insert As String = ""
        Dim txt_set, txt_res As String

        Me._acceso._tabla = "t_detalles_pedidos"

        Me.borrar_detalle()

        For c = 0 To Me.grilla1.RowCount() - 1
            If buscar_detalle(Me.grilla1.Rows(c).Cells("id").Value) = busqueda.no_encontro Then
                txt_insert &= "nro_pedido=" & Me._txt_pedido.Text
                txt_insert &= ", nro_sucursal=" & Me._txt_sucursal.Text
                txt_insert &= ", id_articulo=" & Me.grilla1.Rows(c).Cells("id").Value
                txt_insert &= ", cantidad=" & Me.grilla1.Rows(c).Cells("cantidad").Value.ToString.Replace(",", ".")
                txt_insert &= ", precio=" & Me.grilla1.Rows(c).Cells("precio").Value.ToString.Replace(",", ".")

                Me._acceso._insertar(txt_insert)
                txt_insert = ""
            Else
                txt_set = "cantidad=" & Me.grilla1.Rows(c).Cells("cantidad").Value.ToString.Replace(",", ".")
                txt_set &= ", precio=" & Me.grilla1.Rows(c).Cells("precio").Value.ToString.Replace(",", ".")

                txt_res = "nro_sucursal= " & Me._txt_sucursal.Text.Trim
                txt_res &= ",nro_pedido= " & Me._txt_pedido.Text.Trim
                txt_res &= ",id_articulo= " & Me.grilla1.Rows(c).Cells("id").Value

                Me._acceso._modificar(txt_set, txt_res)
                txt_set = ""
                txt_res = ""
            End If
        Next
    End Sub
    Private Sub borrar_detalle()
        Dim tabla As New Data.DataTable
        Dim sql, borrar As String
        Dim rgt, rgg As Integer
        Dim encontre As Boolean = False


        sql = "SELECT id_articulo FROM t_detalles_pedidos "
        sql &= " WHERE nro_pedido = " & Me._txt_pedido.Text
        sql &= " AND nro_sucursal=" & Me._txt_sucursal.Text

        tabla = Me._acceso._consulta(sql)
        If tabla.Rows.Count() = 0 Then
            Exit Sub
        End If

        For rgt = 0 To tabla.Rows.Count() - 1
            encontre = False
            For rgg = 0 To Me.grilla1.RowCount() - 1
                If tabla.Rows(rgt)(0) = Me.grilla1.Rows(rgg).Cells(1).Value Then
                    encontre = True
                    Exit For
                End If
            Next
            If encontre = False Then
                borrar = "DELETE FROM t_detalles_pedidos "
                borrar &= " WHERE nro_pedido = " & Me._txt_pedido.Text
                borrar &= " AND nro_sucursal= " & Me._txt_sucursal.Text
                borrar &= " AND id_articulo= " & tabla.Rows(rgt)(0)
                Me._acceso._borrar(borrar)
            End If
        Next

    End Sub
    Private Function buscar_detalle(ByVal articulo As String) As busqueda
        Dim tabla As New Data.DataTable
        Dim sql As String

        sql = "SELECT * FROM t_detalles_pedidos "
        sql &= " WHERE nro_pedido = " & Me._txt_pedido.Text
        sql &= " AND nro_sucursal=" & Me._txt_sucursal.Text
        sql &= " AND id_articulo=" & articulo

        tabla = Me._acceso._consulta(sql)

        Select Case tabla.Rows.Count()
            Case 0
                Return busqueda.no_encontro
            Case 1
                Return busqueda.si_encontro
        End Select
    End Function
    Private Sub cmd_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_grabar.Click

        If validar_pedido() = _resultado.exitoso Then
            If Me.grilla1.Rows.Count = 0 Then
                MsgBox("Falta el detalle del pedido")
                Exit Sub
            End If
            'comienza la conexión con manejo de transacción 
            Me._acceso._iniciar_conexion_con_transaccion()
            Me._graba_pedido()
            Me._grabar_detalle()
            Dim estado As Object
            estado = Me._acceso._finalizar_conexio_con_transaccion()
            'Finaliza conexión 
            If estado.ToString = "_ok" Then
                MsgBox("Se grabó exitosamente", MsgBoxStyle.Information, "Importante")
            Else
                MsgBox("Se produjo error en la grabación", MsgBoxStyle.Information, "Importante")
            End If

        End If
    End Sub
    Private Function validar_pedido() As _resultado
        If Me._txt_sucursal.Text = "" Then
            MsgBox("Falta la sucursal", MsgBoxStyle.Critical, "Importante")
            Me._txt_sucursal.Focus()
            Return _resultado.erroneo
        End If
        If Me._txt_pedido.Text = "" Then
            MsgBox("Falta el pedido", MsgBoxStyle.Critical, "Importante")
            Me._txt_pedido.Focus()
            Return _resultado.erroneo
        End If
        If Me._txt_fecha.Text = "" Then
            MsgBox("Falta la fecha", MsgBoxStyle.Critical, "Importante")
            Me._txt_fecha.Focus()
            Return _resultado.erroneo
        End If
        If Me._objEsp_cliente._valor = "" Then
            MsgBox("Falta el cliente", MsgBoxStyle.Critical, "Importante")
            Me._objEsp_cliente.Focus()
            Return _resultado.erroneo
        End If

        Return _resultado.exitoso

    End Function

    Private Sub _txt_cantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _txt_cantidad.TextChanged
        Dim a, b As Double

        a = Val(Me._txt_precio.Text.Replace(",", "."))
        b = Val(Me._txt_cantidad.Text.Replace(",", "."))

        Me._txt_Subtotal.Text = a * b

    End Sub

    Private Sub frm_orden_pedido_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Esta seguro que desea cerrar el formulairo", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Importante") = MsgBoxResult.Ok Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub limpiar(ByVal de_donde As Object)

        Dim gri As DataGridView

        For Each obj As System.Windows.Forms.Control In de_donde
            'MsgBox(obj.Name)
            Me.grilla1.Rows.Clear()
            Select Case obj.GetType().ToString
                Case "System.Windows.Forms.TextBox"
                    obj.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    obj.Text = ""
                Case "System.Windows.Forms.DataGridView"
                    gri = obj
                    gri.Rows.Clear()
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
    End Sub

    Private Sub recuperar_datos()
        Dim sql As String
        Dim tabla As New Data.DataTable

        sql = "SELECT t_pedidos.* " & _
            " FROM(t_pedidos) " & _
            " WHERE (nro_pedido = " & Trim(Me._txt_pedido.Text) & ")" & _
            " AND (nro_sucursal = " & Trim(Me._txt_sucursal.Text) & ")"

        tabla = Me._acceso._consulta(sql)

        Me._txt_fecha.Text = tabla.Rows(0)("fecha")
        Me._objEsp_cliente._valor = tabla.Rows(0)("id_cliente")

        Me._txt_sub_total.Text = tabla.Rows(0)("sub_total")
        Me._txt_total.Text = tabla.Rows(0)("total")
        Me._txt_decuento.Text = IIf(tabla.Rows(0)("descuentos").GetType().ToString = "System.DBNull", "0", tabla.Rows(0)("descuentos"))

        sql = "SELECT t_detalles_pedidos.cantidad, t_articulos.id_articulo, t_articulos.n_articulo, t_detalles_pedidos.precio" & _
              " FROM (t_detalles_pedidos INNER JOIN " & _
              " t_articulos ON t_detalles_pedidos.id_articulo = t_articulos.id_articulo) " & _
              " WHERE (nro_pedido = " & Trim(Me._txt_pedido.Text) & ")" & _
              " AND (nro_sucursal = " & Trim(Me._txt_sucursal.Text) & ")"


        tabla = Me._acceso._consulta(sql)

        Dim c As Integer

        For c = 0 To tabla.Rows.Count() - 1
            Me.grilla1.Rows.Add(tabla.Rows(c)("cantidad"), tabla.Rows(c)("id_articulo") _
                                , tabla.Rows(c)("n_articulo"), tabla.Rows(c)("precio") _
                                , tabla.Rows(c)("cantidad") * tabla.Rows(c)("precio"))
        Next


    End Sub

    Private Sub _cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmd_buscar.Click
        Me.limpiar(Me.Controls)
        Me.estado = accion.modificar
        frm_buscar_pedido.ShowDialog()
        If Me._txt_pedido.Text <> "" Then
            Me.recuperar_datos()
        End If
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        Me.limpiar(Me.Controls)
        Me._txt_fecha.Text = Today.Date()
        Me._txt_fecha.Focus()
        Me.estado = accion.insertar
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.grilla1.Rows.Clear()
    End Sub

    Private Sub grilla1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla1.CellDoubleClick
        If MsgBox("Está seguno que desea borrar esta fila de la grilla", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importante") = MsgBoxResult.Yes Then
            Me.grilla1.Rows.RemoveAt(Me.grilla1.CurrentRow.Index)
            Me._txt_sub_total.Text = Me._calcular_total()
            Me._txt_total.Text = Me._txt_sub_total.Text
        End If
    End Sub

    Private Sub _cmd_RC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim c As Integer
        Dim calcular As Double

        For c = 0 To Me.grilla1.Rows.Count - 1
            Me.grilla1.Rows(c).Cells(4).Value = Double.Parse(Me.grilla1.Rows(c).Cells(0).Value) * Me.grilla1.Rows(c).Cells(3).Value
            calcular += Me.grilla1.Rows(c).Cells(4).Value
        Next
        Me._txt_sub_total.Text = calcular
        Me._txt_total.Text = Me._txt_sub_total.Text - Me._txt_decuento.Text
    End Sub
End Class
