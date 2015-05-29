<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tp4_acceso_datos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tp4_acceso_datos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox
        Me.txt_nombres = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox
        Me.lst_datos = New System.Windows.Forms.ListBox
        Me.cmd_nuevo = New System.Windows.Forms.Button
        Me.cmd_grabar = New System.Windows.Forms.Button
        Me.cmd_cancelar = New System.Windows.Forms.Button
        Me.cmd_salir = New System.Windows.Forms.Button
        Me.cmb_estado_civil = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opt_masculino = New System.Windows.Forms.RadioButton
        Me.opt_femenino = New System.Windows.Forms.RadioButton
        Me.chk_fallecio = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(31, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Documento"
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(106, 28)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(337, 20)
        Me.txt_apellido.TabIndex = 0
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(106, 79)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_documento.TabIndex = 2
        '
        'txt_nombres
        '
        Me.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombres.Location = New System.Drawing.Point(106, 54)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(337, 20)
        Me.txt_nombres.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(44, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombres"
        '
        'txt_documento
        '
        Me.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento.Location = New System.Drawing.Point(106, 106)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(58, 20)
        Me.txt_documento.TabIndex = 3
        '
        'lst_datos
        '
        Me.lst_datos.FormattingEnabled = True
        Me.lst_datos.Location = New System.Drawing.Point(1, 253)
        Me.lst_datos.Name = "lst_datos"
        Me.lst_datos.Size = New System.Drawing.Size(465, 108)
        Me.lst_datos.TabIndex = 6
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = CType(resources.GetObject("cmd_nuevo.Image"), System.Drawing.Image)
        Me.cmd_nuevo.Location = New System.Drawing.Point(1, 367)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(40, 44)
        Me.cmd_nuevo.TabIndex = 7
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.Image = CType(resources.GetObject("cmd_grabar.Image"), System.Drawing.Image)
        Me.cmd_grabar.Location = New System.Drawing.Point(47, 367)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(40, 44)
        Me.cmd_grabar.TabIndex = 8
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(93, 367)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(40, 44)
        Me.cmd_cancelar.TabIndex = 9
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(426, 367)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(40, 44)
        Me.cmd_salir.TabIndex = 10
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmb_estado_civil
        '
        Me.cmb_estado_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado_civil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_estado_civil.FormattingEnabled = True
        Me.cmb_estado_civil.Location = New System.Drawing.Point(106, 132)
        Me.cmb_estado_civil.Name = "cmb_estado_civil"
        Me.cmb_estado_civil.Size = New System.Drawing.Size(121, 21)
        Me.cmb_estado_civil.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(31, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Estado Civil"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.opt_masculino)
        Me.GroupBox1.Controls.Add(Me.opt_femenino)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 62)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'opt_masculino
        '
        Me.opt_masculino.AutoSize = True
        Me.opt_masculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt_masculino.Location = New System.Drawing.Point(22, 39)
        Me.opt_masculino.Name = "opt_masculino"
        Me.opt_masculino.Size = New System.Drawing.Size(72, 17)
        Me.opt_masculino.TabIndex = 1
        Me.opt_masculino.Text = "Masculino"
        Me.opt_masculino.UseVisualStyleBackColor = True
        '
        'opt_femenino
        '
        Me.opt_femenino.AutoSize = True
        Me.opt_femenino.Checked = True
        Me.opt_femenino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt_femenino.Location = New System.Drawing.Point(22, 16)
        Me.opt_femenino.Name = "opt_femenino"
        Me.opt_femenino.Size = New System.Drawing.Size(70, 17)
        Me.opt_femenino.TabIndex = 0
        Me.opt_femenino.TabStop = True
        Me.opt_femenino.Text = "Femenino"
        Me.opt_femenino.UseVisualStyleBackColor = True
        '
        'chk_fallecio
        '
        Me.chk_fallecio.AutoSize = True
        Me.chk_fallecio.BackColor = System.Drawing.Color.Transparent
        Me.chk_fallecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_fallecio.Location = New System.Drawing.Point(106, 230)
        Me.chk_fallecio.Name = "chk_fallecio"
        Me.chk_fallecio.Size = New System.Drawing.Size(59, 17)
        Me.chk_fallecio.TabIndex = 11
        Me.chk_fallecio.Text = "Falleció"
        Me.chk_fallecio.UseVisualStyleBackColor = False
        '
        'frm_tp4_acceso_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(468, 411)
        Me.Controls.Add(Me.chk_fallecio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_estado_civil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.lst_datos)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_tipo_documento)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_tp4_acceso_datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Personas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lst_datos As System.Windows.Forms.ListBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmb_estado_civil As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents opt_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents chk_fallecio As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
