Imports LiveCharts.Defaults
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class view_bieudo

    ' các thông số để vẽ cột 
    Public btmap As Bitmap
    Private _gr1 As Graphics
    Public Pn As Pen = New Pen(Brushes.Black, 2)
    Public netdim As Pen = New Pen(Brushes.Black, 1)
    Public pn_blue As Pen = New Pen(Brushes.Blue, 2)
    Public pn_magenta As Pen = New Pen(Brushes.Magenta, 1)
    Public Pn2 As Pen = New Pen(Brushes.Red, 1)
    Private tooltip As ToolTip = New ToolTip()
    Private clickPosition As Point? = Nothing
    Private Global_beta As Double
    Private ee As Double
    ''' <summary>
    ''' Độ lệch tâm ngẫu nhiên
    ''' </summary>
    Private ea As Double
    ''' <summary>
    ''' Độ lẹch tâm ban đầu 
    ''' </summary>
    Private eo As Double
    ''' <summary>
    ''' moment quan tinh
    ''' </summary>

    Private I As Double
    Private Nth As Double

    ' he so neta
    Private neta As Double
    Private K_n As Double
    Private K_m As Double

    Public Property Gr As Graphics
        Get
            Return _gr1
        End Get
        Set(value As Graphics)
            _gr1 = value
        End Set
    End Property

    Private Sub btn_ve_Click(sender As Object, e As EventArgs) Handles btn_ve.Click

        txt_duongkinhcot.Text = Data.duongkinhbandau
        txt_lopbaove.Text = Data.lopbaove

        txt_chieudaitinhtoan.Text = Data.chieudaitinh
        txt_m.Text = Data.momen
        txt_n.Text = Data.ntu

    End Sub

    Private Sub txt_bankinh_TextChanged(sender As Object, e As EventArgs) Handles txt_duongkinhcot.TextChanged
        Try
            hamvebieudo()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_lopbaove_TextChanged(sender As Object, e As EventArgs) Handles txt_lopbaove.TextChanged, txt_n.TextChanged, txt_step_anpha.TextChanged, txt_chieudaitinhtoan.TextChanged

        If IsNumeric(txt_lopbaove.Text) Then
            If IsNumeric(txt_duongkinhcot.Text) Then
                Dim a As Double = Val(txt_duongkinhcot.Text)
                Dim b As Double = Val(txt_lopbaove.Text)
                Dim beta As Double = (a - b) / a

            End If
        End If

        Try
            Chart1.Series.Clear()
            Dim step_anpha As Double = Val(txt_step_anpha.Text)
            Vebieudo(step_anpha, Data.hesokeodai)
            '   CreateNewLiveChart()
            Vecot()

        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' Hàm vẽ biểu đồ Thứ nguyên, đầu vào là Beta
    ''' </summary>
    Private Sub Vebieudo(step_anpha As Double, hskeodaik As Double)
        Tinhtoan_K() ' Tính Toán K : 
        Ba.value = Tinh_Ba() ' TÍnh Ba
        ' Tính Ba
        Chart1.Titles.Clear()
        Chart1.Titles.Add(" BIỂU ĐỒ TÍNH TOÁN KHÔNG THỨ NGUYÊN ") ' specify chart name
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")

        Dim mau(10) As Color
        mau(1) = Color.Red
        mau(2) = Color.Blue
        mau(3) = Color.Green
        mau(4) = Color.Magenta
        mau(5) = Color.Aqua
        mau(6) = Color.Black

        Chart1.Series.Clear()


        Dim anpha As Double
        Dim name As String
        Dim coll As Integer
        For anpha = 0.05 To 1 Step step_anpha
            name = "@ " + anpha.ToString
            Chart1.Series.Add(name)
            coll += 1
            If coll = 7 Then
                coll = 1
            End If
            Chart1.Series(name).Color = mau(coll)
            Chart1.Series(name).ChartType = DataVisualization.Charting.SeriesChartType.Line

            With Chart1.ChartAreas("Default")
                .AxisX.Title = "m" 'trục M
                .AxisX.Minimum = 0
                .AxisX.MajorGrid.LineColor = Color.SkyBlue
                .AxisX.LineWidth = 2
                .AxisX.LineColor = Color.Aquamarine
                .AxisY.MajorGrid.LineColor = Color.SkyBlue
                .AxisY.Title = "n" ' Trục n
                .AxisY.LineWidth = 2
                .AxisY.LineColor = Color.Aquamarine
                .AxisY.Minimum = 0
            End With
            ' Khai báo các thông số để bắt đầu vẽ
            Dim Phi_S As Double
            Dim Phi As Double
            Dim n, m As Double
            Dim esi As Double = 0.12
            Dim dental As Double = 1.5 + 6 * vatlieu_cot.Rs * 10 ^ -4
            Dim ba As Double = Global_beta

            For esi = 0.12 To 1 Step 0.01
                Phi_S = 1 - dental * esi
                If Phi_S < 0 Then
                    Phi_S = 0
                End If
                Phi = esi * Math.PI
                n = esi * (1 + anpha) - 0.159 * Math.Sin(2 * Phi) - anpha * Phi_S ' công thức thôi, sô fixx cứng
                m = 0.2122 * Math.Pow(Math.Sin(Phi), 3) + 0.3183 * ba * anpha * Math.Sin(Phi) + ba * anpha * Phi_S * (0.2 + 1.3 * esi)
                Dim nn As Double = Math.Round(n, 3) * 100 ' đổi ra đơn vị lớn để vẽ
                Dim mm As Double = Math.Round(m, 3) * 100

                Chart1.Series(name).Points.AddXY(mm, nn)

            Next
        Next
        ' vẽ K 
        Dim m_k As Double = K_m * 100
        Dim n_k As Double = K_n * 100
        ' Tinh khoang cach 
        Data.kck = Math.Sqrt(Math.Pow(K_m, 2) + Math.Pow(K_n, 2))

        'Dim n1, m1 As Double
        'n1 = (n_k * 70) / m_k
        'm1 = 70

        Chart1.Series.Add("K")
        Chart1.Series("K").Color = Color.Red
        Chart1.Series("K").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("K").Points.AddXY(0, 0)
        Chart1.Series("K").Points.AddXY(m_k, n_k)
        'Chart1.Series("K").Points.AddXY(m1, n1)       
        Chart1.Series.Add("K2")
        Chart1.Series("K2").Color = Color.Blue
        Chart1.Series("K2").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("K2").Points.AddXY(m_k, n_k)
        ' Hai điểm mk,nk kéo dài để laayd được đoạn giao
        Dim m1 As Double = m_k * hskeodaik
        Dim n1 As Double = n_k * hskeodaik
        Chart1.Series("K2").Points.AddXY(m1, n1)


    End Sub


    Private Sub btn_tinh_Click(sender As Object, e As EventArgs)


    End Sub
    ''' <summary>
    ''' Hàm Tính độ lech tâm tĩnh học : 
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function DolechtamTH() As Double
        Dim ee As Double
        Dim a, b As Double
        a = Val(txt_m.Text)
        b = Val(txt_n.Text)
        ee = a / b
        Return ee
    End Function
    ''' <summary>
    ''' Hàm tính độ lệch tâm ngầu nhiên
    ''' </summary>
    ''' <param name="l"></param>
    ''' <param name="h">Đường KÍnh</param>
    ''' <returns></returns>
    Private Function Dolechtamngaunhien_ea(l As Double, h As Double) As Double
        Dim a, b As Double
        a = l / 600
        b = h / 30
        Return If((a > b), a, b)
    End Function



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ElementHost1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs) Handles ElementHost1.ChildChanged

    End Sub

    Private Sub Chart1_MouseClick(sender As Object, e As MouseEventArgs) Handles Chart1.MouseClick

        Dim pos = e.Location
        clickPosition = pos
        Dim results = Me.Chart1.HitTest(pos.X, pos.Y, False, ChartElementType.PlottingArea)
        For Each result In results
            If result.ChartElementType = ChartElementType.PlottingArea Then
                Dim xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X)
                Dim yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y)
                '  tooltip.Show("Giá trị m" & xVal & ", Giá Trị n" & yVal, Me.Chart1, e.Location.X, e.Location.Y - 15)

                Dim p As New Point(e.Location.X + 150, e.Location.Y)
                FRM_PointView.dgv.Rows(0).Cells(0).Value = Math.Round((xVal / 100), 5)
                FRM_PointView.dgv.Rows(0).Cells(1).Value = Math.Round((yVal / 100), 5)
                FRM_PointView.Location = p
                FRM_PointView.SendToBack()
                FRM_PointView.Show()




                If rd_diemdau.Checked = True Then
                    Dim x As Double = Math.Round(xVal * 0.01, 4) ' m laf M
                    Dim y As Double = Math.Round(yVal * 0.01, 4) ' y la n 
                    txt_xdau.Text = x.ToString
                    txt_ydau.Text = y.ToString

                    ' Tính khoảng cách :  Từ O đến điểm đầu : 
                    Data.kc1 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))
                    txt_d1o.Text = Data.kc1.ToString
                    Try
                        txt_kq_noisuy.Text = RltAnpha().ToString
                        Data.anpha = RltAnpha()
                        Dim dk As Double = Convert.ToDouble(txt_duongkinhcot.Text) / 10 ' Đổi ra cm nhé, chu deo phai mm
                        hamtinhthep(dk)
                    Catch ex As Exception

                    End Try
                ElseIf rd_diemsau.Checked = True Then
                    Dim x As Double = Math.Round(xVal * 0.01, 4) ' m laf M
                    Dim y As Double = Math.Round(yVal * 0.01, 4) ' y la n 
                    txt_xsau.Text = x.ToString
                    txt_ysau.Text = y.ToString
                    Data.kc2 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))
                    txt_d2o.Text = Data.kc2.ToString
                    ' tính luôn điểm 
                    Try
                        txt_kq_noisuy.Text = RltAnpha().ToString
                        Data.anpha = RltAnpha()
                        Dim dk As Double = Convert.ToDouble(txt_duongkinhcot.Text) / 10
                        hamtinhthep(dk)
                    Catch ex As Exception

                    End Try

                End If
            End If
        Next
        ' show kết quả

    End Sub

    Private Sub view_bieudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data.hesokeodai = txt_hskeodai.Text
        Dim step_anpha As Double = Val(txt_step_anpha.Text)
        Vebieudo(step_anpha, Data.hesokeodai)

        CreateNewLiveChart()
        txt_n.Text = Data.ntu
        Dim _mx As Double = Val(Data.mx)
        Dim _my As Double = Val(Data.my)
        Dim _Find_m As Double = Math.Sqrt((_mx ^ 2 + _my ^ 2))
        Dim _n As Double = Convert.ToDouble(Data.ntu)
        txt_m.Text = _Find_m.ToString()
        txt_n.Text = Math.Abs(_n).ToString()



    End Sub

    Private Function Tinh_Ba() As Double
        If IsNumeric(txt_lopbaove.Text) Then
            If IsNumeric(txt_duongkinhcot.Text) Then
                Dim a As Double = Val(txt_duongkinhcot.Text) / 2 ' bán kính
                Dim b As Double = Val(txt_lopbaove.Text)
                Global_beta = (a - b) / a

                lb_ba.Text = Math.Round(Global_beta, 3).ToString
            End If
        End If
        If Global_beta <> 0 Then
            Return Global_beta
        Else
            Return 0
        End If
    End Function
    Private Sub CreateNewLiveChart()
        Dim a As LiveCharts.SeriesCollection = New LiveCharts.SeriesCollection()
        For anpha1 = 0.1 To 1 Step 0.1
            Dim b As New LineSeries()
            Dim Phi_S As Double
            Dim Phi As Double
            Dim n, m As Double
            Dim esi As Double
            Dim dental As Double = 1.5 + 6 * 280 * 10 ^ -4
            Dim ba As Double = Global_beta
            Dim ch = New ChartValues(Of ObservablePoint)
            For esi = 0.12 To 1 Step 0.01
                Phi_S = 1 - dental * esi
                If Phi_S < 0 Then
                    Phi_S = 0
                End If
                Phi = esi * Math.PI
                n = esi * (1 + anpha1) - 0.159 * Math.Sin(2 * Phi) - anpha1 * Phi_S
                m = 0.2122 * Math.Pow(Math.Sin(Phi), 3) + 0.3183 * ba * anpha1 * Math.Sin(Phi) + ba * anpha1 * Phi_S * (0.2 + 1.3 * esi)
                Dim nn As Double = Math.Round(n, 3) * 100
                Dim mm As Double = Math.Round(m, 3) * 100
                ch.Add(New ObservablePoint(mm, nn))
            Next
            b.Values = ch
            b.PointGeometrySize = 0.5
            b.StrokeThickness = 3

            a.Add(b)
        Next
        Dim m_k As Double = K_m * 100
        Dim n_k As Double = K_n * 100
        Dim b1 As New LineSeries()
        Dim ch1 = New ChartValues(Of ObservablePoint)
        ch1.Add(New ObservablePoint(0, 0))
        ch1.Add(New ObservablePoint(m_k, n_k))
        b1.Values = ch1
        b1.PointGeometrySize = 5

        a.Add(b1)
        CartesianChart1.Series = a

    End Sub

    ''' <summary>
    ''' Hàm tính Toán để trả ra giá trị của K 
    '''Từ đó ra bấm vào biểu đồ rồi bắt đầu nội suy
    ''' </summary>


    Private Sub txt_hskeodai_TextChanged(sender As Object, e As EventArgs) Handles txt_hskeodai.TextChanged, txt_kq_noisuy.TextChanged
        hamlaygiatrikeodai()
    End Sub
    Private Sub txt_anphadau_TextChanged(sender As Object, e As EventArgs) Handles txt_anphadau.TextChanged
        rd_diemdau.Checked = True
    End Sub
    Private Sub txt_anphasau_TextChanged(sender As Object, e As EventArgs) Handles txt_anphasau.TextChanged
        rd_diemsau.Checked = True
    End Sub

    Private Sub cbbdiameter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbdiameter.SelectedIndexChanged
        Data.duongkinhve = hamchonthep()
    End Sub
    Private Sub txt_sothanh_TextChanged(sender As Object, e As EventArgs) Handles txt_sothanh.TextChanged
        hamchonthep()
    End Sub
    Private Sub txt_m_TextChanged(sender As Object, e As EventArgs) Handles txt_m.TextChanged
        hamvebieudo()
    End Sub



    ' các hàm vẽ nhanh của lớp này : 

    Private Sub hamgetanpha()
        txt_kq_noisuy.Text = RltAnpha().ToString
        Data.anpha = RltAnpha()
    End Sub
    Private Function hamtinhthep(dk As Double) As Double
        lb_steel.Text = Math.Round(_As(dk), 3).ToString + "Cm2"
        Return Math.Round(_As(dk), 3)
    End Function
    Private Function hamchonthep() As Integer
        Try
            Dim sothanh As Integer = CInt(txt_sothanh.Text)
            Dim iscurrent As Integer = cbbdiameter.SelectedIndex
            Dim Dk As Integer ' đường Kính
            Dim ct As choncotthep

            Dk = CInt(cbbdiameter.Items(iscurrent))
            ct = New choncotthep(sothanh, Dk)
            lb_thepsaukhichon.Text = (ct.dientichchon * 0.01).ToString + "Cm2"
            ' lấy dữ liệu để vẽ : 
            Data.sothanhthep = CInt(txt_sothanh.Text)
            Data.bankinh1 = Convert.ToDouble(txt_duongkinhcot.Text) / 2
            Dim lopbaove As Double = CInt(txt_lopbaove.Text)
            Data.bankinh2 = Data.bankinh1 - lopbaove
            Data.duongkinh = Dk
            Data.dientich = ct.dientichchon * 0.01 ' để đổi đơn vị ra cm2
            Return Dk
        Catch ex As Exception
            ' lỗi lần đầu load
        End Try
        Return 0
    End Function
    Private Sub hamvebieudo()
        Chart1.Series.Clear()
        Dim step_anpha As Double = Val(txt_step_anpha.Text)


        Vebieudo(step_anpha, Data.hesokeodai)
        '   CreateNewLiveChart()
        Vecot()

    End Sub

    ''' <summary>
    ''' return AS
    ''' </summary>
    ''' <param name="diameter">is Diameter </param>
    ''' <returns></returns>
    ''' ' Hàm tính giá trị của diện tích thép, đầu vào là đường kính
    Private Function _As(diameter As Double) As Double
        Dim Rb As Double = Data.vatlieu_cot.Rb
        Dim Rs As Double = Data.vatlieu_cot.Rs
        Dim anpha As Double = Convert.ToDouble(txt_kq_noisuy.Text)
        Dim dientichthep As Double
        Dim hamluong As Double = (Rb * anpha) / Rs
        dientichthep = hamluong * Math.PI * (diameter ^ 2 / 4)
        Return dientichthep
    End Function
    ''' <summary>
    ''' Hàm trả tra anpha
    ''' </summary>
    ''' <returns></returns>
    Private Function RltAnpha() As Double
        Dim kq As Double
        Dim ts, ms As Double
        Dim y1, y2, x1, x2, x As Double
        y2 = Convert.ToDouble(txt_anphasau.Text)
        y1 = Convert.ToDouble(txt_anphadau.Text)

        x1 = Data.kc1
        x2 = Data.kc2
        x = Data.kck

        ts = y2 * (x - x1) + y1 * (x2 - x)
        ms = x2 - x1
        kq = Math.Round(ts / ms, 3)
        Return kq
    End Function
    ' Hàm lấy Giá trị điểm K kéo dài
    Private Sub hamlaygiatrikeodai()
        If IsNumeric(txt_hskeodai.Text) Then
            Data.hesokeodai = Convert.ToDouble(txt_hskeodai.Text)
        Else

        End If
    End Sub
    'Hàm vẽ mặt cawtsc cột
    Private Sub Vecot()
        Dim fn As Font = Draw.font(10)
        btmap = New Bitmap(1000, 1000)
        Gr = Graphics.FromImage(btmap)

        ' lấy giá trị đường kính của cột, điểm tầm của ảnh 
        Dim Scale As Double = 0.25 ' tỉ lệ trên ban ve
        Dim Diameter As Single = 1000 'Convert.ToSingle(txt_duongkinh.Text)
        Dim radius As Integer = Diameter / 2 ' bán kính thật
        Dim radius_model As Integer = radius * Scale
        Dim diameter2 As Single = Diameter - 200
        Dim radius_model2 As Integer = (diameter2 / 2) * Scale
        Dim PointCenter, Point_12h As Point


        '=========Thân của hàm vẽ=====================
        'Ve hinh tron o giuong
        Draw.Create_New_cicle(Gr, pn_blue, PointCenter, Diameter, Scale)
        ' Vẽ hinh tron ben trong
        Dim ht2 As RectangleF = Draw.Create_New_cicle(Gr, Pn, PointCenter, diameter2, Scale)
        Draw.Fill_ciccle(Gr, Brushes.Aquamarine, ht2)
        'vẽ trục 
        'Dim x_center, y_center As Integer
        'x_center = Convert.ToInt32(PointCenter.X)
        'y_center = Convert.ToInt32(PointCenter.Y)
        'Dim p2 As Point
        'p2.X = PointCenter.X
        'p2.Y = Convert.ToInt32((PointCenter.Y - radius_model)) ' là bán kính trên bản vẽ
        'Gr.DrawLine(Pn, PointCenter, p2)
        'Gr.DrawLine(Pn, x_center, y_center, x_center - radius_model, y_center)
        'Gr.DrawLine(Pn, x_center, y_center, x_center + radius_model, y_center)
        'Gr.DrawLine(Pn, x_center, y_center, x_center, y_center + radius_model)

        ' vẽ thép 
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_model2, PointCenter.Y, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_model2, PointCenter.Y, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X, PointCenter.Y + radius_model2, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X, PointCenter.Y - radius_model2, 10, 1, Brushes.Magenta)
        Dim b As Double = 45 * Math.PI / 180
        Dim radius_5h As Integer = Convert.ToInt32(Math.Cos(b) * radius_model2)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_5h, PointCenter.Y + radius_5h, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X + radius_5h, PointCenter.Y - radius_5h, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_5h, PointCenter.Y - radius_5h, 10, 1, Brushes.Magenta)
        Draw.Create_new_Steel(Gr, Pn, PointCenter.X - radius_5h, PointCenter.Y + radius_5h, 10, 1, Brushes.Magenta)
        'Dim kich thuoc cua hinh tron nho 
        Dim p1, p2 As Point
        p1.X = PointCenter.X + radius_model + 20
        p1.Y = PointCenter.Y - radius_model2
        p2.X = PointCenter.X + radius_model + 20
        p2.Y = PointCenter.Y + radius_model2
        Dim giatri1 As Double = Convert.ToDouble(txt_duongkinhcot.Text) - 80 'giá trị của đường kính hình tròn bên trong
        Draw.Create_New_Dim(p1, p2, netdim, Gr, giatri1.ToString, fn)
        ' Tạo Dim cho Hình tròn to bên ngoài
        Dim p3, p4 As Point
        p3.X = PointCenter.X + radius_model + 80
        p3.Y = PointCenter.Y - radius_model
        p4.X = PointCenter.X + radius_model + 80
        p4.Y = PointCenter.Y + radius_model
        Draw.Create_New_Dim(p3, p4, netdim, Gr, txt_duongkinhcot.Text, fn)
        '=========Thân của hàm vẽ
        ' Chuyển hình vẽ lên ảnh

    End Sub
    ' Hàm tính toán tọa độ K
    Private Function Tinhtoan_K() As Boolean

        Dim duongkinhcot As Double = Convert.ToDouble(txt_duongkinhcot.Text)
        Dim bk As Double = duongkinhcot / 2
        Dim lucdoc As Double = Convert.ToDouble(txt_n.Text)
        Dim chieudaitinhtoan As Double = Val(txt_chieudaitinhtoan.Text)

        ' Tinh do lech tam tinh hoc : 
        ee = DolechtamTH() * 1000 ' đổi ra đơn vị milimet
        ea = Dolechtamngaunhien_ea(chieudaitinhtoan, duongkinhcot)
        ' Tính độ lệch tâm ban đầu :
        eo = If((ee > ea), ee, ea)
        'Tính moment quan tính 
        I = (Math.PI * duongkinhcot ^ 4) / 64
        ' Lục doc tôi han 
        Nth = (Data.vatlieu_cot.Eb * 2.5 * I) / Math.Pow(chieudaitinhtoan, 2) / 1000
        neta = 1 / (1 - (lucdoc / Nth))
        ' Tinh toa do diem K :
        K_n = (lucdoc * 1000) / (Data.vatlieu_cot.Rb * Math.PI * bk ^ 2) ' 200 là bán kính.  
        K_m = K_n * neta * eo / bk
        ' gán điểm 
        lb_xk.Text = Math.Round(K_m, 3).ToString
        lb_yk.Text = Math.Round(K_n, 3).ToString
        K.X = Math.Round(K_m, 3)
        K.Y = Math.Round(K_n, 3)
        If K.X <> 0 And K.Y <> 0 Then
            Return True ' Nếu K khác rỗng thì trả ra giá trị K
        Else
            Return False ' Nếu không thí trả ra sai : 

        End If

    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


End Class


