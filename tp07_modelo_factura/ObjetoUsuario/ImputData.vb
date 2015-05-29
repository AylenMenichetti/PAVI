Public Class InputData

    Public Property _dato() As String
        Get
            Return Me.txt.Text
        End Get
        Set(ByVal value As String)
            Me.txt.Text = value
        End Set
    End Property
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal _rotulo As String, ByVal _etiqueta As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.Text = _rotulo
        Me.etiqueta.Text = _etiqueta

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub InputData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt.SelectionStart = Me.txt.Text.Length()
        Me.txt.SelectionLength = 0
    End Sub

    Private Sub txt_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt.Validating
        Me.Close()
    End Sub

End Class