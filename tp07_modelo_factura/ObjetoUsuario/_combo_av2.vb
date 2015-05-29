Imports System.Windows.Forms


Public Class _combo_av2
    Enum tipo_pk
        numerico
        texto
    End Enum

    Dim cadena_conexion As String
    Dim _acceso As New acceso_a_datos
    Dim _combo As New combo
    Dim for_top, for_left As Integer
    Dim tabla As String
    Dim pk As String
    Dim descripcion As String
    Dim pk_tipo As tipo_pk = tipo_pk.numerico

    Dim validar As Boolean
    Dim descriptor_del_contenido As String = ""
    Dim mensajeError As String = ""

    Dim marcarError As New ErrorProvider

    Public Property _marcarError As ErrorProvider
        Set(ByVal value As ErrorProvider)
            marcarError = value
        End Set
        Get
            Return marcarError
        End Get
    End Property

    Public Property _mensajeError As String
        Set(ByVal value As String)
            mensajeError = value
        End Set
        Get
            Return mensajeError
        End Get
    End Property
    Public Property _validar As Boolean
        Set(ByVal value As Boolean)
            validar = value
        End Set
        Get
            Return validar
        End Get
    End Property
    Public Property _descriptor_del_contenido As String
        Set(ByVal value As String)
            Me.descriptor_del_contenido = value
        End Set
        Get
            Return descriptor_del_contenido
        End Get
    End Property
    Public Property _valor As String
        Set(ByVal value As String)
            Me._txt_id.Text = value
        End Set
        Get
            Return Me._txt_id.Text
        End Get
    End Property
    Public Property _cadena_conexion() As String
        Get
            Return cadena_conexion
        End Get
        Set(ByVal value As String)
            Me.cadena_conexion = value
            Me._acceso._CadenaConexion = value
        End Set
    End Property

    Public Property _etiqueta() As String
        Get
            Return Me._lbl_etiqueta.Text
        End Get
        Set(ByVal value As String)
            Me._lbl_etiqueta.Text = value
        End Set
    End Property
    Public Property _tabla() As String
        Get
            Return Me.tabla
        End Get
        Set(ByVal value As String)
            Me.tabla = value
        End Set
    End Property
    Public Property _pk() As String
        Get
            Return Me.pk
        End Get
        Set(ByVal value As String)
            Me.pk = value
        End Set
    End Property
    Public Property _descripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(ByVal value As String)
            Me.descripcion = value
        End Set
    End Property
    Public Property _top() As Integer
        Get
            Return for_top
        End Get
        Set(ByVal value As Integer)
            for_top = value
        End Set
    End Property
    Public Property _left() As Integer
        Get
            Return for_left
        End Get
        Set(ByVal value As Integer)
            for_left = value
        End Set
    End Property
    Public Property _pk_tipo As tipo_pk
        Get
            Return pk_tipo
        End Get
        Set(ByVal value As tipo_pk)
            pk_tipo = value
        End Set
    End Property
    Private Sub _txt_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _txt_id.KeyPress

        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 166) Then
            Dim frm1 As New InputData("Ingrese Código", "Código")
            frm1._dato = e.KeyChar
            frm1.ShowDialog()
            Me.buscar(frm1._dato)
            e.KeyChar = ""
            frm1.Close()
        End If

    End Sub

    Private Sub _txt_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _txt_id.TextChanged
        If Me._txt_id.Text = "" Then
            Exit Sub
        End If
        Me.buscar(Me._txt_id.Text)
    End Sub
    Private Sub buscar(ByVal dato As String)
        If IsNumeric(dato) Then
            If Me.pk_tipo = tipo_pk.numerico Then
                buscar_dato(Me.pk & " = " & dato)
            Else
                buscar_dato(Me.pk & " = '" & dato & "'")
            End If
        Else
            If Me.pk_tipo = tipo_pk.texto Then
                buscar_dato(Me.pk & " = '" & Me.pk.Trim & "' OR " & Me._descripcion & " like '%" & dato & "%'")
            Else
                buscar_dato(Me._descripcion & " like '%" & dato & "%'")
            End If
        End If
    End Sub
    Private Sub buscar_dato(ByVal restriccion As String)
        Dim tabla As New Data.DataTable

        Me._acceso._tabla = Me.tabla
        tabla = Me._acceso.leo_tabla(restriccion)

        Select Case tabla.Rows.Count
            Case 1
                Me._txt_descpripcion.Text = tabla.Rows(0)(Me.descripcion)
                Me._txt_id.Text = tabla.Rows(0)(Me.pk)
            Case 0
                Me._combo.cargar(Me._cmb_combo, Me._acceso.leo_tabla(Me.pk, Me.descripcion))
                Me.cambio_estado()

            Case Else
                Me._combo.cargar(Me._cmb_combo, tabla)
                Me.cambio_estado()

        End Select
    End Sub

    Private Sub _cmb_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmb_buscar.Click
        Me._acceso._tabla = Me.tabla
        Me._combo.cargar(Me._cmb_combo, Me._acceso.leo_tabla(Me.pk, Me.descripcion))
        Me.cambio_estado()
    End Sub
    Private Sub cambio_estado()
        If Me._cmb_combo.Visible = False Then
            Me._cmb_buscar.Visible = False
            Me._txt_id.Visible = False
            Me._txt_descpripcion.Visible = False
            Me._cmb_combo.Visible = True
            Me._cmb_combo.Focus()

            Me._cmb_combo.SelectedIndex = 0
            Me.Cursor = Cursors.Arrow

            Me._cmb_combo.DroppedDown = True

        Else
            Me._cmb_buscar.Visible = True
            'Me._cmd_nuevo.Visible = True
            Me._txt_id.Visible = True
            Me._txt_descpripcion.Visible = True
            Me._cmb_combo.Visible = False
        End If
    End Sub

    Private Sub _cmb_combo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmb_combo.SelectionChangeCommitted
        Me._txt_id.Text = sender.selectedValue
        Me.cambio_estado()
    End Sub


End Class
