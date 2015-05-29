Public Class frm_ABM_gener
    Dim _tabla As String = ""
    Dim _pk As String = ""
    Dim _descripcion As String = ""
    'Dim string_conexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\documentos\utn\pav1_VB.NET\clases\TP5_MENU_GRILLA\DBF.mdb"

    Enum estado
        insertar
        modificar
    End Enum
    Enum valida
        ok
        errores
    End Enum
    Enum respuesta
        si
        no
    End Enum
    Dim accion As estado = estado.insertar
    Dim validar As valida = valida.errores
    Dim ad As New acceso_a_datos

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal tabla As String, ByVal nombre_pk As String, ByVal nombre_descripcion As String)
        InitializeComponent()

        _tabla = tabla
        _pk = nombre_pk
        _descripcion = nombre_descripcion
        Me.Text = "ABM - " & Me._tabla

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ad._tabla = Me._tabla
        Me.cargo_grilla(Me.ad.leo_tabla(Me._pk, Me._descripcion))

    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        Me.accion = estado.insertar
        Me.txt_nombre.Text = ""
        Me.txt_numero.Text = ""
        Me.txt_numero.Enabled = True
        Me.txt_nombre.Focus()
    End Sub

    Private Sub cargo_grilla(ByVal tabla As Data.DataTable)
        Me.grid.DataSource = tabla
        Me.seteo_grilla()
    End Sub

    Private Sub seteo_grilla()

        Me.grid.Columns(0).HeaderText = "Id"
        Me.grid.Columns(1).HeaderText = "Descripción"
        Me.grid.Columns(1).Width = 250

    End Sub

    Private Sub cmd_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_grabar.Click
        If validacion() = valida.ok Then
            If Me.accion = estado.insertar Then
                Me.inserta()
                Me.accion = estado.modificar
            Else
                Me.modificar()
            End If
            Me.ad._tabla = Me._tabla
            Me.cargo_grilla(Me.ad.leo_tabla(Me._pk, Me._descripcion))
        End If
    End Sub
    Private Function validacion() As valida

        If Me.txt_nombre.Text = "" Then
            MsgBox("El nombre del tipo no puede estar vacio", MsgBoxStyle.Critical, "Error")
            Me.txt_nombre.Focus()
            Return valida.errores
        End If
    End Function
    Private Sub inserta()

        Dim tabla As New Data.DataTable
        Dim sql_insert As String = ""
        Dim sql As String = ""
        Dim valor As Integer = 0


        If Me.txt_numero.Text = "" Then

            sql = "select max(" & Me._pk & ") as ultimo from " & Me._tabla
            tabla = Me.ad._consulta(sql)
            valor = tabla.Rows(0)("ultimo")
            Me.txt_numero.Text = valor + 1

        End If

        sql_insert = "insert into " & Me._tabla & " ( "
        sql_insert &= Me._pk
        sql_insert &= ", " & Me._descripcion & ") "
        sql_insert &= "valueS (" & Me.txt_numero.Text
        sql_insert &= ", '" & Me.txt_nombre.Text & "')"

        'MsgBox(sql_insert)

        Me.ad._insertar(sql_insert)

    
    End Sub
    Private Sub modificar()
        Dim sql_update As String = ""

        sql_update = "update " & Me._tabla
        sql_update &= " set " & Me._descripcion & " = '" & Me.txt_nombre.Text & "'"
        sql_update &= " where " & Me._pk & " = " & Me.txt_numero.Text

        Me.ad._modicar(sql_update)

    End Sub
    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick

        'MsgBox(Me.grid.Rows(Me.grid.CurrentRow.Index).Cells(1).Value)
        Me.txt_nombre.Text = Me.grid.CurrentRow.Cells(1).Value
        Me.txt_numero.Text = Me.grid.CurrentRow.Cells(0).Value
        Me.accion = estado.modificar
        Me.txt_nombre.Focus()
        Me.txt_numero.Enabled = False


    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
End Class