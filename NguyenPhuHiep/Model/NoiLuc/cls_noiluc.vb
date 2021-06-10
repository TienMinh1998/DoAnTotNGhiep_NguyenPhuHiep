Public Class cls_noiluc ' bảng nội lực khi chuaw đem đi tổ hơphj
    Public Story As String
    Public column As String
    Public outputcase As String
    Public station As Double
    Public p, p2, V2, V3, T, M2, M3 As Double
    Private _m As Double

    Public ReadOnly Property M As Double
        Get
            _m = Math.Sqrt(Math.Pow(M2, 2) + Math.Pow(M3, 2))
            Return _m
        End Get
    End Property
End Class
