Public Class Draw

    ''' <summary>
    ''' Hàm này ở trong lớp vẽ,Ghi dim theo chiều dọc
    ''' </summary>
    ''' <param name="Strartpoint">Điểm bắt đầu</param>
    ''' <param name="EndPoint">Điểm kết Thúc</param>
    ''' <param name="pen">Bút Pen</param>
    ''' <param name="Gr">grapic</param>
    Public Shared sub Create_New_Dim(Strartpoint As Point, EndPoint As Point, pen As Pen, Gr As Graphics, StringName As String, fn As Font)
        ' Đường Thẳng 
        Gr.DrawLine(pen, Strartpoint, EndPoint)
        ' Đàu Mút :
        ' Đấu Mút 1 : 
        Dim p1 As New Point(Strartpoint.X - 10, Strartpoint.Y)
        Dim p2 As New Point(Strartpoint.X + 10, Strartpoint.Y)
        Gr.DrawLine(pen, p1, p2)
        ' Đàu mút 2 : 
        Dim p3 As New Point(Strartpoint.X - 10, EndPoint.Y)
        Dim p4 As New Point(EndPoint.X + 10, EndPoint.Y)
        Gr.DrawLine(pen, p3, p4)
        'Create View text
        ' diểm chèn dim 
        Dim pdim As New Point(Strartpoint.X + 10, Strartpoint.Y + (EndPoint.Y - Strartpoint.Y) / 2)


        Gr.DrawString(StringName, fn, Brushes.Blue, pdim)
    End sub

    'hàm vẽ hình chữ nhật truyền vào tâm 
    ''' <summary>
    ''' Vẽ hình chữ nhật truyền vào tâm
    ''' </summary>
    ''' <param name="pen">Bút vẽ</param>
    ''' <param name="Gr">Gr</param>
    ''' <param name="P_center">Điểm tâm</param>
    ''' <param name="chieucao">Chiều cao</param>
    ''' <param name="chieurong">Chiều Rộng</param>
    Public Sub hcn(pen As Pen, Gr As Graphics, P_center As Point, chieucao As Single, chieurong As Single)
        ' điểm vẽ thật 
        Dim x, y As Single
        x = Convert.ToSingle(P_center.X - chieurong / 2)
        y = Convert.ToSingle(P_center.Y - chieucao / 2)
        ' diểm 2 : 
        ' Vẽ hình chữ nhật
        Gr.DrawRectangle(pen, x, y, chieurong, chieucao)
    End Sub
    ''' <summary>
    ''' Hàm vẽ đường tròn, truyền vào tâm
    ''' </summary>
    ''' <param name="Gr">Đồ Họa</param>
    ''' <param name="pen">Bút vẽ</param>
    ''' <param name="P_center">Điểm tâm</param>
    ''' <param name="b">Bán Kính</param>
    ''' <param name="scale">Tỉ lệ</param>
    ''' <returns></returns>
    Public Shared Function Create_New_cicle(Gr As Graphics, pen As Pen, P_center As Point, b As Single, scale As Double) As RectangleF
        Dim x, y As Single
        Dim b1 As Single = Convert.ToSingle(scale * b)
        x = Convert.ToSingle(P_center.X - b1 / 2)
        y = Convert.ToSingle(P_center.Y - b1 / 2)
        ' vẽ hình tròn 
        Dim rtf As RectangleF
        rtf.X = x
        rtf.Y = y
        rtf.Width = b1
        rtf.Height = b1
        Gr.DrawEllipse(pen, x, y, b1, b1)
        Return rtf
    End Function
    ''' <summary>
    ''' Hàm vẽ đường thẳng
    ''' </summary>
    ''' <param name="Gr"></param>
    ''' <param name="pen"></param>
    ''' <param name="Startpoint"></param>
    ''' <param name="EndPoint"></param>
    ''' <returns></returns>
    Public Shared Function Create_New_Line(Gr As Graphics, pen As Pen, Startpoint As Point, EndPoint As Point) As Boolean
        Gr.DrawLine(pen, Startpoint, EndPoint)
        Return True
    End Function

    Public Shared Function Create_new_Steel(Gr As Graphics, pen As Pen, P_chen As Point, b As Single, scale As Double, bur As Brush) As Boolean
        Dim rtf As RectangleF
        rtf = Create_New_cicle(Gr, pen, P_chen, b, scale)
        Gr.FillEllipse(bur, rtf)
        Return True
    End Function

    Public Shared Function Create_new_Steel(Gr As Graphics, pen As Pen, x As Integer, y As Integer, b As Single, scale As Double, bur As Brush) As Boolean
        Dim rtf As RectangleF
        Dim p1 As Point
        p1.X = x
        p1.Y = y
        rtf = Create_New_cicle(Gr, pen, p1, b, scale)
        Gr.FillEllipse(bur, rtf)
        Return True
    End Function

    'Hàm đổ màu 1 khối hình tròn 

    Public Shared Sub Fill_ciccle(Gr As Graphics, bur As Brush, rtf As RectangleF)
        Gr.FillEllipse(bur, rtf)
    End Sub
    Public Shared Function font(size As Single) As Font
        Dim TM_font As Font = New Font("Tahoma", size, FontStyle.Bold Or FontStyle.Regular)
        Return TM_font
    End Function
End Class
