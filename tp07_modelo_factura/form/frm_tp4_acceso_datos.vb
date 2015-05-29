Public Class frm_tp4_acceso_datos
    Enum estado
        insertar
        modificar
    End Enum
    Enum validacion
        positiva
        negativa
    End Enum
    Dim editar As estado = estado.insertar
    Dim _conex As New acceso_a_datos
    Dim _combo As New combo
 
    Private Sub frm_tp3_acceso_datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me._combo.cargar(Me.cmb_tipo_documento, "tipo_documento")
        Me._combo.cargar(Me.cmb_estado_civil, "estado_civil")

        carga_lista()

        Me.ToolTip1.SetToolTip(Me.cmd_nuevo, "Nuevo Registro")
        Me.ToolTip1.SetToolTip(Me.cmd_grabar, "Grabar la información actula")
        Me.ToolTip1.SetToolTip(Me.cmd_cancelar, "Borra el registro seleccionado de la lista")

    End Sub

    Private Function insertar() As Boolean
        Dim consulta As String = ""

        consulta = "insert into personas ("
        consulta &= "apellido, nombres, tipo_documento, documento, estado_civil, sexo, fallecio) "
        consulta &= "values ('" & Me.txt_apellido.Text & "', '" & Me.txt_nombres.Text & "' ,"
        consulta &= Me.cmb_tipo_documento.SelectedValue & ", " & Me.txt_documento.Text & ","
        consulta &= Me.cmb_estado_civil.SelectedValue & ", "
        consulta &= IIf(Me.opt_femenino.Checked = True, 2, 1) & ", "
        consulta &= Me.chk_fallecio.Checked & ")"

        Me._conex._insertar(consulta)

        Return True
    End Function

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
    Private Sub cmd_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_grabar.Click
        If Me.validar() = validacion.positiva Then
            If Me.editar = estado.insertar Then
                If Me.validar_existencia() = validacion.negativa Then
                    Me.insertar()
                    Me.editar = estado.modificar
                    Me.txt_documento.Enabled = False
                    MessageBox.Show("Se grabó exitosamente", "Importante", _
                    MessageBoxButtons.OK)
                Else
                    MsgBox("Ya existe una persona con ese número de documento", MsgBoxStyle.OkOnly, "Importante")
                    Exit Sub
                End If
            Else
                Me.modificar(Me.txt_documento.Text)
            End If
            Me.carga_lista()
        End If
    End Sub
    Private Function validar() As validacion
        If Me.txt_apellido.Text = "" Then
            MsgBox("El apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txt_apellido.Focus()
            Return validacion.negativa
        End If
        Return validacion.positiva
    End Function
    Private Function validar_existencia() As validacion
        Dim dt As New Data.DataTable

        dt = Me._conex._consulta("select * from personas where documento = " & Me.txt_documento.Text)

        If dt.Rows.Count() = 1 Then
            Return validacion.positiva
        Else
            Return validacion.negativa
        End If

    End Function
    Private Sub carga_lista()

        Dim tabla2 As New Data.DataTable
        tabla2 = Me._conex._consulta("select apellido+', '+nombres as nombre, documento from personas")
        Me.lst_datos.DataSource = tabla2
        Me.lst_datos.ValueMember = "documento"
        Me.lst_datos.DisplayMember = "nombre"

    End Sub
    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        Me.limpiar(Me)
        Me.editar = estado.insertar
        Me.txt_documento.Enabled = True
        Me.txt_apellido.Focus()
    End Sub

    Private Sub limpiar(ByVal EsteFormulario As System.Windows.Forms.Form)

        For Each EsteControl As System.Windows.Forms.Control In EsteFormulario.Controls

            Select Case EsteControl.GetType().ToString()
                Case "System.Windows.Forms.ComboBox"
                    EsteControl.ResetText()
                Case "System.Windows.Forms.TextBox"
                    EsteControl.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    EsteControl.Text = ""
            End Select
        Next

    End Sub
    Private Sub recupero(ByVal nro_documento As Integer)

        Dim dt As New Data.DataTable

        dt = Me._conex._consulta("select * from personas where documento = " & nro_documento)

        Dim cc As Int16 = 0

        'While dt.Rows.Count > cc
        '    MsgBox(dt.Rows(cc)("Apellido") & "    " & dt.Rows(cc)("documento"))
        '    cc += 1
        'End While

        Me.txt_apellido.Text = dt.Rows(0)("apellido")
        Me.txt_nombres.Text = dt.Rows(0)("nombres")
        Me.txt_documento.Text = dt.Rows(0)("documento")
        Me.cmb_tipo_documento.SelectedValue = dt.Rows(0)("tipo_documento")
        Me.cmb_estado_civil.SelectedValue = dt.Rows(0)("estado_civil")
        If dt.Rows(0)("sexo") = 2 Then
            Me.opt_femenino.Checked = True
        Else
            Me.opt_masculino.Checked = True
        End If
        Me.chk_fallecio.Checked = dt.Rows(0)("fallecio")

    End Sub

    Private Sub lst_datos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_datos.DoubleClick
        Me.recupero(Me.lst_datos.SelectedValue)
        Me.txt_documento.Enabled = False
        Me.editar = estado.modificar
    End Sub
    Private Sub modificar(ByVal nro_documento As Integer)

         Dim consulta As String = ""

        consulta = "update personas "
        consulta &= "set apellido = '" & Me.txt_apellido.Text & "'"
        consulta &= ", nombres = '" & Me.txt_nombres.Text & "'"
        consulta &= ", tipo_documento = " & Me.cmb_tipo_documento.SelectedValue
        consulta &= ", estado_civil = " & Me.cmb_estado_civil.SelectedValue
        consulta &= ", sexo = " & IIf(Me.opt_femenino.Checked = True, 2, 1)
        consulta &= ", fallecio = " & Me.chk_fallecio.Checked
        consulta &= " where documento = " & nro_documento

        Me._conex._modicar(consulta)

    End Sub
    Private Sub borrar(ByVal nro_documento As Integer)

        Me._conex._borrar("DELETE FROM personas WHERE documento = " & nro_documento)

    End Sub
  
    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If Me.lst_datos.SelectedIndex = -1 Then
            MsgBox("No seleccionó ninguna persona para borrar", MsgBoxStyle.Critical, "Importante")
            Exit Sub
        End If

        If MessageBox.Show("Está seguro que quiere borra ese registro", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.borrar(Me.lst_datos.SelectedValue)
            Me.carga_lista()
        End If
    End Sub
End Class
