<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _combo_av2
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_combo_av2))
        Me._txt_descpripcion = New System.Windows.Forms.TextBox()
        Me._txt_id = New System.Windows.Forms.TextBox()
        Me._lbl_etiqueta = New System.Windows.Forms.Label()
        Me._cmb_combo = New System.Windows.Forms.ComboBox()
        Me._cmb_buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_txt_descpripcion
        '
        Me._txt_descpripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txt_descpripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_descpripcion.Location = New System.Drawing.Point(169, 3)
        Me._txt_descpripcion.Name = "_txt_descpripcion"
        Me._txt_descpripcion.Size = New System.Drawing.Size(156, 20)
        Me._txt_descpripcion.TabIndex = 1
        '
        '_txt_id
        '
        Me._txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txt_id.Location = New System.Drawing.Point(101, 3)
        Me._txt_id.Name = "_txt_id"
        Me._txt_id.Size = New System.Drawing.Size(62, 20)
        Me._txt_id.TabIndex = 0
        '
        '_lbl_etiqueta
        '
        Me._lbl_etiqueta.Location = New System.Drawing.Point(3, 5)
        Me._lbl_etiqueta.Name = "_lbl_etiqueta"
        Me._lbl_etiqueta.Size = New System.Drawing.Size(92, 15)
        Me._lbl_etiqueta.TabIndex = 2
        Me._lbl_etiqueta.Text = "Label1"
        Me._lbl_etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_cmb_combo
        '
        Me._cmb_combo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._cmb_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._cmb_combo.FormattingEnabled = True
        Me._cmb_combo.Location = New System.Drawing.Point(101, 3)
        Me._cmb_combo.Name = "_cmb_combo"
        Me._cmb_combo.Size = New System.Drawing.Size(271, 21)
        Me._cmb_combo.TabIndex = 3
        Me._cmb_combo.Visible = False
        '
        '_cmb_buscar
        '
        Me._cmb_buscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._cmb_buscar.Image = CType(resources.GetObject("_cmb_buscar.Image"), System.Drawing.Image)
        Me._cmb_buscar.Location = New System.Drawing.Point(328, 1)
        Me._cmb_buscar.Name = "_cmb_buscar"
        Me._cmb_buscar.Size = New System.Drawing.Size(23, 24)
        Me._cmb_buscar.TabIndex = 2
        Me._cmb_buscar.Text = "..."
        Me._cmb_buscar.UseVisualStyleBackColor = True
        '
        '_combo_av2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me._lbl_etiqueta)
        Me.Controls.Add(Me._txt_id)
        Me.Controls.Add(Me._txt_descpripcion)
        Me.Controls.Add(Me._cmb_buscar)
        Me.Controls.Add(Me._cmb_combo)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Name = "_combo_av2"
        Me.Size = New System.Drawing.Size(383, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _cmb_buscar As System.Windows.Forms.Button
    Friend WithEvents _txt_descpripcion As System.Windows.Forms.TextBox
    Friend WithEvents _lbl_etiqueta As System.Windows.Forms.Label
    Friend WithEvents _cmb_combo As System.Windows.Forms.ComboBox
    Private WithEvents _txt_id As System.Windows.Forms.TextBox

End Class
