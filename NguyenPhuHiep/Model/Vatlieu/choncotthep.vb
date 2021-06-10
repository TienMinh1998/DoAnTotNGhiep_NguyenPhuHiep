Public Class choncotthep
    Private _sothanhthep As Integer
    Private _duongkinh As Integer
    Private _AreaSteel As Double

    Public Property Sothanhthep As Integer
        Get
            Return _sothanhthep
        End Get
        Set(value As Integer)
            _sothanhthep = value
        End Set
    End Property
    Public Property Duongkinh As Integer
        Get
            Return _duongkinh
        End Get
        Set(value As Integer)
            _duongkinh = value
        End Set
    End Property
    Public ReadOnly Property AreaSteel As Double ' thuộc tính chỉ đọc
        Get
            Return _AreaSteel
        End Get
    End Property
    Public Sub New(n As Integer, DK As Integer)
        _sothanhthep = n
        _duongkinh = DK
    End Sub
    Public Sub New()
        ' Hàm KHởi tạo không có gì
    End Sub
    Private Function Area(DK As Integer) As Double
        Select Case DK
            Case 6
                _AreaSteel = 28.3
            Case 8
                _AreaSteel = 50.3
            Case 10
                _AreaSteel = 78.5
            Case 12
                _AreaSteel = 113
            Case 14
                _AreaSteel = 154
            Case 16
                _AreaSteel = 201
            Case 18
                _AreaSteel = 254
            Case 20
                _AreaSteel = 314
            Case 22
                _AreaSteel = 380
            Case 25
                _AreaSteel = 419
            Case 28
                _AreaSteel = 615
            Case Else
                _AreaSteel = 0
        End Select
        Return AreaSteel
    End Function
    ''' <summary>
    ''' đơn vị để là mm
    ''' </summary>
    ''' <returns></returns>
    Public Function dientichchon() As Double
        Return _sothanhthep * Area(_duongkinh)
    End Function


End Class
