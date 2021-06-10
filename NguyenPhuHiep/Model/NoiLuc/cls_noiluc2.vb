' Dữ liệu đem đi tổ hợp , lấy từ bảng mà ta đã lọc ra : 


Public Class cls_noiluc2 ' Cho thằng cơ bản 1 kế thừa lại là xong 

    Private _name As String  ' M3,m2,o
    Private _TT As Double
    Private _HT As Double
    Private _GXP As Double
    Private _GXT As Double
    Private _GYp As Double
    Private _GYT As Double

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property TT As Double
        Get
            Return _TT
        End Get
        Set(value As Double)
            _TT = value
        End Set
    End Property

    Public Property HT As Double
        Get
            Return _HT
        End Get
        Set(value As Double)
            _HT = value
        End Set
    End Property

    Public Property GXP As Double
        Get
            Return _GXP
        End Get
        Set(value As Double)
            _GXP = value
        End Set
    End Property

    Public Property GXT As Double
        Get
            Return _GXT
        End Get
        Set(value As Double)
            _GXT = value
        End Set
    End Property

    Public Property GYp As Double
        Get
            Return _GYp
        End Get
        Set(value As Double)
            _GYp = value
        End Set
    End Property

    Public Property GYT As Double
        Get
            Return _GYT
        End Get
        Set(value As Double)
            _GYT = value
        End Set
    End Property
End Class
