<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orden_pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orden_pedido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me._txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._txt_sucursal = New System.Windows.Forms.MaskedTextBox()
        Me._txt_pedido = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grilla1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._cmd_agregar_grilla = New System.Windows.Forms.Button()
        Me._txt_articulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me._cmd_buscar_articulo = New System.Windows.Forms.Button()
        Me._txt_Subtotal = New System.Windows.Forms.MaskedTextBox()
        Me._txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me._txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me._txt_id_articulo = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me._txt_decuento = New System.Windows.Forms.MaskedTextBox()
        Me._txt_total = New System.Windows.Forms.MaskedTextBox()
        Me._txt_sub_total = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._objEsp_cliente = New WindowsApplication1._combo_av2()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        '_txt_fecha
        '
        Me._txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_fecha.Location = New System.Drawing.Point(112, 16)
        Me._txt_fecha.Mask = "00/00/0000"
        Me._txt_fecha.Name = "_txt_fecha"
        Me._txt_fecha.Size = New System.Drawing.Size(74, 20)
        Me._txt_fecha.TabIndex = 0
        Me._txt_fecha.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro Pedido"
        '
        '_txt_sucursal
        '
        Me._txt_sucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_sucursal.Location = New System.Drawing.Point(112, 40)
        Me._txt_sucursal.Name = "_txt_sucursal"
        Me._txt_sucursal.Size = New System.Drawing.Size(40, 20)
        Me._txt_sucursal.TabIndex = 1
        Me._txt_sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_pedido
        '
        Me._txt_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_pedido.Location = New System.Drawing.Point(224, 40)
        Me._txt_pedido.Name = "_txt_pedido"
        Me._txt_pedido.Size = New System.Drawing.Size(58, 20)
        Me._txt_pedido.TabIndex = 2
        Me._txt_pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grilla1)
        Me.GroupBox1.Controls.Add(Me._cmd_agregar_grilla)
        Me.GroupBox1.Controls.Add(Me._txt_articulo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_1)
        Me.GroupBox1.Controls.Add(Me._cmd_buscar_articulo)
        Me.GroupBox1.Controls.Add(Me._txt_Subtotal)
        Me.GroupBox1.Controls.Add(Me._txt_precio)
        Me.GroupBox1.Controls.Add(Me._txt_cantidad)
        Me.GroupBox1.Controls.Add(Me._txt_id_articulo)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 272)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'grilla1
        '
        Me.grilla1.AllowUserToAddRows = False
        Me.grilla1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grilla1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grilla1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Id, Me.Articulo, Me.Precio, Me.Subtotal})
        Me.grilla1.Location = New System.Drawing.Point(7, 70)
        Me.grilla1.Name = "grilla1"
        Me.grilla1.RowHeadersWidth = 20
        Me.grilla1.Size = New System.Drawing.Size(490, 190)
        Me.grilla1.TabIndex = 7
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 70
        '
        'Id
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Id.DefaultCellStyle = DataGridViewCellStyle3
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Width = 50
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Artículo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Width = 200
        '
        'Precio
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 62
        '
        'Subtotal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Width = 70
        '
        '_cmd_agregar_grilla
        '
        Me._cmd_agregar_grilla.Location = New System.Drawing.Point(423, 41)
        Me._cmd_agregar_grilla.Name = "_cmd_agregar_grilla"
        Me._cmd_agregar_grilla.Size = New System.Drawing.Size(75, 23)
        Me._cmd_agregar_grilla.TabIndex = 6
        Me._cmd_agregar_grilla.Text = "Agregar"
        Me._cmd_agregar_grilla.UseVisualStyleBackColor = True
        '
        '_txt_articulo
        '
        Me._txt_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_articulo.Location = New System.Drawing.Point(180, 19)
        Me._txt_articulo.Name = "_txt_articulo"
        Me._txt_articulo.Size = New System.Drawing.Size(318, 20)
        Me._txt_articulo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Artículo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Precio"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(46, 46)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_1.TabIndex = 0
        Me.lbl_1.Text = "Cantidad"
        '
        '_cmd_buscar_articulo
        '
        Me._cmd_buscar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmd_buscar_articulo.Location = New System.Drawing.Point(146, 18)
        Me._cmd_buscar_articulo.Name = "_cmd_buscar_articulo"
        Me._cmd_buscar_articulo.Size = New System.Drawing.Size(28, 20)
        Me._cmd_buscar_articulo.TabIndex = 1
        Me._cmd_buscar_articulo.Text = "..."
        Me._cmd_buscar_articulo.UseVisualStyleBackColor = True
        '
        '_txt_Subtotal
        '
        Me._txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_Subtotal.Location = New System.Drawing.Point(337, 44)
        Me._txt_Subtotal.Name = "_txt_Subtotal"
        Me._txt_Subtotal.Size = New System.Drawing.Size(58, 20)
        Me._txt_Subtotal.TabIndex = 5
        Me._txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_precio
        '
        Me._txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_precio.Location = New System.Drawing.Point(219, 44)
        Me._txt_precio.Name = "_txt_precio"
        Me._txt_precio.Size = New System.Drawing.Size(58, 20)
        Me._txt_precio.TabIndex = 4
        Me._txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_cantidad
        '
        Me._txt_cantidad.AccessibleDescription = ""
        Me._txt_cantidad.AllowPromptAsInput = False
        Me._txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_cantidad.Location = New System.Drawing.Point(100, 44)
        Me._txt_cantidad.Name = "_txt_cantidad"
        Me._txt_cantidad.Size = New System.Drawing.Size(58, 20)
        Me._txt_cantidad.SkipLiterals = False
        Me._txt_cantidad.TabIndex = 3
        Me._txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_id_articulo
        '
        Me._txt_id_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_id_articulo.Location = New System.Drawing.Point(100, 18)
        Me._txt_id_articulo.Name = "_txt_id_articulo"
        Me._txt_id_articulo.Size = New System.Drawing.Size(40, 20)
        Me._txt_id_articulo.TabIndex = 0
        Me._txt_id_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SubTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Decuento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(413, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total"
        '
        '_cmd_buscar
        '
        Me._cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.BUSCAR01
        Me._cmd_buscar.Location = New System.Drawing.Point(140, 13)
        Me._cmd_buscar.Name = "_cmd_buscar"
        Me._cmd_buscar.Size = New System.Drawing.Size(35, 35)
        Me._cmd_buscar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me._cmd_buscar, "Buscar un Pedido Realizado")
        Me._cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(327, 13)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(35, 35)
        Me.cmd_salir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cmd_salir, "Salir del Formulario")
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(88, 13)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(35, 35)
        Me.cmd_cancelar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmd_cancelar, "Cancelar")
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.Image = CType(resources.GetObject("cmd_grabar.Image"), System.Drawing.Image)
        Me.cmd_grabar.Location = New System.Drawing.Point(49, 13)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(35, 35)
        Me.cmd_grabar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmd_grabar, "Grabar")
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = CType(resources.GetObject("cmd_nuevo.Image"), System.Drawing.Image)
        Me.cmd_nuevo.Location = New System.Drawing.Point(10, 13)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(35, 35)
        Me.cmd_nuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cmd_nuevo, "Nuevo")
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        '_txt_decuento
        '
        Me._txt_decuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_decuento.Location = New System.Drawing.Point(456, 395)
        Me._txt_decuento.Name = "_txt_decuento"
        Me._txt_decuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txt_decuento.Size = New System.Drawing.Size(58, 20)
        Me._txt_decuento.TabIndex = 7
        Me._txt_decuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_total
        '
        Me._txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_total.Location = New System.Drawing.Point(456, 418)
        Me._txt_total.Name = "_txt_total"
        Me._txt_total.ReadOnly = True
        Me._txt_total.Size = New System.Drawing.Size(58, 20)
        Me._txt_total.TabIndex = 8
        Me._txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txt_sub_total
        '
        Me._txt_sub_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_sub_total.Location = New System.Drawing.Point(456, 372)
        Me._txt_sub_total.Name = "_txt_sub_total"
        Me._txt_sub_total.ReadOnly = True
        Me._txt_sub_total.Size = New System.Drawing.Size(58, 20)
        Me._txt_sub_total.TabIndex = 6
        Me._txt_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me._cmd_buscar)
        Me.GroupBox2.Controls.Add(Me.cmd_salir)
        Me.GroupBox2.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox2.Controls.Add(Me.cmd_grabar)
        Me.GroupBox2.Controls.Add(Me.cmd_nuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 54)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        '_objEsp_cliente
        '
        Me._objEsp_cliente._cadena_conexion = Nothing
        Me._objEsp_cliente._descripcion = "n_cliente"
        Me._objEsp_cliente._descriptor_del_contenido = "Razon Social - Nombre Cliente"
        Me._objEsp_cliente._etiqueta = "Clientes"
        Me._objEsp_cliente._left = 0
        Me._objEsp_cliente._mensajeError = ""
        Me._objEsp_cliente._pk = "id_cliente"
        Me._objEsp_cliente._pk_tipo = WindowsApplication1._combo_av2.tipo_pk.numerico
        Me._objEsp_cliente._tabla = "t_clientes"
        Me._objEsp_cliente._top = 0
        Me._objEsp_cliente._validar = False
        Me._objEsp_cliente._valor = ""
        Me._objEsp_cliente.BackColor = System.Drawing.Color.Transparent
        Me._objEsp_cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me._objEsp_cliente.Location = New System.Drawing.Point(10, 63)
        Me._objEsp_cliente.Name = "_objEsp_cliente"
        Me._objEsp_cliente.Size = New System.Drawing.Size(383, 27)
        Me._objEsp_cliente.TabIndex = 9
        '
        'frm_orden_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 446)
        Me.Controls.Add(Me._objEsp_cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me._txt_total)
        Me.Controls.Add(Me._txt_decuento)
        Me.Controls.Add(Me._txt_sub_total)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me._txt_pedido)
        Me.Controls.Add(Me._txt_sucursal)
        Me.Controls.Add(Me._txt_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_orden_pedido"
        Me.Text = "Orden de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _txt_sucursal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_pedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _txt_articulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents _cmd_buscar_articulo As System.Windows.Forms.Button
    Friend WithEvents _txt_id_articulo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _txt_Subtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_precio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grilla1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents _cmd_agregar_grilla As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents _txt_decuento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_sub_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _objEsp_cliente As WindowsApplication1._combo_av2

End Class
