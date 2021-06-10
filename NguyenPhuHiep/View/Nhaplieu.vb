Public Class Nhaplieu
    Public issua As Integer = -1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        innitmodel()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public btmap As Bitmap
    Private _gr1 As Graphics
    Public Pn As Pen = New Pen(Brushes.Black, 2)
    Public netdim As Pen = New Pen(Brushes.Black, 1)
    Public pn_blue As Pen = New Pen(Brushes.Blue, 2)
    Public pn_magenta As Pen = New Pen(Brushes.Magenta, 1)
    Public Pn2 As Pen = New Pen(Brushes.Red, 1)
    Public Property Gr As Graphics
        Get
            Return _gr1
        End Get
        Set(value As Graphics)
            _gr1 = value
        End Set
    End Property
    Public Draws As Draw
    Private Sub btn_xacnhan_Click(sender As Object, e As EventArgs) Handles btn_xem.Click
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

        PointCenter.X = Convert.ToInt32(PictureBox1.Width / 2) - 60
        PointCenter.Y = Convert.ToInt32(PictureBox1.Height / 2)
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
        Dim giatri1 As Double = Convert.ToDouble(txt_duongkinh.Text) - 80 'giá trị của đường kính hình tròn bên trong
        Draw.Create_New_Dim(p1, p2, netdim, Gr, giatri1.ToString, fn)
        ' Tạo Dim cho Hình tròn to bên ngoài
        Dim p3, p4 As Point
        p3.X = PointCenter.X + radius_model + 80
        p3.Y = PointCenter.Y - radius_model
        p4.X = PointCenter.X + radius_model + 80
        p4.Y = PointCenter.Y + radius_model
        Draw.Create_New_Dim(p3, p4, netdim, Gr, txt_duongkinh.Text, fn)
        '=========Thân của hàm vẽ
        ' Chuyển hình vẽ lên ảnh
        PictureBox1.Image = btmap
    End Sub

    Private Sub btn_test_Click(sender As Object, e As EventArgs)


    End Sub
    Dim giatri As Integer
    Private Sub txt_duongkinh_TextChanged(sender As Object, e As EventArgs) Handles txt_duongkinh.TextChanged


    End Sub
    ' hàm vẽ cột

    ' hàm ve cột 2


    Private Sub Nhaplieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_chieudaitinhtoan.TextChanged

    End Sub

    Private Sub btn_xoatrang_Click(sender As Object, e As EventArgs) Handles btn_xoatrang.Click
        txt_chieudaitinhtoan.Text = ""
        txt_duongkinh.Text = ""
        txt_lucdoc.Text = ""
        txt_momenuon.Text = ""
        txt_tencot.Text = ""
        txt_tencot.Focus()

    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        ' Bay giữ liệu từ cơ sở dữ liệu sang : 

        If issua < 0 Then
            MessageBox.Show("Bạn phải chọn nguồn dữ liệu")

        Else
            MessageBox.Show(Dgv_View.CurrentRow.Index.ToString)
        End If

    End Sub

    Private Sub btn_Bieudo_Click(sender As Object, e As EventArgs)
        Dim fn As Font = Draw.font(10)
        btmap = New Bitmap(2000, 2000)

        Gr = Graphics.FromImage(btmap)
        ' Khai báo các thông số : 
        Dim Phi_S As Double
        Dim Phi As Double
        Dim n, m As Double
        Dim esi As Double = 0.12
        Dim dental As Double = 1.5 + 6 * 280 * 10 ^ -4
        Dim ba As Double = 0.9
        ' Tiến hành vẽ : 
        For anpha = 0.1 To 0.6 Step 0.1
            For esi = 0.12 To 1 Step 0.02
                Phi_S = 1 - dental * esi
                If Phi_S < 0 Then
                    Phi_S = 0
                End If
                Phi = esi * Math.PI
                n = esi * (1 + anpha) - 0.159 * Math.Sin(2 * Phi) - anpha * Phi_S
                m = 0.2122 * Math.Pow(Math.Sin(Phi), 3) + 0.3183 * ba * anpha * Math.Sin(Phi) + ba * anpha * Phi_S * (0.2 + 1.3 * esi)
                Dim a As Double = Math.Round(n, 3) * 200
                Dim bb As Double = Math.Round(m, 3) * 200
                Dim pt As Point
                pt.X = a
                pt.Y = bb
                Draw.Create_new_Steel(Gr, Pn, pt.X, pt.Y, 2, 1, Brushes.Magenta)



            Next
        Next


        ' Vẽ ở trong này : 
        PictureBox1.Image = btmap
    End Sub
    Public dem = 0
    Private Sub btn_themmoi_Click(sender As Object, e As EventArgs) Handles btn_themmoi.Click, btn_luu.Click
        ' Lấy dữ liệu từ FRM 
        Dim name As String
        Dim a, b, c, d As Double
        name = txt_tencot.Text
        a = Convert.ToDouble(txt_lucdoc.Text)
        b = Convert.ToDouble(txt_momenuon.Text)
        c = Convert.ToDouble(txt_duongkinh.Text)
        d = Convert.ToDouble(txt_chieudaitinhtoan.Text)
        '  Dim cot As New cot_chuatinh(dem.ToString, name, a, b, c, d)
        '  Data.dscolchuatinh.Add(cot)
        Dgv_View.Rows.Add(dem, txt_tencot.Text, txt_lucdoc.Text, txt_momenuon.Text, txt_duongkinh.Text, txt_chieudaitinhtoan.Text)
        dem += 1
        btn_luu.Enabled = False



    End Sub

    Private Sub Dgv_View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_View.CellContentClick
        issua = Dgv_View.CurrentRow.Index
    End Sub
    Public Sub innitmodel()
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

        PointCenter.X = Convert.ToInt32(PictureBox1.Width / 2) - 60
        PointCenter.Y = Convert.ToInt32(PictureBox1.Height / 2)
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
        Dim giatri1 As Double = Convert.ToDouble(txt_duongkinh.Text) - 80 'giá trị của đường kính hình tròn bên trong
        Draw.Create_New_Dim(p1, p2, netdim, Gr, giatri1.ToString, fn)
        ' Tạo Dim cho Hình tròn to bên ngoài
        Dim p3, p4 As Point
        p3.X = PointCenter.X + radius_model + 80
        p3.Y = PointCenter.Y - radius_model
        p4.X = PointCenter.X + radius_model + 80
        p4.Y = PointCenter.Y + radius_model
        Draw.Create_New_Dim(p3, p4, netdim, Gr, txt_duongkinh.Text, fn)
        '=========Thân của hàm vẽ
        ' Chuyển hình vẽ lên ảnh
        PictureBox1.Image = btmap
    End Sub

    Private Sub btn_xacnhan_Click_1(sender As Object, e As EventArgs) Handles btn_xacnhan.Click

    End Sub
End Class