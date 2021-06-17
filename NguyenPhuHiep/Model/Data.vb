' Dữ liệu dùng chung cho toàn bộ chương Trình 
Module Data
    ' Cot chua tinh 
    Public mycol As cot_chuatinh






    ' vat lieu cua cot 
    Public vatlieu_cot As Material
    ' Danh sach cit chua tinh 
    Public dscolchuatinh As New List(Of cot_chuatinh)
    Public hesokeodai As Double
    'Nội Suy : 
    Public kc1 As Double
    Public kc2 As Double
    Public kck As Double
    ' Kết quả nội suy 
    Public anpha As Double
    Public sothanhthep As Integer

    Public bankinh1 As Double
    Public bankinh2 As Double
    ' Kiểm tra
    Public _cotkiemtra As cotkiemtra
    Public duongkinh As Double
    Public sothanh As Double
    Public dientich As Double
    ' giá trị của điểm K để tí vẽ lại 

    Public K As Point
    ' bảng nội lực

    Public BangNoiLuc As New List(Of cls_noiluc)
    Public elementt As New Element

    ' bmaf add(
    Public Sub Add(stori As String, column As String, outputcase As String, station As Double, P As Double,
                  V2 As Double,
                  V3 As Double,
                  T As Double,
                  M2 As Double, M3 As Double)
        Dim clsNl As New cls_noiluc()
        clsNl.Story = stori
        clsNl.column = column
        clsNl.outputcase = outputcase
        clsNl.station = station
        clsNl.p = P
        clsNl.V2 = V2
        clsNl.V3 = V3
        clsNl.T = T
        clsNl.M2 = M2
        clsNl.M3 = M3
        BangNoiLuc.Add(clsNl)


    End Sub

    ' NỘi lực của form excel chọn bắn sang form tính toán bằng biểu đồ :
    Public mx As String
    Public my As String
    Public ntu As String
    Public momen As String
    Public chieudaitinh As String
    Public duongkinhbandau As String
    Public lopbaove As String

    ' Dữ liệu để vẽ
    Public duongkinhve As Integer
    Public chieudaitinhtoancot As String
    Public lopbaovecot As String

End Module
