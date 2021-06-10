
''' <summary>
'''  Bảng tổ hợp nội lực tại 1 tiết diện
''' </summary>
Public Class Element
    Private _tencot As String
    Public location As Double ' Vị trí tổ hơk
    Public Garena As New List(Of cls_noiluc2) ' danh sách

    Public Property Tencot As String
        Get
            Return _tencot
        End Get
        Set(value As String)
            _tencot = value
        End Set
    End Property
End Class
