<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputData
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
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt = New TextBoxv01()
        Me.SuspendLayout()
        '
        'etiqueta
        '
        Me.etiqueta.Location = New System.Drawing.Point(3, 23)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(86, 17)
        Me.etiqueta.TabIndex = 1
        Me.etiqueta.Text = "Etiqueta"
        Me.etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt._datoBD = False
        Me.txt._descriptor_del_contenido = "Texto para búsqueda por descrición"
        Me.txt._mensajeError = ""
        Me.txt._tipo_dato = TextBoxv01.t_dato.texto
        Me.txt._validar = False
        Me.txt._valor = ""
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Location = New System.Drawing.Point(95, 23)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 20)
        Me.txt.TabIndex = 0
        '
        'InputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.etiqueta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mensaje"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiqueta As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt As TextBoxv01
End Class
