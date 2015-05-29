Imports System.Windows.Forms

Public Class TextBoxv01

    Inherits TextBox
    Enum t_dato
        texto
        numerico
        fecha
        mixto
    End Enum
    Dim validar As Boolean = True
    Dim datoBD As Boolean = False
    Dim tipo_dato As t_dato
    Dim descriptor_del_contenido As String = ""
    Dim mensajeError As String = ""
    Dim marcarError As New ErrorProvider

    Public Property _datoBD As Boolean
        Set(ByVal value As Boolean)
            Me.datoBD = value
        End Set
        Get
            Return datoBD
        End Get
    End Property

    Public Property _marcarError As ErrorProvider
        Set(ByVal value As ErrorProvider)
            marcarError = value
        End Set
        Get
            Return marcarError
        End Get
    End Property

    ''' <summary>
    ''' Aquí se puede agregar escuetamente la descripción del contenido del objeto, esto se utilizará 
    ''' para conformar el mensaje de error si no se declaró mensaje de error, en la validación atomáticas
    '''  si es un objeto validable
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _descriptor_del_contenido As String
        Set(ByVal value As String)
            Me.descriptor_del_contenido = value
        End Set
        Get
            Return descriptor_del_contenido
        End Get
    End Property
    Public Property _tipo_dato As t_dato
        Set(ByVal value As t_dato)
            tipo_dato = value
        End Set
        Get
            Return tipo_dato
        End Get
    End Property

    Public Property _valor As String
        Set(ByVal value As String)
            Me.Text = value
        End Set
        Get
            Return Me.Text
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
    Public Property _mensajeError As String
        Set(ByVal value As String)
            mensajeError = value
        End Set
        Get
            Return mensajeError
        End Get
    End Property
    Public Sub New()
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub

    Private Function validar_dato(ByVal keychar As String) As String
        Select Case Asc(keychar)
            Case 24, 4, 19, 127, 13, 9, 15, 14, 8
                Return keychar
        End Select

        If IsNumeric(keychar) = False Then
            MsgBox("Este carater no es un numero ( " + keychar + " )", vbCritical, "Importante")
            Return ""
        End If
        Return keychar
    End Function

    Private Sub _KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

        Select Case tipo_dato
            Case t_dato.numerico
                e.KeyChar = Me.validar_dato(e.KeyChar)
        End Select
    End Sub

End Class
