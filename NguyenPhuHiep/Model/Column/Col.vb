
' Lớp Cột 
Public Class Col

    Private _id As Integer
    Private _Dk As Double
    Private _radius As Double
    Private _Chieudai As Double
    Private _lucdoc As Double
    Private _momen As Double

    Private _lopbaove As Double
    Private _ra As Double ' đây là k/c từ tâm cột đến tâm cốt thép

    ' Tính Các Tỉ số : 
    Private _w As Double
    Private _beta As Double
    Private _denta As Double
    Private _Er As Double ' Ép xi lon R theo tiêu chuẩn cũ 
    Private _vatlieu As Material
    ''' <summary>
    ''' Ứng xuất tới hạn trong vùng bê tông chịu nén, với tải trọng thường xuyên lấy bằng 500Mpa, 
    ''' Với tải trọng ngắn hạn lấy bằng 400Mpa
    ''' </summary>
    Private _ximau As Integer
    ''' <summary>
    ''' hàm khởi tạo của cột
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="Dk"></param>
    ''' <param name="chieudai"></param>
    ''' <param name="lucdoc"></param>
    ''' <param name="momen"></param>
    ''' <param name="lopbaove">Lớp bảo vệ</param>
    ''' <param name="mt">Vật Liệu truyền vào</param>
    Public Sub New(id As Integer, Dk As Double, chieudai As Double, lucdoc As Double, momen As Double, lopbaove As Double, mt As Material)

        Me.Id = id
        Me.Dk = Dk
        Me.Chieudai = chieudai
        Me.Lucdoc = lucdoc
        Me.Momen = momen
        Me.Lopbaove = lopbaove
        Me.vatlieu = mt
        Me.Ximau = 400
        Me.Ra = Radius - Me.Lopbaove


        '1  Tính kc den tam cot thep
        Me.Ra = Me.Radius - Me.Lopbaove
        '2 TÍnh Tỉ số Beta
        Me.Beta = Me.Ra / Me.Radius
        '3 Tính Denta : 
        Me.Denta = 1.5 * (6 * mt.Rs) / 10 ^ 4
        '4  Tinh Omega : < noi luc tu so do doan hoi > 
        Me.W = 0.85 - 0.008 * Me.vatlieu.Rb
        '5 Tính ép xi lon R  Theo tiều chuẩn cũ : 
        Me.Er = W / (1 + Vatlieu.Rs / Ximau * (1 - (W / 1.1)))

    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    ''' <summary>
    ''' Đường Kính của cột
    ''' </summary>
    ''' <returns></returns>
    Public Property Dk As Double
        Get
            Return _Dk
        End Get
        Set(value As Double)
            _Dk = value
        End Set
    End Property

    Public Property Chieudai As Double
        Get
            Return _Chieudai
        End Get
        Set(value As Double)
            _Chieudai = value
        End Set
    End Property

    Public Property Lucdoc As Double
        Get
            Return _lucdoc
        End Get
        Set(value As Double)
            _lucdoc = value
        End Set
    End Property

    Public Property Momen As Double
        Get
            Return _momen
        End Get
        Set(value As Double)
            _momen = value
        End Set
    End Property

    Public Property Lopbaove As Double
        Get
            Return _lopbaove
        End Get
        Set(value As Double)
            _lopbaove = value
        End Set
    End Property

    Public Property Ra As Double
        Get
            Return _ra
        End Get
        Set(value As Double)
            _ra = value
        End Set
    End Property

    Public Property Radius As Double
        Get
            Return _radius
        End Get
        Set(value As Double)
            _radius = value
        End Set
    End Property

    Public Property Beta As Double
        Get
            Return _beta
        End Get
        Set(value As Double)
            _beta = value
        End Set
    End Property

    Public Property Denta As Double
        Get
            Return _denta
        End Get
        Set(value As Double)
            _denta = value
        End Set
    End Property
    ''' <summary>
    ''' Nội Lực Từ sơ đồ đàn hồi
    ''' </summary>
    ''' <returns></returns>
    Public Property W As Double
        Get
            Return _w
        End Get
        Set(value As Double)
            _w = value
        End Set
    End Property

    Public Property Er As Double
        Get
            Return _Er
        End Get
        Set(value As Double)
            _Er = value
        End Set
    End Property
    ''' <summary>
    ''' Vật Liệu sử dụng để thiết kế cột, trong đó có thép và bê tông
    ''' </summary>
    ''' <returns></returns>
    Public Property Vatlieu As Material
        Get
            Return _vatlieu
        End Get
        Set(value As Material)
            _vatlieu = value
        End Set
    End Property
    ''' <summary>
    ''' Ứng xuât giới hạn của vùng bê tông chịu nén(khi bê tông đạt đến cường độ giới hạn) 
    ''' Với tải trọng thường xuyên lấy bằng 500Mpa, tải trọng tạm thời và ngắn hạn lấy bằng 400Mpa
    ''' </summary>
    ''' <returns></returns>
    Public Property Ximau As Integer
        Get
            Return _ximau
        End Get
        Set(value As Integer)
            _ximau = value
        End Set
    End Property
End Class
