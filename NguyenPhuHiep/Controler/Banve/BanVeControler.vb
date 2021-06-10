Public Class BanVeControler
    ' lớp xử lý
    Public BanVe As VDProLib5.vdEntities

    Public Active As Boolean
    Public Sub New()
        Active = View_BanVe.vdr.ActiveDocument.Open(Application.StartupPath + Hamve.links, 0, 0)
        View_BanVe.vdr.ActiveDocument.Entities.EraseAll()
        BanVe = View_BanVe.vdr.ActiveDocument.Entities
    End Sub
    Public Sub vecot(centerpoint As Point, sothanhthep As Double, chieudaicot As Double)

        Hamve.vehinhtron(BanVe, New Point(centerpoint.X, centerpoint.Y), Data.bankinh1) ' bán kính khi chưa trừ đi lớp bảo vệ
        Hamve.vehinhtron(BanVe, New Point(centerpoint.X, centerpoint.Y), Data.bankinh2, "1") ' bán kính khi đã trừ đi lớp bảo vệk
        vesothanhthep(sothanhthep, New Point(centerpoint.X, centerpoint.Y), Data.bankinh2)
        ' Chèn Text 
        Dim diemchentext As New Point
        diemchentext.X = centerpoint.X - CInt(Data.bankinh1)
        diemchentext.Y = centerpoint.Y + CInt(Data.bankinh1) + 100 ' cộng thêm 1 lượng bán kính
        ' Hamve.CreateNewText(BanVe, "MAT BANG BO TRI THEP COT", diemchentext, Data.bankinh1 / 20)
        ' ghi dim
        ' ĐIỂM 1 " 
        'Dim p1 As Point
        'p1.X = CInt(centerpoint.X - bankinh2)
        'p1.Y = CInt(centerpoint.Y - Data.bankinh1 - 0.1# * Data.bankinh1)
        'Dim p2 As Point
        'p2.X = CInt(centerpoint.X + Data.bankinh2)
        'p2.Y = CInt(centerpoint.Y - Data.bankinh1 - 0.1# * Data.bankinh1)
        'Dim p3 As Point
        'p3.X = p2.Xda
        'p3.Y = p2.Y - 0.1# * Data.bankinh1

        ' TÍnh kc từ tâm đến điểm đặt đim

        Dim kc As Integer = CInt(Data.bankinh1) + 300 ' 300 là kc giữa các đường dim
        '
        Dim p1 As New Point
        p1.X = centerpoint.X - kc
        p1.Y = centerpoint.Y - CInt(Data.bankinh1)
        Dim p2 As New Point
        p2.X = centerpoint.X - kc
        p2.Y = centerpoint.Y + CInt(Data.bankinh1)
        Dim p3 As New Point
        p3.X = centerpoint.X - kc - 300
        p3.Y = centerpoint.Y
        ' dim cho dim 600 :
        Dim p4 As New Point
        p4.X = centerpoint.X - (kc - 150)
        p4.Y = centerpoint.Y - CInt(Data.bankinh1)
        Dim p5 As New Point
        p5.X = centerpoint.X - (kc - 150)
        p5.Y = centerpoint.Y
        Dim p6 As New Point
        p6.X = centerpoint.X - kc
        p6.Y = centerpoint.Y - CInt(Data.bankinh1 / 2)


        ' dim cho dim 600 2 :
        Dim p7 As New Point
        p7.X = centerpoint.X - (kc - 150)
        p7.Y = centerpoint.Y
        Dim p8 As New Point
        p8.X = centerpoint.X - (kc - 150)
        p8.Y = centerpoint.Y + CInt(Data.bankinh1)
        Dim p9 As New Point
        p9.X = centerpoint.X - kc
        p9.Y = centerpoint.Y + CInt(Data.bankinh1 / 2)
        Hamve.CreateVewDim(BanVe, p1, p2, p3)
        Hamve.CreateVewDim(BanVe, p4, p5, p6)
        Hamve.CreateVewDim(BanVe, p7, p8, p9)
        Dim PointText = New Point()
        PointText.X = centerpoint.X - 150
        PointText.Y = centerpoint.Y - CInt(Data.bankinh1) - 500
        Hamve.CreateNewText(BanVe, "1-1", PointText, 200)
        ' Vẽ hình như nhật to
        ' B1 : Lấy tạo độ tâm hình chư nhật
        Dim diemchen2 As New Point()
        diemchen2.X = centerpoint.X + 4 * kc
        diemchen2.Y = centerpoint.Y
        Hamve.CreateNewReatangule(BanVe, 2800, 1200, diemchen2)
        Dim diem1 As New Point()
        diem1.X = diemchen2.X - CInt(Data.bankinh1) - 300
        diem1.Y = diemchen2.Y + CInt(chieudaicot / 2)

        Dim diem2 As New Point()
        diem2.X = diemchen2.X - CInt(Data.bankinh1) - 300
        diem2.Y = diemchen2.Y - CInt(chieudaicot / 2)

        Dim chandim1 = New Point()
        chandim1.X = diemchen2.X - CInt(Data.bankinh1) - 300 - 150
        chandim1.Y = diemchen2.Y

        Hamve.CreateVewDim(BanVe, diem1, diem2, chandim1)

        Hamve.zoom()
    End Sub

    Private Sub vesothanhthep(sothanh As Double, CenterPoint As Point, bK_quay As Double)
        Dim gocquay As Double = (360 / sothanh) * (Math.PI / 180.0#)
        Dim x, y As Double
        For i = 0 To sothanh
            x = Math.Cos(gocquay * i) * bK_quay + CenterPoint.X
            y = Math.Sin(gocquay * i) * bK_quay + CenterPoint.Y
            Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
        Next


    End Sub
End Class
