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
        vesothanhthep(sothanhthep, New Point(centerpoint.X, centerpoint.Y), Data.bankinh2, "D" + Data.duongkinhve.ToString)
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
    Dim lst_diemchen As New List(Of Point)
    Dim lst_diemchen1 As New List(Of Point)
    Dim lst_diemchen2 As New List(Of Point)
    Private Sub vesothanhthep(sothanh As Double, CenterPoint As Point, bK_quay As Double, duongkinhthep As String)
        Dim gocquay As Double = (360 / sothanh) * (Math.PI / 180.0#)
        Dim x, y As Double
        Dim diemchen As Point
        Dim rd As Integer = CInt(Data.bankinh1 / 35.0#)
        ' Chèn vào vị trí số thanh chia 8
        Dim vitrichen As Integer = CInt(Math.Truncate(sothanh / 8.0#))
        Dim vitrichen2 As Integer = CInt(Math.Truncate(sothanh * (3.0# / 8.0#)))
        Dim vitrichen3 As Integer = CInt(Math.Truncate(sothanh * (5.0# / 8.0#)))
        Dim vitrichen4 As Integer = CInt(Math.Truncate(sothanh * (7.0# / 8.0#)))
        ' Cho hinh chu nhat
        Dim _vitrichen, _vitrichen2, _vitrichen3, _vitrichen4 As Integer
        Dim _vitrichen_1, _vitrichen2_1, _vitrichen3_1, _vitrichen4_1 As Integer
        If sothanh <= 16 Then ' nhỏ hơn 16
            _vitrichen = CInt(Math.Truncate(sothanh * (3.0# / 16.0#)))
            _vitrichen2 = CInt(Math.Truncate(sothanh * (5.0# / 16.0#)))
            _vitrichen3 = CInt(Math.Truncate(sothanh * (11.0# / 16.0#)))
            _vitrichen4 = CInt(Math.Truncate(sothanh * (13.0# / 16.0#)))
            ' cho hình chữ nhật ngang
            _vitrichen_1 = CInt(Math.Truncate(sothanh * (1.0# / 16.0#)))
            _vitrichen2_1 = CInt(Math.Truncate(sothanh * (7.0# / 16.0#)))
            _vitrichen3_1 = CInt(Math.Truncate(sothanh * (9.0# / 16.0#)))
            _vitrichen4_1 = CInt(Math.Truncate(sothanh * (15.0# / 16.0#)))
        ElseIf sothanh <= 24 Then ' vào đến đây là lớn hơn 16 nhỏ hơn 24
            _vitrichen = CInt(Math.Truncate(sothanh * (5.0# / 24.0#)))
            _vitrichen2 = CInt(Math.Truncate(sothanh * (7.0# / 24.0#)))
            _vitrichen3 = CInt(Math.Truncate(sothanh * (17.0# / 24.0#)))
            _vitrichen4 = CInt(Math.Truncate(sothanh * (19.0# / 24.0#)))
            ' hình chữ nhật ngang
            _vitrichen_1 = CInt(Math.Truncate(sothanh * (1.0# / 24.0#)))
            _vitrichen2_1 = CInt(Math.Truncate(sothanh * (11.0# / 24.0#)))
            _vitrichen3_1 = CInt(Math.Truncate(sothanh * (13.0# / 24.0#)))
            _vitrichen4_1 = CInt(Math.Truncate(sothanh * (23.0# / 24.0#)))
        End If




        For i = 0 To sothanh
            x = Math.Cos(gocquay * i) * bK_quay + CenterPoint.X
            y = Math.Sin(gocquay * i) * bK_quay + CenterPoint.Y
            Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
            If i = vitrichen Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                Hamve.thep_doc_cot(BanVe, diemchen, duongkinhthep)

                diemchen.Y = diemchen.Y + rd

                lst_diemchen.Add(diemchen)


                Dim p2 As Point
                p2.X = diemchen.X + rd
                p2.Y = diemchen.Y - rd
                lst_diemchen.Add(p2)

            End If
            If i = vitrichen2 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y + rd
                lst_diemchen.Add(diemchen) ' p3
                Dim p4 As Point
                p4.X = diemchen.X - rd
                p4.Y = diemchen.Y - rd
                lst_diemchen.Add(p4)

            End If
            If i = vitrichen3 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.X = diemchen.X
                diemchen.Y = diemchen.Y - rd
                lst_diemchen.Add(diemchen)
                Dim p6 As Point
                p6.X = diemchen.X - rd
                p6.Y = diemchen.Y + rd
                lst_diemchen.Add(p6)


            End If
            If i = vitrichen4 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y - rd
                diemchen.X = diemchen.X

                lst_diemchen.Add(diemchen)
                Dim p8 As Point
                p8.X = diemchen.X + rd
                p8.Y = diemchen.Y + rd
                lst_diemchen.Add(p8)
            End If

            ' Thép đai hình chữ nhật

            If i = _vitrichen Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y + rd
                lst_diemchen1.Add(diemchen)
                Dim p2 As Point
                p2.X = diemchen.X + rd
                p2.Y = diemchen.Y - rd
                lst_diemchen1.Add(p2)

            End If
            If i = _vitrichen2 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y + rd
                lst_diemchen1.Add(diemchen) ' p3
                Dim p4 As Point
                p4.X = diemchen.X - rd
                p4.Y = diemchen.Y - rd
                lst_diemchen1.Add(p4)

            End If
            If i = _vitrichen3 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.X = diemchen.X
                diemchen.Y = diemchen.Y - rd
                lst_diemchen1.Add(diemchen)
                Dim p6 As Point
                p6.X = diemchen.X - rd
                p6.Y = diemchen.Y + rd
                lst_diemchen1.Add(p6)


            End If
            If i = _vitrichen4 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y - rd
                diemchen.X = diemchen.X

                lst_diemchen1.Add(diemchen)
                Dim p8 As Point
                p8.X = diemchen.X + rd
                p8.Y = diemchen.Y + rd
                lst_diemchen1.Add(p8)
            End If
            ' thép đai cho hình chữ nhật nằm ngang
            If i = _vitrichen_1 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y + rd
                lst_diemchen2.Add(diemchen)
                Dim p2 As Point
                p2.X = diemchen.X + rd
                p2.Y = diemchen.Y - rd
                lst_diemchen2.Add(p2)

            End If
            If i = _vitrichen2_1 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y + rd
                lst_diemchen2.Add(diemchen) ' p3
                Dim p4 As Point
                p4.X = diemchen.X - rd
                p4.Y = diemchen.Y - rd
                lst_diemchen2.Add(p4)

            End If
            If i = _vitrichen3_1 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.X = diemchen.X
                diemchen.Y = diemchen.Y - rd
                lst_diemchen2.Add(diemchen)
                Dim p6 As Point
                p6.X = diemchen.X - rd
                p6.Y = diemchen.Y + rd
                lst_diemchen2.Add(p6)


            End If
            If i = _vitrichen4_1 Then
                diemchen = Hamve.vethep(BanVe, New Point(CInt(x), CInt(y)), Data.bankinh1 / 35.0#, "1")
                diemchen.Y = diemchen.Y - rd
                diemchen.X = diemchen.X

                lst_diemchen2.Add(diemchen)
                Dim p8 As Point
                p8.X = diemchen.X + rd
                p8.Y = diemchen.Y + rd
                lst_diemchen2.Add(p8)
            End If
        Next
        Hamve.CreateNewPoline(BanVe, lst_diemchen)
        Hamve.CreateNewPoline(BanVe, lst_diemchen1)
        Hamve.CreateNewPoline(BanVe, lst_diemchen2)



    End Sub
End Class
