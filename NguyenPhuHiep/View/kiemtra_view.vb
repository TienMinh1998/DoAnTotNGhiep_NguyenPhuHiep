Imports System.Math

Public Class kiemtra_view

    Private Sub Getdata()
        Try
            Dim dk As Double = Convert.ToDouble(txt_duongkinh.Text)
            Dim bk As Double = dk / 2
            Dim lucdoc As Double = Convert.ToDouble(txt_lucdoc.Text)
            Dim chieudai As Double = Convert.ToDouble(txt_chieudaicot.Text)
            Dim moment As Double = Convert.ToDouble(txt_moment.Text)
            Dim tt As New TinhToan()
            tt.TinhToanK(dk, bk, lucdoc, chieudai, moment)

            lb_XK.Text = K.X.ToString
            lb_YK.Text = K.Y.ToString
        Catch ex As Exception

        End Try

    End Sub


    Private Sub kiemtra_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
    End Sub
    Private Sub display()
        Dim dkcol, bkcol, Acol, Ascol As Double
        Ascol = kiemtraThepControler.dientichthep
        dkcol = Convert.ToDouble(txt_duongkinh.Text)
        kiemtraThepControler.duongkinhchon = dkcol
        bkcol = dkcol / 2.0#
        Acol = PI * (bkcol / 10) ^ 2
        Dim kq As Double = Ascol / Acol
        lb_hamluongthep.Text = Round(kq, 3).ToString
    End Sub
    Private Sub hamchonthep()

        Dim sothanh As Double = Convert.ToDouble(txt_sothanh.Text)
        Dim iscurrent As Integer = cbbdiameter.SelectedIndex
        Dim Dk As Integer ' đường Kính
        Dim ct As choncotthep

        Dk = CInt(cbbdiameter.Items(iscurrent))
        ct = New choncotthep(sothanh, Dk)
        Dim dt As Double
        kiemtraThepControler.dientichthep = ct.dientichchon * 0.01
        dt = kiemtraThepControler.dientichthep
        lb_as.Text = dt.ToString + "Cm2"
        display()

        ' lấy dữ liệu để vẽ : 
        'Data.sothanhthep = CInt(txt_sothanh.Text)
        'Data.bankinh1 = Convert.ToDouble(txt_duongkinhcot.Text) / 2
        'Dim lopbaove As Double = CInt(txt_lopbaove.Text)
        'Data.bankinh2 = Data.bankinh1 - lopbaove
        'Data.duongkinh = Dk
        'Data.dientich = ct.dientichchon * 0.01 ' để đổi đơn vị ra cm2
    End Sub

    Private Sub hamvebieudo()
        Dim anpha As Double
        Dim rs, rb, A, Ass As Double
        rs = vatlieu_cot.Rs
        rb = vatlieu_cot.Rb
        Dim bkcol As Double = kiemtraThepControler.duongkinhchon / 2
        A = PI * (bkcol * 0.1) ^ 2 ' nh
        Ass = kiemtraThepControler.dientichthep
        anpha = Round((rs * Ass) / (rb * A), 3)
        Hamvebieudotuongtac(anpha)
    End Sub
    Private Sub btn_kiemtra_Click(sender As Object, e As EventArgs) Handles btn_kiemtra.Click
        ' Tính anpha : 
        Getdata()

    End Sub
    ' các hàm 
    Private Sub Hamvebieudotuongtac(anpha As Double)
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
        Dim name As String
        Dim coll As Integer
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
        Dim b As Double = Ba.value

        For esi = 0.12 To 1 Step 0.01
            Phi_S = 1 - dental * esi
            If Phi_S < 0 Then
                Phi_S = 0
            End If
            Phi = esi * Math.PI
            n = esi * (1 + anpha) - 0.159 * Math.Sin(2 * Phi) - anpha * Phi_S ' công thức thôi, sô fixx cứng
            m = 0.2122 * Math.Pow(Math.Sin(Phi), 3) + 0.3183 * b * anpha * Math.Sin(Phi) + b * anpha * Phi_S * (0.2 + 1.3 * esi)
            Dim nn As Double = Math.Round(n, 3) * 100 ' đổi ra đơn vị lớn để vẽ
            Dim mm As Double = Math.Round(m, 3) * 100

            Chart1.Series(name).Points.AddXY(mm, nn)

        Next

        Dim m_k As Double = K.X * 100
        Dim n_k As Double = K.Y * 100
        ' Tinh khoang cach 


        'Dim n1, m1 As Double
        'n1 = (n_k * 70) / m_k
        'm1 = 70

        Chart1.Series.Add("K")
        Chart1.Series("K").Color = Color.Blue
        Chart1.Series("K").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("K").Points.AddXY(-0.5 + m_k, 2 + n_k)
        Chart1.Series("K").Points.AddXY(0.5 + m_k, 2 + n_k)
        Chart1.Series("K").Points.AddXY(0.5 + m_k, -2 + n_k)
        Chart1.Series("K").Points.AddXY(-0.5 + m_k, -2 + n_k)
        Chart1.Series("K").Points.AddXY(-0.5 + m_k, 2 + n_k)
    End Sub

    Private Sub txt_sothanh_TextChanged(sender As Object, e As EventArgs) Handles txt_sothanh.TextChanged, txt_duongkinh.TextChanged, txt_moment.TextChanged, txt_lucdoc.TextChanged, txt_chieudaicot.TextChanged
        Try
            hamchonthep()
            hamvebieudo()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbdiameter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbdiameter.SelectedIndexChanged
        Try
            hamchonthep()
            hamvebieudo()

        Catch ex As Exception

        End Try

    End Sub
End Class