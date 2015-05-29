<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inicio_sistema
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMTipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AMBOrdenDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMPersonasToolStripMenuItem, Me.ABMTipoDocumentoToolStripMenuItem, Me.ABMTToolStripMenuItem, Me.AMBOrdenDePedidosToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ABMPersonasToolStripMenuItem
        '
        Me.ABMPersonasToolStripMenuItem.Name = "ABMPersonasToolStripMenuItem"
        Me.ABMPersonasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ABMPersonasToolStripMenuItem.Text = "ABM Personas"
        '
        'ABMTipoDocumentoToolStripMenuItem
        '
        Me.ABMTipoDocumentoToolStripMenuItem.Name = "ABMTipoDocumentoToolStripMenuItem"
        Me.ABMTipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ABMTipoDocumentoToolStripMenuItem.Text = "ABM Tipo de Documento"
        '
        'ABMTToolStripMenuItem
        '
        Me.ABMTToolStripMenuItem.Name = "ABMTToolStripMenuItem"
        Me.ABMTToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ABMTToolStripMenuItem.Text = "ABM Tipo de Estado Civil"
        '
        'AMBOrdenDePedidosToolStripMenuItem
        '
        Me.AMBOrdenDePedidosToolStripMenuItem.Name = "AMBOrdenDePedidosToolStripMenuItem"
        Me.AMBOrdenDePedidosToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AMBOrdenDePedidosToolStripMenuItem.Text = "AMB Orden de Pedidos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'frm_inicio_sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 515)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_inicio_sistema"
        Me.Text = "Sistema Aprendizaje"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMPersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTipoDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AMBOrdenDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
