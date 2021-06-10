''' <summary>
''' LỚp cột lúc chưa tính toán
''' </summary>
Public Class cot_chuatinh
    Public id As Integer
    Public name As String
    Public lucdoc As Double
    Public momen As Double
    Public duongkinh As Double
    Public chieudai As Double
    Public lopbaove As Double

    'Hàm khởi tạo không tham số: 

    Public Sub New()

    End Sub
    ' hàm khởi tạo có tham số
    Public Sub New(id As Integer, name As String, lucdoc As Double, momen As Double, duongkinh As Double, chieudai As Double, lopbaove As Double)
        Me.id = id
        Me.name = name
        Me.lucdoc = lucdoc
        Me.momen = momen
        Me.duongkinh = duongkinh
        Me.chieudai = chieudai
        Me.lopbaove = lopbaove

    End Sub
End Class
