'Lớp các thông số của vật liệu sử dụng
' gồm có thông số của bê tông và thông số thép

'Key của bê tông : 
' 0 : B20
' 1 : B25
' 2 : B30
' 3 : B35 

Public Class Material
    ' Các thông số của vật Liệu : 
    Private _tenbetong As String
    Private _rb As Double
    Private _rbt As Double
    Private _eb As Double
    Private _namebt As String
    ' Các thông số của thép
    Private _tenthep As String
    Private _rs As Double
    Private _rsc As Double
    Private _es As Double

    Public Property Rb As Double
        Get
            Return _rb
        End Get
        Set(value As Double)
            _rb = value
        End Set
    End Property
    Public Property Rbt As Double
        Get
            Return _rbt
        End Get
        Set(value As Double)
            _rbt = value
        End Set
    End Property
    Public Property Eb As Double
        Get
            Return _eb
        End Get
        Set(value As Double)
            _eb = value
        End Set
    End Property
    Public Property Rs As Double
        Get
            Return _rs
        End Get
        Set(value As Double)
            _rs = value
        End Set
    End Property
    Public Property Rsc As Double
        Get
            Return _rsc
        End Get
        Set(value As Double)
            _rsc = value
        End Set
    End Property
    Public Property Es As Double
        Get
            Return _es
        End Get
        Set(value As Double)
            _es = value
        End Set
    End Property
    Public Property Tenthep As String
        Get
            Return _tenthep
        End Get
        Set(value As String)
            _tenthep = value
        End Set
    End Property
    Public Property Tenbetong As String
        Get
            Return _tenbetong
        End Get
        Set(value As String)
            _tenbetong = value
        End Set
    End Property



    'Hàm khởi tạo 1 : B20 
    ''' <summary>
    ''' Hàm khởi tạo cho bê tông và thép thep mã
    ''' </summary>
    ''' <param name="code_1">Là mã của bê tông</param>
    ''' <param name="code_2">Là mã của thép</param>
    Public Sub New(code_1 As Byte, code_2 As Byte)
        ' Chọn bê tông 
        Select Case code_1
            Case 0 ' B20
                Me.Rb = 11.5
                Me.Rbt = 0.9
                Me.Eb = 27000
                Me.Tenbetong = "B20"
            Case 1 ' B25
                Me.Rb = 14.5
                Me.Rbt = 10.5
                Me.Eb = 30000
                Me.Tenbetong = "B25"
            Case 2 ' B30
                Me.Rb = 17
                Me.Rbt = 12
                Me.Eb = 32500
                Me.Tenbetong = "B30"
            Case 3 ' B35
                Me.Rb = 19500
                Me.Rbt = 1300
                Me.Eb = 34500
                Me.Tenbetong = "B35"
        End Select
        ' Chọn thép
        Select Case code_2
            Case 0 ' CB240-T
                Me.Rs = 210
                Me.Rsc = 210
                Me.Es = 210000
                Me.Tenthep = "CB240-T<Trơn>"
            Case 1 ' CB300-V
                Me.Rs = 260
                Me.Rsc = 260
                Me.Es = 210000
                Me.Tenthep = "CB300-T<Vằn>"
            Case 2 ' CB400-V
                Me.Rs = 350
                Me.Rsc = 350
                Me.Es = 200000
                Me.Tenthep = "CB400-T<Vằn>"
            Case 3 'CB500-V
                Me.Rs = 435
                Me.Rsc = 435
                Me.Es = 200000
                Me.Tenthep = "CB500-T<Vằn>"
            Case 4 'Vật liệu Test
                Me.Rs = 400
                Me.Rsc = 400
                Me.Es = 200000
                Me.Tenthep = "Vật liệu Test- Tiêu chuẩn cũ"

        End Select

    End Sub
    ' Hàm khởi tạo 2 : Chỉ có bê tông 
    Public Sub New(code_1 As Byte)
        Select Case code_1
            Case 0 ' B20
                Me.Rb = 11500
                Me.Rbt = 900
                Me.Eb = 27000
                Me.Tenbetong = "B20"
            Case 1 ' B25
                Me.Rb = 14.5
                Me.Rbt = 1050
                Me.Eb = 30000
                Me.Tenbetong = "B25"
            Case 2 ' B30
                Me.Rb = 17000
                Me.Rbt = 1200
                Me.Eb = 32500
                Me.Tenbetong = "B30"
            Case 3 ' B35
                Me.Rb = 19.5
                Me.Rbt = 1300
                Me.Eb = 34500
                Me.Tenbetong = "B35"
        End Select
    End Sub
    ' Hàm khởi tạo 3 : Chỉ có thép 
    Public Sub New(code_2 As Byte, bl As Boolean)
        Select Case code_2
            Case 0 ' CB240-T
                Me.Rs = 210
                Me.Rsc = 210
                Me.Es = 210000
                Me.Tenthep = "CB240-T<Trơn>"
            Case 1 ' CB300-V
                Me.Rs = 260
                Me.Rsc = 260
                Me.Es = 210000
                Me.Tenthep = "CB300-T<Vằn>"
            Case 2 ' CB400-V
                Me.Rs = 350
                Me.Rsc = 350
                Me.Es = 200000
                Me.Tenthep = "CB400-T<Vằn>"
            Case 3 'CB500-V
                Me.Rs = 435
                Me.Rsc = 435
                Me.Es = 200000
                Me.Tenthep = "CB500-T<Vằn>"
            Case 4 'Vật liệu Test
                Me.Rs = 400
                Me.Rsc = 400
                Me.Es = 200000
                Me.Tenthep = "Vật liệu Test- Tiêu chuẩn cũ"
        End Select
    End Sub
End Class
